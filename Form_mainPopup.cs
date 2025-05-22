using OpenAI_API.Chat;
using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static OpenAI_API.Chat.ChatMessage;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using NAudio.Wave;
using NAudio.Lame;
using Whisper.net.Ggml;
using AiCompanion.Services;
using System.Linq;
using System.Media;

namespace AiCompanion
{
    public partial class Form_mainPopup : Form
    {
        // Constants and Windows API declarations for hotkey handling
        private const int HOTKEY_ID = 1;
        private const int STT_HOTKEY_ID = 2; // ID for Speech-to-Text hotkey

        // Enumeration for key modifiers (e.g., Alt, Ctrl, etc.)
        [Flags]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        private const int WM_HOTKEY = 0x0312;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        // Windows API methods for handling window focus and hotkeys
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Store the handle of the window that had focus
        private IntPtr _previousWindowHandle;
        private string _copiedText = ""; // Holds the copied text
        string copiedTextPre = ""; //holds previous clipboard text (used in quick prompts)

        // STT recording related fields
        private WaveInEvent waveIn;
        private WaveFileWriter waveWriter;
        private MemoryStream waveStream;
        private bool isRecording = false;
        private bool isRecordingProcessing = false;
        private WhisperNetService _whisperNetService;
        private OpenAIAPI openAiApi;
        
        // Sound player for audio feedback
        private SoundPlayer soundPlayer;

        // Define the mapping once, e.g., as a static readonly field
        private static readonly Dictionary<string, Keys> SpecialKeyMappings = new()
        {
            { ".", Keys.OemPeriod },
            { ",", Keys.Oemcomma },
            { "#", Keys.OemQuestion },
            { "-", Keys.OemMinus },
            { "+", Keys.Oemplus },
            { "ß", Keys.OemOpenBrackets },
            { "<", Keys.Oemtilde }
        };

        // Constructor for the main popup form
        public Form_mainPopup()
        {
            InitializeComponent();            
            try
            {
                // Hide the form initially and set properties
                this.Hide();
                this.Opacity = 0;
                this.ShowInTaskbar = false;
                this.KeyPreview = true;
                if (Properties.Settings.Default.FirstLaunch && string.IsNullOrEmpty(Properties.Settings.Default.API_Key))
                {
                    if (Properties.Settings.Default.UseNewUI)
                    {
                        Properties.Settings.Default.API_Key = InputBox.Show("First Launch enter API Key:", "API Key not set");
                        Properties.Settings.Default.Save();
                    }
                }
                
                // Initialize API client and WhisperNetService
                openAiApi = new OpenAIAPI(Properties.Settings.Default.API_Key);
                openAiApi.ApiUrlFormat = Properties.Settings.Default.API_URL + "{0}/{1}";
                _whisperNetService = new WhisperNetService();
                
                // Initialize sound player for audio feedback
                string soundFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "bubble-pop1.wav");
                if (File.Exists(soundFilePath))
                {
                    soundPlayer = new SoundPlayer(soundFilePath);
                }
                
                // Register hotkeys
                RegisterUserHotkey();
                RegisterSttHotkey();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error registering hotkey: " + ex.Message);
            }
        }

        public void RegisterUserHotkey()
        {
            // Simulating user input. In practice, get this from a user input interface.
            string modifierInput = string.IsNullOrWhiteSpace(Properties.Settings.Default.HotKeyMod)
                                    ? "Alt"
                                    : Properties.Settings.Default.HotKeyMod;
            string keyInput = string.IsNullOrWhiteSpace(Properties.Settings.Default.HotKeyKey)
                                    ? "g"
                                    : Properties.Settings.Default.HotKeyKey;

            // Convert modifier string to corresponding flags
            KeyModifiers modifiers = ParseModifiers(modifierInput);

            // Convert key string to corresponding Keys enum value
            Keys key = (Keys)Enum.Parse(typeof(Keys), keyInput, true);

            // Register the hotkey with the parsed values
            RegisterHotKey(this.Handle, HOTKEY_ID, (int)modifiers, (int)key);
        }
        
        /// <summary>
        /// Registers a hotkey for Speech-to-Text functionality
        /// </summary>
        public void RegisterSttHotkey()
        {
            // Get STT hotkey settings or use defaults if not set
            string modifierInput = string.IsNullOrWhiteSpace(Properties.Settings.Default.SttHotKeyMod)
                                    ? "Alt"
                                    : Properties.Settings.Default.SttHotKeyMod;
            string keyInput = string.IsNullOrWhiteSpace(Properties.Settings.Default.SttHotKeyKey)
                                    ? "s"
                                    : Properties.Settings.Default.SttHotKeyKey;

            // Convert modifier string to corresponding flags
            KeyModifiers modifiers = ParseModifiers(modifierInput);

            // Convert key string to corresponding Keys enum value
            Keys key;
            if (SpecialKeyMappings.TryGetValue(keyInput, out key))
            {
                // key is set by the dictionary
            }
            else
            {
                key = (Keys)Enum.Parse(typeof(Keys), keyInput, true);
            }

            // Register the STT hotkey with the parsed values
            RegisterHotKey(this.Handle, STT_HOTKEY_ID, (int)modifiers, (int)key);
        }
        private KeyModifiers ParseModifiers(string modifierInput)
        {
            KeyModifiers modifiers = KeyModifiers.None;

            if (modifierInput.Contains("Alt"))
                modifiers |= KeyModifiers.Alt;
            if (modifierInput.Contains("Control") || modifierInput.Contains("Ctrl"))
                modifiers |= KeyModifiers.Control;
            if (modifierInput.Contains("Shift"))
                modifiers |= KeyModifiers.Shift;
            if (modifierInput.Contains("Windows") || modifierInput.Contains("Win"))
                modifiers |= KeyModifiers.Windows;

            return modifiers;
        }

        /// <summary>
        /// WndProc handles Windows messages, specifically for detecting the registered hotkey press.
        /// </summary>
        /// <param name="m">Windows message object</param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Check if any of our registered hotkeys was pressed
            if (m.Msg == WM_HOTKEY)
            {
                int hotkeyId = m.WParam.ToInt32();
                
                if (hotkeyId == HOTKEY_ID)
                {
                    try
                    {
                        CopyTextFromPreviousWindow();


                        // Position and show the popup form
                        position_form(this);
                        this.Show();
                        this.Opacity = 100;
                        this.WindowState = FormWindowState.Normal;
                        this.Activate();
                        this.Size = new Size(322, 46);
                    if (Properties.Settings.Default.UseNewUI)
                    {
                        //old buttons down
                        /*
                        btn_prompt.Location = new Point(2, 51);
                        btn_TTS.Location = new Point(100, 51);
                        btn_Speak2Text.Location = new Point(172, 51);
                        */
                        btn_promptN.Visible = true;
                        btn_TtsN.Visible = true;
                        btn_Speak2TextN.Visible = true;
                        //add & as hotkey
                        btn_promptN.Text = "&Prompt";
                        btn_TtsN.Text = "&TTS";
                        btn_Speak2TextN.Text = "&STT";
                        btn_ImagePrompt.Text = "&Image";

                        //remove  & as hotkey at old
                        btn_prompt.Text = "Prompt";
                        btn_TTS.Text = "TTS";
                        btn_Speak2Text.Text = "STT";


                        //hide old buttons
                        btn_prompt.Visible = false;
                        btn_prompt.Enabled = false;
                        btn_TTS.Visible = false;
                        btn_Speak2Text.Visible = false;
                        _ = btn_promptN.Focus();
                    }
                    else
                    {
                        //add & as hotkey
                        btn_prompt.Text = "&Prompt";
                        btn_TTS.Text = "&TTS";
                        btn_Speak2Text.Text = "&STT";
                        //remove & at new
                        btn_promptN.Text = "Prompt";
                        btn_TtsN.Text = "TTS";
                        btn_Speak2TextN.Text = "STT";

                        //old buttons up
                        btn_prompt.Location = new Point(2, 3);
                        btn_TTS.Location = new Point(100, 3);
                        btn_Speak2Text.Location = new Point(172, 3);
                        //hide new
                        btn_promptN.Visible = false;
                        btn_TtsN.Visible = false;
                        btn_Speak2TextN.Visible = false;
                        _ = btn_prompt.Focus();
                    }
                    this.Invalidate();
                    this.Update();
                }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show("Error handling hotkey event: " + ex.Message);
                    }
                }
                else if (hotkeyId == STT_HOTKEY_ID)
                {
                    try
                    {
                        // Store the handle of the window that had focus
                        _previousWindowHandle = GetForegroundWindow();
                        
                        // Stop recording if it's in progress
                        if (isRecording)
                        {
                            StopDirectRecording();
                        }else{
                            // Start recording directly when the hotkey is pressed
                            if(!isRecordingProcessing)
                                StartDirectRecording();
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show("Error handling STT hotkey event: " + ex.Message);
                    }
                }
            }
        }

        public void CopyTextFromPreviousWindow(bool onlyOnChange = true)
        {
            // Get the window that had focus before the hotkey was pressed
            _previousWindowHandle = GetForegroundWindow();

            // Get the current content of the clipboard to compare
            copiedTextPre = Clipboard.GetText();

            // Focus on the previous window and send a Ctrl+C to copy selected text
            if (_previousWindowHandle != IntPtr.Zero && SetForegroundWindow(_previousWindowHandle))
            {
                // Try copying the text twice if needed
                if (TryCopyText(out string copiedText, copiedTextPre, onlyOnChange) ||
                    TryCopyText(out copiedText, copiedTextPre, onlyOnChange))
                {
                    _copiedText = copiedText;
                }
            }
        }

        private bool TryCopyText(out string copiedText, string previousText, bool onlyOnChange=false)
        {
            Thread.Sleep(300);
            SendKeys.SendWait("^c"); // Simulate pressing Ctrl+C
            Thread.Sleep(100);
            copiedText = Clipboard.GetText();
            if (copiedText == previousText && onlyOnChange)
                copiedText = "";

            // Return true if the clipboard content changed or if it should be returned anyhow
            return copiedText != previousText || !onlyOnChange;
        }


        /// <summary>
        /// Handles the form's deactivation event (losing focus) by hiding the form.
        /// </summary>
        private void Form_mainPopup_Deactivate(object sender, EventArgs e)
        {
            Form_hide(this);
        }

        /// <summary>
        /// Prevents the form from closing and hides it instead when the user attempts to close it.
        /// </summary>
        private void Form_mainPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Prevent the form from closing
            Form_hide(this);
        }

        /// <summary>
        /// Exits the application when the user selects the tray icon's "Exit" option.
        /// </summary>
        private void trayToolStripMenuExit_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop recording if it's in progress
                if (isRecording)
                {
                    StopDirectRecording();
                }
                
                // Unregister the hotkeys, hide the tray icon, and exit the application
                _ = UnregisterHotKey(this.Handle, HOTKEY_ID);
                _ = UnregisterHotKey(this.Handle, STT_HOTKEY_ID);
                trayIcon.Visible = false;
                System.Windows.Forms.Application.Exit();
                this.Close();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error exiting application: " + ex.Message);
            }
        }

        /// <summary>
        /// Opens the application settings form.
        /// </summary>
        private void TrayToolStripMenuSettings_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and show the main form 
                if (Properties.Settings.Default.UseNewUI)
                {
                    FormMain mainForm = new FormMain(_previousWindowHandle, "TabPageSettings");
                    ShowForm(mainForm);
                }

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening main form: " + ex.Message);
            }
        }

        /// <summary>
        /// Opens the application about form.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                // Create and show the main form 
                if (Properties.Settings.Default.UseNewUI)
                {
                    FormMain mainForm = new FormMain(_previousWindowHandle, "TabPageAbout");
                    ShowForm(mainForm);
                }

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening main form: " + ex.Message);
            }
        }

        private void btn_TTSn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and show the main form 
                FormMain mainForm = new FormMain(_previousWindowHandle, "TabPageTTS", _copiedText);
                ShowForm(mainForm);

            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening main form: " + ex.Message);
            }
        }

        private void btn_Speak2Text_Click_N(object sender, EventArgs e)
        {
            try
            {
                // Create and show the main form 
                FormMain mainForm = new FormMain(_previousWindowHandle, "TabPageSTT");
                ShowForm(mainForm);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening main form: " + ex.Message);
            }

        }

        private void btn_prompt_Click_N(object sender, EventArgs e)
        {
            try
            {
                // Create and show the main form 
                FormMain mainForm = new FormMain(_previousWindowHandle, "TabPagePrompt", _copiedText);
                ShowForm(mainForm);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening main form: " + ex.Message);
            }
        }

        private void btn_ImagePrompt_Click(object sender, EventArgs e)
        {
            try
            {

                using (ScreenCaptureForm captureForm = new ScreenCaptureForm())
                {
                    if (captureForm.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap screenshot = captureForm.GetCapturedImage();
                        string base64Image = ConvertBitmapToBase64(screenshot, 80); // 75 is the quality parameter (1-100)

                        if (base64Image != null)
                        {
                            // send the captured screenshot to prompt                            
                            try
                            {
                                // Create and show the main form selecting the prompt tab
                                FormMain mainForm = new FormMain(_previousWindowHandle, "TabPagePrompt", _copiedText, base64Image);
                                ShowForm(mainForm);
                            }
                            catch (Exception ex)
                            {
                                _ = MessageBox.Show("Error opening prompt form with image: " + ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error creating screenshot form: " + ex.Message);
            }


        }

        public static string ConvertBitmapToBase64(Bitmap bitmap, long quality)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Set the quality parameter for JPEG compression
                ImageCodecInfo jpegEncoder = GetEncoder(ImageFormat.Jpeg);
                EncoderParameters encoderParams = new EncoderParameters(1);
                encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                // Save the bitmap as a JPEG with the specified quality
                bitmap.Save(ms, jpegEncoder, encoderParams);

                // Convert the byte array of the JPEG image to Base64 string
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        // Helper function to get the JPEG encoder
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        #region "Funtions and metods"

        /// <summary>
        /// Positions the form near the current cursor position, ensuring it stays on-screen.
        /// </summary>
        /// <param name="form">Form to position</param>
        private void position_form(Form form)
        {
            try
            {
                // Get the current cursor position and screen bounds
                Point cursorPosition = Cursor.Position;
                Rectangle screenBounds = Screen.FromPoint(cursorPosition).WorkingArea;

                // Calculate the form's position based on the cursor position
                int formX = cursorPosition.X;
                int formY = cursorPosition.Y;

                // Prevent the form from going off-screen
                if (formX + form.Width > screenBounds.Right)
                    formX = screenBounds.Right - form.Width;

                if (formY + form.Height > screenBounds.Bottom)
                    formY = screenBounds.Bottom - form.Height;

                // Set the form's location
                form.Location = new Point(formX, formY);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error positioning form: " + ex.Message);
            }
        }
        /// <summary>
        /// Shows a form, making it visible and positioning it properly.
        /// </summary>
        /// <param name="form">Form to display</param>
        private void ShowForm(Form form)
        {
            form.Opacity = 100;
            form.WindowState = FormWindowState.Normal;
            form.ShowInTaskbar = true;
            position_form(form);
            form.Activate();
            form.Show();
            Form_hide(this);
        }

        /// <summary>
        /// Hides the form and resets its visibility and state.
        /// </summary>
        /// <param name="form">Form to hide</param>
        private void Form_hide(Form form)
        {
            try
            {
                // Hide the form and reset its properties
                form.Hide();
                form.ShowInTaskbar = false;
                form.Opacity = 0;

                // Stop recording if it's in progress
                if (isRecording)
                {
                    StopDirectRecording();
                }
                
                // Unregister and re-register the hotkeys to ensure they remain functional
                _ = UnregisterHotKey(this.Handle, HOTKEY_ID);
                _ = UnregisterHotKey(this.Handle, STT_HOTKEY_ID);
                System.Threading.Thread.Sleep(100);
                RegisterUserHotkey();
                RegisterSttHotkey();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error hiding form: " + ex.Message);
            }
        }
        #endregion

        #region "Quick prompts"
        //handle quick short cuts 1-5 for prompts
        private void Form_mainPopup_KeyUp(object sender, KeyEventArgs e)
        {
            int keyNumber = -1;

            if (e.KeyCode >= Keys.D1 && e.KeyCode <= Keys.D5) // Checks if keys "1" to "5" were pressed
            {
                keyNumber = e.KeyCode - Keys.D0;
            }
            else if (e.KeyCode >= Keys.NumPad1 && e.KeyCode <= Keys.NumPad5) // Checks if NumPad keys "1" to "5" were pressed
            {
                keyNumber = e.KeyCode - Keys.NumPad0;
            }

            if (keyNumber >= 1 && keyNumber <= 5)
            {
                string quickPrompt = Properties.Settings.Default[$"QPrompt{keyNumber}"] as string;
                if (!string.IsNullOrEmpty(quickPrompt))
                {
                    QuickPrompt(_copiedText.Length>0 ? _copiedText : copiedTextPre, quickPrompt);
                }
            }
            Form_hide(this);
        }

        
        private async void QuickPrompt(string inputText, string prePrompt)
        {

            OpenAIAPI openAiApi; // Instance of the OpenAI API

            openAiApi = new OpenAIAPI(Properties.Settings.Default.API_Key);
            openAiApi.ApiUrlFormat = Properties.Settings.Default.API_URL + "{0}/{1}";

            if (!string.IsNullOrEmpty(inputText))
            {
                try
                {

                    // Create the chat request
                    var chatRequest = new ChatRequest()
                    {
                        Model = Properties.Settings.Default.QPromptModel,
                        Messages = new[]
                        {
                            new ChatMessage(ChatMessageRole.System, prePrompt),
                            new ChatMessage(ChatMessageRole.User, inputText)
                        }
                    };


                    this.Cursor = Cursors.WaitCursor;

                    // Send the request and get the response
                    var chatResult = await openAiApi.Chat.CreateChatCompletionAsync(chatRequest);


                    if (chatResult != null)
                    {
                        var result = chatResult.Choices[0].Message.TextContent;
                        //Debug.WriteLine("Quick prompt result: " + result);
                        if (_previousWindowHandle != IntPtr.Zero)
                        {
                            // Set focus back to the previously focused window
                            if (SetForegroundWindow(_previousWindowHandle))
                            {
                                Thread.Sleep(100);
                                // Set text to clipboard
                                Clipboard.SetText(result); 
                                Thread.Sleep(100);
                                // Send Ctrl+V to paste the selected text
                                SendKeys.SendWait("^v");

                                // Reset the window handle
                                _previousWindowHandle = IntPtr.Zero;
                            }
                        }
                    }
                    this.Cursor = Cursors.Default;
                    
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    Debug.WriteLine("Faild inserting back. " + ex.ToString());
                }
            }
        }
        #endregion

        #region "Direct STT Recording"
        private void StartDirectRecording()
        {
            try
            {
                isRecording = true;
                // Initialize recording components
                waveIn = new WaveInEvent();
                waveIn.DeviceNumber = 0;

                // Check which engine is selected to determine the appropriate sample rate
                string selectedEngine = Properties.Settings.Default.STTEngine;
                if (string.IsNullOrEmpty(selectedEngine) || selectedEngine != "Whisper.net")
                {
                    // Use 44.1kHz for OpenAI (default)
                    waveIn.WaveFormat = new WaveFormat(44100, 1); // 44.1kHz, mono
                }
                else
                {
                    // Use 16kHz for Whisper.net as required
                    waveIn.WaveFormat = new WaveFormat(16000, 1); // 16kHz, mono
                }

                // Create memory stream for holding wave data
                waveStream = new MemoryStream();
                waveWriter = new WaveFileWriter(waveStream, waveIn.WaveFormat);

                // Set up event for recording data
                waveIn.DataAvailable += (s, a) =>
                {
                    try
                    {
                        // Make sure we don't try to write more bytes than available in the buffer
                        if (a.BytesRecorded <= a.Buffer.Length)
                        {
                            waveWriter.Write(a.Buffer, 0, a.BytesRecorded);
                        }
                        else
                        {
                            // If BytesRecorded is somehow larger than buffer length, only write what's available
                            waveWriter.Write(a.Buffer, 0, a.Buffer.Length);
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error writing audio data: {ex.Message}");
                        isRecordingProcessing = false;
                        isRecording = false;
                    }
                };

                // Event when recording stops
                waveIn.RecordingStopped += (s, a) =>
                {
                    isRecordingProcessing = true;
                    try
                    {
                        waveWriter.Flush(); // Ensure all data is written to the memory stream

                        // Check which engine is selected and save in appropriate format
                        string selectedEngine = Properties.Settings.Default.STTEngine;
                        if (string.IsNullOrEmpty(selectedEngine) || selectedEngine != "Whisper.net")
                        {
                            // Use MP3 for OpenAI (default)
                            string pathToFile = SaveAsMp3(waveStream);
                            waveWriter.Dispose();
                            waveStream.Dispose();
                            waveIn.Dispose();
                            TranscribeAudio(pathToFile);
                        }
                        else
                        {
                            // Use WAV for Whisper.net
                            string pathToFile = SaveAsWav(waveStream);
                            waveWriter.Dispose();
                            waveStream.Dispose();
                            waveIn.Dispose();
                            TranscribeAudio(pathToFile);
                        }
                        isRecordingProcessing = false;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error stoping recording: " + e.Message);
                        isRecording = false;
                        isRecordingProcessing = false;
                    }
                };

                // Start recording
                waveIn.StartRecording();
                isRecording = true;

                PlaySound();

                // Visual feedback that recording has started
                this.Cursor = Cursors.WaitCursor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting recording: " + ex.Message);
                isRecording = false;
                isRecordingProcessing = false;
            }
        }

        private void StopDirectRecording()
        {
            if (waveIn != null && isRecording && !isRecordingProcessing)
            {
                // Play sound when STT hotkey is released
                PlaySound();
                
                // Stop recording
                waveIn.StopRecording();                
                isRecording = false;
                this.Cursor = Cursors.Default;
            }
        }
        
        private void PlaySound()
        {
            try
            {
                // Play sound if the sound player is initialized
                if (soundPlayer != null)
                {
                    soundPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error playing sound: {ex.Message}");
            }
        }

        // Save the recorded data as an MP3 file
        private string SaveAsMp3(MemoryStream waveStream)
        {
            waveStream.Position = 0; // Reset the position of the memory stream

            string tempFile = Path.Combine(Path.GetTempPath(), $"STT.mp3");
            DeleteFile(tempFile);
            using (var mp3File = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                using (var mp3Writer = new LameMP3FileWriter(mp3File, new WaveFormat(44100, 1), LAMEPreset.ABR_128))
                {
                    waveStream.CopyTo(mp3Writer); // Convert the wave data to MP3
                }
            }
            return tempFile;
        }

        // Save the recorded data as a WAV file (for Whisper.net)
        private string SaveAsWav(MemoryStream waveStream)
        {
            waveStream.Position = 0; // Reset the position of the memory stream

            string tempFile = Path.Combine(Path.GetTempPath(), $"STT.wav");
            DeleteFile(tempFile);
            using (var fileStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                // Copy the wave data directly without conversion
                waveStream.CopyTo(fileStream);
            }
            return tempFile;
        }

        private void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch
                {
                    // Ignore errors if file is in use or cannot be deleted
                }
            }
        }

        private async void TranscribeAudio(string path)
        {
            try
            {
                string resultText = string.Empty;
                string selectedEngine = Properties.Settings.Default.STTEngine; // Get the selected engine
                string language = Properties.Settings.Default.STT_lang; // Get the selected language

                // Default to OpenAI if setting is not present or invalid
                if (string.IsNullOrEmpty(selectedEngine) || (selectedEngine != "OpenAI" && selectedEngine != "Whisper.net"))
                {
                    selectedEngine = "OpenAI";
                }

                if (selectedEngine == "Whisper.net")
                {
                    // Use Whisper.net for transcription
                    string modelName = Properties.Settings.Default.WhisperNetModel; // e.g., "Base"
                    if (string.IsNullOrEmpty(modelName)) modelName = "Base"; // Default model

                    if (Enum.TryParse<GgmlType>(modelName, true, out GgmlType selectedModelType))
                    {
                        var segments = await _whisperNetService.TranscribeAsync(path, selectedModelType, language);
                        resultText = string.Join(" ", segments.Select(s => s.Text));
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Whisper.net model type specified in settings: {modelName}. Falling back to Base model.");
                        var segments = await _whisperNetService.TranscribeAsync(path, GgmlType.Base, language);
                        resultText = string.Join(" ", segments.Select(s => s.Text));
                    }
                }
                else // Default to OpenAI
                {
                    // Use OpenAI for transcription
                    resultText = await openAiApi.Transcriptions.GetTextAsync(path, language);
                }
                // skip when result is [BLANK_AUDIO] 

                // Set the transcribed text to the clipboard and paste it to the active window
                if (!string.IsNullOrEmpty(resultText) && _previousWindowHandle != IntPtr.Zero && resultText != "[BLANK_AUDIO]")
                {
                    // Set focus back to the previously focused window
                    if (SetForegroundWindow(_previousWindowHandle))
                    {
                        Thread.Sleep(100);
                        // Set text to clipboard
                        Clipboard.SetText(resultText);
                        Thread.Sleep(100);
                        // Send Ctrl+V to paste the transcribed text
                        SendKeys.SendWait("^v");

                        // Reset the window handle
                        _previousWindowHandle = IntPtr.Zero;
                    }
                }

                DeleteFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during transcription: {ex.Message}", "Transcription Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}

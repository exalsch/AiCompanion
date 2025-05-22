using NAudio.Lame;
using NAudio.Wave;
using OpenAI_API;
using OpenAI_API.Audio;
using OpenAI_API.Chat;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenAI_API.Chat.ChatMessage;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using AiCompanion.Services; // Added for WhisperNetService
using Whisper.net.Ggml; // Added for GgmlType

namespace AiCompanion
{
    public partial class FormMain : MaterialForm
    {
        private OpenAIAPI openAiApi; // Instance of the OpenAI API
        private readonly WhisperNetService _whisperNetService; // Added for Whisper.net

        //TTS related globals
        private WaveInEvent waveIn;
        private WaveFileWriter waveWriter;
        private MemoryStream waveStream;
        private bool isRecording = false;
        private string base64Image = null;
        //STT related globals
        private bool shouldStop = false; // Indicates if the audio playback should stop
        private IntPtr previousWindowHandle; // Store the handle of the window that had focus

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        #region "Shared and global"
        public FormMain(IntPtr prevWindowHandle, string startTab = "", string copiedText = "", string base64Img = null)
        {
            InitializeComponent();
            //get and set version
            var version = System.Windows.Forms.Application.ProductVersion;

            //this.Text = this.Text + " " + version; //TODO: Can't get this to work ffs!
            lblAboutVersion.Text = "Version: 1.0.4.0";// + version;

            //init API Client
            openAiApi = new OpenAIAPI(Properties.Settings.Default.API_Key);
            openAiApi.ApiUrlFormat = Properties.Settings.Default.API_URL + "{0}/{1}";
            _whisperNetService = new WhisperNetService(); // Initialize WhisperNetService
            //pre fill controls and vars
            txt_TextTTS.Text = copiedText;
            txt_inputPrompt.Text = copiedText;
            previousWindowHandle = prevWindowHandle;


            //have we got an image?
            if (base64Img != null)
            {
                base64Image = base64Img;
                picPrompt.Image = LoadImageFromBase64String(base64Image);
                picPrompt.Visible = true;
            }
            else
            {
                picPrompt.Visible = false;
            }


            // Populate and set STT Engine ComboBox
            cmbSttEngine.Items.Add("OpenAI");
            cmbSttEngine.Items.Add("Whisper.net");
            // Ensure the setting exists and is valid, otherwise default
            string currentSttEngine = Properties.Settings.Default.STTEngine;
            if (cmbSttEngine.Items.Contains(currentSttEngine))
            {
                cmbSttEngine.SelectedItem = currentSttEngine;
            }
            else if (cmbSttEngine.Items.Count > 0)
            {
                cmbSttEngine.SelectedIndex = 0; // Default to the first item if setting is invalid
                Properties.Settings.Default.STTEngine = cmbSttEngine.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }

            // Populate Whisper.net Model ComboBox
            foreach (var modelName in Enum.GetNames(typeof(GgmlType)))
            {
                cmbWhisperNetModel.Items.Add(modelName);
            }
            // Ensure the setting exists and is valid, otherwise default
            string currentWhisperModel = Properties.Settings.Default.WhisperNetModel;
            if (cmbWhisperNetModel.Items.Contains(currentWhisperModel))
            {
                cmbWhisperNetModel.SelectedItem = currentWhisperModel;
            }
            else if (cmbWhisperNetModel.Items.Count > 0)
            {
                cmbWhisperNetModel.SelectedIndex = 0; // Default to the first model
                Properties.Settings.Default.WhisperNetModel = cmbWhisperNetModel.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }

            // Initial state for Whisper.net model controls
            UpdateWhisperNetModelControlsVisibility();

            // Wire up event handlers
            this.cmbSttEngine.SelectedIndexChanged += new System.EventHandler(this.cmbSttEngine_SelectedIndexChanged);
            this.cmbWhisperNetModel.SelectedIndexChanged += new System.EventHandler(this.cmbWhisperNetModel_SelectedIndexChanged);

            // Load settings into controls
            txt_ApiKey.Text = Properties.Settings.Default.API_Key;
            txt_API_URL.Text = Properties.Settings.Default.API_URL;

            //Voice lang
            cmbSttLanguage.SelectedItem = cmbSttLanguage.Items.Contains(Properties.Settings.Default.STT_lang)
                ? Properties.Settings.Default.STT_lang
                : "en";
            //Voice
            cmbBxVoiceTTS.SelectedItem = cmbBxVoiceTTS.Items.Contains(Properties.Settings.Default.TtsVoice)
                ? Properties.Settings.Default.TtsVoice
                : "nova";

            //prompt model

            try
            {
                //Fill model combobox                    
                foreach (var model in Program.modelsList)
                {
                    cmb_Model.Items.Add(model.ModelID);
                }
                // Set the selected item if it exists in the combo box items
                cmb_Model.SelectedItem = cmb_Model.Items.Contains(Properties.Settings.Default.ModelLLM)
                ? Properties.Settings.Default.ModelLLM
                : "gpt - 4o - mini";
            }
            catch (Exception)
            {

                throw; //TODO Handle this maybe
            }

            //Quick Prompts models

            try
            {
                //Fill model combobox                    
                foreach (var model in Program.modelsList)
                {
                    cmb_SettingQuickPromptModel.Items.Add(model.ModelID);
                }
                // Set the selected item if it exists in the combo box items
                cmb_SettingQuickPromptModel.SelectedItem = cmb_SettingQuickPromptModel.Items.Contains(Properties.Settings.Default.QPromptModel)
                ? Properties.Settings.Default.QPromptModel
                : "gpt - 4o - mini";
            }
            catch (Exception)
            {

                throw; //TODO Handle this maybe
            }

            //hotkey
            txt_HotkeyKey.Text = Properties.Settings.Default.HotKeyKey;
            cmbHotKeyMod.SelectedItem = Properties.Settings.Default.HotKeyMod;

            chkAutoStartSTT.Checked = Properties.Settings.Default.AutoStartSTT;
            chkAutoStartTTS.Checked = Properties.Settings.Default.AutoStartTTS;
            txt_SttHotkeyKey.Text = Properties.Settings.Default.SttHotKeyKey;
            cmbSttHotKeyMod.SelectedItem = Properties.Settings.Default.SttHotKeyMod;
            switchDarkMode.Switched = Properties.Settings.Default.useDarkMode;

            txt_PrePrompt.Text = Properties.Settings.Default.PrePromt;
            chkExThoughts.Checked = Properties.Settings.Default.ExcludeAiThoughts;
            txt_QuickPrompt1.Text = Properties.Settings.Default.QPrompt1;
            txt_QuickPrompt2.Text = Properties.Settings.Default.QPrompt2;
            txt_QuickPrompt3.Text = Properties.Settings.Default.QPrompt3;
            txt_QuickPrompt4.Text = Properties.Settings.Default.QPrompt4;
            txt_QuickPrompt5.Text = Properties.Settings.Default.QPrompt5;


            if (switchDarkMode.Switched)
                metroStyleManager.Style = ReaLTaiizor.Enum.Metro.Style.Dark;

            foreach (string item in Properties.Settings.Default.prePromtSelections)
            {
                // Add items from the StringCollection to the ComboBox
                cmbPrePrompts.Items.Add(item);
            }
            //check autostart
            AutoStartManager autoStartManager = new AutoStartManager(Assembly.GetExecutingAssembly().GetName().Name);
            if (autoStartManager.IsInAutoStart())
                chkBAutoStartApp.Checked = true;
            else
                chkBAutoStartApp.Checked = false;

            //Handle tab selection from the main popup
            if (startTab == "TabPagePrompt")
            {
                //clean up 
                txt_resultPrompt.Text = "";

                TabControl.SelectTab("TabPagePrompt");
                txt_inputPrompt.Select(0, 0);
                btn_sendPrompt.Focus();
            }
            if (startTab == "TabPageTTS")
            {
                TabControl.SelectTab("TabPageTTS");
                btn_playTTS.Focus();
                if (txt_TextTTS.Text.Length > 0 && Properties.Settings.Default.AutoStartTTS)
                    btn_play_Click(this, EventArgs.Empty);
            }
            if (startTab == "TabPageSTT")
            {
                txt_resultSTT.Text = "";
                TabControl.SelectTab("TabPageSTT");
                // Check if there is an available recording device
                if (WaveIn.DeviceCount < 1)
                {
                    statusLabel.Text = "No microphone device found!";
                    btn_record.Enabled = false;
                }
                else
                {
                    if (Properties.Settings.Default.AutoStartSTT)
                        btn_record_Click(this, EventArgs.Empty);
                    btn_record.Select();
                }
            }
            if (startTab == "TabPageSettings")
            {

                //cmbx_SettingQuickPromptModel.Items.AddRange(new ListViewItem[] {
                TabControl.SelectTab("TabPageSettings");
            }
        }

        private void cmbSttEngine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSttEngine.SelectedItem != null)
            {
                Properties.Settings.Default.STTEngine = cmbSttEngine.SelectedItem.ToString();
                Properties.Settings.Default.Save();
                UpdateWhisperNetModelControlsVisibility();
            }
        }

        private void cmbWhisperNetModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWhisperNetModel.SelectedItem != null)
            {
                Properties.Settings.Default.WhisperNetModel = cmbWhisperNetModel.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void UpdateWhisperNetModelControlsVisibility()
        {
            bool isWhisperNetSelected = (cmbSttEngine.SelectedItem?.ToString() == "Whisper.net");
            lblWhisperNetModel.Visible = isWhisperNetSelected;
            cmbWhisperNetModel.Visible = isWhisperNetSelected;
            // You might want to use .Enabled instead of .Visible if you prefer them to be grayed out
            // lblWhisperNetModel.Enabled = isWhisperNetSelected;
            // cmbWhisperNetModel.Enabled = isWhisperNetSelected;
        }

        public static Bitmap LoadImageFromBase64String(string base64String)
        {
            // Convert the Base64 string back to a byte array
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Create a MemoryStream from the byte array
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Load the image from the MemoryStream
                return new Bitmap(ms);
            }
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel.Text = "Idle";
            toolTipMain.SetToolTip(statusLabel, null);

            if (TabControl.SelectedTab.Text == "TabPagePrompt")
            {

                // Give focus to the input textbox
                txt_inputPrompt.Focus();
                // Set the cursor to the beginning of the text
                //txt_input.Select(0, 0);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing form: " + ex.Message);
            }
        }
        /// <summary>
        /// Event handler for key presses.
        /// Handles the Alt+Enter key combination to trigger Send button click.
        /// </summary>
        private void txt_inputPrompt_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Enter && e.Modifiers == Keys.Alt) || (e.KeyCode == Keys.Enter && e.Shift))
            {
                try
                {
                    // Trigger the Send button click event when Alt + Enter is pressed
                    btn_send_Click(sender, e);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error processing key press: " + ex.Message);
                }
            }
        }

        private void txt_inputPrompt_KeyPressed(object sender, KeyPressEventArgs e)
        {

        }
        /// <summary>
        /// Tries to delete file
        /// </summary>
        /// <param name="files">String with file path to delete.</param>
        private void deleteFile(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                    System.IO.File.Delete(path);
            }
            catch (Exception ex) { Debug.WriteLine(ex); } // Log the error but continue
        }

        /// <summary>
        /// Tries to delete files
        /// </summary>
        /// <param name="files">Array of file paths to delete.</param>
        static void DeleteFiles(string[] files)
        {
            foreach (var file in files)
            {
                try
                {
                    if (System.IO.File.Exists(file))
                        System.IO.File.Delete(file);
                }
                catch (Exception ex) { Debug.WriteLine(ex); } // Log the error but continue
            }
        }
        #endregion

        #region "SpeachToText"
        private void btn_record_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                try
                {
                    txt_resultSTT.Text = "";
                    StartRecording();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error recording voice: " + ex.Message);
                }
                btn_record.Text = "Stop";
                btn_record.NormalBorderColor = System.Drawing.Color.Red;
                statusLabel.Text = "Recording...";
            }
            else
            {
                try
                {
                    StopRecording();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error processing recording: " + ex.Message);
                }
                btn_record.Text = "Record";
                btn_record.NormalBorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
                statusLabel.Text = "Stopped. MP3 Saved...";
            }
            btn_record.Select();
        }
        private void StartRecording()
        {
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
                waveWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };

            // Event when recording stops
            waveIn.RecordingStopped += (s, a) =>
            {
                statusLabel.Text = "Processing recording...";
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
                    transcribe(pathToFile);
                }
                else
                {
                    // Use WAV for Whisper.net
                    string pathToFile = SaveAsWav(waveStream);
                    waveWriter.Dispose();
                    waveStream.Dispose();
                    waveIn.Dispose();
                    transcribe(pathToFile);
                }

                toolTipMain.SetToolTip(statusLabel, null);
            };

            // Start recording
            waveIn.StartRecording();
            isRecording = true;
        }

        private void comboBoxSttLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Properties.Settings.Default.STT_lang = cmbSttLanguage.SelectedItem.ToString();
                Properties.Settings.Default.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }
        private void StopRecording()
        {
            if (waveIn != null)
            {
                // Stop recording
                waveIn.StopRecording();
                isRecording = false;
            }
        }

        // Save the recorded data as an MP3 file
        private string SaveAsMp3(MemoryStream waveStream)
        {
            waveStream.Position = 0; // Reset the position of the memory stream

            string tempFile = Path.Combine(Path.GetTempPath(), $"STT.mp3");
            deleteFile(tempFile);
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
            deleteFile(tempFile);
            using (var fileStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                // Copy the wave data directly without conversion
                waveStream.CopyTo(fileStream);
            }
            return tempFile;
        }

        private async void transcribe(string path)
        {
            try
            {
                string resultText = string.Empty;
                string selectedEngine = Properties.Settings.Default.STTEngine; // Placeholder for actual setting

                // Default to OpenAI if setting is not present or invalid
                if (string.IsNullOrEmpty(selectedEngine) || (selectedEngine != "OpenAI" && selectedEngine != "Whisper.net"))
                {
                    selectedEngine = "OpenAI";
                }

                if (selectedEngine == "Whisper.net")
                {
                    statusLabel.Text = "Transcribing (Whisper.net)...";
                    string modelName = Properties.Settings.Default.WhisperNetModel; // e.g., "Base"
                    if (string.IsNullOrEmpty(modelName)) modelName = "Base"; // Default model

                    if (Enum.TryParse<GgmlType>(modelName, true, out GgmlType selectedModelType))
                    {
                        var segments = await _whisperNetService.TranscribeAsync(path, selectedModelType, cmbSttLanguage.Text.Trim());
                        resultText = string.Join(" ", segments.Select(s => s.Text));
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Whisper.net model type specified in settings: {modelName}. Falling back to Base model.");
                        var segments = await _whisperNetService.TranscribeAsync(path, GgmlType.Base, cmbSttLanguage.Text.Trim());
                        resultText = string.Join(" ", segments.Select(s => s.Text));
                    }
                }
                else // Default to OpenAI
                {
                    statusLabel.Text = "Transcribing (OpenAI)...";
                    resultText = await openAiApi.Transcriptions.GetTextAsync(path, cmbSttLanguage.Text.Trim());
                }

                if (txt_resultSTT.InvokeRequired)
                {
                    txt_resultSTT.Invoke(new Action(() =>
                    {
                        txt_resultSTT.Text += resultText;
                        statusLabel.Text = "Transcription complete.";
                    }));
                }
                else
                {
                    txt_resultSTT.Text += resultText;
                    statusLabel.Text = "Transcription complete.";
                }

                deleteFile(path);
            }
            catch (Exception ex) // Catch specific exceptions if possible
            {
                // Log the exception or show a more specific error message
                MessageBox.Show($"Error during transcription: {ex.Message}", "Transcription Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (txt_resultSTT.InvokeRequired)
                {
                    txt_resultSTT.Invoke(new Action(() => statusLabel.Text = "Transcription failed."));
                }
                else
                {
                    statusLabel.Text = "Transcription failed.";
                }
                // Consider not re-throwing if you handle it here, or re-throw a custom exception
                // throw;
            }
        }

        /// <summary>
        /// Event handler for the Copy button click.
        /// Copies the result text to the clipboard and hides the form.
        /// </summary>
        private void btn_copySTT_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_resultSTT.Text);
                this.Close();
                this.ShowInTaskbar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }

        private void btn_clearSTT_Click(object sender, EventArgs e)
        {
            txt_resultSTT.Text = "";
        }

        private void btn_asPromptSTT_Click(object sender, EventArgs e)
        {
            txt_inputPrompt.Text = txt_resultSTT.Text + Environment.NewLine + txt_inputPrompt.Text;

            TabControl.SelectTab("TabPagePrompt");
            txt_inputPrompt.Select(0, 0);
            btn_sendPrompt.Focus();
        }

        #endregion

        #region "TTS"

        /// <summary>
        /// Handles the play button click event.
        /// Sends a text-to-speech request and processes the response.
        /// </summary>
        private async void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                btn_playTTS.Enabled = false; // Disable play button to prevent multiple clicks
                statusLabel.Text = "Requesting...";

                string txt = txt_TextTTS.Text;
                string voice = cmbBxVoiceTTS.Text.ToLower();
                double speed = (double)((4.0 / 100) * range_SpeedTTS.Value);
                speed = speed < 0.25 ? 0.25 : speed; //min 0,25
                speed = speed > 4.0 ? 4 : speed; //max 4
                // Stream the TTS result asynchronously
                await Task.Run(() => StreamTTS(txt, voice, speed));

                // Get the generated MP3 files from the temp directory
                string[] mp3Files = Directory.GetFiles(Path.GetTempPath(), "TTS*.mp3");

                // If the user chose to download the result, save the merged MP3 file
                if (checkBoxDownloadTTS.Checked)
                    SaveMergedFiles(mp3Files);

                // Delete temporary audio files after processing
                DeleteFiles(mp3Files);
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error getting transcription! ";
                toolTipMain.SetToolTip(statusLabel, ex.Message);
            }
            finally
            {
                btn_playTTS.Enabled = true;
                btn_stopTTS.Enabled = false;
            }
        }

        /// <summary>
        /// Saves merged MP3 files into a single output file using SaveFileDialog.
        /// </summary>
        /// <param name="mp3Files">Array of MP3 file paths to merge.</param>
        private void SaveMergedFiles(string[] mp3Files)
        {
            using (var saveFileDialog = new SaveFileDialog
            {
                FileName = "tts.mp3",
                Filter = "MP3 files (*.mp3)|*.mp3",
                DefaultExt = "mp3",
                AddExtension = true,
                Title = "Save audio file as..."
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Merge MP3 files into one file
                        MergeMp3Files(mp3Files, saveFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        statusLabel.Text = "Error moving file!";
                        toolTipMain.SetToolTip(statusLabel, ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Downloads text-to-speech audio chunks asynchronously, saves them to temporary files, and merges them.
        /// </summary>
        /// <param name="text">The text to convert to speech.</param>
        /// <param name="voice">The selected voice for TTS.</param>
        /// <param name="speed">The playback speed for TTS.</param>
        /// <param name="chunkSize">The size of each text chunk to be converted.</param>
        /// <returns>Task for asynchronous execution.</returns>
        async Task DownloadTTS(string text, string voice, double speed, int chunkSize = 4096)
        {
            try
            {
                var chunks = SplitTextIntoChunks(text, chunkSize); // Split text into manageable chunks

                for (int i = 0; i < chunks.Count; i++)
                {
                    string tempFile = Path.Combine(Path.GetTempPath(), $"TTS{i}.mp3");

                    try
                    {
                        var req = new TextToSpeechRequest
                        {
                            Input = chunks[i],
                            ResponseFormat = "mp3",
                            Voice = voice,
                            Speed = speed,
                            Model = OpenAI_API.Models.Model.TTS_Speed
                        };

                        // Save each speech chunk to a file
                        await openAiApi.TextToSpeech.SaveSpeechToFileAsync(req, tempFile);
                    }
                    catch (Exception ex)
                    {
                        statusLabel.Text = "Failed storing file! ";
                        toolTipMain.SetToolTip(statusLabel, ex.Message);
                    }
                }

                // Merge and save files
                string[] mp3Files = Directory.GetFiles(Path.GetTempPath(), "TTS*.mp3");
                SaveMergedFiles(mp3Files);
                DeleteFiles(mp3Files);
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error downloading TTS";
                toolTipMain.SetToolTip(statusLabel, ex.Message);
            }
        }

        /// <summary>
        /// Streams the text-to-speech audio asynchronously and plays it.
        /// Also saves the streamed result as a temporary MP3 file.
        /// </summary>
        /// <param name="text">The text to convert to speech.</param>
        /// <param name="voice">The selected voice for TTS.</param>
        /// <param name="speed">The playback speed for TTS.</param>
        /// <param name="chunkSize">The size of each text chunk to be converted.</param>
        /// <returns>Task for asynchronous execution.</returns>
        async Task StreamTTS(string text, string voice, double speed, int chunkSize = 4096)
        {
            try
            {
                var chunks = SplitTextIntoChunks(text, chunkSize); // Split the text into chunks

                for (int i = 0; i < chunks.Count; i++)
                {
                    using (var result = await openAiApi.TextToSpeech.GetSpeechAsStreamAsync(chunks[i], voice, speed, "mp3", OpenAI_API.Models.Model.TTS_Speed))
                    {
                        Thread.Sleep(500); // Allow time for buffering

                        if (result.Length > 0)
                        {
                            Invoke((Action)(() => { btn_stopTTS.Enabled = true; statusLabel.Text = "Playing..."; }));

                            // Play the MP3 stream
                            using (var mp3Reader = new Mp3FileReader(result))
                            using (var waveOut = new WaveOutEvent())
                            {
                                waveOut.Init(mp3Reader);
                                waveOut.Play();

                                // Continue playback unless stopped by the user
                                while (waveOut.PlaybackState == PlaybackState.Playing && !shouldStop)
                                {
                                    Thread.Sleep(100);
                                }

                                if (shouldStop)
                                {
                                    waveOut.Stop();
                                    shouldStop = false;
                                }
                            }

                            // Save streamed result as a temp file
                            await SaveResultAsTempFile(result, i);
                        }
                    }
                }

                Invoke((Action)(() =>
                {
                    statusLabel.Text = "Idle";
                    toolTipMain.SetToolTip(statusLabel, null);
                }));
            }
            catch (Exception ex)
            {
                Invoke((Action)(() =>
                {
                    statusLabel.Text = "Error playing stream: " + ex.Message;
                    toolTipMain.SetToolTip(statusLabel, ex.Message);
                }));

            }
        }

        /// <summary>
        /// Saves the streamed audio result as a temporary MP3 file.
        /// </summary>
        /// <param name="result">The audio stream to save.</param>
        /// <param name="index">The index to name the temporary file uniquely.</param>
        /// <returns>Task for asynchronous execution.</returns>
        async Task SaveResultAsTempFile(Stream result, int index)
        {
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    result.Position = 0;
                    await result.CopyToAsync(memoryStream);
                    string tempFile = Path.Combine(Path.GetTempPath(), $"TTS{index}.mp3");
                    System.IO.File.WriteAllBytes(tempFile, memoryStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Failed storing file! ";
                toolTipMain.SetToolTip(statusLabel, ex.Message);
            }
        }

        /// <summary>
        /// Splits a long text into smaller chunks to handle the TTS request more efficiently.
        /// </summary>
        /// <param name="text">The input text to split.</param>
        /// <param name="chunkSize">The maximum size of each chunk.</param>
        /// <returns>List of text chunks.</returns>
        List<string> SplitTextIntoChunks(string text, int chunkSize)
        {
            var chunks = new List<string>();
            int currentPosition = 0;

            while (currentPosition < text.Length)
            {
                // Determine the chunk end position while ensuring that words are not split
                int endPosition = Math.Min(currentPosition + chunkSize, text.Length);
                if (endPosition < text.Length && !char.IsWhiteSpace(text[endPosition]))
                {
                    int lastSpaceIndex = text.LastIndexOf(' ', endPosition);
                    if (lastSpaceIndex > currentPosition) endPosition = lastSpaceIndex;
                }

                chunks.Add(text.Substring(currentPosition, endPosition - currentPosition).Trim());
                currentPosition = endPosition;

                // Skip any spaces at the start of the next chunk
                while (currentPosition < text.Length && char.IsWhiteSpace(text[currentPosition]))
                    currentPosition++;
            }

            return chunks;
        }

        /// <summary>
        /// Merges multiple MP3 files into a single output MP3 file.
        /// </summary>
        /// <param name="mp3Files">Array of MP3 file paths to merge.</param>
        /// <param name="outputFilePath">The path where the merged MP3 file will be saved.</param>
        static void MergeMp3Files(string[] mp3Files, string outputFilePath)
        {
            using (var writer = new FileStream(outputFilePath, FileMode.Create))
            {
                foreach (var mp3File in mp3Files)
                {
                    using (var reader = new Mp3FileReader(mp3File))
                    {
                        Mp3Frame frame;
                        while ((frame = reader.ReadNextFrame()) != null)
                        {
                            writer.Write(frame.RawData, 0, frame.RawData.Length);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the stop button click event to stop audio playback.
        /// </summary>
        private void btn_stop_Click(object sender, EventArgs e) => shouldStop = true;

        /// <summary>
        /// Handles changes to the voice selection combo box.
        /// </summary>
        private void cmbBxVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //make it lower case and save
            Properties.Settings.Default.TtsVoice = cmbBxVoiceTTS.Text.ToLower();
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Handles changes to the speed numeric up-down control.
        /// </summary>
        private void numUD_Speed_ValueChanged(object sender, EventArgs e) => Properties.Settings.Default.Save();

        /// <summary>
        /// Handles the download button click event to download and save the TTS output.
        /// </summary>
        private async void btn_Download_Click(object sender, EventArgs e)
        {
            // Clean up any leftover temporary files
            DeleteFiles(Directory.GetFiles(Path.GetTempPath(), "TTS*.mp3"));

            btn_playTTS.Enabled = false;
            statusLabel.Text = "Requesting file...";

            // Download the TTS output
            await DownloadTTS(txt_TextTTS.Text, cmbBxVoiceTTS.Text.ToLower(), (double)range_SpeedTTS.Value);

            btn_playTTS.Enabled = true;
            statusLabel.Text = "Idle";
            toolTipMain.SetToolTip(statusLabel, null);
        }

        private void Form_TTS_Load(object sender, EventArgs e)
        {
            string valueToSelect = char.ToUpper(Properties.Settings.Default.TtsVoice[0]) + Properties.Settings.Default.TtsVoice.Substring(1);
            // Check if the ComboBox contains the value
            int index = cmbBxVoiceTTS.FindStringExact(valueToSelect);

            if (index != -1)
            {
                // If the value is found, select it
                cmbBxVoiceTTS.SelectedIndex = index;
            }
            else
            {
                // If not found, select the first item
                if (cmbBxVoiceTTS.Items.Count > 0)
                {
                    cmbBxVoiceTTS.SelectedIndex = 0;
                }
            }

        }
        private void range_SpeedTTS_Scroll(object sender)
        {
            try
            {
                Properties.Settings.Default.TtsSpeed = range_SpeedTTS.Value;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }

        private void cmbBxVoiceTTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.TtsVoice = cmbBxVoiceTTS.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }

        private void TabControl_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the focused control is btn_record and the space key was pressed
            if (TabControl.SelectedTab.Name == "TabPageSTT" && e.KeyCode == Keys.Space)
            {
                // Handle the space key 
                btn_record_Click(sender, e);
            }
        }
        #endregion

        #region "Prompt"

        /// <summary>
        /// Event handler for the Send button click.
        /// Sends a chat prompt to the OpenAI API and displays the response.
        /// </summary>
        private async void btn_send_Click(object sender, EventArgs e)
        {
            txt_resultPrompt.Text = "";
            try
            {
                string inputText = txt_inputPrompt.Text;

                // Create the chat request
                var chatRequest = new ChatRequest()
                {
                    Model = Properties.Settings.Default.ModelLLM,
                    Messages = new[]
                    {
                        new ChatMessage(ChatMessageRole.System,
                            Properties.Settings.Default.PrePromt
                            + (!string.IsNullOrWhiteSpace(this.cmbPrePrompts.Text) ? " " + this.cmbPrePrompts.Text : "")),
                        new ChatMessage(ChatMessageRole.User, inputText)
                    }
                };

                //adding the image
                if (base64Image != null)
                {
                    // Convert the Base64 string back to a byte array
                    byte[] imageBytes = Convert.FromBase64String(base64Image);
                    chatRequest.Messages[1].Images.Add(ImageInput.FromImageBytes(imageBytes));
                }


                this.Cursor = Cursors.WaitCursor;

                // Send the request and get the response
                var chatResult = await openAiApi.Chat.CreateChatCompletionAsync(chatRequest);

                this.Cursor = Cursors.Default;

                if (chatResult != null)
                {
                    var result = chatResult.Choices[0].Message.TextContent;
                    //remove any <thinking> blocks
                    if (Properties.Settings.Default.ExcludeAiThoughts)
                    {
                        result = Regex.Replace(result, @"<thinking>(.*?)</thinking>", "", RegexOptions.Multiline);
                    }

                    txt_resultPrompt.Text = result;
                    btn_insertPrompt.Enabled = true;
                    btn_copyPrompt.Enabled = true;
                    btn_sendPrompt.Enabled = false;
                    statusLabel.Text = "Tokens used: " + chatResult.Usage.TotalTokens.ToString();
                }
                else
                {
                    MessageBox.Show("Error: Unable to communicate with OpenAI API");
                }
            }

            catch (System.Net.Http.HttpRequestException ex) when (ex.Message.Contains("NotFound"))
            {
                MessageBox.Show("HTTP Request Error: URL not found. Please check the API endpoint URL.\n\nError details: " + ex.Message,
                                "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optional: additional handling, e.g., retry logic or alert to user
            }
            catch (System.Net.Http.HttpRequestException ex)
            {
                // General HttpRequestException handling for any other HTTP-related errors
                MessageBox.Show("An HTTP request error occurred.\n\nError details: " + ex.Message,
                                "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Error during API call: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the Copy button click.
        /// Copies the result text to the clipboard and hides the form.
        /// </summary>
        private void btn_copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_resultPrompt.Text);
                this.Hide();
                this.ShowInTaskbar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the Insert button click.
        /// Inserts the result text into the previously focused window using paste operation.
        /// </summary>
        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (previousWindowHandle != IntPtr.Zero)
                {
                    // Set focus back to the previously focused window
                    if (SetForegroundWindow(previousWindowHandle))
                    {
                        // Set text to clipboard
                        Clipboard.SetText(txt_resultPrompt.Text);
                        // Send Ctrl+V to paste the selected text
                        SendKeys.SendWait("^v");

                        // Reset the window handle
                        previousWindowHandle = IntPtr.Zero;
                    }
                    else
                    {
                        MessageBox.Show("Error: Unable to set focus to the previous window.");
                    }
                }

                this.Hide();
                this.ShowInTaskbar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting text: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for input text changes.
        /// Enables the Send button when text is input.
        /// </summary>
        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_inputPrompt.Text.Length > 0)
                    btn_sendPrompt.Enabled = true;
                else
                    btn_sendPrompt.Enabled = false;

                if (txt_inputPrompt.Text == "Prompt here...")
                    txt_inputPrompt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing text change: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for model selection changes.
        /// Saves the selected model setting.
        /// </summary>
        private void cmb_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.ModelLLM = cmb_Model.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message);
            }
        }

        /// <summary>        
        /// Saves the prepromts to settings
        /// </summary>
        private void SavePrePrompts()
        {
            // Create or retrieve the existing StringCollection
            StringCollection items = Properties.Settings.Default.prePromtSelections ?? new StringCollection();

            // Clear current items in the StringCollection and add updated ones from ComboBox
            items.Clear();
            foreach (var item in cmbPrePrompts.Items)
            {
                items.Add(item.ToString());
            }

            // Save the updated StringCollection back to settings
            Properties.Settings.Default.prePromtSelections = items;
            Properties.Settings.Default.Save();
        }

        private void btnAddPrePromt_Click(object sender, EventArgs e)
        {
            // Get the entered text
            string enteredText = InputBox.Show("Enter a custom directive :", "New directive");
            if (!string.IsNullOrWhiteSpace(enteredText))
            {
                // Add the new item if it's not already in the ComboBox
                if (!cmbPrePrompts.Items.Contains(enteredText) && !string.IsNullOrEmpty(enteredText))
                {
                    cmbPrePrompts.Items.Add(enteredText);
                    cmbPrePrompts.SelectedIndex = cmbPrePrompts.Items.Count - 1; // Select the newly added item
                }
                SavePrePrompts();
            }
        }

        private void btnRemovePrePromt_Click(object sender, EventArgs e)
        {
            // Remove selected item from ComboBox and save the updated list to settings
            if (cmbPrePrompts.SelectedItem != null)
            {
                cmbPrePrompts.Items.Remove(cmbPrePrompts.SelectedItem);
                SavePrePrompts();
            }
        }


        private void cmbPrePrompts_TextChanged(object sender, EventArgs e)
        {
            //not an existing item selected, disable the remove button otherwise enable
            if (cmbPrePrompts.SelectedIndex == -1)
            {
                btnRemovePrePromt.Enabled = false;
            }
            else
            {
                btnRemovePrePromt.Enabled = true;
            }
        }

        private void sendToTTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_TextTTS.Text = txt_inputPrompt.Text;

            TabControl.SelectTab("TabPageTTS");
            btn_playTTS.Focus();
            if (txt_TextTTS.Text.Length > 0 && Properties.Settings.Default.AutoStartTTS)
                btn_play_Click(this, EventArgs.Empty);

        }
        private void setAsPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_inputPrompt.Text = txt_resultPrompt.Text;
            txt_resultPrompt.Text = "";
            btn_sendPrompt.Enabled = true;
            txt_resultPromptContextMenu.Hide();
            btn_sendPrompt.Focus();
            txt_resultPromptContextMenu.Hide();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_resultPrompt.Copy();
            txt_resultPromptContextMenu.Hide();
        }
        private void picPromptToolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            base64Image = null;
            picPrompt.Image = null;
            picPrompt.Visible = false;
        }

        private void txt_inputPrompt_Click(object sender, EventArgs e)
        {
            if (txt_inputPrompt.Text == "Prompt here...")
                txt_inputPrompt.Text = "";
        }

        #endregion

        #region "Settings"
        private void btn_saveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.API_Key = txt_ApiKey.Text;
                Properties.Settings.Default.PrePromt = txt_PrePrompt.Text;
                Properties.Settings.Default.ExcludeAiThoughts = chkExThoughts.Checked;
                txt_API_URL.Text = txt_API_URL.Text.EndsWith("/")
                    ? txt_API_URL.Text
                    : txt_API_URL.Text + "/";
                Properties.Settings.Default.API_URL = txt_API_URL.Text;
                openAiApi = new OpenAIAPI(txt_ApiKey.Text);
                openAiApi.ApiUrlFormat = txt_API_URL.Text + "{0}/{1}";

                Properties.Settings.Default.FirstLaunch = false;
                Properties.Settings.Default.useDarkMode = switchDarkMode.Switched;
                Properties.Settings.Default.AutoStartSTT = chkAutoStartSTT.Checked;
                Properties.Settings.Default.AutoStartTTS = chkAutoStartTTS.Checked;
                Properties.Settings.Default.STTEngine = cmbSttEngine.SelectedItem.ToString();
                Properties.Settings.Default.STT_lang = cmbSttLanguage.SelectedItem.ToString();
                Properties.Settings.Default.WhisperNetModel = cmbWhisperNetModel.SelectedItem.ToString();
                //hotkey changed? need a restart for now 
                //TODO: make some kind of auto reload in the mainPopup
                if (txt_HotkeyKey.Text != Properties.Settings.Default.HotKeyKey ||
                    cmbHotKeyMod.SelectedItem.ToString() != Properties.Settings.Default.HotKeyMod ||
                    txt_SttHotkeyKey.Text != Properties.Settings.Default.SttHotKeyKey ||
                    cmbSttHotKeyMod.SelectedItem.ToString() != Properties.Settings.Default.SttHotKeyMod)
                    MessageBox.Show("A change of HotKey, currently requires a program restart!");

                Properties.Settings.Default.HotKeyKey = txt_HotkeyKey.Text;
                Properties.Settings.Default.HotKeyMod = cmbHotKeyMod.SelectedItem.ToString();
                Properties.Settings.Default.SttHotKeyKey = txt_SttHotkeyKey.Text;
                Properties.Settings.Default.SttHotKeyMod = cmbSttHotKeyMod.SelectedItem.ToString();

                if (cmb_SettingQuickPromptModel.Items.Count > 0)
                {
                    Properties.Settings.Default.QPromptModel = cmb_SettingQuickPromptModel.SelectedItem.ToString();
                }
                Properties.Settings.Default.QPrompt1 = txt_QuickPrompt1.Text;
                Properties.Settings.Default.QPrompt2 = txt_QuickPrompt2.Text;
                Properties.Settings.Default.QPrompt3 = txt_QuickPrompt3.Text;
                Properties.Settings.Default.QPrompt4 = txt_QuickPrompt4.Text;
                Properties.Settings.Default.QPrompt5 = txt_QuickPrompt5.Text;

                Properties.Settings.Default.Save();
                // if whisper.net is selected, download the model
                if (cmbSttEngine.SelectedItem.ToString() == "Whisper.net")
                {
                    string model = Properties.Settings.Default.WhisperNetModel;
                    if (Enum.TryParse<GgmlType>(model, true, out GgmlType selectedModelType))
                    {
                        Task.Run(async () =>
                        {
                            try
                            {
                                this.Invoke((System.Windows.Forms.MethodInvoker)delegate
                                {
                                    statusLabel.Text = $"Downloading Whisper.net model {model} ...";
                                });

                                await _whisperNetService.EnsureModelExistsAsync(selectedModelType).ConfigureAwait(false);

                                this.Invoke((System.Windows.Forms.MethodInvoker)delegate
                                {
                                    statusLabel.Text = $"Whisper.net model {model} downloaded.";
                                });
                            }
                            catch (Exception ex)
                            {
                                this.Invoke((System.Windows.Forms.MethodInvoker)delegate
                                {
                                    statusLabel.Text = $"Error downloading model: {ex.Message}";
                                });
                            }
                        });
                    }
                }
                //handle autostart
                AutoStartManager autoStartManager = new AutoStartManager(Assembly.GetExecutingAssembly().GetName().Name);
                if (chkBAutoStartApp.Checked)
                    autoStartManager.AddToAutoStart(); // Add to autostart
                else
                    autoStartManager.RemoveFromAutoStart(); // Remove from autostart
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving: " + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void txt_HotkeyKey_TextChanged(object sender, EventArgs e)
        {

            txt_HotkeyKey.Text = txt_HotkeyKey.Text.ToLower();
        }
        // Event handler to filter out invalid keys
        private void Txt_HotkeyKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow letters (A-Z), digits (0-9), and function keys (e.g., F1-F12)
            if (!IsValidHotKeyKey(e.KeyChar))
            {
                // Invalid key, prevent the character from being added
                e.Handled = true;
            }
        }
        private bool IsValidHotKeyKey(char keyChar)
        {
            // Check if the character is a letter or digit
            if (char.IsLetterOrDigit(keyChar))
                return true;

            // Allow common control keys (backspace, delete, etc.)
            if (char.IsControl(keyChar))
                return true;

            // Block everything else as invalid
            return false;
        }


        private void txt_SttHotkeyKey_TextChanged(object sender, EventArgs e)
        {
            txt_SttHotkeyKey.Text = txt_SttHotkeyKey.Text.ToLower();
        }

        private void txt_SttHotkeyKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow letters (A-Z), digits (0-9), and function keys (e.g., F1-F12)
            if (!IsValidHotKeyKey(e.KeyChar))
            {
                // Invalid key, prevent the character from being added
                e.Handled = true;
            }
        }
        private void switchDarkMode_SwitchedChanged(object sender)
        {
            try
            {
                Properties.Settings.Default.useDarkMode = switchDarkMode.Switched;
                if (switchDarkMode.Switched)
                    metroStyleManager.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
                else
                    metroStyleManager.Style = ReaLTaiizor.Enum.Metro.Style.Light;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }

        #endregion

        private void FormMain_Load(object sender, EventArgs e)
        {
            MinimumSize = new System.Drawing.Size(412, 562);
            chkAutoStartSTT.Checked = Properties.Settings.Default.AutoStartSTT;
            chkAutoStartTTS.Checked = Properties.Settings.Default.AutoStartTTS;
        }

        private void cmbSttEngine_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSttEngine.SelectedItem.ToString() == "Whisper.net")
            {
                // add "auto" as language option to STT cmb box            
                cmbSttLanguage.Items.Insert(0, "auto");
            }
            else
            {
                // remove "auto" from STT cmb box
                cmbSttLanguage.Items.Remove("auto");
            }
        }

    }
}

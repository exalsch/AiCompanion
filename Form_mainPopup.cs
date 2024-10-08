﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AiCompanion
{
    public partial class Form_mainPopup : Form
    {
        // Constants and Windows API declarations for hotkey handling
        private const int HOTKEY_ID = 1;

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
                if (Properties.Settings.Default.FirstLaunch && string.IsNullOrEmpty(Properties.Settings.Default.API_Key))
                {
                    if (Properties.Settings.Default.UseNewUI)
                    {
                        Properties.Settings.Default.API_Key = InputBox.Show("First Launch enter API Key:", "API Key not set");
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Form_Settings mainForm = new Form_Settings();
                        _ = mainForm.ShowDialog();
                    }
                }
                // Register a hotkey (Alt + G)
                RegisterUserHotkey();
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

            // Check if the hotkey was pressed
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                try
                {
                    // Get the window that had focus before the hotkey was pressed
                    _previousWindowHandle = GetForegroundWindow();

                    // Get the current content of the clipboard to compare
                    string copiedTextPre = Clipboard.GetText();

                    // Focus on the previous window and send a Ctrl+C to copy selected text
                    if (_previousWindowHandle != IntPtr.Zero && SetForegroundWindow(_previousWindowHandle))
                    {
                        System.Threading.Thread.Sleep(300);
                        SendKeys.SendWait("^c"); // Simulate pressing Ctrl+C
                        System.Threading.Thread.Sleep(100);

                        // Get the updated clipboard content
                        string copiedText = Clipboard.GetText();

                        // If the clipboard content changed, update the internal copy
                        if (copiedTextPre != copiedText)
                        {
                            _copiedText = copiedText;
                        }
                        else
                        { //try again
                            System.Threading.Thread.Sleep(100);
                            SendKeys.SendWait("^c"); // Simulate pressing Ctrl+C
                            System.Threading.Thread.Sleep(100);
                            copiedText = Clipboard.GetText();
                            if (copiedTextPre != copiedText)
                                _copiedText = copiedText;
                        }


                    }



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
        }

        /// <summary>
        /// Handles the click event for the 'Prompt' button, which opens the Form_TextPrompt form.
        /// </summary>
        private void btn_prompt_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and show the text prompt form
                var pForm = new Form_TextPrompt(_copiedText, _previousWindowHandle);
                ShowForm(pForm);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening Text Prompt form: " + ex.Message);
            }
        }

        /// <summary>
        /// Handles the click event for the 'TTS' button, which opens the Form_TTS form.
        /// </summary>
        private void btn_TTS_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and show the TTS form
                var ttsForm = new Form_TTS(_copiedText);
                ShowForm(ttsForm);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening TTS form: " + ex.Message);
            }
        }


        /// <summary>
        /// Handles the click event for the 'Speach-to-text' button, which opens the Form_Speach2Text form.
        /// </summary>
        private void btn_Speak2Text_Click(object sender, EventArgs e)
        {
            try
            {
                // Create and show the settings form as a modal dialog
                Form_Speach2Text STTform = new Form_Speach2Text();
                ShowForm(STTform);
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error opening Speach-to-text form: " + ex.Message);
            }
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
                // Unregister the hotkey, hide the tray icon, and exit the application
                _ = UnregisterHotKey(this.Handle, HOTKEY_ID);
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
                else
                {
                    Form_Settings mainForm = new Form_Settings();
                    _ = mainForm.ShowDialog();
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
                else
                {
                    Form_AboutBox mainForm = new Form_AboutBox();
                    _ = mainForm.ShowDialog();
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

                // Unregister and re-register the hotkey to ensure it remains functional
                _ = UnregisterHotKey(this.Handle, HOTKEY_ID);
                System.Threading.Thread.Sleep(100);
                RegisterUserHotkey();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("Error hiding form: " + ex.Message);
            }
        }
        #endregion

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
    }
}

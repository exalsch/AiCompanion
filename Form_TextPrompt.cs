using OpenAI_API;
using OpenAI_API.Chat;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AiCompanion
{
    public partial class Form_TextPrompt : Form
    {
        private const int HOTKEY_ID = 1;

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

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private IntPtr _previousWindowHandle; // Store the handle of the window that had focus
        private OpenAIAPI _openAIAPI;

        /// <summary>
        /// Constructor for Form_TextPrompt.
        /// Initializes the form with the given prompt and previous window handle.
        /// </summary>
        /// <param name="promt">Initial prompt text.</param>
        /// <param name="prevWindowHandle">Handle of the previously focused window.</param>
        public Form_TextPrompt(string promt, IntPtr prevWindowHandle)
        {
            InitializeComponent();
            this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version;

            try
            {
                string apiKey = Properties.Settings.Default.API_Key;
                _previousWindowHandle = prevWindowHandle;
                txt_input.Text = promt;

                // Initialize OpenAI API with the API key from environment variable
                _openAIAPI = new OpenAIAPI(apiKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing OpenAI API: " + ex.Message);
            }
        }

        /// <summary>
        /// Position the form near the current cursor location without going off-screen.
        /// </summary>
        private void position_form()
        {
            try
            {
                // Get the current position of the cursor
                Point cursorPosition = Cursor.Position;

                // Get the screen's working area (taking into account taskbars, etc.)
                Rectangle screenBounds = Screen.FromPoint(cursorPosition).WorkingArea;

                // Adjust the form's position to prevent it from going off-screen
                int formX = cursorPosition.X;
                int formY = cursorPosition.Y;

                // If the form would go off the right edge, move it to the left of the cursor
                if (formX + this.Width > screenBounds.Right)
                {
                    formX = screenBounds.Right - this.Width;
                }

                // If the form would go off the bottom edge, move it above the cursor
                if (formY + this.Height > screenBounds.Bottom)
                {
                    formY = screenBounds.Bottom - this.Height;
                }

                // Set the form's location
                this.Location = new Point(formX, formY);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error positioning form: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for the Send button click.
        /// Sends a chat prompt to the OpenAI API and displays the response.
        /// </summary>
        private async void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = txt_input.Text;

                // Create the chat request
                var chatRequest = new ChatRequest()
                {
                    Model = Properties.Settings.Default.ModelLLM,
                    Messages = new[]
                    {
                        new ChatMessage(ChatMessageRole.System, Properties.Settings.Default.PrePromt),
                        new ChatMessage(ChatMessageRole.User, inputText)
                    }
                };

                this.Cursor = Cursors.WaitCursor;

                // Send the request and get the response
                var chatResult = await _openAIAPI.Chat.CreateChatCompletionAsync(chatRequest);

                this.Cursor = Cursors.Default;

                if (chatResult != null)
                {
                    var result = chatResult.Choices[0].Message.TextContent;
                    txt_result.Text = result;
                    btn_insert.Enabled = true;
                    btn_copy.Enabled = true;
                    btn_send.Enabled = false;
                    toolStripStatusLabel.Text = "Tokens used: " + chatResult.Usage.TotalTokens.ToString();
                }
                else
                {
                    MessageBox.Show("Error: Unable to communicate with OpenAI API");
                }
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
                Clipboard.SetText(txt_result.Text);
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
                if (_previousWindowHandle != IntPtr.Zero)
                {
                    // Set focus back to the previously focused window
                    if (SetForegroundWindow(_previousWindowHandle))
                    {
                        // Set text to clipboard
                        Clipboard.SetText(txt_result.Text);
                        // Send Ctrl+V to paste the selected text
                        SendKeys.SendWait("^v");

                        // Reset the window handle
                        _previousWindowHandle = IntPtr.Zero;
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
        /// Event handler for the Cancel button click.
        /// Closes the form.
        /// </summary>
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
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.Alt)
            {
                try
                {
                    // Trigger the Send button click event when Alt + Enter is pressed
                    btn_send_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing key press: " + ex.Message);
                }
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
                btn_send.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing text change: " + ex.Message);
            }
        }

        /// <summary>
        /// Event handler for form activation.
        /// Sets focus to the input textbox when the form is activated.
        /// </summary>
        private void Form_TextPrompt_Activated(object sender, EventArgs e)
        {
            try
            {
                this.toolStripStatusLabel.Text = "";
                // Give focus to the input textbox
                txt_input.Focus();
                // Set the cursor to the beginning of the text
                txt_input.SelectionStart = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting focus to input field: " + ex.Message);
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
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message);
            }
        }
    }
}
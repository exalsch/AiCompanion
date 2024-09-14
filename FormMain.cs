﻿using NAudio.Lame;
using NAudio.Wave;
using OpenAI_API;
using OpenAI_API.Audio;
using OpenAI_API.Chat;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiCompanion
{
    public partial class FormMain : MaterialForm
    {
        private OpenAIAPI openAiApi; // Instance of the OpenAI API

        //TTS related globals
        private WaveInEvent waveIn;
        private WaveFileWriter waveWriter;
        private MemoryStream waveStream;
        private bool isRecording = false;
        //STT related globals
        private bool shouldStop = false; // Indicates if the audio playback should stop
        private IntPtr previousWindowHandle; // Store the handle of the window that had focus

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        #region "Shared and global"
        public FormMain(IntPtr prevWindowHandle, string startTab = "", string copiedText = "")
        {
            InitializeComponent();
            this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version;
            lblAboutVersion.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version;
            openAiApi = new OpenAIAPI(Properties.Settings.Default.API_Key);
            //pre fill controls and vars
            txt_TextTTS.Text = copiedText;
            txt_input.Text = copiedText;
            previousWindowHandle = prevWindowHandle;
            statusLabel.Text = "Idle";

            //Load settings
            cmbSttLanguage.SelectedText = Properties.Settings.Default.STT_lang;
            cmbBxVoiceTTS.SelectedText = Properties.Settings.Default.TtsVoice;
            cmb_Model.SelectedText = Properties.Settings.Default.ModelLLM;

            foreach (string item in Properties.Settings.Default.prePromtSelections)
            {
                // Add items from the StringCollection to the ComboBox
                cmbPrePrompts.Items.Add(item);
            }

            if (startTab == "TabPagePrompt")
            {
                TabControl.SelectTab("TabPagePrompt");
                txt_input.Select(0, 0);
                btn_sendPrompt.Focus();
            }
            if (startTab == "TabPageTTS")
            {
                TabControl.SelectTab("TabPageTTS");
                btn_playTTS.Focus();
            }
            if (startTab == "TabPageSTT")
            {
                TabControl.SelectTab("TabPageSTT");
                // Check if there is an available recording device
                if (WaveIn.DeviceCount < 1)
                {
                    statusLabel.Text = "No microphone device found!";
                    btn_record.Enabled = false;
                }
                else
                {
                    btn_record.Focus();
                }
            }
            if (startTab == "TabPageSettings")
            {
                TabControl.SelectTab("TabPageSettings");
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel.Text = "Idle";
            if (string.IsNullOrEmpty(Properties.Settings.Default.API_Key))
            {
                Properties.Settings.Default.API_Key = InputBox.Show("Enter API Key:", "API Key not set");
                Properties.Settings.Default.Save();
                TabControl.SelectTab("TabPageSettings");
            }
            if (TabControl.SelectedTab.Text == "TabPagePrompt")
            {

                // Give focus to the input textbox
                txt_input.Focus();
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
        /// Tries to delete file
        /// </summary>
        /// <param name="files">String with file path to delete.</param>
        private void deleteFile(string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
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
                    if (File.Exists(file))
                        File.Delete(file);
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
                StartRecording();
                btn_record.Text = "Stop";
                statusLabel.Text = "Recording...";
            }
            else
            {
                StopRecording();
                btn_record.Text = "Record";
                statusLabel.Text = "Stopped. MP3 Saved...";
            }
        }
        private void StartRecording()
        {
            // Initialize recording components
            waveIn = new WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new WaveFormat(44100, 1); // 44.1kHz, mono

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
                string pathToFile = SaveAsMp3(waveStream); // Save data as MP3
                waveWriter.Dispose(); // Dispose the wave writer after saving the MP3
                waveStream.Dispose(); // Dispose the stream after saving the MP3
                waveIn.Dispose(); // Clean up the waveIn resource
                transcribe(pathToFile);
                statusLabel.Text = "Idle";
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

        private async void transcribe(string path)
        {
            string resultText = await openAiApi.Transcriptions.GetTextAsync(path, cmbSttLanguage.Text.Trim());
            txt_resultSTT.Text = txt_resultSTT.Text + resultText;
            // inline
            //string resultText = await openAiApi.Transcriptions.GetTextAsync("conversation.mp3", "en", "This is a transcript of a conversation between a medical doctor and her patient: ", 0.3);
            deleteFile(path);
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
                double speed = (double)range_SpeedTTS.Value;

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
                statusLabel.Text = "Error: " + ex.Message;
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
                        statusLabel.Text = "Error moving file: " + ex.Message;
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
                        statusLabel.Text = "Failed storing file: " + ex.Message;
                    }
                }

                // Merge and save files
                string[] mp3Files = Directory.GetFiles(Path.GetTempPath(), "TTS*.mp3");
                SaveMergedFiles(mp3Files);
                DeleteFiles(mp3Files);
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error downloading TTS: " + ex.Message;
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
                }));
            }
            catch (Exception ex)
            {
                Invoke((Action)(() =>
                {
                    statusLabel.Text = "Error playing stream: " + ex.Message;
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
                    File.WriteAllBytes(tempFile, memoryStream.ToArray());
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Failed storing file: " + ex.Message;
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
        #endregion

        #region "Prompt"

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
                        new ChatMessage(ChatMessageRole.System,
                            Properties.Settings.Default.PrePromt
                            + (!string.IsNullOrWhiteSpace(this.cmbPrePrompts.Text) ? " " + this.cmbPrePrompts.Text : "")),
                        new ChatMessage(ChatMessageRole.User, inputText)
                    }
                };

                this.Cursor = Cursors.WaitCursor;

                // Send the request and get the response
                var chatResult = await openAiApi.Chat.CreateChatCompletionAsync(chatRequest);

                this.Cursor = Cursors.Default;

                if (chatResult != null)
                {
                    var result = chatResult.Choices[0].Message.TextContent;
                    txt_result.Text = result;
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
                if (previousWindowHandle != IntPtr.Zero)
                {
                    // Set focus back to the previously focused window
                    if (SetForegroundWindow(previousWindowHandle))
                    {
                        // Set text to clipboard
                        Clipboard.SetText(txt_result.Text);
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
                btn_sendPrompt.Enabled = true;
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
                Properties.Settings.Default.ModelLLM = cmb_Model.SelectedText;
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
            string enteredText = InputBox.Show("Enter an custom directive :", "New directive");
            // Add a dot and space if needed
            enteredText = !string.IsNullOrWhiteSpace(enteredText) && !enteredText.Trim().EndsWith(".") ? enteredText.TrimEnd() + ". " : enteredText;

            // Add the new item if it's not already in the ComboBox
            if (!cmbPrePrompts.Items.Contains(enteredText) && !string.IsNullOrEmpty(enteredText))
            {
                cmbPrePrompts.Items.Add(enteredText);
                cmbPrePrompts.SelectedIndex = cmbPrePrompts.Items.Count - 1; // Select the newly added item
            }
            SavePrePrompts();
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
            //not an existing item selected eable the add button otherwise disable
            if (cmbPrePrompts.SelectedIndex == -1)
            {
                btnAddPrePromt.Enabled = true;
                btnRemovePrePromt.Enabled = false;
            }
            else
            {
                btnAddPrePromt.Enabled = false;
                btnRemovePrePromt.Enabled = true;
            }
        }
        #endregion


        #region "Settings"
        private void btn_saveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.API_Key = txt_ApiKey.Text;
                Properties.Settings.Default.UseNewUI = chkUseNewUI.Checked;
                Properties.Settings.Default.FirstLaunch = false;
                Properties.Settings.Default.useDarkMode = switchDarkMode.Switched;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }
        #endregion

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
                Properties.Settings.Default.TtsVoice = cmbBxVoiceTTS.SelectedText;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            MinimumSize = new System.Drawing.Size(412, 562);
        }
    }
}

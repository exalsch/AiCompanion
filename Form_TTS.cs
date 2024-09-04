using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using OpenAI_API;
using OpenAI_API.Audio;
using System.Diagnostics;

namespace AiCompanion
{
    public partial class Form_TTS : Form
    {
        private bool shouldStop = false; // Indicates if the audio playback should stop
        private OpenAIAPI _openAIAPI; // Instance of the OpenAI API

        /// <summary>
        /// Constructor for the Form_TTS class.
        /// Initializes the form and sets up the OpenAI API.
        /// </summary>
        /// <param name="text">The initial text input for TTS conversion.</param>
        public Form_TTS(string text)
        {
            InitializeComponent();
            txt_Text.Text = text;
            _openAIAPI = new OpenAIAPI(Properties.Settings.Default.API_Key);
        }

        /// <summary>
        /// Handles the play button click event.
        /// Sends a text-to-speech request and processes the response.
        /// </summary>
        private async void btn_play_Click(object sender, EventArgs e)
        {
            try
            {
                btn_play.Enabled = false; // Disable play button to prevent multiple clicks
                toolStripStatusLabel.Text = "Requesting...";

                string txt = txt_Text.Text;
                string voice = cmbBxVoice.Text;
                double speed = (double)numUD_Speed.Value;

                // Stream the TTS result asynchronously
                await Task.Run(() => StreamTTS(txt, voice, speed));

                // Get the generated MP3 files from the temp directory
                string[] mp3Files = Directory.GetFiles(Path.GetTempPath(), "TTS*.mp3");

                // If the user chose to download the result, save the merged MP3 file
                if (checkBoxDownload.Checked)
                    SaveMergedFiles(mp3Files);

                // Delete temporary audio files after processing
                DeleteTempAudioFiles(mp3Files);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Error: " + ex.Message;
            }
            finally
            {
                btn_play.Enabled = true;
                btn_stop.Enabled = false;
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
                        toolStripStatusLabel.Text = "Error moving file: " + ex.Message;
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
                        await _openAIAPI.TextToSpeech.SaveSpeechToFileAsync(req, tempFile);
                    }
                    catch (Exception ex)
                    {
                        toolStripStatusLabel.Text = "Failed storing file: " + ex.Message;
                    }
                }

                // Merge and save files
                string[] mp3Files = Directory.GetFiles(Path.GetTempPath(), "TTS*.mp3");
                SaveMergedFiles(mp3Files);
                DeleteTempAudioFiles(mp3Files);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Error downloading TTS: " + ex.Message;
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
                    using (var result = await _openAIAPI.TextToSpeech.GetSpeechAsStreamAsync(chunks[i], voice, speed, "mp3", OpenAI_API.Models.Model.TTS_Speed))
                    {
                        Thread.Sleep(500); // Allow time for buffering

                        if (result.Length > 0)
                        {
                            Invoke((Action)(() => { btn_stop.Enabled = true; toolStripStatusLabel.Text = "Playing..."; }));

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

                toolStripStatusLabel.Text = "Idle";
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Error playing stream: " + ex.Message;
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
                toolStripStatusLabel.Text = "Failed storing file: " + ex.Message;
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
        /// Deletes temporary audio files generated during TTS conversion.
        /// </summary>
        /// <param name="files">Array of file paths to delete.</param>
        static void DeleteTempAudioFiles(string[] files)
        {
            foreach (var file in files)
            {
                try { File.Delete(file); }
                catch (Exception ex) { Debug.WriteLine(ex); } // Log the error but continue
            }
        }

        /// <summary>
        /// Handles the stop button click event to stop audio playback.
        /// </summary>
        private void btn_stop_Click(object sender, EventArgs e) => shouldStop = true;

        /// <summary>
        /// Handles changes to the voice selection combo box.
        /// </summary>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => Properties.Settings.Default.Save();

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
            DeleteTempAudioFiles(Directory.GetFiles(Path.GetTempPath(), "TTS*.mp3"));

            btn_play.Enabled = false;
            toolStripStatusLabel.Text = "Requesting file...";

            // Download the TTS output
            await DownloadTTS(txt_Text.Text, cmbBxVoice.Text, (double)numUD_Speed.Value);

            btn_play.Enabled = true;
            toolStripStatusLabel.Text = "Idle";
        }
    }
}

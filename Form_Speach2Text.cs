using NAudio.Lame;
using NAudio.Wave;
using OpenAI_API;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AiCompanion
{

    public partial class Form_Speach2Text : Form
    {

        private WaveInEvent waveIn;
        private WaveFileWriter waveWriter;
        private MemoryStream waveStream;
        private bool isRecording = false;
        private OpenAIAPI _openAIAPI; // Instance of the OpenAI API

        public Form_Speach2Text()
        {
            InitializeComponent();
            _openAIAPI = new OpenAIAPI(Properties.Settings.Default.API_Key);
            // Check if there is an available recording device
            if (WaveIn.DeviceCount < 1)
            {
                statusLabel.Text = "No microphone device found!";
                btn_record.Enabled = false;
            }
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            if (!isRecording)
            {
                StartRecording();
                btn_record.Text = "Stop Recording";
                statusLabel.Text = "Recording...";
            }
            else
            {
                StopRecording();
                btn_record.Text = "Start Recording";
                statusLabel.Text = "Stopped. MP3 Saved.";
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
                waveWriter.Flush(); // Ensure all data is written to the memory stream
                string pathToFile = SaveAsMp3(waveStream); // Save data as MP3
                waveWriter.Dispose(); // Dispose the wave writer after saving the MP3
                waveStream.Dispose(); // Dispose the stream after saving the MP3
                waveIn.Dispose(); // Clean up the waveIn resource
                transcribe(pathToFile);
            };

            // Start recording
            waveIn.StartRecording();
            isRecording = true;
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
            string resultText = await _openAIAPI.Transcriptions.GetTextAsync(path);
            txt_result.Text = txt_result.Text + resultText;
            // inline
            //string resultText = await openAiApi.Transcriptions.GetTextAsync("conversation.mp3", "en", "This is a transcript of a conversation between a medical doctor and her patient: ", 0.3);
            deleteFile(path);
        }

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
        /// Event handler for the Copy button click.
        /// Copies the result text to the clipboard and hides the form.
        /// </summary>
        private void btn_copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_result.Text);
                this.Close();
                this.ShowInTaskbar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error copying to clipboard: " + ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }
    }
}

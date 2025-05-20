using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Whisper.net;
using Whisper.net.Ggml;

namespace AiCompanion.Services
{
    public class WhisperNetService
    {
        private readonly string _modelsDirectory;

        public WhisperNetService(string modelsBasePath = null)
        {
            // Determine the directory to store models.
            // Defaults to a 'WhisperModels' subdirectory in the application's base directory.
            if (string.IsNullOrEmpty(modelsBasePath))
            {
                modelsBasePath = AppDomain.CurrentDomain.BaseDirectory;
            }
            _modelsDirectory = Path.Combine(modelsBasePath, "WhisperModels");

            // Ensure the models directory exists.
            if (!Directory.Exists(_modelsDirectory))
            {
                Directory.CreateDirectory(_modelsDirectory);
            }
        }

        public string GetModelPath(GgmlType ggmlType)
        {
            // Generates a standard model file name based on the GgmlType.
            // Example: GgmlType.Base -> "ggml-base.bin"
            return Path.Combine(_modelsDirectory, $"ggml-{ggmlType.ToString().ToLowerInvariant()}.bin");
        }

        public async Task<bool> EnsureModelExistsAsync(GgmlType ggmlType)
        {
            var modelPath = GetModelPath(ggmlType);
            if (!File.Exists(modelPath))
            {
                Console.WriteLine($"Model {modelPath} not found. Attempting to download...");
                try
                {
                    using var modelStream = await WhisperGgmlDownloader.Default.GetGgmlModelAsync(ggmlType);
                    using var fileWriter = File.OpenWrite(modelPath);
                    await modelStream.CopyToAsync(fileWriter);
                    Console.WriteLine($"Model {modelPath} downloaded successfully.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error downloading model {ggmlType}: {ex.Message}");
                    // Clean up partially downloaded file if it exists
                    if (File.Exists(modelPath))
                    {
                        File.Delete(modelPath);
                    }
                    return false;
                }
            }
            return true; // Model already exists
        }

        public async Task<List<SegmentData>> TranscribeAsync(string audioFilePath, GgmlType modelType = GgmlType.Base, string language = "auto")
        {
            var transcriptionResults = new List<SegmentData>();
            var modelPath = GetModelPath(modelType);

            if (!File.Exists(audioFilePath))
            {
                Console.WriteLine($"Audio file not found: {audioFilePath}");
                return transcriptionResults; // Return empty list
            }

            if (!await EnsureModelExistsAsync(modelType))
            {
                Console.WriteLine($"Could not ensure model {modelType} is available. Transcription aborted.");
                return transcriptionResults; // Return empty list
            }

            try
            {
                using var whisperFactory = WhisperFactory.FromPath(modelPath);
                using var processor = whisperFactory.CreateBuilder()
                    .WithLanguage(language)
                    .Build();

                using var fileStream = File.OpenRead(audioFilePath);

                await foreach (var segment in processor.ProcessAsync(fileStream))
                {
                    transcriptionResults.Add(segment);
                    // For now, just logging. In a real app, you'd collect these or stream them.
                    Console.WriteLine($"[{segment.Start} -> {segment.End}]: {segment.Text}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during transcription with model {modelType}: {ex.Message}");
                // Optionally, clear results if partial transcription is not desired on error
                // transcriptionResults.Clear();
            }

            return transcriptionResults;
        }

        public IEnumerable<GgmlType> GetAvailableModelTypes()
        {
            // Returns all GgmlType enum values.
            // You might want to filter this list based on what you practically want to offer.
            return Enum.GetValues(typeof(GgmlType)).Cast<GgmlType>();
        }
    }
}

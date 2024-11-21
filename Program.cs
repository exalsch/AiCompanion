using OpenAI_API;
using OpenAI_API.Models;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: Add Settings window to allow setting API key, model, API Endpoint,pre-promt additions, https://stackoverflow.com/a/62018445/3193057
//TODO: Add tokenizer to be able calculating cost (https://antbucc.github.io/PE4GenAI/tokenization/)
//TODO: Add region screenshoter to send it to GPT4-o-vision with a promt. New form?
//TODO: Add autostart option
/*TODO: Enable local OOLAMA usage:
 * OpenAIClientOptions settings = new()
 *{
 *    Endpoint = new Uri("https://my-domain.tld")
 *}; 
 */

namespace AiCompanion
{
    internal static class Program
    {

        // Global list to store model information
        public static List<Model> modelsList = new List<Model>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Check settings
            string apiKey = Properties.Settings.Default.API_Key;

            if (string.IsNullOrEmpty(apiKey) || Properties.Settings.Default.FirstLaunch)
            {
                MessageBox.Show("API key need to be set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
                //Show settings as dialog but hide other tabs
                FormMain setForm = new FormMain(0, "TabPageSettings");
                foreach (ReaLTaiizor.Child.Metro.MetroTabPage tabPage in setForm.TabControl.TabPages)
                {
                    if(tabPage.Name!= "TabPageSettings")
                        tabPage.Hide();                    

                }
                setForm.ShowDialog();
                foreach(ReaLTaiizor.Child.Metro.MetroTabPage tabPage in setForm.TabControl.TabPages)
                {
                    if (tabPage.Name != "TabPageSettings")
                        tabPage.Show();
                }
            }
            if (!string.IsNullOrEmpty(apiKey))
            {
                // Call the async function to populate the models list
                LoadModelsAsync(apiKey).GetAwaiter().GetResult();
            }

                // Create the form but do not show it initially
                Form_mainPopup mainForm = new Form_mainPopup();
            mainForm.Load += (sender, args) => mainForm.Hide();

            // Start the application, but the form will be hidden
            Application.Run();

            //Application.Run(new Form_mainPopup());
            Properties.Settings.Default.FirstLaunch = false;
            Properties.Settings.Default.Save();
        }
        // Async method to load models and populate the global list
        private static async Task LoadModelsAsync(string apiKey)
        {
            try
            {
                var api = new OpenAIAPI(apiKey);

                // Get the available models
                var models = await api.Models.GetModelsAsync();

                // Display the models in the list
                foreach (var model in models)
                {
                    // Populate the global list
                    var exclusions = new[] { "tts", "embed", "dall" };
                    if (model.OwnedBy != "openai-internal" && !exclusions.Any(exclusion => model.ModelID.Contains(exclusion)))
                        modelsList.Add(model);
                    
                    //Debug.WriteLine(model);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error while loading models: {ex.Message}");
            }
        }
    }
}

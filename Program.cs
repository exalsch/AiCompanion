using OpenAI_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AiCompanion.Form_TextPrompt;
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

                Form_Settings form2 = new Form_Settings();
                // show it as a modal dialog (the current form is blocked until Form2 is closed)
                form2.ShowDialog();                
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.ModelLLM))
            {
                MessageBox.Show("Model setting is missing. Setting to default gpt-4o-mini");
                Properties.Settings.Default.ModelLLM = "gpt-4o-mini";
                Properties.Settings.Default.Save();
            }

            Application.Run(new Form_mainPopup());
            Properties.Settings.Default.FirstLaunch = false;
            Properties.Settings.Default.Save();
        }
    }
}

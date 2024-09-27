using System;
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
                // Create and show the main form 
                if (Properties.Settings.Default.UseNewUI)
                {
                    FormMain setForm = new FormMain(0, "TabPageSettings");
                    setForm.ShowDialog();
                }
                else
                {
                    Form_Settings setForm = new Form_Settings();
                    _ = setForm.ShowDialog();
                }
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
    }
}

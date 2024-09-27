using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace AiCompanion
{

    public partial class InputBox : MetroForm
    {
        public string InputText { get; private set; }
        public InputBox(string prompt, string title)
        {
            InitializeComponent();
            this.inputLabel.Text = prompt;
            this.Text = title;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            InputText = inputTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public static string Show(string prompt, string title)
        {
            InputBox inputBox = new InputBox(prompt, title);
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                return inputBox.InputText;
            }
            return null;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}

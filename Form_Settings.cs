using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiCompanion
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.API_Key = txt_ApiKey.Text;
            Properties.Settings.Default.PrePromt = txtPrePromt.Text;
            Properties.Settings.Default.ModelLLM = cmb_Model.Text;
            Properties.Settings.Default.FirstLaunch =false;
            Properties.Settings.Default.UseNewUI = chkUseNewUI.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}

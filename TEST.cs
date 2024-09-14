using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;


namespace AiCompanion
{
    public partial class TEST : MaterialForm
    {
        public TEST()
        {
            InitializeComponent();
            MoveFormToCenterOfSecondaryScreen(this);
        }

        public void MoveFormToCenterOfSecondaryScreen(Form form)
        {
            // Check if there is more than one screen (secondary screen exists)
            if (Screen.AllScreens.Length > 1)
            {
                // Get the secondary screen (usually the second in the list)
                Screen secondaryScreen = Screen.AllScreens[0];

                // Get the working area of the secondary screen (excludes taskbar and other docked elements)
                Rectangle workingArea = secondaryScreen.WorkingArea;

                // Calculate the centered position
                int centerX = workingArea.Left + (workingArea.Width - form.Width) / 2;
                int centerY = workingArea.Top + (workingArea.Height - form.Height) / 2;

                // Move the form to the center of the secondary screen
                form.StartPosition = FormStartPosition.Manual;
                form.Location = new Point(centerX, centerY);
            }
            else
            {
                // If there's no secondary screen, fallback to center on the primary screen
                form.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void TEST_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using ReaLTaiizor.Forms;

namespace AiCompanion
{
    internal class MetroRichTextPlacholder : ReaLTaiizor.Controls.MetroRichTextBox
    {
        private bool showingPlaceholder;

        private string placeholderText = "Enter description here...";

        // Public property to set the placeholder text
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                if (showingPlaceholder)
                {
                    SetPlaceholder(null, EventArgs.Empty);

                }
            }
        }

        public MetroRichTextPlacholder()
        {
            // Set the initial placeholder
            LoadPlaceholder();

            // Attach events to handle focus and text changes
            this.GotFocus += RemovePlaceholder;
            this.LostFocus += SetPlaceholder;
            this.TextChanged += CheckIfEmpty;
        }

        public void LoadPlaceholder()
        {
            SetPlaceholder(null, EventArgs.Empty);
        }

        private void SetPlaceholder(object sender, EventArgs e) // Add (object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                showingPlaceholder = true;
                this.Text = placeholderText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Italic);
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e) // Ensure signature matches
        {
            if (showingPlaceholder)
            {
                showingPlaceholder = false;
                this.Text = "";
                this.ForeColor = SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
            }
        }


        // Ensure the signature matches (object sender, EventArgs e) for TextChanged
        private void CheckIfEmpty(object sender)
        {
            if (string.IsNullOrWhiteSpace(this.Text) && !this.Focused)
            {
                SetPlaceholder(null, EventArgs.Empty);

            }
        }
    }
}

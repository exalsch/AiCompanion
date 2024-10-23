using System;
using System.Drawing;

using System.Windows.Forms;

namespace AiCompanion
{
    partial class InputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputLabel = new ReaLTaiizor.Controls.MetroLabel();
            inputTextBox = new ReaLTaiizor.Controls.MetroTextBox();
            OkButton = new ReaLTaiizor.Controls.MetroDefaultButton();
            btn_cancel = new ReaLTaiizor.Controls.MetroButton();
            metroStyleManager1 = new ReaLTaiizor.Manager.MetroStyleManager();
            SuspendLayout();
            // 
            // inputLabel
            // 
            inputLabel.Font = new Font("Microsoft Sans Serif", 10F);
            inputLabel.IsDerivedStyle = true;
            inputLabel.Location = new Point(16, 43);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(348, 48);
            inputLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            inputLabel.StyleManager = metroStyleManager1;
            inputLabel.TabIndex = 0;
            inputLabel.Text = "Input text:";
            inputLabel.ThemeAuthor = "Taiizor";
            inputLabel.ThemeName = "MetroLight";
            // 
            // inputTextBox
            // 
            inputTextBox.AutoCompleteCustomSource = null;
            inputTextBox.AutoCompleteMode = AutoCompleteMode.None;
            inputTextBox.AutoCompleteSource = AutoCompleteSource.None;
            inputTextBox.BorderColor = Color.FromArgb(155, 155, 155);
            inputTextBox.DisabledBackColor = Color.FromArgb(204, 204, 204);
            inputTextBox.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            inputTextBox.DisabledForeColor = Color.FromArgb(136, 136, 136);
            inputTextBox.Font = new Font("Microsoft Sans Serif", 10F);
            inputTextBox.HoverColor = Color.FromArgb(102, 102, 102);
            inputTextBox.Image = null;
            inputTextBox.IsDerivedStyle = true;
            inputTextBox.Lines = null;
            inputTextBox.Location = new Point(16, 94);
            inputTextBox.MaxLength = 32767;
            inputTextBox.Multiline = false;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ReadOnly = false;
            inputTextBox.Size = new Size(348, 47);
            inputTextBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            inputTextBox.StyleManager = metroStyleManager1;
            inputTextBox.TabIndex = 1;
            inputTextBox.TextAlign = HorizontalAlignment.Left;
            inputTextBox.ThemeAuthor = "Taiizor";
            inputTextBox.ThemeName = "MetroLight";
            inputTextBox.UseSystemPasswordChar = false;
            inputTextBox.WatermarkText = "";
            // 
            // OkButton
            // 
            OkButton.DisabledBackColor = Color.FromArgb(204, 204, 204);
            OkButton.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            OkButton.DisabledForeColor = Color.FromArgb(136, 136, 136);
            OkButton.Font = new Font("Microsoft Sans Serif", 10F);
            OkButton.HoverBorderColor = Color.FromArgb(102, 102, 102);
            OkButton.HoverColor = Color.FromArgb(102, 102, 102);
            OkButton.HoverTextColor = Color.White;
            OkButton.IsDerivedStyle = true;
            OkButton.Location = new Point(16, 147);
            OkButton.Name = "OkButton";
            OkButton.NormalBorderColor = Color.FromArgb(204, 204, 204);
            OkButton.NormalColor = Color.FromArgb(238, 238, 238);
            OkButton.NormalTextColor = Color.Black;
            OkButton.PressBorderColor = Color.FromArgb(51, 51, 51);
            OkButton.PressColor = Color.FromArgb(51, 51, 51);
            OkButton.PressTextColor = Color.White;
            OkButton.Size = new Size(75, 23);
            OkButton.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            OkButton.StyleManager = metroStyleManager1;
            OkButton.TabIndex = 2;
            OkButton.Text = "Ok";
            OkButton.ThemeAuthor = "Taiizor";
            OkButton.ThemeName = "MetroLight";
            OkButton.Click += OkButton_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btn_cancel.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btn_cancel.DisabledForeColor = Color.Gray;
            btn_cancel.Font = new Font("Microsoft Sans Serif", 10F);
            btn_cancel.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btn_cancel.HoverColor = Color.FromArgb(95, 207, 255);
            btn_cancel.HoverTextColor = Color.White;
            btn_cancel.IsDerivedStyle = true;
            btn_cancel.Location = new Point(97, 147);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btn_cancel.NormalColor = Color.FromArgb(65, 177, 225);
            btn_cancel.NormalTextColor = Color.White;
            btn_cancel.PressBorderColor = Color.FromArgb(35, 147, 195);
            btn_cancel.PressColor = Color.FromArgb(35, 147, 195);
            btn_cancel.PressTextColor = Color.White;
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_cancel.StyleManager = metroStyleManager1;
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancel";
            btn_cancel.ThemeAuthor = "Taiizor";
            btn_cancel.ThemeName = "MetroLight";
            btn_cancel.Click += btn_cancel_Click;
            // 
            // metroStyleManager1
            // 
            metroStyleManager1.CustomTheme = "C:\\Users\\ALSCH\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            metroStyleManager1.OwnerForm = this;
            metroStyleManager1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroStyleManager1.ThemeAuthor = "Taiizor";
            metroStyleManager1.ThemeName = "MetroLight";
            // 
            // InputBox
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 192);
            Controls.Add(btn_cancel);
            Controls.Add(OkButton);
            Controls.Add(inputTextBox);
            Controls.Add(inputLabel);
            Name = "InputBox";
            Padding = new Padding(2, 70, 2, 2);
            ShowHeader = true;
            ShowIcon = false;
            ShowLeftRect = false;
            StyleManager = metroStyleManager1;
            Text = "INPUTBOX";
            TextColor = Color.White;
            Load += InputBox_Load;
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MetroLabel inputLabel;
        private ReaLTaiizor.Controls.MetroTextBox inputTextBox;
        private ReaLTaiizor.Controls.MetroDefaultButton OkButton;
        private ReaLTaiizor.Controls.MetroButton btn_cancel;
        private ReaLTaiizor.Manager.MetroStyleManager metroStyleManager1;
    }

}
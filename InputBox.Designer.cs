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
            this.inputLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.inputTextBox = new ReaLTaiizor.Controls.MetroTextBox();
            this.OkButton = new ReaLTaiizor.Controls.MetroDefaultButton();
            this.btn_cancel = new ReaLTaiizor.Controls.MetroButton();
            this.metroStyleManager1 = new ReaLTaiizor.Manager.MetroStyleManager();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputLabel.IsDerivedStyle = true;
            this.inputLabel.Location = new System.Drawing.Point(16, 43);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(348, 48);
            this.inputLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.inputLabel.StyleManager = null;
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Input text:";
            this.inputLabel.ThemeAuthor = "Taiizor";
            this.inputLabel.ThemeName = "MetroLight";
            // 
            // inputTextBox
            // 
            this.inputTextBox.AutoCompleteCustomSource = null;
            this.inputTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.inputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.inputTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.inputTextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.inputTextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.inputTextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputTextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.inputTextBox.Image = null;
            this.inputTextBox.IsDerivedStyle = true;
            this.inputTextBox.Lines = null;
            this.inputTextBox.Location = new System.Drawing.Point(16, 94);
            this.inputTextBox.MaxLength = 32767;
            this.inputTextBox.Multiline = false;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = false;
            this.inputTextBox.Size = new System.Drawing.Size(348, 47);
            this.inputTextBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.inputTextBox.StyleManager = null;
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputTextBox.ThemeAuthor = "Taiizor";
            this.inputTextBox.ThemeName = "MetroLight";
            this.inputTextBox.UseSystemPasswordChar = false;
            this.inputTextBox.WatermarkText = "";
            // 
            // OkButton
            // 
            this.OkButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OkButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.OkButton.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OkButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.OkButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.OkButton.HoverTextColor = System.Drawing.Color.White;
            this.OkButton.IsDerivedStyle = true;
            this.OkButton.Location = new System.Drawing.Point(16, 147);
            this.OkButton.Name = "OkButton";
            this.OkButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.OkButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OkButton.NormalTextColor = System.Drawing.Color.Black;
            this.OkButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OkButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OkButton.PressTextColor = System.Drawing.Color.White;
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.OkButton.StyleManager = null;
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.ThemeAuthor = "Taiizor";
            this.OkButton.ThemeName = "MetroLight";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_cancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_cancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_cancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_cancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_cancel.HoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.IsDerivedStyle = true;
            this.btn_cancel.Location = new System.Drawing.Point(97, 147);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_cancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_cancel.NormalTextColor = System.Drawing.Color.White;
            this.btn_cancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_cancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_cancel.PressTextColor = System.Drawing.Color.White;
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_cancel.StyleManager = null;
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.ThemeAuthor = "Taiizor";
            this.btn_cancel.ThemeName = "MetroLight";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.CustomTheme = "C:\\Users\\ALSCH\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.metroStyleManager1.OwnerForm = null;
            this.metroStyleManager1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroStyleManager1.ThemeAuthor = "Taiizor";
            this.metroStyleManager1.ThemeName = "MetroLight";
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 192);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel);
            this.Name = "InputBox";
            this.Padding = new System.Windows.Forms.Padding(2, 70, 2, 2);
            this.ShowHeader = true;
            this.ShowIcon = false;
            this.ShowLeftRect = false;
            this.StyleManager = this.metroStyleManager1;
            this.Text = "INPUTBOX";
            this.TextColor = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroLabel inputLabel;
        private ReaLTaiizor.Controls.MetroTextBox inputTextBox;
        private ReaLTaiizor.Controls.MetroDefaultButton OkButton;
        private ReaLTaiizor.Controls.MetroButton btn_cancel;
        private ReaLTaiizor.Manager.MetroStyleManager metroStyleManager1;
    }

}
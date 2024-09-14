namespace AiCompanion
{
    partial class Form_mainPopup
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mainPopup));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenuStrip = new ReaLTaiizor.Controls.MetroContextMenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_promptN = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_TtsN = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_Speak2TextN = new ReaLTaiizor.Controls.MaterialButton();
            this.toolTip = new ReaLTaiizor.Controls.MetroToolTip();
            this.btn_prompt = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_TTS = new ReaLTaiizor.Controls.MaterialButton();
            this.btn_Speak2Text = new ReaLTaiizor.Controls.MaterialButton();
            this.trayContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "AiCompanion";
            this.trayIcon.Visible = true;
            // 
            // trayContextMenuStrip
            // 
            this.trayContextMenuStrip.IsDerivedStyle = true;
            this.trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.trayContextMenuStrip.Name = "trayContextMenuStrip";
            this.trayContextMenuStrip.Size = new System.Drawing.Size(117, 70);
            this.trayContextMenuStrip.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.trayContextMenuStrip.StyleManager = null;
            this.trayContextMenuStrip.ThemeAuthor = "Taiizor";
            this.trayContextMenuStrip.ThemeName = "MetroLight";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.TrayToolStripMenuSettings_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.trayToolStripMenuExit_Click);
            // 
            // btn_promptN
            // 
            this.btn_promptN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_promptN.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_promptN.Depth = 0;
            this.btn_promptN.HighEmphasis = true;
            this.btn_promptN.Icon = null;
            this.btn_promptN.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_promptN.Location = new System.Drawing.Point(2, 3);
            this.btn_promptN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_promptN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_promptN.Name = "btn_promptN";
            this.btn_promptN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_promptN.Size = new System.Drawing.Size(81, 36);
            this.btn_promptN.TabIndex = 4;
            this.btn_promptN.Text = "Prompt";
            this.toolTip.SetToolTip(this.btn_promptN, "Text Promts");
            this.btn_promptN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_promptN.UseAccentColor = false;
            this.btn_promptN.UseVisualStyleBackColor = true;
            this.btn_promptN.Click += new System.EventHandler(this.btn_prompt_Click_N);
            // 
            // btn_TtsN
            // 
            this.btn_TtsN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TtsN.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_TtsN.Depth = 0;
            this.btn_TtsN.HighEmphasis = true;
            this.btn_TtsN.Icon = null;
            this.btn_TtsN.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_TtsN.Location = new System.Drawing.Point(100, 3);
            this.btn_TtsN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_TtsN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_TtsN.Name = "btn_TtsN";
            this.btn_TtsN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_TtsN.Size = new System.Drawing.Size(64, 36);
            this.btn_TtsN.TabIndex = 5;
            this.btn_TtsN.Text = "TTS";
            this.toolTip.SetToolTip(this.btn_TtsN, "Text-To-Speach");
            this.btn_TtsN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_TtsN.UseAccentColor = false;
            this.btn_TtsN.UseVisualStyleBackColor = true;
            this.btn_TtsN.Click += new System.EventHandler(this.btn_TTSn_Click);
            // 
            // btn_Speak2TextN
            // 
            this.btn_Speak2TextN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Speak2TextN.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Speak2TextN.Depth = 0;
            this.btn_Speak2TextN.HighEmphasis = true;
            this.btn_Speak2TextN.Icon = null;
            this.btn_Speak2TextN.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            this.btn_Speak2TextN.Location = new System.Drawing.Point(172, 3);
            this.btn_Speak2TextN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Speak2TextN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Speak2TextN.Name = "btn_Speak2TextN";
            this.btn_Speak2TextN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Speak2TextN.Size = new System.Drawing.Size(64, 36);
            this.btn_Speak2TextN.TabIndex = 6;
            this.btn_Speak2TextN.Text = "STT";
            this.toolTip.SetToolTip(this.btn_Speak2TextN, "Speach-To-Text");
            this.btn_Speak2TextN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Speak2TextN.UseAccentColor = false;
            this.btn_Speak2TextN.UseVisualStyleBackColor = true;
            this.btn_Speak2TextN.Click += new System.EventHandler(this.btn_Speak2Text_Click_N);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.White;
            this.toolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.toolTip.IsDerivedStyle = true;
            this.toolTip.OwnerDraw = true;
            this.toolTip.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.toolTip.StyleManager = null;
            this.toolTip.ThemeAuthor = "Taiizor";
            this.toolTip.ThemeName = "MetroLight";
            // 
            // btn_prompt
            // 
            this.btn_prompt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_prompt.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_prompt.Depth = 0;
            this.btn_prompt.HighEmphasis = true;
            this.btn_prompt.Icon = null;
            this.btn_prompt.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_prompt.Location = new System.Drawing.Point(2, 51);
            this.btn_prompt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_prompt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_prompt.Name = "btn_prompt";
            this.btn_prompt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_prompt.Size = new System.Drawing.Size(81, 36);
            this.btn_prompt.TabIndex = 9;
            this.btn_prompt.Text = "Prompt";
            this.toolTip.SetToolTip(this.btn_prompt, "Text Promts");
            this.btn_prompt.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_prompt.UseAccentColor = false;
            this.btn_prompt.UseVisualStyleBackColor = true;
            this.btn_prompt.Click += new System.EventHandler(this.btn_prompt_Click);
            // 
            // btn_TTS
            // 
            this.btn_TTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TTS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_TTS.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_TTS.Depth = 0;
            this.btn_TTS.HighEmphasis = true;
            this.btn_TTS.Icon = null;
            this.btn_TTS.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_TTS.Location = new System.Drawing.Point(100, 51);
            this.btn_TTS.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_TTS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_TTS.Name = "btn_TTS";
            this.btn_TTS.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_TTS.Size = new System.Drawing.Size(64, 36);
            this.btn_TTS.TabIndex = 7;
            this.btn_TTS.Text = "TTS";
            this.btn_TTS.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_TTS.UseAccentColor = false;
            this.btn_TTS.UseVisualStyleBackColor = true;
            this.btn_TTS.Click += new System.EventHandler(this.btn_TTS_Click);
            // 
            // btn_Speak2Text
            // 
            this.btn_Speak2Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Speak2Text.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Speak2Text.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Speak2Text.Depth = 0;
            this.btn_Speak2Text.HighEmphasis = true;
            this.btn_Speak2Text.Icon = null;
            this.btn_Speak2Text.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btn_Speak2Text.Location = new System.Drawing.Point(172, 51);
            this.btn_Speak2Text.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Speak2Text.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btn_Speak2Text.Name = "btn_Speak2Text";
            this.btn_Speak2Text.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Speak2Text.Size = new System.Drawing.Size(64, 36);
            this.btn_Speak2Text.TabIndex = 8;
            this.btn_Speak2Text.Text = "STT";
            this.btn_Speak2Text.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Speak2Text.UseAccentColor = false;
            this.btn_Speak2Text.UseVisualStyleBackColor = true;
            this.btn_Speak2Text.Click += new System.EventHandler(this.btn_Speak2Text_Click);
            // 
            // Form_mainPopup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(244, 96);
            this.Controls.Add(this.btn_prompt);
            this.Controls.Add(this.btn_Speak2Text);
            this.Controls.Add(this.btn_TTS);
            this.Controls.Add(this.btn_Speak2TextN);
            this.Controls.Add(this.btn_TtsN);
            this.Controls.Add(this.btn_promptN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_mainPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "AiCompanion";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.Form_mainPopup_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_mainPopup_FormClosing);
            this.Load += new System.EventHandler(this.Form_mainPopup_Load);
            this.trayContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon trayIcon;
        private ReaLTaiizor.Controls.MaterialButton btn_promptN;
        private ReaLTaiizor.Controls.MetroContextMenuStrip trayContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ReaLTaiizor.Controls.MaterialButton btn_TtsN;
        private ReaLTaiizor.Controls.MaterialButton btn_Speak2TextN;
        private ReaLTaiizor.Controls.MetroToolTip toolTip;
        private ReaLTaiizor.Controls.MaterialButton btn_TTS;
        private ReaLTaiizor.Controls.MaterialButton btn_Speak2Text;
        private ReaLTaiizor.Controls.MaterialButton btn_prompt;
    }
}
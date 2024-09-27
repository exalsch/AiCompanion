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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_mainPopup));
            trayIcon = new System.Windows.Forms.NotifyIcon(components);
            trayContextMenuStrip = new ReaLTaiizor.Controls.MetroContextMenuStrip();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btn_promptN = new ReaLTaiizor.Controls.MaterialButton();
            btn_TtsN = new ReaLTaiizor.Controls.MaterialButton();
            btn_Speak2TextN = new ReaLTaiizor.Controls.MaterialButton();
            toolTip = new ReaLTaiizor.Controls.MetroToolTip();
            btn_prompt = new ReaLTaiizor.Controls.MaterialButton();
            btn_ImagePrompt = new ReaLTaiizor.Controls.MaterialButton();
            btn_TTS = new ReaLTaiizor.Controls.MaterialButton();
            btn_Speak2Text = new ReaLTaiizor.Controls.MaterialButton();
            trayContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // trayIcon
            // 
            trayIcon.ContextMenuStrip = trayContextMenuStrip;
            trayIcon.Icon = (System.Drawing.Icon)resources.GetObject("trayIcon.Icon");
            trayIcon.Text = "AiCompanion";
            trayIcon.Visible = true;
            // 
            // trayContextMenuStrip
            // 
            trayContextMenuStrip.IsDerivedStyle = true;
            trayContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem, aboutToolStripMenuItem1, exitToolStripMenuItem });
            trayContextMenuStrip.Name = "trayContextMenuStrip";
            trayContextMenuStrip.Size = new System.Drawing.Size(117, 70);
            trayContextMenuStrip.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            trayContextMenuStrip.StyleManager = null;
            trayContextMenuStrip.ThemeAuthor = "Taiizor";
            trayContextMenuStrip.ThemeName = "MetroLight";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += TrayToolStripMenuSettings_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += trayToolStripMenuExit_Click;
            // 
            // btn_promptN
            // 
            btn_promptN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn_promptN.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_promptN.Depth = 0;
            btn_promptN.HighEmphasis = true;
            btn_promptN.Icon = null;
            btn_promptN.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_promptN.Location = new System.Drawing.Point(2, 3);
            btn_promptN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn_promptN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_promptN.Name = "btn_promptN";
            btn_promptN.NoAccentTextColor = System.Drawing.Color.Empty;
            btn_promptN.Size = new System.Drawing.Size(81, 36);
            btn_promptN.TabIndex = 4;
            btn_promptN.Text = "Prompt";
            toolTip.SetToolTip(btn_promptN, "Text Promts");
            btn_promptN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_promptN.UseAccentColor = false;
            btn_promptN.UseVisualStyleBackColor = true;
            btn_promptN.Click += btn_prompt_Click_N;
            // 
            // btn_TtsN
            // 
            btn_TtsN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn_TtsN.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_TtsN.Depth = 0;
            btn_TtsN.HighEmphasis = true;
            btn_TtsN.Icon = null;
            btn_TtsN.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_TtsN.Location = new System.Drawing.Point(100, 3);
            btn_TtsN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn_TtsN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_TtsN.Name = "btn_TtsN";
            btn_TtsN.NoAccentTextColor = System.Drawing.Color.Empty;
            btn_TtsN.Size = new System.Drawing.Size(64, 36);
            btn_TtsN.TabIndex = 5;
            btn_TtsN.Text = "TTS";
            toolTip.SetToolTip(btn_TtsN, "Text-To-Speach");
            btn_TtsN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_TtsN.UseAccentColor = false;
            btn_TtsN.UseVisualStyleBackColor = true;
            btn_TtsN.Click += btn_TTSn_Click;
            // 
            // btn_Speak2TextN
            // 
            btn_Speak2TextN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn_Speak2TextN.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Speak2TextN.Depth = 0;
            btn_Speak2TextN.HighEmphasis = true;
            btn_Speak2TextN.Icon = null;
            btn_Speak2TextN.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            btn_Speak2TextN.Location = new System.Drawing.Point(172, 3);
            btn_Speak2TextN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn_Speak2TextN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Speak2TextN.Name = "btn_Speak2TextN";
            btn_Speak2TextN.NoAccentTextColor = System.Drawing.Color.Empty;
            btn_Speak2TextN.Size = new System.Drawing.Size(64, 36);
            btn_Speak2TextN.TabIndex = 6;
            btn_Speak2TextN.Text = "STT";
            toolTip.SetToolTip(btn_Speak2TextN, "Speach-To-Text");
            btn_Speak2TextN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Speak2TextN.UseAccentColor = false;
            btn_Speak2TextN.UseVisualStyleBackColor = true;
            btn_Speak2TextN.Click += btn_Speak2Text_Click_N;
            // 
            // toolTip
            // 
            toolTip.BackColor = System.Drawing.Color.White;
            toolTip.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            toolTip.ForeColor = System.Drawing.Color.FromArgb(170, 170, 170);
            toolTip.IsDerivedStyle = true;
            toolTip.OwnerDraw = true;
            toolTip.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            toolTip.StyleManager = null;
            toolTip.ThemeAuthor = "Taiizor";
            toolTip.ThemeName = "MetroLight";
            // 
            // btn_prompt
            // 
            btn_prompt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn_prompt.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_prompt.Depth = 0;
            btn_prompt.HighEmphasis = true;
            btn_prompt.Icon = null;
            btn_prompt.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_prompt.Location = new System.Drawing.Point(2, 51);
            btn_prompt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn_prompt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_prompt.Name = "btn_prompt";
            btn_prompt.NoAccentTextColor = System.Drawing.Color.Empty;
            btn_prompt.Size = new System.Drawing.Size(81, 36);
            btn_prompt.TabIndex = 9;
            btn_prompt.Text = "Prompt";
            toolTip.SetToolTip(btn_prompt, "Text Promts");
            btn_prompt.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_prompt.UseAccentColor = false;
            btn_prompt.UseVisualStyleBackColor = true;
            btn_prompt.Click += btn_prompt_Click;
            // 
            // btn_ImagePrompt
            // 
            btn_ImagePrompt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn_ImagePrompt.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_ImagePrompt.Depth = 0;
            btn_ImagePrompt.HighEmphasis = true;
            btn_ImagePrompt.Icon = null;
            btn_ImagePrompt.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_ImagePrompt.Location = new System.Drawing.Point(244, 3);
            btn_ImagePrompt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn_ImagePrompt.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_ImagePrompt.Name = "btn_ImagePrompt";
            btn_ImagePrompt.NoAccentTextColor = System.Drawing.Color.Empty;
            btn_ImagePrompt.Size = new System.Drawing.Size(67, 36);
            btn_ImagePrompt.TabIndex = 10;
            btn_ImagePrompt.Text = "Image";
            toolTip.SetToolTip(btn_ImagePrompt, "Text promt with image");
            btn_ImagePrompt.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_ImagePrompt.UseAccentColor = false;
            btn_ImagePrompt.UseVisualStyleBackColor = true;
            btn_ImagePrompt.Click += btn_ImagePrompt_Click;
            // 
            // btn_TTS
            // 
            btn_TTS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btn_TTS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn_TTS.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_TTS.Depth = 0;
            btn_TTS.HighEmphasis = true;
            btn_TTS.Icon = null;
            btn_TTS.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_TTS.Location = new System.Drawing.Point(100, 51);
            btn_TTS.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn_TTS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_TTS.Name = "btn_TTS";
            btn_TTS.NoAccentTextColor = System.Drawing.Color.Empty;
            btn_TTS.Size = new System.Drawing.Size(64, 36);
            btn_TTS.TabIndex = 7;
            btn_TTS.Text = "TTS";
            btn_TTS.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_TTS.UseAccentColor = false;
            btn_TTS.UseVisualStyleBackColor = true;
            btn_TTS.Click += btn_TTS_Click;
            // 
            // btn_Speak2Text
            // 
            btn_Speak2Text.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btn_Speak2Text.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btn_Speak2Text.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Speak2Text.Depth = 0;
            btn_Speak2Text.HighEmphasis = true;
            btn_Speak2Text.Icon = null;
            btn_Speak2Text.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Speak2Text.Location = new System.Drawing.Point(172, 51);
            btn_Speak2Text.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btn_Speak2Text.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Speak2Text.Name = "btn_Speak2Text";
            btn_Speak2Text.NoAccentTextColor = System.Drawing.Color.Empty;
            btn_Speak2Text.Size = new System.Drawing.Size(64, 36);
            btn_Speak2Text.TabIndex = 8;
            btn_Speak2Text.Text = "STT";
            btn_Speak2Text.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Speak2Text.UseAccentColor = false;
            btn_Speak2Text.UseVisualStyleBackColor = true;
            btn_Speak2Text.Click += btn_Speak2Text_Click;
            // 
            // Form_mainPopup
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ClientSize = new System.Drawing.Size(322, 46);
            Controls.Add(btn_ImagePrompt);
            Controls.Add(btn_prompt);
            Controls.Add(btn_Speak2Text);
            Controls.Add(btn_TTS);
            Controls.Add(btn_Speak2TextN);
            Controls.Add(btn_TtsN);
            Controls.Add(btn_promptN);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_mainPopup";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "AiCompanion";
            TopMost = true;
            Deactivate += Form_mainPopup_Deactivate;
            FormClosing += Form_mainPopup_FormClosing;
            trayContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ReaLTaiizor.Controls.MaterialButton btn_ImagePrompt;
    }
}
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
            this.btn_prompt = new System.Windows.Forms.Button();
            this.btn_TTS = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.try_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TrayToolStripMenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.trayToolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.try_contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_prompt
            // 
            this.btn_prompt.Location = new System.Drawing.Point(2, 2);
            this.btn_prompt.Name = "btn_prompt";
            this.btn_prompt.Size = new System.Drawing.Size(24, 21);
            this.btn_prompt.TabIndex = 0;
            this.btn_prompt.Text = "&P";
            this.toolTip.SetToolTip(this.btn_prompt, "Text Prompt");
            this.btn_prompt.UseVisualStyleBackColor = true;
            this.btn_prompt.Click += new System.EventHandler(this.btn_prompt_Click);
            // 
            // btn_TTS
            // 
            this.btn_TTS.Location = new System.Drawing.Point(32, 2);
            this.btn_TTS.Name = "btn_TTS";
            this.btn_TTS.Size = new System.Drawing.Size(21, 21);
            this.btn_TTS.TabIndex = 1;
            this.btn_TTS.Text = "&S";
            this.toolTip.SetToolTip(this.btn_TTS, "Whisper TTS");
            this.btn_TTS.UseVisualStyleBackColor = true;
            this.btn_TTS.Click += new System.EventHandler(this.btn_TTS_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.try_contextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "AiCompanion";
            this.trayIcon.Visible = true;
            // 
            // try_contextMenu
            // 
            this.try_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TrayToolStripMenuSettings,
            this.aboutToolStripMenuItem,
            this.trayToolStripMenuExit});
            this.try_contextMenu.Name = "try_contextMenu";
            this.try_contextMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // TrayToolStripMenuSettings
            // 
            this.TrayToolStripMenuSettings.Name = "TrayToolStripMenuSettings";
            this.TrayToolStripMenuSettings.Size = new System.Drawing.Size(180, 22);
            this.TrayToolStripMenuSettings.Text = "Settings";
            this.TrayToolStripMenuSettings.Click += new System.EventHandler(this.TrayToolStripMenuSettings_Click);
            // 
            // trayToolStripMenuExit
            // 
            this.trayToolStripMenuExit.Name = "trayToolStripMenuExit";
            this.trayToolStripMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.trayToolStripMenuExit.Size = new System.Drawing.Size(180, 22);
            this.trayToolStripMenuExit.Text = "Exit";
            this.trayToolStripMenuExit.Click += new System.EventHandler(this.trayToolStripMenuExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form_mainPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(56, 28);
            this.Controls.Add(this.btn_prompt);
            this.Controls.Add(this.btn_TTS);
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
            this.try_contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_prompt;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btn_TTS;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip try_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem TrayToolStripMenuSettings;
        private System.Windows.Forms.ToolStripMenuItem trayToolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
namespace AiCompanion
{
    partial class Form_TTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TTS));
            btn_play = new System.Windows.Forms.Button();
            txt_Text = new System.Windows.Forms.RichTextBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            btn_stop = new System.Windows.Forms.Button();
            lblSpeed = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cmbBxVoice = new System.Windows.Forms.ComboBox();
            checkBoxDownload = new System.Windows.Forms.CheckBox();
            btn_Download = new System.Windows.Forms.Button();
            trackBarSpeed = new System.Windows.Forms.TrackBar();
            lblSpeedVal = new System.Windows.Forms.Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).BeginInit();
            SuspendLayout();
            // 
            // btn_play
            // 
            btn_play.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_play.Location = new System.Drawing.Point(14, 337);
            btn_play.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_play.Name = "btn_play";
            btn_play.Size = new System.Drawing.Size(47, 27);
            btn_play.TabIndex = 0;
            btn_play.Text = "&Play";
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += btn_play_Click;
            // 
            // txt_Text
            // 
            txt_Text.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_Text.Location = new System.Drawing.Point(14, 14);
            txt_Text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_Text.Name = "txt_Text";
            txt_Text.Size = new System.Drawing.Size(335, 305);
            txt_Text.TabIndex = 2;
            txt_Text.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            statusStrip1.Location = new System.Drawing.Point(0, 397);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(366, 20);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(26, 15);
            toolStripStatusLabel.Text = "Idle";
            // 
            // btn_stop
            // 
            btn_stop.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_stop.Enabled = false;
            btn_stop.Location = new System.Drawing.Point(68, 337);
            btn_stop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new System.Drawing.Size(48, 27);
            btn_stop.TabIndex = 1;
            btn_stop.Text = "&Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // lblSpeed
            // 
            lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new System.Drawing.Point(107, 371);
            lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(42, 15);
            lblSpeed.TabIndex = 7;
            lblSpeed.Text = "Speed:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(220, 343);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "Voice:";
            // 
            // cmbBxVoice
            // 
            cmbBxVoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cmbBxVoice.FormattingEnabled = true;
            cmbBxVoice.Items.AddRange(new object[] { "Alloy", "Echo", "Fable", "Onyx", "Nova", "Shimmer" });
            cmbBxVoice.Location = new System.Drawing.Point(266, 337);
            cmbBxVoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbBxVoice.Name = "cmbBxVoice";
            cmbBxVoice.Size = new System.Drawing.Size(68, 23);
            cmbBxVoice.TabIndex = 6;
            cmbBxVoice.Text = "Fable";
            cmbBxVoice.SelectedIndexChanged += cmbBxVoice_SelectedIndexChanged;
            // 
            // checkBoxDownload
            // 
            checkBoxDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxDownload.AutoSize = true;
            checkBoxDownload.Location = new System.Drawing.Point(14, 369);
            checkBoxDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxDownload.Name = "checkBoxDownload";
            checkBoxDownload.Size = new System.Drawing.Size(85, 19);
            checkBoxDownload.TabIndex = 4;
            checkBoxDownload.Text = "Save Audio";
            checkBoxDownload.UseVisualStyleBackColor = true;
            // 
            // btn_Download
            // 
            btn_Download.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_Download.Location = new System.Drawing.Point(124, 337);
            btn_Download.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new System.Drawing.Size(88, 27);
            btn_Download.TabIndex = 3;
            btn_Download.Text = "&Download";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // trackBarSpeed
            // 
            trackBarSpeed.Location = new System.Drawing.Point(156, 368);
            trackBarSpeed.Maximum = 100;
            trackBarSpeed.Minimum = 10;
            trackBarSpeed.Name = "trackBarSpeed";
            trackBarSpeed.Size = new System.Drawing.Size(178, 45);
            trackBarSpeed.TabIndex = 10;
            trackBarSpeed.Value = 25;
            trackBarSpeed.Scroll += trackBarSpeed_Scroll;
            // 
            // lblSpeedVal
            // 
            lblSpeedVal.AutoSize = true;
            lblSpeedVal.Location = new System.Drawing.Point(328, 371);
            lblSpeedVal.Name = "lblSpeedVal";
            lblSpeedVal.Size = new System.Drawing.Size(29, 15);
            lblSpeedVal.TabIndex = 11;
            lblSpeedVal.Tag = "25 is the default";
            lblSpeedVal.Text = "25%";
            // 
            // Form_TTS
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(366, 417);
            Controls.Add(lblSpeedVal);
            Controls.Add(btn_Download);
            Controls.Add(checkBoxDownload);
            Controls.Add(cmbBxVoice);
            Controls.Add(label1);
            Controls.Add(lblSpeed);
            Controls.Add(btn_stop);
            Controls.Add(statusStrip1);
            Controls.Add(txt_Text);
            Controls.Add(btn_play);
            Controls.Add(trackBarSpeed);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(382, 456);
            Name = "Form_TTS";
            Text = "TextToSpeach";
            Load += Form_TTS_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.RichTextBox txt_Text;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxVoice;
        private System.Windows.Forms.CheckBox checkBoxDownload;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label lblSpeedVal;
    }
}
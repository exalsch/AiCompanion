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
            this.btn_play = new System.Windows.Forms.Button();
            this.txt_Text = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.numUD_Speed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxVoice = new System.Windows.Forms.ComboBox();
            this.checkBoxDownload = new System.Windows.Forms.CheckBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_play.Location = new System.Drawing.Point(12, 292);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "&Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // txt_Text
            // 
            this.txt_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Text.Location = new System.Drawing.Point(12, 12);
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(288, 265);
            this.txt_Text.TabIndex = 7;
            this.txt_Text.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 341);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(314, 20);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(26, 15);
            this.toolStripStatusLabel.Text = "Idle";
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(58, 292);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(41, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "&Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(105, 319);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 4;
            this.lblSpeed.Text = "Speed:";
            // 
            // numUD_Speed
            // 
            this.numUD_Speed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numUD_Speed.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::AiCompanion.Properties.Settings.Default, "TtsSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numUD_Speed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numUD_Speed.Location = new System.Drawing.Point(152, 316);
            this.numUD_Speed.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUD_Speed.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numUD_Speed.Name = "numUD_Speed";
            this.numUD_Speed.Size = new System.Drawing.Size(37, 20);
            this.numUD_Speed.TabIndex = 2;
            this.numUD_Speed.Value = global::AiCompanion.Properties.Settings.Default.TtsSpeed;
            this.numUD_Speed.ValueChanged += new System.EventHandler(this.numUD_Speed_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Voice:";
            // 
            // cmbBxVoice
            // 
            this.cmbBxVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbBxVoice.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AiCompanion.Properties.Settings.Default, "TtsVoice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbBxVoice.FormattingEnabled = true;
            this.cmbBxVoice.Location = new System.Drawing.Point(238, 315);
            this.cmbBxVoice.Name = "cmbBxVoice";
            this.cmbBxVoice.Size = new System.Drawing.Size(59, 21);
            this.cmbBxVoice.TabIndex = 10;
            this.cmbBxVoice.Text = global::AiCompanion.Properties.Settings.Default.TtsVoice;
            this.cmbBxVoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxDownload
            // 
            this.checkBoxDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDownload.AutoSize = true;
            this.checkBoxDownload.Location = new System.Drawing.Point(12, 319);
            this.checkBoxDownload.Name = "checkBoxDownload";
            this.checkBoxDownload.Size = new System.Drawing.Size(81, 17);
            this.checkBoxDownload.TabIndex = 11;
            this.checkBoxDownload.Text = "Save Audio";
            this.checkBoxDownload.UseVisualStyleBackColor = true;
            // 
            // btn_Download
            // 
            this.btn_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Download.Location = new System.Drawing.Point(106, 292);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(75, 23);
            this.btn_Download.TabIndex = 12;
            this.btn_Download.Text = "&Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // Form_TTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 361);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.checkBoxDownload);
            this.Controls.Add(this.cmbBxVoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUD_Speed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_Text);
            this.Controls.Add(this.btn_play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(330, 400);
            this.Name = "Form_TTS";
            this.Text = "TextToSpeach";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.RichTextBox txt_Text;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown numUD_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxVoice;
        private System.Windows.Forms.CheckBox checkBoxDownload;
        private System.Windows.Forms.Button btn_Download;
    }
}
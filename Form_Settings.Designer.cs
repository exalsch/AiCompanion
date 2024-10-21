namespace AiCompanion
{
    partial class Form_Settings
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
            Properties.Settings settings1 = new Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txt_ApiKey = new System.Windows.Forms.TextBox();
            cmb_Model = new System.Windows.Forms.ComboBox();
            txtPrePromt = new System.Windows.Forms.TextBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            cmb_HotKeyMod = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            txt_HotkeyKey = new System.Windows.Forms.TextBox();
            btn_Done = new System.Windows.Forms.Button();
            chkUseNewUI = new System.Windows.Forms.CheckBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.87561F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.12439F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(txt_ApiKey, 1, 0);
            tableLayoutPanel1.Controls.Add(cmb_Model, 1, 1);
            tableLayoutPanel1.Controls.Add(txtPrePromt, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_Done, 1, 5);
            tableLayoutPanel1.Controls.Add(chkUseNewUI, 1, 4);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(720, 307);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "OpenAI API Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 45);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(4, 90);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Pre Promt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(4, 135);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Hotkey";
            // 
            // txt_ApiKey
            // 
            settings1.API_Key = "";
            settings1.AutoStartSTT = false;
            settings1.AutoStartTTS = false;
            settings1.FirstLaunch = true;
            settings1.HotKeyKey = "g";
            settings1.HotKeyMod = "Alt";
            settings1.ModelLLM = "gpt-4o-mini";
            settings1.PrePromt = "You are a helpful assistant for the user of this client PC. try to give a direct reply that can be pasted directly by the user.";
            settings1.prePromtSelections = (System.Collections.Specialized.StringCollection)resources.GetObject("settings1.prePromtSelections");
            settings1.SettingsKey = "";
            settings1.STT_lang = "en";
            settings1.TtsSpeed = new decimal(new int[] { 1, 0, 0, 0 });
            settings1.TtsVoice = "Fable";
            settings1.useDarkMode = false;
            settings1.UseNewUI = true;
            txt_ApiKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings1, "API_Key", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            txt_ApiKey.Location = new System.Drawing.Point(118, 3);
            txt_ApiKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_ApiKey.Name = "txt_ApiKey";
            txt_ApiKey.Size = new System.Drawing.Size(592, 23);
            txt_ApiKey.TabIndex = 0;
            // 
            // cmb_Model
            // 
            cmb_Model.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings1, "ModelLLM", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            cmb_Model.FormattingEnabled = true;
            cmb_Model.Items.AddRange(new object[] { "gpt-4o-mini", "gpt-4o", "gpt-4-turbo", "gpt-4", "gpt-3.5-turbo", "gpt-3.5-turbo-instruct" });
            cmb_Model.Location = new System.Drawing.Point(118, 48);
            cmb_Model.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmb_Model.Name = "cmb_Model";
            cmb_Model.Size = new System.Drawing.Size(299, 23);
            cmb_Model.TabIndex = 1;
            cmb_Model.Text = "gpt-4o-mini";
            // 
            // txtPrePromt
            // 
            txtPrePromt.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings1, "PrePromt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            txtPrePromt.Location = new System.Drawing.Point(118, 93);
            txtPrePromt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPrePromt.Multiline = true;
            txtPrePromt.Name = "txtPrePromt";
            txtPrePromt.Size = new System.Drawing.Size(592, 29);
            txtPrePromt.TabIndex = 2;
            txtPrePromt.Text = "You are a helpful assistant for the user of this client PC. try to give a direct reply that can be pasted directly by the user.";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cmb_HotKeyMod);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(txt_HotkeyKey);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(118, 138);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(598, 39);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // cmb_HotKeyMod
            // 
            cmb_HotKeyMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings1, "HotKeyMod", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            cmb_HotKeyMod.FormattingEnabled = true;
            cmb_HotKeyMod.Items.AddRange(new object[] { "ALT", "CTR", "SHIFT", "WIN" });
            cmb_HotKeyMod.Location = new System.Drawing.Point(4, 3);
            cmb_HotKeyMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmb_HotKeyMod.Name = "cmb_HotKeyMod";
            cmb_HotKeyMod.Size = new System.Drawing.Size(140, 23);
            cmb_HotKeyMod.TabIndex = 0;
            cmb_HotKeyMod.Text = "ALT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(152, 0);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(15, 15);
            label5.TabIndex = 8;
            label5.Text = "+";
            // 
            // txt_HotkeyKey
            // 
            txt_HotkeyKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", settings1, "HotKeyKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            txt_HotkeyKey.Location = new System.Drawing.Point(175, 3);
            txt_HotkeyKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_HotkeyKey.Name = "txt_HotkeyKey";
            txt_HotkeyKey.Size = new System.Drawing.Size(125, 23);
            txt_HotkeyKey.TabIndex = 1;
            txt_HotkeyKey.Text = "g";
            // 
            // btn_Done
            // 
            btn_Done.Location = new System.Drawing.Point(118, 228);
            btn_Done.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new System.Drawing.Size(88, 27);
            btn_Done.TabIndex = 3;
            btn_Done.Text = "Done!";
            btn_Done.UseVisualStyleBackColor = true;
            btn_Done.Click += button1_Click;
            // 
            // chkUseNewUI
            // 
            chkUseNewUI.AutoSize = true;
            chkUseNewUI.Location = new System.Drawing.Point(118, 183);
            chkUseNewUI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkUseNewUI.Name = "chkUseNewUI";
            chkUseNewUI.Size = new System.Drawing.Size(86, 19);
            chkUseNewUI.TabIndex = 9;
            chkUseNewUI.Text = "Use New UI";
            chkUseNewUI.UseVisualStyleBackColor = true;
            // 
            // Form_Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(720, 307);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Settings";
            Text = "Settings";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ApiKey;
        private System.Windows.Forms.ComboBox cmb_Model;
        private System.Windows.Forms.TextBox txtPrePromt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmb_HotKeyMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HotkeyKey;
        private System.Windows.Forms.Button btn_Done;
        private System.Windows.Forms.CheckBox chkUseNewUI;
    }
}
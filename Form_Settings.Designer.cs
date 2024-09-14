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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ApiKey = new System.Windows.Forms.TextBox();
            this.cmb_Model = new System.Windows.Forms.ComboBox();
            this.txtPrePromt = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmb_HotKeyMod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HotkeyKey = new System.Windows.Forms.TextBox();
            this.btn_Done = new System.Windows.Forms.Button();
            this.chkUseNewUI = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.87561F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.12439F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_ApiKey, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_Model, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrePromt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Done, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkUseNewUI, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(610, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OpenAI API Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pre Promt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hotkey";
            // 
            // txt_ApiKey
            // 
            this.txt_ApiKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AiCompanion.Properties.Settings.Default, "API_Key", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_ApiKey.Location = new System.Drawing.Point(99, 3);
            this.txt_ApiKey.Name = "txt_ApiKey";
            this.txt_ApiKey.Size = new System.Drawing.Size(508, 20);
            this.txt_ApiKey.TabIndex = 0;
            this.txt_ApiKey.Text = global::AiCompanion.Properties.Settings.Default.API_Key;
            // 
            // cmb_Model
            // 
            this.cmb_Model.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AiCompanion.Properties.Settings.Default, "ModelLLM", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmb_Model.FormattingEnabled = true;
            this.cmb_Model.Items.AddRange(new object[] {
            "gpt-4o-mini",
            "gpt-4o",
            "gpt-4-turbo",
            "gpt-4",
            "gpt-3.5-turbo",
            "gpt-3.5-turbo-instruct"});
            this.cmb_Model.Location = new System.Drawing.Point(99, 35);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.Size = new System.Drawing.Size(257, 21);
            this.cmb_Model.TabIndex = 1;
            this.cmb_Model.Text = global::AiCompanion.Properties.Settings.Default.ModelLLM;
            // 
            // txtPrePromt
            // 
            this.txtPrePromt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AiCompanion.Properties.Settings.Default, "PrePromt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPrePromt.Location = new System.Drawing.Point(99, 67);
            this.txtPrePromt.Multiline = true;
            this.txtPrePromt.Name = "txtPrePromt";
            this.txtPrePromt.Size = new System.Drawing.Size(508, 26);
            this.txtPrePromt.TabIndex = 2;
            this.txtPrePromt.Text = global::AiCompanion.Properties.Settings.Default.PrePromt;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmb_HotKeyMod);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txt_HotkeyKey);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(99, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 26);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // cmb_HotKeyMod
            // 
            this.cmb_HotKeyMod.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AiCompanion.Properties.Settings.Default, "HotKeyMod", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmb_HotKeyMod.Enabled = false;
            this.cmb_HotKeyMod.FormattingEnabled = true;
            this.cmb_HotKeyMod.Items.AddRange(new object[] {
            "ALT",
            "CTR",
            "SHIFT",
            "WIN"});
            this.cmb_HotKeyMod.Location = new System.Drawing.Point(3, 3);
            this.cmb_HotKeyMod.Name = "cmb_HotKeyMod";
            this.cmb_HotKeyMod.Size = new System.Drawing.Size(121, 21);
            this.cmb_HotKeyMod.TabIndex = 0;
            this.cmb_HotKeyMod.Text = global::AiCompanion.Properties.Settings.Default.HotKeyMod;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "+";
            // 
            // txt_HotkeyKey
            // 
            this.txt_HotkeyKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AiCompanion.Properties.Settings.Default, "HotKeyKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_HotkeyKey.Enabled = false;
            this.txt_HotkeyKey.Location = new System.Drawing.Point(149, 3);
            this.txt_HotkeyKey.Name = "txt_HotkeyKey";
            this.txt_HotkeyKey.Size = new System.Drawing.Size(108, 20);
            this.txt_HotkeyKey.TabIndex = 1;
            this.txt_HotkeyKey.Text = global::AiCompanion.Properties.Settings.Default.HotKeyKey;
            // 
            // btn_Done
            // 
            this.btn_Done.Location = new System.Drawing.Point(99, 163);
            this.btn_Done.Name = "btn_Done";
            this.btn_Done.Size = new System.Drawing.Size(75, 23);
            this.btn_Done.TabIndex = 3;
            this.btn_Done.Text = "Done!";
            this.btn_Done.UseVisualStyleBackColor = true;
            this.btn_Done.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkUseNewUI
            // 
            this.chkUseNewUI.AutoSize = true;
            this.chkUseNewUI.Location = new System.Drawing.Point(99, 131);
            this.chkUseNewUI.Name = "chkUseNewUI";
            this.chkUseNewUI.Size = new System.Drawing.Size(84, 17);
            this.chkUseNewUI.TabIndex = 9;
            this.chkUseNewUI.Text = "Use New UI";
            this.chkUseNewUI.UseVisualStyleBackColor = true;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 198);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
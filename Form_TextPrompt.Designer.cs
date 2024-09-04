namespace AiCompanion
{
    partial class Form_TextPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TextPrompt));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.RichTextBox();
            this.txt_result = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmb_Model = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_input, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_result, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_send);
            this.flowLayoutPanel1.Controls.Add(this.btn_insert);
            this.flowLayoutPanel1.Controls.Add(this.btn_copy);
            this.flowLayoutPanel1.Controls.Add(this.btn_cancel);
            this.flowLayoutPanel1.Controls.Add(this.cmb_Model);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 541);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 31);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(3, 3);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "&Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Enabled = false;
            this.btn_insert.Location = new System.Drawing.Point(84, 3);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 1;
            this.btn_insert.Text = "&Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Enabled = false;
            this.btn_copy.Location = new System.Drawing.Point(165, 3);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "&Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(246, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_input
            // 
            this.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_input.Location = new System.Drawing.Point(3, 272);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(440, 263);
            this.txt_input.TabIndex = 4;
            this.txt_input.Text = "";
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // txt_result
            // 
            this.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_result.Location = new System.Drawing.Point(3, 3);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(440, 263);
            this.txt_result.TabIndex = 5;
            this.txt_result.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(446, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
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
            this.cmb_Model.Location = new System.Drawing.Point(327, 3);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.Size = new System.Drawing.Size(100, 21);
            this.cmb_Model.TabIndex = 6;
            this.cmb_Model.Text = global::AiCompanion.Properties.Settings.Default.ModelLLM;
            this.cmb_Model.SelectedIndexChanged += new System.EventHandler(this.cmb_Model_SelectedIndexChanged);
            // 
            // Form_TextPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(446, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_TextPrompt";
            this.Text = "AiCompanion";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form_TextPrompt_Activated);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.RichTextBox txt_input;
        private System.Windows.Forms.RichTextBox txt_result;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cmb_Model;
    }
}


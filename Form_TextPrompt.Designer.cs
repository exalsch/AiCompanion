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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TextPrompt));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btn_send = new System.Windows.Forms.Button();
            btn_insert = new System.Windows.Forms.Button();
            btn_copy = new System.Windows.Forms.Button();
            btn_cancel = new System.Windows.Forms.Button();
            cmb_Model = new System.Windows.Forms.ComboBox();
            txt_result = new System.Windows.Forms.RichTextBox();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            txt_input = new System.Windows.Forms.RichTextBox();
            cmbPrePrompts = new System.Windows.Forms.ComboBox();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            btnAddPrePromt = new System.Windows.Forms.Button();
            btnRemovePrePromt = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(txt_result, 0, 0);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new System.Drawing.Size(520, 687);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_send);
            flowLayoutPanel1.Controls.Add(btn_insert);
            flowLayoutPanel1.Controls.Add(btn_copy);
            flowLayoutPanel1.Controls.Add(btn_cancel);
            flowLayoutPanel1.Controls.Add(cmb_Model);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 623);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(512, 37);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_send
            // 
            btn_send.Location = new System.Drawing.Point(4, 3);
            btn_send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_send.Name = "btn_send";
            btn_send.Size = new System.Drawing.Size(88, 27);
            btn_send.TabIndex = 0;
            btn_send.Text = "&Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_insert
            // 
            btn_insert.Enabled = false;
            btn_insert.Location = new System.Drawing.Point(100, 3);
            btn_insert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new System.Drawing.Size(88, 27);
            btn_insert.TabIndex = 1;
            btn_insert.Text = "&Insert";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_copy
            // 
            btn_copy.Enabled = false;
            btn_copy.Location = new System.Drawing.Point(196, 3);
            btn_copy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new System.Drawing.Size(88, 27);
            btn_copy.TabIndex = 2;
            btn_copy.Text = "&Copy";
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += btn_copy_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_cancel.Location = new System.Drawing.Point(292, 3);
            btn_cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(88, 27);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // cmb_Model
            // 
            cmb_Model.FormattingEnabled = true;
            cmb_Model.Items.AddRange(new object[] { "gpt-4o-mini", "gpt-4o", "gpt-4-turbo", "gpt-4", "gpt-3.5-turbo", "gpt-3.5-turbo-instruct" });
            cmb_Model.Location = new System.Drawing.Point(388, 3);
            cmb_Model.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmb_Model.Name = "cmb_Model";
            cmb_Model.Size = new System.Drawing.Size(116, 23);
            cmb_Model.TabIndex = 4;
            cmb_Model.Text = "gpt-4o-mini";
            cmb_Model.SelectedIndexChanged += cmb_Model_SelectedIndexChanged;
            // 
            // txt_result
            // 
            txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_result.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_result.Location = new System.Drawing.Point(4, 3);
            txt_result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_result.Name = "txt_result";
            txt_result.ReadOnly = true;
            txt_result.Size = new System.Drawing.Size(512, 304);
            txt_result.TabIndex = 0;
            txt_result.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 663);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip1.Size = new System.Drawing.Size(520, 24);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new System.Drawing.Size(35, 19);
            toolStripStatusLabel.Text = "Idle...";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.22727F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.77273F));
            tableLayoutPanel2.Controls.Add(txt_input, 0, 1);
            tableLayoutPanel2.Controls.Add(cmbPrePrompts, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(4, 313);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67194F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.32806F));
            tableLayoutPanel2.Size = new System.Drawing.Size(512, 304);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // txt_input
            // 
            txt_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tableLayoutPanel2.SetColumnSpan(txt_input, 2);
            txt_input.Dock = System.Windows.Forms.DockStyle.Fill;
            txt_input.Location = new System.Drawing.Point(4, 35);
            txt_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_input.Name = "txt_input";
            txt_input.Size = new System.Drawing.Size(504, 266);
            txt_input.TabIndex = 0;
            txt_input.Text = "";
            txt_input.TextChanged += txt_input_TextChanged;
            // 
            // cmbPrePrompts
            // 
            cmbPrePrompts.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbPrePrompts.FormattingEnabled = true;
            cmbPrePrompts.Location = new System.Drawing.Point(4, 3);
            cmbPrePrompts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbPrePrompts.Name = "cmbPrePrompts";
            cmbPrePrompts.Size = new System.Drawing.Size(377, 23);
            cmbPrePrompts.TabIndex = 1;
            toolTip1.SetToolTip(cmbPrePrompts, "Custom pre-promts. Use to force specific behaviour/style/etc for the reply.");
            cmbPrePrompts.TextChanged += cmbPrePrompts_TextChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAddPrePromt);
            flowLayoutPanel2.Controls.Add(btnRemovePrePromt);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.Location = new System.Drawing.Point(389, 3);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(119, 26);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // btnAddPrePromt
            // 
            btnAddPrePromt.Location = new System.Drawing.Point(0, 0);
            btnAddPrePromt.Margin = new System.Windows.Forms.Padding(0, 0, 4, 3);
            btnAddPrePromt.Name = "btnAddPrePromt";
            btnAddPrePromt.Size = new System.Drawing.Size(42, 27);
            btnAddPrePromt.TabIndex = 0;
            btnAddPrePromt.Text = "Add";
            btnAddPrePromt.UseVisualStyleBackColor = true;
            btnAddPrePromt.Click += btnAddPrePromt_Click;
            // 
            // btnRemovePrePromt
            // 
            btnRemovePrePromt.Location = new System.Drawing.Point(50, 0);
            btnRemovePrePromt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 3);
            btnRemovePrePromt.Name = "btnRemovePrePromt";
            btnRemovePrePromt.Size = new System.Drawing.Size(65, 27);
            btnRemovePrePromt.TabIndex = 1;
            btnRemovePrePromt.Text = "Remove";
            btnRemovePrePromt.UseVisualStyleBackColor = true;
            btnRemovePrePromt.Click += btnRemovePrePromt_Click;
            // 
            // Form_TextPrompt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new System.Drawing.Size(520, 687);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_TextPrompt";
            Text = "AiCompanion";
            TopMost = true;
            Activated += Form_TextPrompt_Activated;
            Load += Form_TextPrompt_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cmb_Model;
        private System.Windows.Forms.ComboBox cmbPrePrompts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnAddPrePromt;
        private System.Windows.Forms.Button btnRemovePrePromt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


namespace AiCompanion
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TabControl = new ReaLTaiizor.Controls.MetroTabControl();
            this.TabPagePrompt = new ReaLTaiizor.Child.Metro.MetroTabPage();
            this.btn_sendPrompt = new ReaLTaiizor.Controls.MetroDefaultButton();
            this.metroStyleManager = new ReaLTaiizor.Manager.MetroStyleManager();
            this.cmb_Model = new ReaLTaiizor.Controls.MetroComboBox();
            this.btn_copyPrompt = new ReaLTaiizor.Controls.MetroButton();
            this.btn_insertPrompt = new ReaLTaiizor.Controls.MetroButton();
            this.txt_input = new ReaLTaiizor.Controls.MetroTextBox();
            this.btnRemovePrePromt = new ReaLTaiizor.Controls.MetroButton();
            this.btnAddPrePromt = new ReaLTaiizor.Controls.MetroButton();
            this.cmbPrePrompts = new ReaLTaiizor.Controls.MetroComboBox();
            this.txt_result = new ReaLTaiizor.Controls.MetroRichTextBox();
            this.metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            this.TabPageTTS = new ReaLTaiizor.Child.Metro.MetroTabPage();
            this.txt_TextTTS = new ReaLTaiizor.Controls.MetroTextBox();
            this.range_SpeedTTS = new ReaLTaiizor.Controls.MetroTrackBar();
            this.cmbBxVoiceTTS = new ReaLTaiizor.Controls.MetroComboBox();
            this.lblVoice = new ReaLTaiizor.Controls.MetroLabel();
            this.lblSpeed = new ReaLTaiizor.Controls.MetroLabel();
            this.checkBoxDownloadTTS = new ReaLTaiizor.Controls.MetroCheckBox();
            this.btn_DownloadTTS = new ReaLTaiizor.Controls.MetroButton();
            this.btn_stopTTS = new ReaLTaiizor.Controls.MetroButton();
            this.btn_playTTS = new ReaLTaiizor.Controls.MetroDefaultButton();
            this.TabPageSTT = new ReaLTaiizor.Child.Metro.MetroTabPage();
            this.cmbSttLanguage = new ReaLTaiizor.Controls.MetroComboBox();
            this.btn_clearSTT = new ReaLTaiizor.Controls.MetroButton();
            this.btn_copySTT = new ReaLTaiizor.Controls.MetroButton();
            this.btn_record = new ReaLTaiizor.Controls.MetroDefaultButton();
            this.txt_resultSTT = new ReaLTaiizor.Controls.MetroRichTextBox();
            this.TabPageSettings = new ReaLTaiizor.Child.Metro.MetroTabPage();
            this.metroLabel6 = new ReaLTaiizor.Controls.MetroLabel();
            this.switchDarkMode = new ReaLTaiizor.Controls.MetroSwitch();
            this.metroLabel5 = new ReaLTaiizor.Controls.MetroLabel();
            this.btn_saveSettings = new ReaLTaiizor.Controls.MetroDefaultButton();
            this.metroTextBox1 = new ReaLTaiizor.Controls.MetroTextBox();
            this.metroLabel4 = new ReaLTaiizor.Controls.MetroLabel();
            this.metroLabel3 = new ReaLTaiizor.Controls.MetroLabel();
            this.metroComboBox1 = new ReaLTaiizor.Controls.MetroComboBox();
            this.txt_API_URL = new ReaLTaiizor.Controls.MetroTextBox();
            this.txt_ApiKey = new ReaLTaiizor.Controls.MetroTextBox();
            this.chkUseNewUI = new ReaLTaiizor.Controls.MetroCheckBox();
            this.TabPageAbout = new ReaLTaiizor.Child.Metro.MetroTabPage();
            this.lblAboutVersion = new ReaLTaiizor.Controls.MetroLabel();
            this.metroLinkLabel4 = new ReaLTaiizor.Controls.MetroLinkLabel();
            this.metroLinkLabel3 = new ReaLTaiizor.Controls.MetroLinkLabel();
            this.metroLinkLabel2 = new ReaLTaiizor.Controls.MetroLinkLabel();
            this.metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            this.metroLinkLabel1 = new ReaLTaiizor.Controls.MetroLinkLabel();
            this.metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            this.metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            this.statusLabel = new ReaLTaiizor.Controls.MetroLabel();
            this.WindowControlBox = new ReaLTaiizor.Controls.MetroControlBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.TabPagePrompt.SuspendLayout();
            this.TabPageTTS.SuspendLayout();
            this.TabPageSTT.SuspendLayout();
            this.TabPageSettings.SuspendLayout();
            this.TabPageAbout.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.QuartOut;
            this.TabControl.AnimateTime = 200;
            this.TabControl.BackgroundColor = System.Drawing.Color.White;
            this.TabControl.Controls.Add(this.TabPagePrompt);
            this.TabControl.Controls.Add(this.TabPageTTS);
            this.TabControl.Controls.Add(this.TabPageSTT);
            this.TabControl.Controls.Add(this.TabPageSettings);
            this.TabControl.Controls.Add(this.TabPageAbout);
            this.TabControl.ControlsVisible = true;
            this.TabControl.HotTrack = true;
            this.TabControl.IsDerivedStyle = true;
            this.TabControl.ItemSize = new System.Drawing.Size(100, 38);
            this.TabControl.Location = new System.Drawing.Point(0, 58);
            this.TabControl.MCursor = System.Windows.Forms.Cursors.Hand;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 3;
            this.TabControl.SelectedTextColor = System.Drawing.Color.White;
            this.TabControl.Size = new System.Drawing.Size(412, 571);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.Speed = 100;
            this.TabControl.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.TabControl.StyleManager = this.metroStyleManager;
            this.TabControl.TabIndex = 1;
            this.TabControl.ThemeAuthor = "Taiizor";
            this.TabControl.ThemeName = "MetroLight";
            this.TabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // TabPagePrompt
            // 
            this.TabPagePrompt.BaseColor = System.Drawing.Color.White;
            this.TabPagePrompt.Controls.Add(this.btn_sendPrompt);
            this.TabPagePrompt.Controls.Add(this.cmb_Model);
            this.TabPagePrompt.Controls.Add(this.btn_copyPrompt);
            this.TabPagePrompt.Controls.Add(this.btn_insertPrompt);
            this.TabPagePrompt.Controls.Add(this.txt_input);
            this.TabPagePrompt.Controls.Add(this.btnRemovePrePromt);
            this.TabPagePrompt.Controls.Add(this.btnAddPrePromt);
            this.TabPagePrompt.Controls.Add(this.cmbPrePrompts);
            this.TabPagePrompt.Controls.Add(this.txt_result);
            this.TabPagePrompt.Controls.Add(this.metroDivider1);
            this.TabPagePrompt.Font = null;
            this.TabPagePrompt.ImageIndex = 0;
            this.TabPagePrompt.ImageKey = null;
            this.TabPagePrompt.IsDerivedStyle = true;
            this.TabPagePrompt.Location = new System.Drawing.Point(4, 42);
            this.TabPagePrompt.Name = "TabPagePrompt";
            this.TabPagePrompt.Size = new System.Drawing.Size(402, 516);
            this.TabPagePrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.TabPagePrompt.StyleManager = this.metroStyleManager;
            this.TabPagePrompt.TabIndex = 0;
            this.TabPagePrompt.Text = "Prompt";
            this.TabPagePrompt.ThemeAuthor = "Taiizor";
            this.TabPagePrompt.ThemeName = "MetroLight";
            this.TabPagePrompt.ToolTipText = null;
            // 
            // btn_sendPrompt
            // 
            this.btn_sendPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sendPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_sendPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_sendPrompt.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btn_sendPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_sendPrompt.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_sendPrompt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_sendPrompt.HoverTextColor = System.Drawing.Color.White;
            this.btn_sendPrompt.IsDerivedStyle = true;
            this.btn_sendPrompt.Location = new System.Drawing.Point(0, 488);
            this.btn_sendPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sendPrompt.Name = "btn_sendPrompt";
            this.btn_sendPrompt.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_sendPrompt.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_sendPrompt.NormalTextColor = System.Drawing.Color.Black;
            this.btn_sendPrompt.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_sendPrompt.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_sendPrompt.PressTextColor = System.Drawing.Color.White;
            this.btn_sendPrompt.Size = new System.Drawing.Size(55, 26);
            this.btn_sendPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_sendPrompt.StyleManager = this.metroStyleManager;
            this.btn_sendPrompt.TabIndex = 10;
            this.btn_sendPrompt.Text = "Send";
            this.btn_sendPrompt.ThemeAuthor = "Taiizor";
            this.btn_sendPrompt.ThemeName = "MetroLight";
            this.btn_sendPrompt.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.CustomTheme = "C:\\Users\\ALSCH\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            this.metroStyleManager.OwnerForm = this;
            this.metroStyleManager.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroStyleManager.ThemeAuthor = "Taiizor";
            this.metroStyleManager.ThemeName = "MetroLight";
            // 
            // cmb_Model
            // 
            this.cmb_Model.AllowDrop = true;
            this.cmb_Model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Model.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmb_Model.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Model.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmb_Model.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmb_Model.CausesValidation = false;
            this.cmb_Model.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_Model.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmb_Model.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmb_Model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmb_Model.FormattingEnabled = true;
            this.cmb_Model.IsDerivedStyle = true;
            this.cmb_Model.ItemHeight = 20;
            this.cmb_Model.Items.AddRange(new object[] {
            "gpt-4o-mini",
            "gpt-4o",
            "gpt-4-turbo",
            "gpt-4",
            "gpt-3.5-turbo",
            "gpt-3.5-turbo-instruct"});
            this.cmb_Model.Location = new System.Drawing.Point(294, 488);
            this.cmb_Model.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Model.Name = "cmb_Model";
            this.cmb_Model.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmb_Model.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmb_Model.Size = new System.Drawing.Size(102, 26);
            this.cmb_Model.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cmb_Model.StyleManager = this.metroStyleManager;
            this.cmb_Model.TabIndex = 9;
            this.cmb_Model.ThemeAuthor = "Taiizor";
            this.cmb_Model.ThemeName = "MetroLight";
            this.cmb_Model.SelectedIndexChanged += new System.EventHandler(this.cmb_Model_SelectedIndexChanged);
            // 
            // btn_copyPrompt
            // 
            this.btn_copyPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_copyPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copyPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copyPrompt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_copyPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_copyPrompt.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_copyPrompt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_copyPrompt.HoverTextColor = System.Drawing.Color.White;
            this.btn_copyPrompt.IsDerivedStyle = true;
            this.btn_copyPrompt.Location = new System.Drawing.Point(59, 488);
            this.btn_copyPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_copyPrompt.Name = "btn_copyPrompt";
            this.btn_copyPrompt.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copyPrompt.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copyPrompt.NormalTextColor = System.Drawing.Color.White;
            this.btn_copyPrompt.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_copyPrompt.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_copyPrompt.PressTextColor = System.Drawing.Color.White;
            this.btn_copyPrompt.Size = new System.Drawing.Size(56, 26);
            this.btn_copyPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_copyPrompt.StyleManager = this.metroStyleManager;
            this.btn_copyPrompt.TabIndex = 7;
            this.btn_copyPrompt.Text = "Copy";
            this.btn_copyPrompt.ThemeAuthor = "Taiizor";
            this.btn_copyPrompt.ThemeName = "MetroLight";
            this.btn_copyPrompt.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_insertPrompt
            // 
            this.btn_insertPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_insertPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_insertPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_insertPrompt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_insertPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_insertPrompt.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_insertPrompt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_insertPrompt.HoverTextColor = System.Drawing.Color.White;
            this.btn_insertPrompt.IsDerivedStyle = true;
            this.btn_insertPrompt.Location = new System.Drawing.Point(119, 488);
            this.btn_insertPrompt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_insertPrompt.Name = "btn_insertPrompt";
            this.btn_insertPrompt.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_insertPrompt.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_insertPrompt.NormalTextColor = System.Drawing.Color.White;
            this.btn_insertPrompt.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_insertPrompt.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_insertPrompt.PressTextColor = System.Drawing.Color.White;
            this.btn_insertPrompt.Size = new System.Drawing.Size(45, 26);
            this.btn_insertPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_insertPrompt.StyleManager = this.metroStyleManager;
            this.btn_insertPrompt.TabIndex = 6;
            this.btn_insertPrompt.Text = "Insert";
            this.btn_insertPrompt.ThemeAuthor = "Taiizor";
            this.btn_insertPrompt.ThemeName = "MetroLight";
            this.btn_insertPrompt.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_input
            // 
            this.txt_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_input.AutoCompleteCustomSource = null;
            this.txt_input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_input.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_input.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_input.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_input.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_input.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_input.Image = null;
            this.txt_input.IsDerivedStyle = true;
            this.txt_input.Lines = null;
            this.txt_input.Location = new System.Drawing.Point(0, 319);
            this.txt_input.Margin = new System.Windows.Forms.Padding(2);
            this.txt_input.MaxLength = 32767;
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.ReadOnly = false;
            this.txt_input.Size = new System.Drawing.Size(404, 165);
            this.txt_input.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txt_input.StyleManager = this.metroStyleManager;
            this.txt_input.TabIndex = 5;
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_input.ThemeAuthor = "Taiizor";
            this.txt_input.ThemeName = "MetroLight";
            this.txt_input.UseSystemPasswordChar = false;
            this.txt_input.WatermarkText = "Prompt";
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            // 
            // btnRemovePrePromt
            // 
            this.btnRemovePrePromt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemovePrePromt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemovePrePromt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemovePrePromt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnRemovePrePromt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemovePrePromt.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnRemovePrePromt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnRemovePrePromt.HoverTextColor = System.Drawing.Color.White;
            this.btnRemovePrePromt.IsDerivedStyle = true;
            this.btnRemovePrePromt.Location = new System.Drawing.Point(337, 289);
            this.btnRemovePrePromt.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePrePromt.Name = "btnRemovePrePromt";
            this.btnRemovePrePromt.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemovePrePromt.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnRemovePrePromt.NormalTextColor = System.Drawing.Color.White;
            this.btnRemovePrePromt.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnRemovePrePromt.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnRemovePrePromt.PressTextColor = System.Drawing.Color.White;
            this.btnRemovePrePromt.Size = new System.Drawing.Size(59, 26);
            this.btnRemovePrePromt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btnRemovePrePromt.StyleManager = this.metroStyleManager;
            this.btnRemovePrePromt.TabIndex = 4;
            this.btnRemovePrePromt.Text = "Remove";
            this.btnRemovePrePromt.ThemeAuthor = "Taiizor";
            this.btnRemovePrePromt.ThemeName = "MetroLight";
            this.btnRemovePrePromt.Click += new System.EventHandler(this.btnRemovePrePromt_Click);
            // 
            // btnAddPrePromt
            // 
            this.btnAddPrePromt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPrePromt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddPrePromt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddPrePromt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddPrePromt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddPrePromt.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddPrePromt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddPrePromt.HoverTextColor = System.Drawing.Color.White;
            this.btnAddPrePromt.IsDerivedStyle = true;
            this.btnAddPrePromt.Location = new System.Drawing.Point(292, 289);
            this.btnAddPrePromt.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPrePromt.Name = "btnAddPrePromt";
            this.btnAddPrePromt.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddPrePromt.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddPrePromt.NormalTextColor = System.Drawing.Color.White;
            this.btnAddPrePromt.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddPrePromt.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddPrePromt.PressTextColor = System.Drawing.Color.White;
            this.btnAddPrePromt.Size = new System.Drawing.Size(41, 26);
            this.btnAddPrePromt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btnAddPrePromt.StyleManager = this.metroStyleManager;
            this.btnAddPrePromt.TabIndex = 3;
            this.btnAddPrePromt.Text = "Add";
            this.btnAddPrePromt.ThemeAuthor = "Taiizor";
            this.btnAddPrePromt.ThemeName = "MetroLight";
            this.btnAddPrePromt.Click += new System.EventHandler(this.btnAddPrePromt_Click);
            // 
            // cmbPrePrompts
            // 
            this.cmbPrePrompts.AllowDrop = true;
            this.cmbPrePrompts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPrePrompts.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbPrePrompts.BackColor = System.Drawing.Color.Transparent;
            this.cmbPrePrompts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbPrePrompts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbPrePrompts.CausesValidation = false;
            this.cmbPrePrompts.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbPrePrompts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbPrePrompts.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbPrePrompts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPrePrompts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrePrompts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbPrePrompts.FormattingEnabled = true;
            this.cmbPrePrompts.IsDerivedStyle = true;
            this.cmbPrePrompts.ItemHeight = 20;
            this.cmbPrePrompts.Location = new System.Drawing.Point(0, 289);
            this.cmbPrePrompts.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPrePrompts.Name = "cmbPrePrompts";
            this.cmbPrePrompts.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbPrePrompts.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbPrePrompts.Size = new System.Drawing.Size(288, 26);
            this.cmbPrePrompts.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cmbPrePrompts.StyleManager = this.metroStyleManager;
            this.cmbPrePrompts.TabIndex = 2;
            this.cmbPrePrompts.ThemeAuthor = "Taiizor";
            this.cmbPrePrompts.ThemeName = "MetroLight";
            this.cmbPrePrompts.TextChanged += new System.EventHandler(this.cmbPrePrompts_TextChanged);
            // 
            // txt_result
            // 
            this.txt_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_result.AutoWordSelection = false;
            this.txt_result.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_result.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_result.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_result.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_result.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_result.IsDerivedStyle = true;
            this.txt_result.Lines = null;
            this.txt_result.Location = new System.Drawing.Point(-4, 2);
            this.txt_result.Margin = new System.Windows.Forms.Padding(2);
            this.txt_result.MaxLength = 32767;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(407, 278);
            this.txt_result.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txt_result.StyleManager = this.metroStyleManager;
            this.txt_result.TabIndex = 1;
            this.txt_result.ThemeAuthor = "Taiizor";
            this.txt_result.ThemeName = "MetroLight";
            this.txt_result.WordWrap = true;
            // 
            // metroDivider1
            // 
            this.metroDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDivider1.IsDerivedStyle = true;
            this.metroDivider1.Location = new System.Drawing.Point(-2, 283);
            this.metroDivider1.Margin = new System.Windows.Forms.Padding(2);
            this.metroDivider1.Name = "metroDivider1";
            this.metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            this.metroDivider1.Size = new System.Drawing.Size(405, 4);
            this.metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroDivider1.StyleManager = this.metroStyleManager;
            this.metroDivider1.TabIndex = 0;
            this.metroDivider1.Text = "metroDivider1";
            this.metroDivider1.ThemeAuthor = "Taiizor";
            this.metroDivider1.ThemeName = "MetroLight";
            this.metroDivider1.Thickness = 1;
            // 
            // TabPageTTS
            // 
            this.TabPageTTS.BaseColor = System.Drawing.Color.White;
            this.TabPageTTS.Controls.Add(this.txt_TextTTS);
            this.TabPageTTS.Controls.Add(this.range_SpeedTTS);
            this.TabPageTTS.Controls.Add(this.cmbBxVoiceTTS);
            this.TabPageTTS.Controls.Add(this.lblVoice);
            this.TabPageTTS.Controls.Add(this.lblSpeed);
            this.TabPageTTS.Controls.Add(this.checkBoxDownloadTTS);
            this.TabPageTTS.Controls.Add(this.btn_DownloadTTS);
            this.TabPageTTS.Controls.Add(this.btn_stopTTS);
            this.TabPageTTS.Controls.Add(this.btn_playTTS);
            this.TabPageTTS.Font = null;
            this.TabPageTTS.ImageIndex = 0;
            this.TabPageTTS.ImageKey = null;
            this.TabPageTTS.IsDerivedStyle = true;
            this.TabPageTTS.Location = new System.Drawing.Point(4, 42);
            this.TabPageTTS.Name = "TabPageTTS";
            this.TabPageTTS.Size = new System.Drawing.Size(402, 516);
            this.TabPageTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.TabPageTTS.StyleManager = this.metroStyleManager;
            this.TabPageTTS.TabIndex = 1;
            this.TabPageTTS.Text = "Text-To-Speach";
            this.TabPageTTS.ThemeAuthor = "Taiizor";
            this.TabPageTTS.ThemeName = "MetroLight";
            this.TabPageTTS.ToolTipText = null;
            // 
            // txt_TextTTS
            // 
            this.txt_TextTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TextTTS.AutoCompleteCustomSource = null;
            this.txt_TextTTS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_TextTTS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_TextTTS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_TextTTS.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_TextTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_TextTTS.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_TextTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_TextTTS.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_TextTTS.Image = null;
            this.txt_TextTTS.IsDerivedStyle = true;
            this.txt_TextTTS.Lines = null;
            this.txt_TextTTS.Location = new System.Drawing.Point(-4, 2);
            this.txt_TextTTS.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TextTTS.MaxLength = 32767;
            this.txt_TextTTS.Multiline = true;
            this.txt_TextTTS.Name = "txt_TextTTS";
            this.txt_TextTTS.ReadOnly = false;
            this.txt_TextTTS.Size = new System.Drawing.Size(404, 470);
            this.txt_TextTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txt_TextTTS.StyleManager = this.metroStyleManager;
            this.txt_TextTTS.TabIndex = 10;
            this.txt_TextTTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TextTTS.ThemeAuthor = "Taiizor";
            this.txt_TextTTS.ThemeName = "MetroLight";
            this.txt_TextTTS.UseSystemPasswordChar = false;
            this.txt_TextTTS.WatermarkText = "Text to transrcribe...";
            // 
            // range_SpeedTTS
            // 
            this.range_SpeedTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.range_SpeedTTS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.range_SpeedTTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.range_SpeedTTS.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.range_SpeedTTS.DisabledBorderColor = System.Drawing.Color.Empty;
            this.range_SpeedTTS.DisabledHandlerColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.range_SpeedTTS.DisabledValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.range_SpeedTTS.HandlerColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.range_SpeedTTS.IsDerivedStyle = true;
            this.range_SpeedTTS.Location = new System.Drawing.Point(158, 497);
            this.range_SpeedTTS.Margin = new System.Windows.Forms.Padding(2);
            this.range_SpeedTTS.Maximum = 100;
            this.range_SpeedTTS.Minimum = 0;
            this.range_SpeedTTS.Name = "range_SpeedTTS";
            this.range_SpeedTTS.Size = new System.Drawing.Size(74, 16);
            this.range_SpeedTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.range_SpeedTTS.StyleManager = this.metroStyleManager;
            this.range_SpeedTTS.TabIndex = 9;
            this.range_SpeedTTS.Text = "metroTrackBar1";
            this.range_SpeedTTS.ThemeAuthor = "Taiizor";
            this.range_SpeedTTS.ThemeName = "MetroLight";
            this.range_SpeedTTS.Value = 25;
            this.range_SpeedTTS.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.range_SpeedTTS.Scroll += new ReaLTaiizor.Controls.MetroTrackBar.ScrollEventHandler(this.range_SpeedTTS_Scroll);
            // 
            // cmbBxVoiceTTS
            // 
            this.cmbBxVoiceTTS.AllowDrop = true;
            this.cmbBxVoiceTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxVoiceTTS.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbBxVoiceTTS.BackColor = System.Drawing.Color.Transparent;
            this.cmbBxVoiceTTS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbBxVoiceTTS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbBxVoiceTTS.CausesValidation = false;
            this.cmbBxVoiceTTS.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbBxVoiceTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbBxVoiceTTS.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbBxVoiceTTS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBxVoiceTTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxVoiceTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbBxVoiceTTS.FormattingEnabled = true;
            this.cmbBxVoiceTTS.IsDerivedStyle = true;
            this.cmbBxVoiceTTS.ItemHeight = 20;
            this.cmbBxVoiceTTS.Items.AddRange(new object[] {
            "Alloy",
            "Echo",
            "Fable",
            "Onyx",
            "Nova",
            "Shimmer"});
            this.cmbBxVoiceTTS.Location = new System.Drawing.Point(298, 493);
            this.cmbBxVoiceTTS.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBxVoiceTTS.Name = "cmbBxVoiceTTS";
            this.cmbBxVoiceTTS.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbBxVoiceTTS.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbBxVoiceTTS.Size = new System.Drawing.Size(102, 26);
            this.cmbBxVoiceTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cmbBxVoiceTTS.StyleManager = this.metroStyleManager;
            this.cmbBxVoiceTTS.TabIndex = 8;
            this.cmbBxVoiceTTS.ThemeAuthor = "Taiizor";
            this.cmbBxVoiceTTS.ThemeName = "MetroLight";
            this.cmbBxVoiceTTS.SelectedIndexChanged += new System.EventHandler(this.cmbBxVoiceTTS_SelectedIndexChanged);
            // 
            // lblVoice
            // 
            this.lblVoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVoice.IsDerivedStyle = true;
            this.lblVoice.Location = new System.Drawing.Point(236, 497);
            this.lblVoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoice.Name = "lblVoice";
            this.lblVoice.Size = new System.Drawing.Size(52, 16);
            this.lblVoice.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblVoice.StyleManager = this.metroStyleManager;
            this.lblVoice.TabIndex = 7;
            this.lblVoice.Text = "Voice:";
            this.lblVoice.ThemeAuthor = "Taiizor";
            this.lblVoice.ThemeName = "MetroLight";
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSpeed.IsDerivedStyle = true;
            this.lblSpeed.Location = new System.Drawing.Point(98, 496);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(56, 20);
            this.lblSpeed.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblSpeed.StyleManager = this.metroStyleManager;
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "Speed:";
            this.lblSpeed.ThemeAuthor = "Taiizor";
            this.lblSpeed.ThemeName = "MetroLight";
            // 
            // checkBoxDownloadTTS
            // 
            this.checkBoxDownloadTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxDownloadTTS.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDownloadTTS.BackgroundColor = System.Drawing.Color.White;
            this.checkBoxDownloadTTS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.checkBoxDownloadTTS.Checked = false;
            this.checkBoxDownloadTTS.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.checkBoxDownloadTTS.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.checkBoxDownloadTTS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDownloadTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.checkBoxDownloadTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxDownloadTTS.IsDerivedStyle = true;
            this.checkBoxDownloadTTS.Location = new System.Drawing.Point(2, 496);
            this.checkBoxDownloadTTS.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDownloadTTS.Name = "checkBoxDownloadTTS";
            this.checkBoxDownloadTTS.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            this.checkBoxDownloadTTS.Size = new System.Drawing.Size(92, 16);
            this.checkBoxDownloadTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.checkBoxDownloadTTS.StyleManager = this.metroStyleManager;
            this.checkBoxDownloadTTS.TabIndex = 4;
            this.checkBoxDownloadTTS.Text = "Save Audio";
            this.checkBoxDownloadTTS.ThemeAuthor = "Taiizor";
            this.checkBoxDownloadTTS.ThemeName = "MetroLight";
            // 
            // btn_DownloadTTS
            // 
            this.btn_DownloadTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DownloadTTS.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_DownloadTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_DownloadTTS.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_DownloadTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_DownloadTTS.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_DownloadTTS.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_DownloadTTS.HoverTextColor = System.Drawing.Color.White;
            this.btn_DownloadTTS.IsDerivedStyle = true;
            this.btn_DownloadTTS.Location = new System.Drawing.Point(98, 476);
            this.btn_DownloadTTS.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DownloadTTS.Name = "btn_DownloadTTS";
            this.btn_DownloadTTS.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_DownloadTTS.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_DownloadTTS.NormalTextColor = System.Drawing.Color.White;
            this.btn_DownloadTTS.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_DownloadTTS.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_DownloadTTS.PressTextColor = System.Drawing.Color.White;
            this.btn_DownloadTTS.Size = new System.Drawing.Size(71, 15);
            this.btn_DownloadTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_DownloadTTS.StyleManager = this.metroStyleManager;
            this.btn_DownloadTTS.TabIndex = 3;
            this.btn_DownloadTTS.Text = "Download";
            this.btn_DownloadTTS.ThemeAuthor = "Taiizor";
            this.btn_DownloadTTS.ThemeName = "MetroLight";
            this.btn_DownloadTTS.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_stopTTS
            // 
            this.btn_stopTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_stopTTS.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_stopTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_stopTTS.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_stopTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_stopTTS.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_stopTTS.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_stopTTS.HoverTextColor = System.Drawing.Color.White;
            this.btn_stopTTS.IsDerivedStyle = true;
            this.btn_stopTTS.Location = new System.Drawing.Point(49, 476);
            this.btn_stopTTS.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stopTTS.Name = "btn_stopTTS";
            this.btn_stopTTS.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_stopTTS.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_stopTTS.NormalTextColor = System.Drawing.Color.White;
            this.btn_stopTTS.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_stopTTS.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_stopTTS.PressTextColor = System.Drawing.Color.White;
            this.btn_stopTTS.Size = new System.Drawing.Size(45, 15);
            this.btn_stopTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_stopTTS.StyleManager = this.metroStyleManager;
            this.btn_stopTTS.TabIndex = 2;
            this.btn_stopTTS.Text = "Stop";
            this.btn_stopTTS.ThemeAuthor = "Taiizor";
            this.btn_stopTTS.ThemeName = "MetroLight";
            this.btn_stopTTS.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_playTTS
            // 
            this.btn_playTTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_playTTS.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_playTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_playTTS.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btn_playTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_playTTS.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_playTTS.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_playTTS.HoverTextColor = System.Drawing.Color.White;
            this.btn_playTTS.IsDerivedStyle = true;
            this.btn_playTTS.Location = new System.Drawing.Point(0, 476);
            this.btn_playTTS.Margin = new System.Windows.Forms.Padding(2);
            this.btn_playTTS.Name = "btn_playTTS";
            this.btn_playTTS.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_playTTS.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_playTTS.NormalTextColor = System.Drawing.Color.Black;
            this.btn_playTTS.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_playTTS.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_playTTS.PressTextColor = System.Drawing.Color.White;
            this.btn_playTTS.Size = new System.Drawing.Size(45, 15);
            this.btn_playTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_playTTS.StyleManager = this.metroStyleManager;
            this.btn_playTTS.TabIndex = 1;
            this.btn_playTTS.Text = "Play";
            this.btn_playTTS.ThemeAuthor = "Taiizor";
            this.btn_playTTS.ThemeName = "MetroLight";
            this.btn_playTTS.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // TabPageSTT
            // 
            this.TabPageSTT.BaseColor = System.Drawing.Color.White;
            this.TabPageSTT.Controls.Add(this.cmbSttLanguage);
            this.TabPageSTT.Controls.Add(this.btn_clearSTT);
            this.TabPageSTT.Controls.Add(this.btn_copySTT);
            this.TabPageSTT.Controls.Add(this.btn_record);
            this.TabPageSTT.Controls.Add(this.txt_resultSTT);
            this.TabPageSTT.Font = null;
            this.TabPageSTT.ImageIndex = 0;
            this.TabPageSTT.ImageKey = null;
            this.TabPageSTT.IsDerivedStyle = true;
            this.TabPageSTT.Location = new System.Drawing.Point(4, 42);
            this.TabPageSTT.Name = "TabPageSTT";
            this.TabPageSTT.Size = new System.Drawing.Size(402, 516);
            this.TabPageSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.TabPageSTT.StyleManager = this.metroStyleManager;
            this.TabPageSTT.TabIndex = 2;
            this.TabPageSTT.Text = "Speach-To-text";
            this.TabPageSTT.ThemeAuthor = "Taiizor";
            this.TabPageSTT.ThemeName = "MetroLight";
            this.TabPageSTT.ToolTipText = null;
            // 
            // cmbSttLanguage
            // 
            this.cmbSttLanguage.AllowDrop = true;
            this.cmbSttLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSttLanguage.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbSttLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbSttLanguage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cmbSttLanguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbSttLanguage.CausesValidation = false;
            this.cmbSttLanguage.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbSttLanguage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbSttLanguage.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbSttLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSttLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSttLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbSttLanguage.FormattingEnabled = true;
            this.cmbSttLanguage.IsDerivedStyle = true;
            this.cmbSttLanguage.ItemHeight = 20;
            this.cmbSttLanguage.Items.AddRange(new object[] {
            "en",
            "de",
            "cz",
            "se",
            "dk",
            "no",
            "fr",
            "es"});
            this.cmbSttLanguage.Location = new System.Drawing.Point(157, 488);
            this.cmbSttLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSttLanguage.Name = "cmbSttLanguage";
            this.cmbSttLanguage.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbSttLanguage.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbSttLanguage.Size = new System.Drawing.Size(62, 26);
            this.cmbSttLanguage.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.cmbSttLanguage.StyleManager = this.metroStyleManager;
            this.cmbSttLanguage.TabIndex = 4;
            this.cmbSttLanguage.ThemeAuthor = "Taiizor";
            this.cmbSttLanguage.ThemeName = "MetroLight";
            this.cmbSttLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxSttLanguage_SelectedIndexChanged);
            // 
            // btn_clearSTT
            // 
            this.btn_clearSTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clearSTT.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_clearSTT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_clearSTT.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_clearSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_clearSTT.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_clearSTT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_clearSTT.HoverTextColor = System.Drawing.Color.White;
            this.btn_clearSTT.IsDerivedStyle = true;
            this.btn_clearSTT.Location = new System.Drawing.Point(103, 488);
            this.btn_clearSTT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clearSTT.Name = "btn_clearSTT";
            this.btn_clearSTT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_clearSTT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_clearSTT.NormalTextColor = System.Drawing.Color.White;
            this.btn_clearSTT.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_clearSTT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_clearSTT.PressTextColor = System.Drawing.Color.White;
            this.btn_clearSTT.Size = new System.Drawing.Size(50, 26);
            this.btn_clearSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_clearSTT.StyleManager = this.metroStyleManager;
            this.btn_clearSTT.TabIndex = 3;
            this.btn_clearSTT.Text = "Clear";
            this.btn_clearSTT.ThemeAuthor = "Taiizor";
            this.btn_clearSTT.ThemeName = "MetroLight";
            this.btn_clearSTT.Click += new System.EventHandler(this.btn_clearSTT_Click);
            // 
            // btn_copySTT
            // 
            this.btn_copySTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_copySTT.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copySTT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copySTT.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_copySTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_copySTT.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_copySTT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_copySTT.HoverTextColor = System.Drawing.Color.White;
            this.btn_copySTT.IsDerivedStyle = true;
            this.btn_copySTT.Location = new System.Drawing.Point(54, 488);
            this.btn_copySTT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_copySTT.Name = "btn_copySTT";
            this.btn_copySTT.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copySTT.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_copySTT.NormalTextColor = System.Drawing.Color.White;
            this.btn_copySTT.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_copySTT.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_copySTT.PressTextColor = System.Drawing.Color.White;
            this.btn_copySTT.Size = new System.Drawing.Size(45, 26);
            this.btn_copySTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_copySTT.StyleManager = this.metroStyleManager;
            this.btn_copySTT.TabIndex = 2;
            this.btn_copySTT.Text = "Copy";
            this.btn_copySTT.ThemeAuthor = "Taiizor";
            this.btn_copySTT.ThemeName = "MetroLight";
            this.btn_copySTT.Click += new System.EventHandler(this.btn_copySTT_Click);
            // 
            // btn_record
            // 
            this.btn_record.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_record.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_record.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_record.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btn_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_record.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_record.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_record.HoverTextColor = System.Drawing.Color.White;
            this.btn_record.IsDerivedStyle = true;
            this.btn_record.Location = new System.Drawing.Point(-2, 488);
            this.btn_record.Margin = new System.Windows.Forms.Padding(2);
            this.btn_record.Name = "btn_record";
            this.btn_record.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_record.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_record.NormalTextColor = System.Drawing.Color.Black;
            this.btn_record.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_record.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_record.PressTextColor = System.Drawing.Color.White;
            this.btn_record.Size = new System.Drawing.Size(52, 26);
            this.btn_record.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_record.StyleManager = this.metroStyleManager;
            this.btn_record.TabIndex = 1;
            this.btn_record.Text = "Record";
            this.btn_record.ThemeAuthor = "Taiizor";
            this.btn_record.ThemeName = "MetroLight";
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // txt_resultSTT
            // 
            this.txt_resultSTT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resultSTT.AutoWordSelection = false;
            this.txt_resultSTT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_resultSTT.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_resultSTT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_resultSTT.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_resultSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_resultSTT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_resultSTT.IsDerivedStyle = true;
            this.txt_resultSTT.Lines = null;
            this.txt_resultSTT.Location = new System.Drawing.Point(-2, 2);
            this.txt_resultSTT.Margin = new System.Windows.Forms.Padding(2);
            this.txt_resultSTT.MaxLength = 32767;
            this.txt_resultSTT.Name = "txt_resultSTT";
            this.txt_resultSTT.ReadOnly = true;
            this.txt_resultSTT.Size = new System.Drawing.Size(402, 482);
            this.txt_resultSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txt_resultSTT.StyleManager = this.metroStyleManager;
            this.txt_resultSTT.TabIndex = 0;
            this.txt_resultSTT.ThemeAuthor = "Taiizor";
            this.txt_resultSTT.ThemeName = "MetroLight";
            this.txt_resultSTT.WordWrap = true;
            // 
            // TabPageSettings
            // 
            this.TabPageSettings.BaseColor = System.Drawing.Color.White;
            this.TabPageSettings.Controls.Add(this.metroLabel6);
            this.TabPageSettings.Controls.Add(this.switchDarkMode);
            this.TabPageSettings.Controls.Add(this.metroLabel5);
            this.TabPageSettings.Controls.Add(this.btn_saveSettings);
            this.TabPageSettings.Controls.Add(this.metroTextBox1);
            this.TabPageSettings.Controls.Add(this.metroLabel4);
            this.TabPageSettings.Controls.Add(this.metroLabel3);
            this.TabPageSettings.Controls.Add(this.metroComboBox1);
            this.TabPageSettings.Controls.Add(this.txt_API_URL);
            this.TabPageSettings.Controls.Add(this.txt_ApiKey);
            this.TabPageSettings.Controls.Add(this.chkUseNewUI);
            this.TabPageSettings.Font = null;
            this.TabPageSettings.ImageIndex = 0;
            this.TabPageSettings.ImageKey = null;
            this.TabPageSettings.IsDerivedStyle = true;
            this.TabPageSettings.Location = new System.Drawing.Point(4, 42);
            this.TabPageSettings.Name = "TabPageSettings";
            this.TabPageSettings.Size = new System.Drawing.Size(404, 525);
            this.TabPageSettings.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.TabPageSettings.StyleManager = this.metroStyleManager;
            this.TabPageSettings.TabIndex = 3;
            this.TabPageSettings.Text = "Settings";
            this.TabPageSettings.ThemeAuthor = "Taiizor";
            this.TabPageSettings.ThemeName = "MetroLight";
            this.TabPageSettings.ToolTipText = null;
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel6.IsDerivedStyle = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 156);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 23);
            this.metroLabel6.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel6.StyleManager = this.metroStyleManager;
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Dark mode:";
            this.metroLabel6.ThemeAuthor = "Taiizor";
            this.metroLabel6.ThemeName = "MetroLight";
            // 
            // switchDarkMode
            // 
            this.switchDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.switchDarkMode.BackgroundColor = System.Drawing.Color.Empty;
            this.switchDarkMode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.switchDarkMode.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.switchDarkMode.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.switchDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchDarkMode.DataBindings.Add(new System.Windows.Forms.Binding("Switched", global::AiCompanion.Properties.Settings.Default, "useDarkMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.switchDarkMode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.switchDarkMode.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.switchDarkMode.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.switchDarkMode.IsDerivedStyle = true;
            this.switchDarkMode.Location = new System.Drawing.Point(100, 156);
            this.switchDarkMode.Name = "switchDarkMode";
            this.switchDarkMode.Size = new System.Drawing.Size(58, 22);
            this.switchDarkMode.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.switchDarkMode.StyleManager = this.metroStyleManager;
            this.switchDarkMode.Switched = global::AiCompanion.Properties.Settings.Default.useDarkMode;
            this.switchDarkMode.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.switchDarkMode.TabIndex = 9;
            this.switchDarkMode.Text = "metroSwitch1";
            this.switchDarkMode.ThemeAuthor = "Taiizor";
            this.switchDarkMode.ThemeName = "MetroLight";
            this.switchDarkMode.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.switchDarkMode.SwitchedChanged += new ReaLTaiizor.Controls.MetroSwitch.SwitchedChangedEventHandler(this.switchDarkMode_SwitchedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel5.IsDerivedStyle = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 23);
            this.metroLabel5.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel5.StyleManager = this.metroStyleManager;
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "API Key:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel5.ThemeAuthor = "Taiizor";
            this.metroLabel5.ThemeName = "MetroLight";
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_saveSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_saveSettings.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btn_saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_saveSettings.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_saveSettings.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_saveSettings.HoverTextColor = System.Drawing.Color.White;
            this.btn_saveSettings.IsDerivedStyle = true;
            this.btn_saveSettings.Location = new System.Drawing.Point(4, 490);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_saveSettings.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_saveSettings.NormalTextColor = System.Drawing.Color.Black;
            this.btn_saveSettings.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_saveSettings.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_saveSettings.PressTextColor = System.Drawing.Color.White;
            this.btn_saveSettings.Size = new System.Drawing.Size(75, 23);
            this.btn_saveSettings.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.btn_saveSettings.StyleManager = this.metroStyleManager;
            this.btn_saveSettings.TabIndex = 7;
            this.btn_saveSettings.Text = "Save";
            this.btn_saveSettings.ThemeAuthor = "Taiizor";
            this.btn_saveSettings.ThemeName = "MetroLight";
            this.btn_saveSettings.Click += new System.EventHandler(this.btn_saveSettings_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.AutoCompleteCustomSource = null;
            this.metroTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroTextBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroTextBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroTextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroTextBox1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroTextBox1.Image = null;
            this.metroTextBox1.IsDerivedStyle = true;
            this.metroTextBox1.Lines = null;
            this.metroTextBox1.Location = new System.Drawing.Point(164, 102);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Multiline = false;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.ReadOnly = false;
            this.metroTextBox1.Size = new System.Drawing.Size(85, 26);
            this.metroTextBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroTextBox1.StyleManager = this.metroStyleManager;
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.Text = "G";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.metroTextBox1.ThemeAuthor = "Taiizor";
            this.metroTextBox1.ThemeName = "MetroLight";
            this.metroTextBox1.UseSystemPasswordChar = false;
            this.metroTextBox1.WatermarkText = "";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel4.IsDerivedStyle = true;
            this.metroLabel4.Location = new System.Drawing.Point(132, 102);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(26, 26);
            this.metroLabel4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel4.StyleManager = this.metroStyleManager;
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "&&";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.ThemeAuthor = "Taiizor";
            this.metroLabel4.ThemeName = "MetroLight";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel3.IsDerivedStyle = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel3.StyleManager = this.metroStyleManager;
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Hotkey:";
            this.metroLabel3.ThemeAuthor = "Taiizor";
            this.metroLabel3.ThemeName = "MetroLight";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.AllowDrop = true;
            this.metroComboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroComboBox1.CausesValidation = false;
            this.metroComboBox1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroComboBox1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroComboBox1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroComboBox1.Enabled = false;
            this.metroComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.IsDerivedStyle = true;
            this.metroComboBox1.ItemHeight = 20;
            this.metroComboBox1.Items.AddRange(new object[] {
            "ALT",
            "CTR",
            "ALT+SHIFT",
            "CTR+SHIFT"});
            this.metroComboBox1.Location = new System.Drawing.Point(4, 102);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroComboBox1.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroComboBox1.Size = new System.Drawing.Size(121, 26);
            this.metroComboBox1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroComboBox1.StyleManager = this.metroStyleManager;
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.ThemeAuthor = "Taiizor";
            this.metroComboBox1.ThemeName = "MetroLight";
            // 
            // txt_API_URL
            // 
            this.txt_API_URL.AutoCompleteCustomSource = null;
            this.txt_API_URL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_API_URL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_API_URL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_API_URL.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_API_URL.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_API_URL.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_API_URL.Enabled = false;
            this.txt_API_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_API_URL.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_API_URL.Image = null;
            this.txt_API_URL.IsDerivedStyle = true;
            this.txt_API_URL.Lines = null;
            this.txt_API_URL.Location = new System.Drawing.Point(4, 3);
            this.txt_API_URL.MaxLength = 32767;
            this.txt_API_URL.Multiline = false;
            this.txt_API_URL.Name = "txt_API_URL";
            this.txt_API_URL.ReadOnly = false;
            this.txt_API_URL.Size = new System.Drawing.Size(398, 30);
            this.txt_API_URL.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txt_API_URL.StyleManager = this.metroStyleManager;
            this.txt_API_URL.TabIndex = 2;
            this.txt_API_URL.Text = "https://api.openai.com/v1/";
            this.txt_API_URL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_API_URL.ThemeAuthor = "Taiizor";
            this.txt_API_URL.ThemeName = "MetroLight";
            this.txt_API_URL.UseSystemPasswordChar = false;
            this.txt_API_URL.WatermarkText = "Open AI URL";
            // 
            // txt_ApiKey
            // 
            this.txt_ApiKey.AutoCompleteCustomSource = null;
            this.txt_ApiKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_ApiKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_ApiKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_ApiKey.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AiCompanion.Properties.Settings.Default, "API_Key", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_ApiKey.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_ApiKey.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_ApiKey.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_ApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_ApiKey.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_ApiKey.Image = null;
            this.txt_ApiKey.IsDerivedStyle = true;
            this.txt_ApiKey.Lines = null;
            this.txt_ApiKey.Location = new System.Drawing.Point(71, 39);
            this.txt_ApiKey.MaxLength = 32767;
            this.txt_ApiKey.Multiline = false;
            this.txt_ApiKey.Name = "txt_ApiKey";
            this.txt_ApiKey.ReadOnly = false;
            this.txt_ApiKey.Size = new System.Drawing.Size(331, 30);
            this.txt_ApiKey.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.txt_ApiKey.StyleManager = this.metroStyleManager;
            this.txt_ApiKey.TabIndex = 1;
            this.txt_ApiKey.Text = global::AiCompanion.Properties.Settings.Default.API_Key;
            this.txt_ApiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ApiKey.ThemeAuthor = "Taiizor";
            this.txt_ApiKey.ThemeName = "MetroLight";
            this.txt_ApiKey.UseSystemPasswordChar = true;
            this.txt_ApiKey.WatermarkText = "API Key";
            // 
            // chkUseNewUI
            // 
            this.chkUseNewUI.BackColor = System.Drawing.Color.Transparent;
            this.chkUseNewUI.BackgroundColor = System.Drawing.Color.White;
            this.chkUseNewUI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chkUseNewUI.Checked = global::AiCompanion.Properties.Settings.Default.UseNewUI;
            this.chkUseNewUI.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chkUseNewUI.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            this.chkUseNewUI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkUseNewUI.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AiCompanion.Properties.Settings.Default, "UseNewUI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkUseNewUI.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chkUseNewUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkUseNewUI.IsDerivedStyle = true;
            this.chkUseNewUI.Location = new System.Drawing.Point(4, 134);
            this.chkUseNewUI.Name = "chkUseNewUI";
            this.chkUseNewUI.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            this.chkUseNewUI.Size = new System.Drawing.Size(135, 16);
            this.chkUseNewUI.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.chkUseNewUI.StyleManager = this.metroStyleManager;
            this.chkUseNewUI.TabIndex = 0;
            this.chkUseNewUI.Text = "UseNewUI";
            this.chkUseNewUI.ThemeAuthor = "Taiizor";
            this.chkUseNewUI.ThemeName = "MetroLight";
            // 
            // TabPageAbout
            // 
            this.TabPageAbout.BaseColor = System.Drawing.Color.White;
            this.TabPageAbout.Controls.Add(this.lblAboutVersion);
            this.TabPageAbout.Controls.Add(this.metroLinkLabel4);
            this.TabPageAbout.Controls.Add(this.metroLinkLabel3);
            this.TabPageAbout.Controls.Add(this.metroLinkLabel2);
            this.TabPageAbout.Controls.Add(this.metroLabel2);
            this.TabPageAbout.Controls.Add(this.metroLinkLabel1);
            this.TabPageAbout.Controls.Add(this.metroLabel1);
            this.TabPageAbout.Font = null;
            this.TabPageAbout.ImageIndex = 0;
            this.TabPageAbout.ImageKey = null;
            this.TabPageAbout.IsDerivedStyle = true;
            this.TabPageAbout.Location = new System.Drawing.Point(4, 42);
            this.TabPageAbout.Name = "TabPageAbout";
            this.TabPageAbout.Size = new System.Drawing.Size(402, 516);
            this.TabPageAbout.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.TabPageAbout.StyleManager = this.metroStyleManager;
            this.TabPageAbout.TabIndex = 4;
            this.TabPageAbout.Text = "About";
            this.TabPageAbout.ThemeAuthor = "Taiizor";
            this.TabPageAbout.ThemeName = "MetroLight";
            this.TabPageAbout.ToolTipText = null;
            // 
            // lblAboutVersion
            // 
            this.lblAboutVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAboutVersion.IsDerivedStyle = true;
            this.lblAboutVersion.Location = new System.Drawing.Point(4, 4);
            this.lblAboutVersion.Name = "lblAboutVersion";
            this.lblAboutVersion.Size = new System.Drawing.Size(100, 23);
            this.lblAboutVersion.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblAboutVersion.StyleManager = this.metroStyleManager;
            this.lblAboutVersion.TabIndex = 6;
            this.lblAboutVersion.Text = "Version: ";
            this.lblAboutVersion.ThemeAuthor = "Taiizor";
            this.lblAboutVersion.ThemeName = "MetroLight";
            // 
            // metroLinkLabel4
            // 
            this.metroLinkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLinkLabel4.IsDerivedStyle = true;
            this.metroLinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroLinkLabel4.Location = new System.Drawing.Point(4, 214);
            this.metroLinkLabel4.Name = "metroLinkLabel4";
            this.metroLinkLabel4.Size = new System.Drawing.Size(395, 23);
            this.metroLinkLabel4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLinkLabel4.StyleManager = this.metroStyleManager;
            this.metroLinkLabel4.TabIndex = 5;
            this.metroLinkLabel4.TabStop = true;
            this.metroLinkLabel4.Text = "https://github.com/Taiizor/ReaLTaiizor";
            this.metroLinkLabel4.ThemeAuthor = "Taiizor";
            this.metroLinkLabel4.ThemeName = "MetroLight";
            this.metroLinkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            // 
            // metroLinkLabel3
            // 
            this.metroLinkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLinkLabel3.IsDerivedStyle = true;
            this.metroLinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroLinkLabel3.Location = new System.Drawing.Point(4, 187);
            this.metroLinkLabel3.Name = "metroLinkLabel3";
            this.metroLinkLabel3.Size = new System.Drawing.Size(395, 23);
            this.metroLinkLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLinkLabel3.StyleManager = this.metroStyleManager;
            this.metroLinkLabel3.TabIndex = 4;
            this.metroLinkLabel3.TabStop = true;
            this.metroLinkLabel3.Text = "https://github.com/openai/openai-dotnet";
            this.metroLinkLabel3.ThemeAuthor = "Taiizor";
            this.metroLinkLabel3.ThemeName = "MetroLight";
            this.metroLinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            // 
            // metroLinkLabel2
            // 
            this.metroLinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLinkLabel2.IsDerivedStyle = true;
            this.metroLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroLinkLabel2.Location = new System.Drawing.Point(4, 164);
            this.metroLinkLabel2.Name = "metroLinkLabel2";
            this.metroLinkLabel2.Size = new System.Drawing.Size(395, 23);
            this.metroLinkLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLinkLabel2.StyleManager = this.metroStyleManager;
            this.metroLinkLabel2.TabIndex = 3;
            this.metroLinkLabel2.TabStop = true;
            this.metroLinkLabel2.Text = "https://github.com/naudio/NAudio";
            this.metroLinkLabel2.ThemeAuthor = "Taiizor";
            this.metroLinkLabel2.ThemeName = "MetroLight";
            this.metroLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel2.IsDerivedStyle = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 120);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(172, 23);
            this.metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel2.StyleManager = this.metroStyleManager;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Wizard1.ico licensed by ";
            this.metroLabel2.ThemeAuthor = "Taiizor";
            this.metroLabel2.ThemeName = "MetroLight";
            // 
            // metroLinkLabel1
            // 
            this.metroLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLinkLabel1.IsDerivedStyle = true;
            this.metroLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.metroLinkLabel1.Location = new System.Drawing.Point(182, 120);
            this.metroLinkLabel1.Name = "metroLinkLabel1";
            this.metroLinkLabel1.Size = new System.Drawing.Size(187, 23);
            this.metroLinkLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLinkLabel1.StyleManager = this.metroStyleManager;
            this.metroLinkLabel1.TabIndex = 1;
            this.metroLinkLabel1.TabStop = true;
            this.metroLinkLabel1.Text = "http://www.icons-land.com";
            this.metroLinkLabel1.ThemeAuthor = "Taiizor";
            this.metroLinkLabel1.ThemeName = "MetroLight";
            this.metroLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(157)))), ((int)(((byte)(205)))));
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroLabel1.IsDerivedStyle = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 143);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(395, 21);
            this.metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroLabel1.StyleManager = this.metroStyleManager;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Libraries used";
            this.metroLabel1.ThemeAuthor = "Taiizor";
            this.metroLabel1.ThemeName = "MetroLight";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroPanel1.BorderThickness = 0;
            this.metroPanel1.Controls.Add(this.statusLabel);
            this.metroPanel1.IsDerivedStyle = true;
            this.metroPanel1.Location = new System.Drawing.Point(0, 628);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(418, 35);
            this.metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroPanel1.StyleManager = this.metroStyleManager;
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.ThemeAuthor = "Taiizor";
            this.metroPanel1.ThemeName = "MetroLight";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoEllipsis = true;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.statusLabel.IsDerivedStyle = true;
            this.statusLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(418, 35);
            this.statusLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.statusLabel.StyleManager = this.metroStyleManager;
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Idle";
            this.statusLabel.ThemeAuthor = "Taiizor";
            this.statusLabel.ThemeName = "MetroLight";
            // 
            // WindowControlBox
            // 
            this.WindowControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindowControlBox.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WindowControlBox.CloseHoverForeColor = System.Drawing.Color.White;
            this.WindowControlBox.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.WindowControlBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowControlBox.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Edge;
            this.WindowControlBox.DisabledForeColor = System.Drawing.Color.DimGray;
            this.WindowControlBox.IsDerivedStyle = true;
            this.WindowControlBox.Location = new System.Drawing.Point(312, 0);
            this.WindowControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.WindowControlBox.MaximizeBox = true;
            this.WindowControlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.WindowControlBox.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.WindowControlBox.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.WindowControlBox.MinimizeBox = true;
            this.WindowControlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.WindowControlBox.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.WindowControlBox.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.WindowControlBox.Name = "WindowControlBox";
            this.WindowControlBox.Size = new System.Drawing.Size(100, 25);
            this.WindowControlBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.WindowControlBox.StyleManager = this.metroStyleManager;
            this.WindowControlBox.TabIndex = 3;
            this.WindowControlBox.Text = "WindowControlBox";
            this.WindowControlBox.ThemeAuthor = "Taiizor";
            this.WindowControlBox.ThemeName = "MetroLight";
            this.WindowControlBox.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(97, -2);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 25);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Hidden Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(412, 652);
            this.Controls.Add(this.WindowControlBox);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(412, 652);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 1, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AICOMPANION";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TabControl.ResumeLayout(false);
            this.TabPagePrompt.ResumeLayout(false);
            this.TabPageTTS.ResumeLayout(false);
            this.TabPageSTT.ResumeLayout(false);
            this.TabPageSettings.ResumeLayout(false);
            this.TabPageAbout.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroTabControl TabControl;
        private ReaLTaiizor.Child.Metro.MetroTabPage TabPagePrompt;
        private ReaLTaiizor.Child.Metro.MetroTabPage TabPageTTS;
        private ReaLTaiizor.Child.Metro.MetroTabPage TabPageSTT;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
        private ReaLTaiizor.Controls.MetroLabel statusLabel;
        private ReaLTaiizor.Manager.MetroStyleManager metroStyleManager;
        private ReaLTaiizor.Controls.MetroButton btn_clearSTT;
        private ReaLTaiizor.Controls.MetroButton btn_copySTT;
        private ReaLTaiizor.Controls.MetroDefaultButton btn_record;
        private ReaLTaiizor.Controls.MetroRichTextBox txt_resultSTT;
        private ReaLTaiizor.Child.Metro.MetroTabPage TabPageSettings;
        private ReaLTaiizor.Controls.MetroControlBox WindowControlBox;
        private ReaLTaiizor.Controls.MetroComboBox cmbSttLanguage;
        private ReaLTaiizor.Controls.MetroLabel lblVoice;
        private ReaLTaiizor.Controls.MetroLabel lblSpeed;
        private ReaLTaiizor.Controls.MetroCheckBox checkBoxDownloadTTS;
        private ReaLTaiizor.Controls.MetroButton btn_DownloadTTS;
        private ReaLTaiizor.Controls.MetroButton btn_stopTTS;
        private ReaLTaiizor.Controls.MetroDefaultButton btn_playTTS;
        private ReaLTaiizor.Controls.MetroComboBox cmbBxVoiceTTS;
        private ReaLTaiizor.Controls.MetroTrackBar range_SpeedTTS;
        private ReaLTaiizor.Controls.MetroTextBox txt_TextTTS;
        private ReaLTaiizor.Controls.MetroRichTextBox txt_result;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.MetroButton btnRemovePrePromt;
        private ReaLTaiizor.Controls.MetroButton btnAddPrePromt;
        private ReaLTaiizor.Controls.MetroComboBox cmbPrePrompts;
        private ReaLTaiizor.Controls.MetroDefaultButton btn_sendPrompt;
        private ReaLTaiizor.Controls.MetroComboBox cmb_Model;
        private ReaLTaiizor.Controls.MetroButton btn_copyPrompt;
        private ReaLTaiizor.Controls.MetroButton btn_insertPrompt;
        private ReaLTaiizor.Controls.MetroTextBox txt_input;
        private System.Windows.Forms.Button btn_cancel;
        private ReaLTaiizor.Child.Metro.MetroTabPage TabPageAbout;
        private ReaLTaiizor.Controls.MetroLinkLabel metroLinkLabel1;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private ReaLTaiizor.Controls.MetroLinkLabel metroLinkLabel4;
        private ReaLTaiizor.Controls.MetroLinkLabel metroLinkLabel3;
        private ReaLTaiizor.Controls.MetroLinkLabel metroLinkLabel2;
        private ReaLTaiizor.Controls.MetroLabel metroLabel2;
        private ReaLTaiizor.Controls.MetroLabel lblAboutVersion;
        private ReaLTaiizor.Controls.MetroTextBox txt_ApiKey;
        private ReaLTaiizor.Controls.MetroCheckBox chkUseNewUI;
        private ReaLTaiizor.Controls.MetroTextBox txt_API_URL;
        private ReaLTaiizor.Controls.MetroLabel metroLabel4;
        private ReaLTaiizor.Controls.MetroLabel metroLabel3;
        private ReaLTaiizor.Controls.MetroComboBox metroComboBox1;
        private ReaLTaiizor.Controls.MetroTextBox metroTextBox1;
        private ReaLTaiizor.Controls.MetroDefaultButton btn_saveSettings;
        private ReaLTaiizor.Controls.MetroLabel metroLabel5;
        private ReaLTaiizor.Controls.MetroLabel metroLabel6;
        private ReaLTaiizor.Controls.MetroSwitch switchDarkMode;
    }
}
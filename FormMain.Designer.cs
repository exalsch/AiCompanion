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
            TabControl = new ReaLTaiizor.Controls.MetroTabControl();
            TabPagePrompt = new ReaLTaiizor.Child.Metro.MetroTabPage();
            picPrompt = new System.Windows.Forms.PictureBox();
            pictPromptContextMenu = new ReaLTaiizor.Controls.MetroContextMenuStrip();
            picPromptToolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            btn_sendPrompt = new ReaLTaiizor.Controls.MetroDefaultButton();
            metroStyleManager = new ReaLTaiizor.Manager.MetroStyleManager();
            cmb_Model = new ReaLTaiizor.Controls.MetroComboBox();
            btn_copyPrompt = new ReaLTaiizor.Controls.MetroButton();
            btn_insertPrompt = new ReaLTaiizor.Controls.MetroButton();
            txt_inputPrompt = new ReaLTaiizor.Controls.MetroTextBox();
            btnRemovePrePromt = new ReaLTaiizor.Controls.MetroButton();
            btnAddPrePromt = new ReaLTaiizor.Controls.MetroButton();
            cmbPrePrompts = new ReaLTaiizor.Controls.MetroComboBox();
            txt_resultPrompt = new ReaLTaiizor.Controls.MetroRichTextBox();
            txt_resultPromptContextMenu = new ReaLTaiizor.Controls.MetroContextMenuStrip();
            sendToTTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setAsPromptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            TabPageTTS = new ReaLTaiizor.Child.Metro.MetroTabPage();
            txt_TextTTS = new ReaLTaiizor.Controls.MetroTextBox();
            range_SpeedTTS = new ReaLTaiizor.Controls.MetroTrackBar();
            cmbBxVoiceTTS = new ReaLTaiizor.Controls.MetroComboBox();
            lblVoice = new ReaLTaiizor.Controls.MetroLabel();
            lblSpeed = new ReaLTaiizor.Controls.MetroLabel();
            checkBoxDownloadTTS = new ReaLTaiizor.Controls.MetroCheckBox();
            btn_DownloadTTS = new ReaLTaiizor.Controls.MetroButton();
            btn_stopTTS = new ReaLTaiizor.Controls.MetroButton();
            btn_playTTS = new ReaLTaiizor.Controls.MetroDefaultButton();
            TabPageSTT = new ReaLTaiizor.Child.Metro.MetroTabPage();
            btn_asPromptSTT = new ReaLTaiizor.Controls.MetroButton();
            cmbSttLanguage = new ReaLTaiizor.Controls.MetroComboBox();
            btn_clearSTT = new ReaLTaiizor.Controls.MetroButton();
            btn_copySTT = new ReaLTaiizor.Controls.MetroButton();
            btn_record = new ReaLTaiizor.Controls.MetroDefaultButton();
            txt_resultSTT = new ReaLTaiizor.Controls.MetroRichTextBox();
            TabPageSettings = new ReaLTaiizor.Child.Metro.MetroTabPage();
            txt_QuickPrompt5 = new ReaLTaiizor.Controls.MetroTextBox();
            metroLabel13 = new ReaLTaiizor.Controls.MetroLabel();
            txt_QuickPrompt4 = new ReaLTaiizor.Controls.MetroTextBox();
            metroLabel12 = new ReaLTaiizor.Controls.MetroLabel();
            txt_QuickPrompt3 = new ReaLTaiizor.Controls.MetroTextBox();
            metroLabel11 = new ReaLTaiizor.Controls.MetroLabel();
            txt_QuickPrompt2 = new ReaLTaiizor.Controls.MetroTextBox();
            metroLabel10 = new ReaLTaiizor.Controls.MetroLabel();
            cmb_SettingQuickPromptModel = new ReaLTaiizor.Controls.MetroComboBox();
            metroLabel9 = new ReaLTaiizor.Controls.MetroLabel();
            txt_QuickPrompt1 = new ReaLTaiizor.Controls.MetroTextBox();
            metroLabel8 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel7 = new ReaLTaiizor.Controls.MetroLabel();
            metroDivider3 = new ReaLTaiizor.Controls.MetroDivider();
            chkBAutoStartApp = new ReaLTaiizor.Controls.MetroCheckBox();
            chkAutoStartTTS = new ReaLTaiizor.Controls.MetroCheckBox();
            chkAutoStartSTT = new ReaLTaiizor.Controls.MetroCheckBox();
            metroLabel6 = new ReaLTaiizor.Controls.MetroLabel();
            switchDarkMode = new ReaLTaiizor.Controls.MetroSwitch();
            metroLabel5 = new ReaLTaiizor.Controls.MetroLabel();
            btn_saveSettings = new ReaLTaiizor.Controls.MetroDefaultButton();
            txt_HotkeyKey = new ReaLTaiizor.Controls.MetroTextBox();
            metroLabel4 = new ReaLTaiizor.Controls.MetroLabel();
            metroLabel3 = new ReaLTaiizor.Controls.MetroLabel();
            cmbHotKeyMod = new ReaLTaiizor.Controls.MetroComboBox();
            txt_API_URL = new ReaLTaiizor.Controls.MetroTextBox();
            txt_ApiKey = new ReaLTaiizor.Controls.MetroTextBox();
            TabPageAbout = new ReaLTaiizor.Child.Metro.MetroTabPage();
            metroLinkLabel5 = new ReaLTaiizor.Controls.MetroLinkLabel();
            metroDivider2 = new ReaLTaiizor.Controls.MetroDivider();
            lblAboutVersion = new ReaLTaiizor.Controls.MetroLabel();
            metroLinkLabel4 = new ReaLTaiizor.Controls.MetroLinkLabel();
            metroLinkLabel3 = new ReaLTaiizor.Controls.MetroLinkLabel();
            metroLinkLabel2 = new ReaLTaiizor.Controls.MetroLinkLabel();
            metroLabel2 = new ReaLTaiizor.Controls.MetroLabel();
            metroLinkLabel1 = new ReaLTaiizor.Controls.MetroLinkLabel();
            metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            statusLabel = new ReaLTaiizor.Controls.MetroLabel();
            WindowControlBox = new ReaLTaiizor.Controls.MetroControlBox();
            btn_cancel = new System.Windows.Forms.Button();
            toolTipMain = new ReaLTaiizor.Controls.MetroToolTip();
            TabControl.SuspendLayout();
            TabPagePrompt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPrompt).BeginInit();
            pictPromptContextMenu.SuspendLayout();
            txt_resultPromptContextMenu.SuspendLayout();
            TabPageTTS.SuspendLayout();
            TabPageSTT.SuspendLayout();
            TabPageSettings.SuspendLayout();
            TabPageAbout.SuspendLayout();
            metroPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TabControl.AnimateEasingType = ReaLTaiizor.Enum.Metro.EasingType.QuartOut;
            TabControl.AnimateTime = 200;
            TabControl.BackgroundColor = System.Drawing.Color.White;
            TabControl.Controls.Add(TabPagePrompt);
            TabControl.Controls.Add(TabPageTTS);
            TabControl.Controls.Add(TabPageSTT);
            TabControl.Controls.Add(TabPageSettings);
            TabControl.Controls.Add(TabPageAbout);
            TabControl.ControlsVisible = true;
            TabControl.HotTrack = true;
            TabControl.IsDerivedStyle = true;
            TabControl.ItemSize = new System.Drawing.Size(100, 38);
            TabControl.Location = new System.Drawing.Point(0, 65);
            TabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabControl.MCursor = System.Windows.Forms.Cursors.Hand;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 3;
            TabControl.SelectedTextColor = System.Drawing.Color.White;
            TabControl.Size = new System.Drawing.Size(481, 661);
            TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            TabControl.Speed = 100;
            TabControl.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TabControl.StyleManager = metroStyleManager;
            TabControl.TabIndex = 1;
            TabControl.ThemeAuthor = "Taiizor";
            TabControl.ThemeName = "MetroLight";
            TabControl.UnselectedTextColor = System.Drawing.Color.Gray;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            TabControl.KeyDown += TabControl_KeyDown;
            // 
            // TabPagePrompt
            // 
            TabPagePrompt.BaseColor = System.Drawing.Color.White;
            TabPagePrompt.Controls.Add(picPrompt);
            TabPagePrompt.Controls.Add(btn_sendPrompt);
            TabPagePrompt.Controls.Add(cmb_Model);
            TabPagePrompt.Controls.Add(btn_copyPrompt);
            TabPagePrompt.Controls.Add(btn_insertPrompt);
            TabPagePrompt.Controls.Add(txt_inputPrompt);
            TabPagePrompt.Controls.Add(btnRemovePrePromt);
            TabPagePrompt.Controls.Add(btnAddPrePromt);
            TabPagePrompt.Controls.Add(cmbPrePrompts);
            TabPagePrompt.Controls.Add(txt_resultPrompt);
            TabPagePrompt.Controls.Add(metroDivider1);
            TabPagePrompt.Font = null;
            TabPagePrompt.ImageIndex = 0;
            TabPagePrompt.ImageKey = null;
            TabPagePrompt.IsDerivedStyle = true;
            TabPagePrompt.Location = new System.Drawing.Point(4, 42);
            TabPagePrompt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPagePrompt.Name = "TabPagePrompt";
            TabPagePrompt.Size = new System.Drawing.Size(473, 615);
            TabPagePrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TabPagePrompt.StyleManager = metroStyleManager;
            TabPagePrompt.TabIndex = 0;
            TabPagePrompt.Text = "Prompt";
            TabPagePrompt.ThemeAuthor = "Taiizor";
            TabPagePrompt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(TabPagePrompt, "Text prompting");
            TabPagePrompt.ToolTipText = null;
            // 
            // picPrompt
            // 
            picPrompt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            picPrompt.ContextMenuStrip = pictPromptContextMenu;
            picPrompt.Location = new System.Drawing.Point(194, 563);
            picPrompt.MaximumSize = new System.Drawing.Size(144, 48);
            picPrompt.Name = "picPrompt";
            picPrompt.Size = new System.Drawing.Size(144, 48);
            picPrompt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPrompt.TabIndex = 11;
            picPrompt.TabStop = false;
            toolTipMain.SetToolTip(picPrompt, "Text prompting");
            picPrompt.Visible = false;
            // 
            // pictPromptContextMenu
            // 
            pictPromptContextMenu.IsDerivedStyle = true;
            pictPromptContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { picPromptToolStripMenuItemRemove });
            pictPromptContextMenu.Name = "txt_resultPromptContextMenu";
            pictPromptContextMenu.Size = new System.Drawing.Size(190, 26);
            pictPromptContextMenu.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            pictPromptContextMenu.StyleManager = null;
            pictPromptContextMenu.ThemeAuthor = "Taiizor";
            pictPromptContextMenu.ThemeName = "MetroLight";
            // 
            // picPromptToolStripMenuItemRemove
            // 
            picPromptToolStripMenuItemRemove.Name = "picPromptToolStripMenuItemRemove";
            picPromptToolStripMenuItemRemove.Size = new System.Drawing.Size(189, 22);
            picPromptToolStripMenuItemRemove.Text = "Remove from prompt";
            picPromptToolStripMenuItemRemove.Click += picPromptToolStripMenuItemRemove_Click;
            // 
            // btn_sendPrompt
            // 
            btn_sendPrompt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_sendPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_sendPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            btn_sendPrompt.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            btn_sendPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_sendPrompt.HoverBorderColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_sendPrompt.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_sendPrompt.HoverTextColor = System.Drawing.Color.White;
            btn_sendPrompt.IsDerivedStyle = true;
            btn_sendPrompt.Location = new System.Drawing.Point(0, 563);
            btn_sendPrompt.Margin = new System.Windows.Forms.Padding(2);
            btn_sendPrompt.Name = "btn_sendPrompt";
            btn_sendPrompt.NormalBorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_sendPrompt.NormalColor = System.Drawing.Color.FromArgb(238, 238, 238);
            btn_sendPrompt.NormalTextColor = System.Drawing.Color.Black;
            btn_sendPrompt.PressBorderColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_sendPrompt.PressColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_sendPrompt.PressTextColor = System.Drawing.Color.White;
            btn_sendPrompt.Size = new System.Drawing.Size(64, 30);
            btn_sendPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_sendPrompt.StyleManager = metroStyleManager;
            btn_sendPrompt.TabIndex = 1;
            btn_sendPrompt.Text = "Send";
            btn_sendPrompt.ThemeAuthor = "Taiizor";
            btn_sendPrompt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_sendPrompt, "Text prompting");
            btn_sendPrompt.Click += btn_send_Click;
            // 
            // metroStyleManager
            // 
            metroStyleManager.CustomTheme = "C:\\Users\\ALSCH\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xml";
            metroStyleManager.OwnerForm = this;
            metroStyleManager.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroStyleManager.ThemeAuthor = "Taiizor";
            metroStyleManager.ThemeName = "MetroLight";
            // 
            // cmb_Model
            // 
            cmb_Model.AllowDrop = true;
            cmb_Model.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmb_Model.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmb_Model.BackColor = System.Drawing.Color.Transparent;
            cmb_Model.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            cmb_Model.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmb_Model.CausesValidation = false;
            cmb_Model.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            cmb_Model.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            cmb_Model.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            cmb_Model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cmb_Model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmb_Model.FormattingEnabled = true;
            cmb_Model.IsDerivedStyle = true;
            cmb_Model.ItemHeight = 20;
            cmb_Model.Location = new System.Drawing.Point(343, 563);
            cmb_Model.Margin = new System.Windows.Forms.Padding(2);
            cmb_Model.Name = "cmb_Model";
            cmb_Model.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            cmb_Model.SelectedItemForeColor = System.Drawing.Color.White;
            cmb_Model.Size = new System.Drawing.Size(118, 26);
            cmb_Model.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            cmb_Model.StyleManager = metroStyleManager;
            cmb_Model.TabIndex = 4;
            cmb_Model.ThemeAuthor = "Taiizor";
            cmb_Model.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(cmb_Model, "Text prompting");
            cmb_Model.SelectedIndexChanged += cmb_Model_SelectedIndexChanged;
            // 
            // btn_copyPrompt
            // 
            btn_copyPrompt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_copyPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_copyPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_copyPrompt.DisabledForeColor = System.Drawing.Color.Gray;
            btn_copyPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_copyPrompt.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_copyPrompt.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_copyPrompt.HoverTextColor = System.Drawing.Color.White;
            btn_copyPrompt.IsDerivedStyle = true;
            btn_copyPrompt.Location = new System.Drawing.Point(69, 563);
            btn_copyPrompt.Margin = new System.Windows.Forms.Padding(2);
            btn_copyPrompt.Name = "btn_copyPrompt";
            btn_copyPrompt.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_copyPrompt.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_copyPrompt.NormalTextColor = System.Drawing.Color.White;
            btn_copyPrompt.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_copyPrompt.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_copyPrompt.PressTextColor = System.Drawing.Color.White;
            btn_copyPrompt.Size = new System.Drawing.Size(65, 30);
            btn_copyPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_copyPrompt.StyleManager = metroStyleManager;
            btn_copyPrompt.TabIndex = 2;
            btn_copyPrompt.Text = "Copy";
            btn_copyPrompt.ThemeAuthor = "Taiizor";
            btn_copyPrompt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_copyPrompt, "Text prompting");
            btn_copyPrompt.Click += btn_copy_Click;
            // 
            // btn_insertPrompt
            // 
            btn_insertPrompt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_insertPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_insertPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_insertPrompt.DisabledForeColor = System.Drawing.Color.Gray;
            btn_insertPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_insertPrompt.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_insertPrompt.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_insertPrompt.HoverTextColor = System.Drawing.Color.White;
            btn_insertPrompt.IsDerivedStyle = true;
            btn_insertPrompt.Location = new System.Drawing.Point(139, 563);
            btn_insertPrompt.Margin = new System.Windows.Forms.Padding(2);
            btn_insertPrompt.Name = "btn_insertPrompt";
            btn_insertPrompt.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_insertPrompt.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_insertPrompt.NormalTextColor = System.Drawing.Color.White;
            btn_insertPrompt.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_insertPrompt.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_insertPrompt.PressTextColor = System.Drawing.Color.White;
            btn_insertPrompt.Size = new System.Drawing.Size(52, 30);
            btn_insertPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_insertPrompt.StyleManager = metroStyleManager;
            btn_insertPrompt.TabIndex = 3;
            btn_insertPrompt.Text = "Insert";
            btn_insertPrompt.ThemeAuthor = "Taiizor";
            btn_insertPrompt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_insertPrompt, "Text prompting");
            btn_insertPrompt.Click += btn_insert_Click;
            // 
            // txt_inputPrompt
            // 
            txt_inputPrompt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_inputPrompt.AutoCompleteCustomSource = null;
            txt_inputPrompt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_inputPrompt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_inputPrompt.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_inputPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_inputPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_inputPrompt.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_inputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_inputPrompt.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_inputPrompt.Image = null;
            txt_inputPrompt.IsDerivedStyle = true;
            txt_inputPrompt.Lines = null;
            txt_inputPrompt.Location = new System.Drawing.Point(0, 368);
            txt_inputPrompt.Margin = new System.Windows.Forms.Padding(2);
            txt_inputPrompt.MaxLength = 32767;
            txt_inputPrompt.Multiline = true;
            txt_inputPrompt.Name = "txt_inputPrompt";
            txt_inputPrompt.ReadOnly = false;
            txt_inputPrompt.Size = new System.Drawing.Size(471, 190);
            txt_inputPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_inputPrompt.StyleManager = metroStyleManager;
            txt_inputPrompt.TabIndex = 0;
            txt_inputPrompt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_inputPrompt.ThemeAuthor = "Taiizor";
            txt_inputPrompt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(txt_inputPrompt, "Text prompting");
            txt_inputPrompt.UseSystemPasswordChar = false;
            txt_inputPrompt.WatermarkText = "Prompt";
            txt_inputPrompt.TextChanged += txt_input_TextChanged;
            txt_inputPrompt.Click += txt_inputPrompt_Click;
            txt_inputPrompt.KeyDown += txt_inputPrompt_KeyDown;
            txt_inputPrompt.KeyUp += txt_inputPrompt_KeyDown;
            // 
            // btnRemovePrePromt
            // 
            btnRemovePrePromt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnRemovePrePromt.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btnRemovePrePromt.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btnRemovePrePromt.DisabledForeColor = System.Drawing.Color.Gray;
            btnRemovePrePromt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btnRemovePrePromt.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btnRemovePrePromt.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btnRemovePrePromt.HoverTextColor = System.Drawing.Color.White;
            btnRemovePrePromt.IsDerivedStyle = true;
            btnRemovePrePromt.Location = new System.Drawing.Point(401, 333);
            btnRemovePrePromt.Margin = new System.Windows.Forms.Padding(2);
            btnRemovePrePromt.Name = "btnRemovePrePromt";
            btnRemovePrePromt.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btnRemovePrePromt.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btnRemovePrePromt.NormalTextColor = System.Drawing.Color.White;
            btnRemovePrePromt.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btnRemovePrePromt.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btnRemovePrePromt.PressTextColor = System.Drawing.Color.White;
            btnRemovePrePromt.Size = new System.Drawing.Size(69, 30);
            btnRemovePrePromt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnRemovePrePromt.StyleManager = metroStyleManager;
            btnRemovePrePromt.TabIndex = 7;
            btnRemovePrePromt.Text = "Remove";
            btnRemovePrePromt.ThemeAuthor = "Taiizor";
            btnRemovePrePromt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btnRemovePrePromt, "Text prompting");
            btnRemovePrePromt.Click += btnRemovePrePromt_Click;
            // 
            // btnAddPrePromt
            // 
            btnAddPrePromt.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAddPrePromt.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btnAddPrePromt.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btnAddPrePromt.DisabledForeColor = System.Drawing.Color.Gray;
            btnAddPrePromt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btnAddPrePromt.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btnAddPrePromt.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btnAddPrePromt.HoverTextColor = System.Drawing.Color.White;
            btnAddPrePromt.IsDerivedStyle = true;
            btnAddPrePromt.Location = new System.Drawing.Point(343, 333);
            btnAddPrePromt.Margin = new System.Windows.Forms.Padding(2);
            btnAddPrePromt.Name = "btnAddPrePromt";
            btnAddPrePromt.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btnAddPrePromt.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btnAddPrePromt.NormalTextColor = System.Drawing.Color.White;
            btnAddPrePromt.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btnAddPrePromt.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btnAddPrePromt.PressTextColor = System.Drawing.Color.White;
            btnAddPrePromt.Size = new System.Drawing.Size(48, 30);
            btnAddPrePromt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnAddPrePromt.StyleManager = metroStyleManager;
            btnAddPrePromt.TabIndex = 6;
            btnAddPrePromt.Text = "Add";
            btnAddPrePromt.ThemeAuthor = "Taiizor";
            btnAddPrePromt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btnAddPrePromt, "Text prompting");
            btnAddPrePromt.Click += btnAddPrePromt_Click;
            // 
            // cmbPrePrompts
            // 
            cmbPrePrompts.AllowDrop = true;
            cmbPrePrompts.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cmbPrePrompts.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbPrePrompts.BackColor = System.Drawing.Color.Transparent;
            cmbPrePrompts.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            cmbPrePrompts.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbPrePrompts.CausesValidation = false;
            cmbPrePrompts.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            cmbPrePrompts.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            cmbPrePrompts.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            cmbPrePrompts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cmbPrePrompts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPrePrompts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbPrePrompts.FormattingEnabled = true;
            cmbPrePrompts.IsDerivedStyle = true;
            cmbPrePrompts.ItemHeight = 20;
            cmbPrePrompts.Location = new System.Drawing.Point(0, 333);
            cmbPrePrompts.Margin = new System.Windows.Forms.Padding(2);
            cmbPrePrompts.Name = "cmbPrePrompts";
            cmbPrePrompts.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            cmbPrePrompts.SelectedItemForeColor = System.Drawing.Color.White;
            cmbPrePrompts.Size = new System.Drawing.Size(338, 26);
            cmbPrePrompts.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            cmbPrePrompts.StyleManager = metroStyleManager;
            cmbPrePrompts.TabIndex = 5;
            cmbPrePrompts.ThemeAuthor = "Taiizor";
            cmbPrePrompts.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(cmbPrePrompts, "Text prompting");
            cmbPrePrompts.TextChanged += cmbPrePrompts_TextChanged;
            // 
            // txt_resultPrompt
            // 
            txt_resultPrompt.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_resultPrompt.AutoWordSelection = false;
            txt_resultPrompt.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_resultPrompt.ContextMenuStrip = txt_resultPromptContextMenu;
            txt_resultPrompt.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_resultPrompt.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_resultPrompt.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_resultPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_resultPrompt.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_resultPrompt.IsDerivedStyle = true;
            txt_resultPrompt.Lines = null;
            txt_resultPrompt.Location = new System.Drawing.Point(-5, 2);
            txt_resultPrompt.Margin = new System.Windows.Forms.Padding(2);
            txt_resultPrompt.MaxLength = 32767;
            txt_resultPrompt.Name = "txt_resultPrompt";
            txt_resultPrompt.ReadOnly = true;
            txt_resultPrompt.Size = new System.Drawing.Size(475, 321);
            txt_resultPrompt.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_resultPrompt.StyleManager = metroStyleManager;
            txt_resultPrompt.TabIndex = 8;
            txt_resultPrompt.ThemeAuthor = "Taiizor";
            txt_resultPrompt.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(txt_resultPrompt, "Text prompting");
            txt_resultPrompt.WordWrap = true;
            // 
            // txt_resultPromptContextMenu
            // 
            txt_resultPromptContextMenu.IsDerivedStyle = true;
            txt_resultPromptContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { sendToTTSToolStripMenuItem, setAsPromptToolStripMenuItem, copyToolStripMenuItem });
            txt_resultPromptContextMenu.Name = "txt_resultPromptContextMenu";
            txt_resultPromptContextMenu.Size = new System.Drawing.Size(148, 70);
            txt_resultPromptContextMenu.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_resultPromptContextMenu.StyleManager = null;
            txt_resultPromptContextMenu.ThemeAuthor = "Taiizor";
            txt_resultPromptContextMenu.ThemeName = "MetroLight";
            // 
            // sendToTTSToolStripMenuItem
            // 
            sendToTTSToolStripMenuItem.Name = "sendToTTSToolStripMenuItem";
            sendToTTSToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            sendToTTSToolStripMenuItem.Text = "Send to TTS";
            sendToTTSToolStripMenuItem.Click += sendToTTSToolStripMenuItem_Click;
            // 
            // setAsPromptToolStripMenuItem
            // 
            setAsPromptToolStripMenuItem.Name = "setAsPromptToolStripMenuItem";
            setAsPromptToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            setAsPromptToolStripMenuItem.Text = "Set as prompt";
            setAsPromptToolStripMenuItem.Click += setAsPromptToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // metroDivider1
            // 
            metroDivider1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new System.Drawing.Point(-2, 327);
            metroDivider1.Margin = new System.Windows.Forms.Padding(2);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new System.Drawing.Size(472, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = metroStyleManager;
            metroDivider1.TabIndex = 0;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            toolTipMain.SetToolTip(metroDivider1, "Text prompting");
            // 
            // TabPageTTS
            // 
            TabPageTTS.BaseColor = System.Drawing.Color.White;
            TabPageTTS.Controls.Add(txt_TextTTS);
            TabPageTTS.Controls.Add(range_SpeedTTS);
            TabPageTTS.Controls.Add(cmbBxVoiceTTS);
            TabPageTTS.Controls.Add(lblVoice);
            TabPageTTS.Controls.Add(lblSpeed);
            TabPageTTS.Controls.Add(checkBoxDownloadTTS);
            TabPageTTS.Controls.Add(btn_DownloadTTS);
            TabPageTTS.Controls.Add(btn_stopTTS);
            TabPageTTS.Controls.Add(btn_playTTS);
            TabPageTTS.Font = null;
            TabPageTTS.ImageIndex = 0;
            TabPageTTS.ImageKey = null;
            TabPageTTS.IsDerivedStyle = true;
            TabPageTTS.Location = new System.Drawing.Point(4, 42);
            TabPageTTS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageTTS.Name = "TabPageTTS";
            TabPageTTS.Size = new System.Drawing.Size(473, 615);
            TabPageTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TabPageTTS.StyleManager = metroStyleManager;
            TabPageTTS.TabIndex = 1;
            TabPageTTS.Text = "Text-To-Speach";
            TabPageTTS.ThemeAuthor = "Taiizor";
            TabPageTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(TabPageTTS, "Read aloud text");
            TabPageTTS.ToolTipText = null;
            // 
            // txt_TextTTS
            // 
            txt_TextTTS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_TextTTS.AutoCompleteCustomSource = null;
            txt_TextTTS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_TextTTS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_TextTTS.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_TextTTS.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_TextTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_TextTTS.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_TextTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_TextTTS.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_TextTTS.Image = null;
            txt_TextTTS.IsDerivedStyle = true;
            txt_TextTTS.Lines = null;
            txt_TextTTS.Location = new System.Drawing.Point(-5, 2);
            txt_TextTTS.Margin = new System.Windows.Forms.Padding(2);
            txt_TextTTS.MaxLength = 32767;
            txt_TextTTS.Multiline = true;
            txt_TextTTS.Name = "txt_TextTTS";
            txt_TextTTS.ReadOnly = false;
            txt_TextTTS.Size = new System.Drawing.Size(471, 542);
            txt_TextTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_TextTTS.StyleManager = metroStyleManager;
            txt_TextTTS.TabIndex = 10;
            txt_TextTTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_TextTTS.ThemeAuthor = "Taiizor";
            txt_TextTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(txt_TextTTS, "Read aloud text");
            txt_TextTTS.UseSystemPasswordChar = false;
            txt_TextTTS.WatermarkText = "Text to transrcribe...";
            // 
            // range_SpeedTTS
            // 
            range_SpeedTTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            range_SpeedTTS.BackgroundColor = System.Drawing.Color.FromArgb(205, 205, 205);
            range_SpeedTTS.Cursor = System.Windows.Forms.Cursors.Hand;
            range_SpeedTTS.DisabledBackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            range_SpeedTTS.DisabledBorderColor = System.Drawing.Color.Empty;
            range_SpeedTTS.DisabledHandlerColor = System.Drawing.Color.FromArgb(196, 196, 196);
            range_SpeedTTS.DisabledValueColor = System.Drawing.Color.FromArgb(205, 205, 205);
            range_SpeedTTS.HandlerColor = System.Drawing.Color.FromArgb(180, 180, 180);
            range_SpeedTTS.IsDerivedStyle = true;
            range_SpeedTTS.Location = new System.Drawing.Point(184, 573);
            range_SpeedTTS.Margin = new System.Windows.Forms.Padding(2);
            range_SpeedTTS.Maximum = 100;
            range_SpeedTTS.Minimum = 0;
            range_SpeedTTS.Name = "range_SpeedTTS";
            range_SpeedTTS.Size = new System.Drawing.Size(86, 16);
            range_SpeedTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            range_SpeedTTS.StyleManager = metroStyleManager;
            range_SpeedTTS.TabIndex = 9;
            range_SpeedTTS.Text = "metroTrackBar1";
            range_SpeedTTS.ThemeAuthor = "Taiizor";
            range_SpeedTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(range_SpeedTTS, "Read aloud text");
            range_SpeedTTS.Value = 25;
            range_SpeedTTS.ValueColor = System.Drawing.Color.FromArgb(65, 177, 225);
            range_SpeedTTS.Scroll += range_SpeedTTS_Scroll;
            // 
            // cmbBxVoiceTTS
            // 
            cmbBxVoiceTTS.AllowDrop = true;
            cmbBxVoiceTTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cmbBxVoiceTTS.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbBxVoiceTTS.BackColor = System.Drawing.Color.Transparent;
            cmbBxVoiceTTS.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            cmbBxVoiceTTS.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbBxVoiceTTS.CausesValidation = false;
            cmbBxVoiceTTS.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            cmbBxVoiceTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            cmbBxVoiceTTS.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            cmbBxVoiceTTS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cmbBxVoiceTTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBxVoiceTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbBxVoiceTTS.FormattingEnabled = true;
            cmbBxVoiceTTS.IsDerivedStyle = true;
            cmbBxVoiceTTS.ItemHeight = 20;
            cmbBxVoiceTTS.Items.AddRange(new object[] { "alloy", "echo", "fable", "onyx", "nova", "shimmer" });
            cmbBxVoiceTTS.Location = new System.Drawing.Point(348, 569);
            cmbBxVoiceTTS.Margin = new System.Windows.Forms.Padding(2);
            cmbBxVoiceTTS.Name = "cmbBxVoiceTTS";
            cmbBxVoiceTTS.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            cmbBxVoiceTTS.SelectedItemForeColor = System.Drawing.Color.White;
            cmbBxVoiceTTS.Size = new System.Drawing.Size(118, 26);
            cmbBxVoiceTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            cmbBxVoiceTTS.StyleManager = metroStyleManager;
            cmbBxVoiceTTS.TabIndex = 8;
            cmbBxVoiceTTS.ThemeAuthor = "Taiizor";
            cmbBxVoiceTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(cmbBxVoiceTTS, "Read aloud text");
            cmbBxVoiceTTS.SelectedIndexChanged += cmbBxVoiceTTS_SelectedIndexChanged;
            // 
            // lblVoice
            // 
            lblVoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblVoice.IsDerivedStyle = true;
            lblVoice.Location = new System.Drawing.Point(275, 573);
            lblVoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblVoice.Name = "lblVoice";
            lblVoice.Size = new System.Drawing.Size(61, 18);
            lblVoice.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lblVoice.StyleManager = metroStyleManager;
            lblVoice.TabIndex = 7;
            lblVoice.Text = "Voice:";
            lblVoice.ThemeAuthor = "Taiizor";
            lblVoice.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(lblVoice, "Read aloud text");
            // 
            // lblSpeed
            // 
            lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblSpeed.IsDerivedStyle = true;
            lblSpeed.Location = new System.Drawing.Point(114, 572);
            lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(65, 23);
            lblSpeed.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lblSpeed.StyleManager = metroStyleManager;
            lblSpeed.TabIndex = 6;
            lblSpeed.Text = "Speed:";
            lblSpeed.ThemeAuthor = "Taiizor";
            lblSpeed.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(lblSpeed, "Read aloud text");
            // 
            // checkBoxDownloadTTS
            // 
            checkBoxDownloadTTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            checkBoxDownloadTTS.BackColor = System.Drawing.Color.Transparent;
            checkBoxDownloadTTS.BackgroundColor = System.Drawing.Color.White;
            checkBoxDownloadTTS.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            checkBoxDownloadTTS.Checked = false;
            checkBoxDownloadTTS.CheckSignColor = System.Drawing.Color.FromArgb(65, 177, 225);
            checkBoxDownloadTTS.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            checkBoxDownloadTTS.Cursor = System.Windows.Forms.Cursors.Hand;
            checkBoxDownloadTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(205, 205, 205);
            checkBoxDownloadTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            checkBoxDownloadTTS.IsDerivedStyle = true;
            checkBoxDownloadTTS.Location = new System.Drawing.Point(2, 572);
            checkBoxDownloadTTS.Margin = new System.Windows.Forms.Padding(2);
            checkBoxDownloadTTS.Name = "checkBoxDownloadTTS";
            checkBoxDownloadTTS.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            checkBoxDownloadTTS.Size = new System.Drawing.Size(107, 16);
            checkBoxDownloadTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            checkBoxDownloadTTS.StyleManager = metroStyleManager;
            checkBoxDownloadTTS.TabIndex = 4;
            checkBoxDownloadTTS.Text = "Save Audio";
            checkBoxDownloadTTS.ThemeAuthor = "Taiizor";
            checkBoxDownloadTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(checkBoxDownloadTTS, "Read aloud text");
            // 
            // btn_DownloadTTS
            // 
            btn_DownloadTTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_DownloadTTS.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_DownloadTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_DownloadTTS.DisabledForeColor = System.Drawing.Color.Gray;
            btn_DownloadTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_DownloadTTS.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_DownloadTTS.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_DownloadTTS.HoverTextColor = System.Drawing.Color.White;
            btn_DownloadTTS.IsDerivedStyle = true;
            btn_DownloadTTS.Location = new System.Drawing.Point(114, 549);
            btn_DownloadTTS.Margin = new System.Windows.Forms.Padding(2);
            btn_DownloadTTS.Name = "btn_DownloadTTS";
            btn_DownloadTTS.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_DownloadTTS.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_DownloadTTS.NormalTextColor = System.Drawing.Color.White;
            btn_DownloadTTS.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_DownloadTTS.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_DownloadTTS.PressTextColor = System.Drawing.Color.White;
            btn_DownloadTTS.Size = new System.Drawing.Size(83, 17);
            btn_DownloadTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_DownloadTTS.StyleManager = metroStyleManager;
            btn_DownloadTTS.TabIndex = 3;
            btn_DownloadTTS.Text = "Download";
            btn_DownloadTTS.ThemeAuthor = "Taiizor";
            btn_DownloadTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_DownloadTTS, "Read aloud text");
            btn_DownloadTTS.Click += btn_Download_Click;
            // 
            // btn_stopTTS
            // 
            btn_stopTTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_stopTTS.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_stopTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_stopTTS.DisabledForeColor = System.Drawing.Color.Gray;
            btn_stopTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_stopTTS.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_stopTTS.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_stopTTS.HoverTextColor = System.Drawing.Color.White;
            btn_stopTTS.IsDerivedStyle = true;
            btn_stopTTS.Location = new System.Drawing.Point(57, 549);
            btn_stopTTS.Margin = new System.Windows.Forms.Padding(2);
            btn_stopTTS.Name = "btn_stopTTS";
            btn_stopTTS.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_stopTTS.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_stopTTS.NormalTextColor = System.Drawing.Color.White;
            btn_stopTTS.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_stopTTS.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_stopTTS.PressTextColor = System.Drawing.Color.White;
            btn_stopTTS.Size = new System.Drawing.Size(52, 17);
            btn_stopTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_stopTTS.StyleManager = metroStyleManager;
            btn_stopTTS.TabIndex = 2;
            btn_stopTTS.Text = "Stop";
            btn_stopTTS.ThemeAuthor = "Taiizor";
            btn_stopTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_stopTTS, "Read aloud text");
            btn_stopTTS.Click += btn_stop_Click;
            // 
            // btn_playTTS
            // 
            btn_playTTS.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_playTTS.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_playTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            btn_playTTS.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            btn_playTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_playTTS.HoverBorderColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_playTTS.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_playTTS.HoverTextColor = System.Drawing.Color.White;
            btn_playTTS.IsDerivedStyle = true;
            btn_playTTS.Location = new System.Drawing.Point(0, 549);
            btn_playTTS.Margin = new System.Windows.Forms.Padding(2);
            btn_playTTS.Name = "btn_playTTS";
            btn_playTTS.NormalBorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_playTTS.NormalColor = System.Drawing.Color.FromArgb(238, 238, 238);
            btn_playTTS.NormalTextColor = System.Drawing.Color.Black;
            btn_playTTS.PressBorderColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_playTTS.PressColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_playTTS.PressTextColor = System.Drawing.Color.White;
            btn_playTTS.Size = new System.Drawing.Size(52, 17);
            btn_playTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_playTTS.StyleManager = metroStyleManager;
            btn_playTTS.TabIndex = 1;
            btn_playTTS.Text = "Play";
            btn_playTTS.ThemeAuthor = "Taiizor";
            btn_playTTS.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_playTTS, "Read aloud text");
            btn_playTTS.Click += btn_play_Click;
            // 
            // TabPageSTT
            // 
            TabPageSTT.BaseColor = System.Drawing.Color.White;
            TabPageSTT.Controls.Add(btn_asPromptSTT);
            TabPageSTT.Controls.Add(cmbSttLanguage);
            TabPageSTT.Controls.Add(btn_clearSTT);
            TabPageSTT.Controls.Add(btn_copySTT);
            TabPageSTT.Controls.Add(btn_record);
            TabPageSTT.Controls.Add(txt_resultSTT);
            TabPageSTT.Font = null;
            TabPageSTT.ImageIndex = 0;
            TabPageSTT.ImageKey = null;
            TabPageSTT.IsDerivedStyle = true;
            TabPageSTT.Location = new System.Drawing.Point(4, 42);
            TabPageSTT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageSTT.Name = "TabPageSTT";
            TabPageSTT.Size = new System.Drawing.Size(473, 615);
            TabPageSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TabPageSTT.StyleManager = metroStyleManager;
            TabPageSTT.TabIndex = 2;
            TabPageSTT.Text = "Speach-To-text";
            TabPageSTT.ThemeAuthor = "Taiizor";
            TabPageSTT.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(TabPageSTT, "Record and transcribe voice");
            TabPageSTT.ToolTipText = null;
            // 
            // btn_asPromptSTT
            // 
            btn_asPromptSTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_asPromptSTT.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_asPromptSTT.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_asPromptSTT.DisabledForeColor = System.Drawing.Color.Gray;
            btn_asPromptSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_asPromptSTT.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_asPromptSTT.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_asPromptSTT.HoverTextColor = System.Drawing.Color.White;
            btn_asPromptSTT.IsDerivedStyle = true;
            btn_asPromptSTT.Location = new System.Drawing.Point(182, 563);
            btn_asPromptSTT.Margin = new System.Windows.Forms.Padding(2);
            btn_asPromptSTT.Name = "btn_asPromptSTT";
            btn_asPromptSTT.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_asPromptSTT.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_asPromptSTT.NormalTextColor = System.Drawing.Color.White;
            btn_asPromptSTT.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_asPromptSTT.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_asPromptSTT.PressTextColor = System.Drawing.Color.White;
            btn_asPromptSTT.Size = new System.Drawing.Size(78, 30);
            btn_asPromptSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_asPromptSTT.StyleManager = metroStyleManager;
            btn_asPromptSTT.TabIndex = 5;
            btn_asPromptSTT.Text = "To Prompt";
            btn_asPromptSTT.ThemeAuthor = "Taiizor";
            btn_asPromptSTT.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_asPromptSTT, "Record and transcribe voice");
            btn_asPromptSTT.Click += btn_asPromptSTT_Click;
            // 
            // cmbSttLanguage
            // 
            cmbSttLanguage.AllowDrop = true;
            cmbSttLanguage.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            cmbSttLanguage.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbSttLanguage.BackColor = System.Drawing.Color.Transparent;
            cmbSttLanguage.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            cmbSttLanguage.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbSttLanguage.CausesValidation = false;
            cmbSttLanguage.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            cmbSttLanguage.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            cmbSttLanguage.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            cmbSttLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cmbSttLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSttLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbSttLanguage.FormattingEnabled = true;
            cmbSttLanguage.IsDerivedStyle = true;
            cmbSttLanguage.ItemHeight = 20;
            cmbSttLanguage.Items.AddRange(new object[] { "en", "de", "cz", "se", "dk", "no", "fr", "es" });
            cmbSttLanguage.Location = new System.Drawing.Point(264, 563);
            cmbSttLanguage.Margin = new System.Windows.Forms.Padding(2);
            cmbSttLanguage.Name = "cmbSttLanguage";
            cmbSttLanguage.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            cmbSttLanguage.SelectedItemForeColor = System.Drawing.Color.White;
            cmbSttLanguage.Size = new System.Drawing.Size(72, 26);
            cmbSttLanguage.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            cmbSttLanguage.StyleManager = metroStyleManager;
            cmbSttLanguage.TabIndex = 4;
            cmbSttLanguage.ThemeAuthor = "Taiizor";
            cmbSttLanguage.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(cmbSttLanguage, "Record and transcribe voice");
            cmbSttLanguage.SelectedIndexChanged += comboBoxSttLanguage_SelectedIndexChanged;
            // 
            // btn_clearSTT
            // 
            btn_clearSTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_clearSTT.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_clearSTT.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_clearSTT.DisabledForeColor = System.Drawing.Color.Gray;
            btn_clearSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_clearSTT.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_clearSTT.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_clearSTT.HoverTextColor = System.Drawing.Color.White;
            btn_clearSTT.IsDerivedStyle = true;
            btn_clearSTT.Location = new System.Drawing.Point(120, 563);
            btn_clearSTT.Margin = new System.Windows.Forms.Padding(2);
            btn_clearSTT.Name = "btn_clearSTT";
            btn_clearSTT.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_clearSTT.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_clearSTT.NormalTextColor = System.Drawing.Color.White;
            btn_clearSTT.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_clearSTT.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_clearSTT.PressTextColor = System.Drawing.Color.White;
            btn_clearSTT.Size = new System.Drawing.Size(58, 30);
            btn_clearSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_clearSTT.StyleManager = metroStyleManager;
            btn_clearSTT.TabIndex = 3;
            btn_clearSTT.Text = "Clear";
            btn_clearSTT.ThemeAuthor = "Taiizor";
            btn_clearSTT.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_clearSTT, "Record and transcribe voice");
            btn_clearSTT.Click += btn_clearSTT_Click;
            // 
            // btn_copySTT
            // 
            btn_copySTT.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_copySTT.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_copySTT.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_copySTT.DisabledForeColor = System.Drawing.Color.Gray;
            btn_copySTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_copySTT.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_copySTT.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_copySTT.HoverTextColor = System.Drawing.Color.White;
            btn_copySTT.IsDerivedStyle = true;
            btn_copySTT.Location = new System.Drawing.Point(63, 563);
            btn_copySTT.Margin = new System.Windows.Forms.Padding(2);
            btn_copySTT.Name = "btn_copySTT";
            btn_copySTT.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_copySTT.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_copySTT.NormalTextColor = System.Drawing.Color.White;
            btn_copySTT.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_copySTT.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_copySTT.PressTextColor = System.Drawing.Color.White;
            btn_copySTT.Size = new System.Drawing.Size(52, 30);
            btn_copySTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_copySTT.StyleManager = metroStyleManager;
            btn_copySTT.TabIndex = 2;
            btn_copySTT.Text = "Copy";
            btn_copySTT.ThemeAuthor = "Taiizor";
            btn_copySTT.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_copySTT, "Record and transcribe voice");
            btn_copySTT.Click += btn_copySTT_Click;
            // 
            // btn_record
            // 
            btn_record.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_record.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_record.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            btn_record.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            btn_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_record.HoverBorderColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_record.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_record.HoverTextColor = System.Drawing.Color.White;
            btn_record.IsDerivedStyle = true;
            btn_record.Location = new System.Drawing.Point(-2, 563);
            btn_record.Margin = new System.Windows.Forms.Padding(2);
            btn_record.Name = "btn_record";
            btn_record.NormalBorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_record.NormalColor = System.Drawing.Color.FromArgb(238, 238, 238);
            btn_record.NormalTextColor = System.Drawing.Color.Black;
            btn_record.PressBorderColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_record.PressColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_record.PressTextColor = System.Drawing.Color.White;
            btn_record.Size = new System.Drawing.Size(61, 30);
            btn_record.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_record.StyleManager = metroStyleManager;
            btn_record.TabIndex = 1;
            btn_record.Text = "Record";
            btn_record.ThemeAuthor = "Taiizor";
            btn_record.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(btn_record, "Record and transcribe voice");
            btn_record.Click += btn_record_Click;
            // 
            // txt_resultSTT
            // 
            txt_resultSTT.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txt_resultSTT.AutoWordSelection = false;
            txt_resultSTT.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_resultSTT.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_resultSTT.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_resultSTT.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_resultSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_resultSTT.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_resultSTT.IsDerivedStyle = true;
            txt_resultSTT.Lines = null;
            txt_resultSTT.Location = new System.Drawing.Point(-2, 2);
            txt_resultSTT.Margin = new System.Windows.Forms.Padding(2);
            txt_resultSTT.MaxLength = 32767;
            txt_resultSTT.Name = "txt_resultSTT";
            txt_resultSTT.ReadOnly = false;
            txt_resultSTT.Size = new System.Drawing.Size(469, 556);
            txt_resultSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_resultSTT.StyleManager = metroStyleManager;
            txt_resultSTT.TabIndex = 0;
            txt_resultSTT.ThemeAuthor = "Taiizor";
            txt_resultSTT.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(txt_resultSTT, "Record and transcribe voice");
            txt_resultSTT.WordWrap = true;
            // 
            // TabPageSettings
            // 
            TabPageSettings.BaseColor = System.Drawing.Color.White;
            TabPageSettings.Controls.Add(txt_QuickPrompt5);
            TabPageSettings.Controls.Add(metroLabel13);
            TabPageSettings.Controls.Add(txt_QuickPrompt4);
            TabPageSettings.Controls.Add(metroLabel12);
            TabPageSettings.Controls.Add(txt_QuickPrompt3);
            TabPageSettings.Controls.Add(metroLabel11);
            TabPageSettings.Controls.Add(txt_QuickPrompt2);
            TabPageSettings.Controls.Add(metroLabel10);
            TabPageSettings.Controls.Add(cmb_SettingQuickPromptModel);
            TabPageSettings.Controls.Add(metroLabel9);
            TabPageSettings.Controls.Add(txt_QuickPrompt1);
            TabPageSettings.Controls.Add(metroLabel8);
            TabPageSettings.Controls.Add(metroLabel7);
            TabPageSettings.Controls.Add(metroDivider3);
            TabPageSettings.Controls.Add(chkBAutoStartApp);
            TabPageSettings.Controls.Add(chkAutoStartTTS);
            TabPageSettings.Controls.Add(chkAutoStartSTT);
            TabPageSettings.Controls.Add(metroLabel6);
            TabPageSettings.Controls.Add(switchDarkMode);
            TabPageSettings.Controls.Add(metroLabel5);
            TabPageSettings.Controls.Add(btn_saveSettings);
            TabPageSettings.Controls.Add(txt_HotkeyKey);
            TabPageSettings.Controls.Add(metroLabel4);
            TabPageSettings.Controls.Add(metroLabel3);
            TabPageSettings.Controls.Add(cmbHotKeyMod);
            TabPageSettings.Controls.Add(txt_API_URL);
            TabPageSettings.Controls.Add(txt_ApiKey);
            TabPageSettings.Font = null;
            TabPageSettings.ImageIndex = 0;
            TabPageSettings.ImageKey = null;
            TabPageSettings.IsDerivedStyle = true;
            TabPageSettings.Location = new System.Drawing.Point(4, 42);
            TabPageSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageSettings.Name = "TabPageSettings";
            TabPageSettings.Size = new System.Drawing.Size(473, 615);
            TabPageSettings.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TabPageSettings.StyleManager = metroStyleManager;
            TabPageSettings.TabIndex = 3;
            TabPageSettings.Text = "Settings";
            TabPageSettings.ThemeAuthor = "Taiizor";
            TabPageSettings.ThemeName = "MetroLight";
            TabPageSettings.ToolTipText = null;
            // 
            // txt_QuickPrompt5
            // 
            txt_QuickPrompt5.AutoCompleteCustomSource = null;
            txt_QuickPrompt5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_QuickPrompt5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_QuickPrompt5.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt5.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_QuickPrompt5.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt5.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_QuickPrompt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_QuickPrompt5.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_QuickPrompt5.Image = null;
            txt_QuickPrompt5.IsDerivedStyle = true;
            txt_QuickPrompt5.Lines = null;
            txt_QuickPrompt5.Location = new System.Drawing.Point(66, 461);
            txt_QuickPrompt5.MaxLength = 32767;
            txt_QuickPrompt5.Multiline = false;
            txt_QuickPrompt5.Name = "txt_QuickPrompt5";
            txt_QuickPrompt5.ReadOnly = false;
            txt_QuickPrompt5.Size = new System.Drawing.Size(403, 30);
            txt_QuickPrompt5.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_QuickPrompt5.StyleManager = metroStyleManager;
            txt_QuickPrompt5.TabIndex = 27;
            txt_QuickPrompt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_QuickPrompt5.ThemeAuthor = "Taiizor";
            txt_QuickPrompt5.ThemeName = "MetroLight";
            txt_QuickPrompt5.UseSystemPasswordChar = false;
            txt_QuickPrompt5.WatermarkText = "";
            // 
            // metroLabel13
            // 
            metroLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel13.IsDerivedStyle = true;
            metroLabel13.Location = new System.Drawing.Point(8, 461);
            metroLabel13.Name = "metroLabel13";
            metroLabel13.Size = new System.Drawing.Size(54, 23);
            metroLabel13.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel13.StyleManager = metroStyleManager;
            metroLabel13.TabIndex = 26;
            metroLabel13.Text = "Key 5:";
            metroLabel13.ThemeAuthor = "Taiizor";
            metroLabel13.ThemeName = "MetroLight";
            // 
            // txt_QuickPrompt4
            // 
            txt_QuickPrompt4.AutoCompleteCustomSource = null;
            txt_QuickPrompt4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_QuickPrompt4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_QuickPrompt4.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt4.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_QuickPrompt4.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt4.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_QuickPrompt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_QuickPrompt4.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_QuickPrompt4.Image = null;
            txt_QuickPrompt4.IsDerivedStyle = true;
            txt_QuickPrompt4.Lines = null;
            txt_QuickPrompt4.Location = new System.Drawing.Point(66, 425);
            txt_QuickPrompt4.MaxLength = 32767;
            txt_QuickPrompt4.Multiline = false;
            txt_QuickPrompt4.Name = "txt_QuickPrompt4";
            txt_QuickPrompt4.ReadOnly = false;
            txt_QuickPrompt4.Size = new System.Drawing.Size(403, 30);
            txt_QuickPrompt4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_QuickPrompt4.StyleManager = metroStyleManager;
            txt_QuickPrompt4.TabIndex = 25;
            txt_QuickPrompt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_QuickPrompt4.ThemeAuthor = "Taiizor";
            txt_QuickPrompt4.ThemeName = "MetroLight";
            txt_QuickPrompt4.UseSystemPasswordChar = false;
            txt_QuickPrompt4.WatermarkText = "";
            // 
            // metroLabel12
            // 
            metroLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel12.IsDerivedStyle = true;
            metroLabel12.Location = new System.Drawing.Point(8, 425);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new System.Drawing.Size(54, 23);
            metroLabel12.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel12.StyleManager = metroStyleManager;
            metroLabel12.TabIndex = 24;
            metroLabel12.Text = "Key 4:";
            metroLabel12.ThemeAuthor = "Taiizor";
            metroLabel12.ThemeName = "MetroLight";
            // 
            // txt_QuickPrompt3
            // 
            txt_QuickPrompt3.AutoCompleteCustomSource = null;
            txt_QuickPrompt3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_QuickPrompt3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_QuickPrompt3.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt3.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_QuickPrompt3.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt3.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_QuickPrompt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_QuickPrompt3.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_QuickPrompt3.Image = null;
            txt_QuickPrompt3.IsDerivedStyle = true;
            txt_QuickPrompt3.Lines = null;
            txt_QuickPrompt3.Location = new System.Drawing.Point(66, 389);
            txt_QuickPrompt3.MaxLength = 32767;
            txt_QuickPrompt3.Multiline = false;
            txt_QuickPrompt3.Name = "txt_QuickPrompt3";
            txt_QuickPrompt3.ReadOnly = false;
            txt_QuickPrompt3.Size = new System.Drawing.Size(403, 30);
            txt_QuickPrompt3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_QuickPrompt3.StyleManager = metroStyleManager;
            txt_QuickPrompt3.TabIndex = 23;
            txt_QuickPrompt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_QuickPrompt3.ThemeAuthor = "Taiizor";
            txt_QuickPrompt3.ThemeName = "MetroLight";
            txt_QuickPrompt3.UseSystemPasswordChar = false;
            txt_QuickPrompt3.WatermarkText = "";
            // 
            // metroLabel11
            // 
            metroLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel11.IsDerivedStyle = true;
            metroLabel11.Location = new System.Drawing.Point(8, 389);
            metroLabel11.Name = "metroLabel11";
            metroLabel11.Size = new System.Drawing.Size(54, 23);
            metroLabel11.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel11.StyleManager = metroStyleManager;
            metroLabel11.TabIndex = 22;
            metroLabel11.Text = "Key 3:";
            metroLabel11.ThemeAuthor = "Taiizor";
            metroLabel11.ThemeName = "MetroLight";
            // 
            // txt_QuickPrompt2
            // 
            txt_QuickPrompt2.AutoCompleteCustomSource = null;
            txt_QuickPrompt2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_QuickPrompt2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_QuickPrompt2.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt2.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_QuickPrompt2.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt2.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_QuickPrompt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_QuickPrompt2.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_QuickPrompt2.Image = null;
            txt_QuickPrompt2.IsDerivedStyle = true;
            txt_QuickPrompt2.Lines = null;
            txt_QuickPrompt2.Location = new System.Drawing.Point(66, 353);
            txt_QuickPrompt2.MaxLength = 32767;
            txt_QuickPrompt2.Multiline = false;
            txt_QuickPrompt2.Name = "txt_QuickPrompt2";
            txt_QuickPrompt2.ReadOnly = false;
            txt_QuickPrompt2.Size = new System.Drawing.Size(403, 30);
            txt_QuickPrompt2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_QuickPrompt2.StyleManager = metroStyleManager;
            txt_QuickPrompt2.TabIndex = 21;
            txt_QuickPrompt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_QuickPrompt2.ThemeAuthor = "Taiizor";
            txt_QuickPrompt2.ThemeName = "MetroLight";
            txt_QuickPrompt2.UseSystemPasswordChar = false;
            txt_QuickPrompt2.WatermarkText = "";
            // 
            // metroLabel10
            // 
            metroLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel10.IsDerivedStyle = true;
            metroLabel10.Location = new System.Drawing.Point(9, 353);
            metroLabel10.Name = "metroLabel10";
            metroLabel10.Size = new System.Drawing.Size(54, 23);
            metroLabel10.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel10.StyleManager = metroStyleManager;
            metroLabel10.TabIndex = 20;
            metroLabel10.Text = "Key 2:";
            metroLabel10.ThemeAuthor = "Taiizor";
            metroLabel10.ThemeName = "MetroLight";
            // 
            // cmb_SettingQuickPromptModel
            // 
            cmb_SettingQuickPromptModel.AllowDrop = true;
            cmb_SettingQuickPromptModel.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmb_SettingQuickPromptModel.BackColor = System.Drawing.Color.Transparent;
            cmb_SettingQuickPromptModel.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            cmb_SettingQuickPromptModel.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmb_SettingQuickPromptModel.CausesValidation = false;
            cmb_SettingQuickPromptModel.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            cmb_SettingQuickPromptModel.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            cmb_SettingQuickPromptModel.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            cmb_SettingQuickPromptModel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cmb_SettingQuickPromptModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb_SettingQuickPromptModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmb_SettingQuickPromptModel.FormattingEnabled = true;
            cmb_SettingQuickPromptModel.IsDerivedStyle = true;
            cmb_SettingQuickPromptModel.ItemHeight = 20;
            cmb_SettingQuickPromptModel.Location = new System.Drawing.Point(66, 279);
            cmb_SettingQuickPromptModel.Name = "cmb_SettingQuickPromptModel";
            cmb_SettingQuickPromptModel.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            cmb_SettingQuickPromptModel.SelectedItemForeColor = System.Drawing.Color.White;
            cmb_SettingQuickPromptModel.Size = new System.Drawing.Size(220, 26);
            cmb_SettingQuickPromptModel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            cmb_SettingQuickPromptModel.StyleManager = metroStyleManager;
            cmb_SettingQuickPromptModel.TabIndex = 19;
            cmb_SettingQuickPromptModel.ThemeAuthor = "Taiizor";
            cmb_SettingQuickPromptModel.ThemeName = "MetroLight";
            // 
            // metroLabel9
            // 
            metroLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel9.IsDerivedStyle = true;
            metroLabel9.Location = new System.Drawing.Point(8, 282);
            metroLabel9.Name = "metroLabel9";
            metroLabel9.Size = new System.Drawing.Size(100, 23);
            metroLabel9.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel9.StyleManager = metroStyleManager;
            metroLabel9.TabIndex = 18;
            metroLabel9.Text = "Model:";
            metroLabel9.ThemeAuthor = "Taiizor";
            metroLabel9.ThemeName = "MetroLight";
            // 
            // txt_QuickPrompt1
            // 
            txt_QuickPrompt1.AutoCompleteCustomSource = null;
            txt_QuickPrompt1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_QuickPrompt1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_QuickPrompt1.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt1.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_QuickPrompt1.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_QuickPrompt1.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_QuickPrompt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_QuickPrompt1.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_QuickPrompt1.Image = null;
            txt_QuickPrompt1.IsDerivedStyle = true;
            txt_QuickPrompt1.Lines = null;
            txt_QuickPrompt1.Location = new System.Drawing.Point(66, 317);
            txt_QuickPrompt1.MaxLength = 32767;
            txt_QuickPrompt1.Multiline = false;
            txt_QuickPrompt1.Name = "txt_QuickPrompt1";
            txt_QuickPrompt1.ReadOnly = false;
            txt_QuickPrompt1.Size = new System.Drawing.Size(403, 30);
            txt_QuickPrompt1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_QuickPrompt1.StyleManager = metroStyleManager;
            txt_QuickPrompt1.TabIndex = 17;
            txt_QuickPrompt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_QuickPrompt1.ThemeAuthor = "Taiizor";
            txt_QuickPrompt1.ThemeName = "MetroLight";
            txt_QuickPrompt1.UseSystemPasswordChar = false;
            txt_QuickPrompt1.WatermarkText = "";
            // 
            // metroLabel8
            // 
            metroLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel8.IsDerivedStyle = true;
            metroLabel8.Location = new System.Drawing.Point(8, 317);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new System.Drawing.Size(54, 23);
            metroLabel8.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel8.StyleManager = metroStyleManager;
            metroLabel8.TabIndex = 16;
            metroLabel8.Text = "Key 1:";
            metroLabel8.ThemeAuthor = "Taiizor";
            metroLabel8.ThemeName = "MetroLight";
            // 
            // metroLabel7
            // 
            metroLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            metroLabel7.IsDerivedStyle = true;
            metroLabel7.Location = new System.Drawing.Point(6, 259);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new System.Drawing.Size(201, 23);
            metroLabel7.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel7.StyleManager = metroStyleManager;
            metroLabel7.TabIndex = 15;
            metroLabel7.Text = "Quick prompt replacements";
            metroLabel7.ThemeAuthor = "Taiizor";
            metroLabel7.ThemeName = "MetroLight";
            toolTipMain.SetToolTip(metroLabel7, "Key bindings for quick prompts that will directly insert");
            // 
            // metroDivider3
            // 
            metroDivider3.IsDerivedStyle = true;
            metroDivider3.Location = new System.Drawing.Point(5, 254);
            metroDivider3.Name = "metroDivider3";
            metroDivider3.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider3.Size = new System.Drawing.Size(464, 4);
            metroDivider3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider3.StyleManager = null;
            metroDivider3.TabIndex = 14;
            metroDivider3.Text = "metroDivider3";
            metroDivider3.ThemeAuthor = "Taiizor";
            metroDivider3.ThemeName = "MetroLight";
            metroDivider3.Thickness = 1;
            // 
            // chkBAutoStartApp
            // 
            chkBAutoStartApp.BackColor = System.Drawing.Color.Transparent;
            chkBAutoStartApp.BackgroundColor = System.Drawing.Color.White;
            chkBAutoStartApp.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            chkBAutoStartApp.Checked = false;
            chkBAutoStartApp.CheckSignColor = System.Drawing.Color.FromArgb(65, 177, 225);
            chkBAutoStartApp.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            chkBAutoStartApp.DisabledBorderColor = System.Drawing.Color.FromArgb(205, 205, 205);
            chkBAutoStartApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chkBAutoStartApp.IsDerivedStyle = true;
            chkBAutoStartApp.Location = new System.Drawing.Point(5, 232);
            chkBAutoStartApp.Name = "chkBAutoStartApp";
            chkBAutoStartApp.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            chkBAutoStartApp.Size = new System.Drawing.Size(202, 16);
            chkBAutoStartApp.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            chkBAutoStartApp.StyleManager = metroStyleManager;
            chkBAutoStartApp.TabIndex = 13;
            chkBAutoStartApp.Text = "Autostart with Windows";
            chkBAutoStartApp.ThemeAuthor = "Taiizor";
            chkBAutoStartApp.ThemeName = "MetroLight";
            // 
            // chkAutoStartTTS
            // 
            chkAutoStartTTS.BackColor = System.Drawing.Color.Transparent;
            chkAutoStartTTS.BackgroundColor = System.Drawing.Color.White;
            chkAutoStartTTS.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            chkAutoStartTTS.Checked = false;
            chkAutoStartTTS.CheckSignColor = System.Drawing.Color.FromArgb(65, 177, 225);
            chkAutoStartTTS.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            chkAutoStartTTS.DisabledBorderColor = System.Drawing.Color.FromArgb(205, 205, 205);
            chkAutoStartTTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chkAutoStartTTS.IsDerivedStyle = true;
            chkAutoStartTTS.Location = new System.Drawing.Point(191, 150);
            chkAutoStartTTS.Name = "chkAutoStartTTS";
            chkAutoStartTTS.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            chkAutoStartTTS.Size = new System.Drawing.Size(195, 16);
            chkAutoStartTTS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            chkAutoStartTTS.StyleManager = metroStyleManager;
            chkAutoStartTTS.TabIndex = 12;
            chkAutoStartTTS.Text = "Auto start Playback - TTS";
            chkAutoStartTTS.ThemeAuthor = "Taiizor";
            chkAutoStartTTS.ThemeName = "MetroLight";
            // 
            // chkAutoStartSTT
            // 
            chkAutoStartSTT.BackColor = System.Drawing.Color.Transparent;
            chkAutoStartSTT.BackgroundColor = System.Drawing.Color.White;
            chkAutoStartSTT.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            chkAutoStartSTT.Checked = false;
            chkAutoStartSTT.CheckSignColor = System.Drawing.Color.FromArgb(65, 177, 225);
            chkAutoStartSTT.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            chkAutoStartSTT.DisabledBorderColor = System.Drawing.Color.FromArgb(205, 205, 205);
            chkAutoStartSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chkAutoStartSTT.IsDerivedStyle = true;
            chkAutoStartSTT.Location = new System.Drawing.Point(5, 150);
            chkAutoStartSTT.Name = "chkAutoStartSTT";
            chkAutoStartSTT.SignStyle = ReaLTaiizor.Enum.Metro.SignStyle.Sign;
            chkAutoStartSTT.Size = new System.Drawing.Size(179, 16);
            chkAutoStartSTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            chkAutoStartSTT.StyleManager = metroStyleManager;
            chkAutoStartSTT.TabIndex = 11;
            chkAutoStartSTT.Text = "Auto start recording - STT";
            chkAutoStartSTT.ThemeAuthor = "Taiizor";
            chkAutoStartSTT.ThemeName = "MetroLight";
            // 
            // metroLabel6
            // 
            metroLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel6.IsDerivedStyle = true;
            metroLabel6.Location = new System.Drawing.Point(4, 199);
            metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new System.Drawing.Size(105, 27);
            metroLabel6.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel6.StyleManager = metroStyleManager;
            metroLabel6.TabIndex = 10;
            metroLabel6.Text = "Dark mode:";
            metroLabel6.ThemeAuthor = "Taiizor";
            metroLabel6.ThemeName = "MetroLight";
            // 
            // switchDarkMode
            // 
            switchDarkMode.BackColor = System.Drawing.Color.Transparent;
            switchDarkMode.BackgroundColor = System.Drawing.Color.Empty;
            switchDarkMode.BorderColor = System.Drawing.Color.FromArgb(165, 159, 147);
            switchDarkMode.CheckColor = System.Drawing.Color.FromArgb(65, 177, 225);
            switchDarkMode.CheckState = ReaLTaiizor.Enum.Metro.CheckState.Unchecked;
            switchDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            switchDarkMode.DisabledBorderColor = System.Drawing.Color.FromArgb(205, 205, 205);
            switchDarkMode.DisabledCheckColor = System.Drawing.Color.FromArgb(100, 65, 177, 225);
            switchDarkMode.DisabledUnCheckColor = System.Drawing.Color.FromArgb(200, 205, 205, 205);
            switchDarkMode.IsDerivedStyle = true;
            switchDarkMode.Location = new System.Drawing.Point(117, 199);
            switchDarkMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            switchDarkMode.Name = "switchDarkMode";
            switchDarkMode.Size = new System.Drawing.Size(58, 22);
            switchDarkMode.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            switchDarkMode.StyleManager = metroStyleManager;
            switchDarkMode.Switched = false;
            switchDarkMode.SymbolColor = System.Drawing.Color.FromArgb(92, 92, 92);
            switchDarkMode.TabIndex = 9;
            switchDarkMode.Text = "metroSwitch1";
            switchDarkMode.ThemeAuthor = "Taiizor";
            switchDarkMode.ThemeName = "MetroLight";
            switchDarkMode.UnCheckColor = System.Drawing.Color.FromArgb(155, 155, 155);
            switchDarkMode.SwitchedChanged += switchDarkMode_SwitchedChanged;
            // 
            // metroLabel5
            // 
            metroLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel5.IsDerivedStyle = true;
            metroLabel5.Location = new System.Drawing.Point(5, 45);
            metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new System.Drawing.Size(70, 27);
            metroLabel5.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel5.StyleManager = metroStyleManager;
            metroLabel5.TabIndex = 8;
            metroLabel5.Text = "API Key:";
            metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            metroLabel5.ThemeAuthor = "Taiizor";
            metroLabel5.ThemeName = "MetroLight";
            // 
            // btn_saveSettings
            // 
            btn_saveSettings.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_saveSettings.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            btn_saveSettings.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            btn_saveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            btn_saveSettings.HoverBorderColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_saveSettings.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            btn_saveSettings.HoverTextColor = System.Drawing.Color.White;
            btn_saveSettings.IsDerivedStyle = true;
            btn_saveSettings.Location = new System.Drawing.Point(5, 565);
            btn_saveSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_saveSettings.Name = "btn_saveSettings";
            btn_saveSettings.NormalBorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            btn_saveSettings.NormalColor = System.Drawing.Color.FromArgb(238, 238, 238);
            btn_saveSettings.NormalTextColor = System.Drawing.Color.Black;
            btn_saveSettings.PressBorderColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_saveSettings.PressColor = System.Drawing.Color.FromArgb(51, 51, 51);
            btn_saveSettings.PressTextColor = System.Drawing.Color.White;
            btn_saveSettings.Size = new System.Drawing.Size(88, 27);
            btn_saveSettings.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btn_saveSettings.StyleManager = metroStyleManager;
            btn_saveSettings.TabIndex = 7;
            btn_saveSettings.Text = "Save";
            btn_saveSettings.ThemeAuthor = "Taiizor";
            btn_saveSettings.ThemeName = "MetroLight";
            btn_saveSettings.Click += btn_saveSettings_Click;
            // 
            // txt_HotkeyKey
            // 
            txt_HotkeyKey.AutoCompleteCustomSource = null;
            txt_HotkeyKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_HotkeyKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_HotkeyKey.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_HotkeyKey.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_HotkeyKey.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_HotkeyKey.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_HotkeyKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_HotkeyKey.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_HotkeyKey.Image = null;
            txt_HotkeyKey.IsDerivedStyle = true;
            txt_HotkeyKey.Lines = null;
            txt_HotkeyKey.Location = new System.Drawing.Point(191, 118);
            txt_HotkeyKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_HotkeyKey.MaxLength = 1;
            txt_HotkeyKey.Multiline = false;
            txt_HotkeyKey.Name = "txt_HotkeyKey";
            txt_HotkeyKey.ReadOnly = false;
            txt_HotkeyKey.Size = new System.Drawing.Size(35, 26);
            txt_HotkeyKey.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_HotkeyKey.StyleManager = metroStyleManager;
            txt_HotkeyKey.TabIndex = 6;
            txt_HotkeyKey.Text = "G";
            txt_HotkeyKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_HotkeyKey.ThemeAuthor = "Taiizor";
            txt_HotkeyKey.ThemeName = "MetroLight";
            txt_HotkeyKey.UseSystemPasswordChar = false;
            txt_HotkeyKey.WatermarkText = "";
            txt_HotkeyKey.TextChanged += txt_HotkeyKey_TextChanged;
            txt_HotkeyKey.KeyPress += Txt_HotkeyKey_KeyPress;
            // 
            // metroLabel4
            // 
            metroLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel4.IsDerivedStyle = true;
            metroLabel4.Location = new System.Drawing.Point(154, 118);
            metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new System.Drawing.Size(30, 30);
            metroLabel4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel4.StyleManager = metroStyleManager;
            metroLabel4.TabIndex = 5;
            metroLabel4.Text = "&&";
            metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            metroLabel4.ThemeAuthor = "Taiizor";
            metroLabel4.ThemeName = "MetroLight";
            // 
            // metroLabel3
            // 
            metroLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel3.IsDerivedStyle = true;
            metroLabel3.Location = new System.Drawing.Point(5, 88);
            metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new System.Drawing.Size(117, 27);
            metroLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel3.StyleManager = metroStyleManager;
            metroLabel3.TabIndex = 4;
            metroLabel3.Text = "Global Hotkey:";
            metroLabel3.ThemeAuthor = "Taiizor";
            metroLabel3.ThemeName = "MetroLight";
            // 
            // cmbHotKeyMod
            // 
            cmbHotKeyMod.AllowDrop = true;
            cmbHotKeyMod.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbHotKeyMod.BackColor = System.Drawing.Color.Transparent;
            cmbHotKeyMod.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            cmbHotKeyMod.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            cmbHotKeyMod.CausesValidation = false;
            cmbHotKeyMod.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            cmbHotKeyMod.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            cmbHotKeyMod.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            cmbHotKeyMod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cmbHotKeyMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbHotKeyMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cmbHotKeyMod.FormattingEnabled = true;
            cmbHotKeyMod.IsDerivedStyle = true;
            cmbHotKeyMod.ItemHeight = 20;
            cmbHotKeyMod.Items.AddRange(new object[] { "Alt", "Control", "Alt+Shift", "Control+Shift" });
            cmbHotKeyMod.Location = new System.Drawing.Point(5, 118);
            cmbHotKeyMod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbHotKeyMod.Name = "cmbHotKeyMod";
            cmbHotKeyMod.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            cmbHotKeyMod.SelectedItemForeColor = System.Drawing.Color.White;
            cmbHotKeyMod.Size = new System.Drawing.Size(140, 26);
            cmbHotKeyMod.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            cmbHotKeyMod.StyleManager = metroStyleManager;
            cmbHotKeyMod.TabIndex = 3;
            cmbHotKeyMod.ThemeAuthor = "Taiizor";
            cmbHotKeyMod.ThemeName = "MetroLight";
            // 
            // txt_API_URL
            // 
            txt_API_URL.AutoCompleteCustomSource = null;
            txt_API_URL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_API_URL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_API_URL.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_API_URL.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_API_URL.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_API_URL.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_API_URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_API_URL.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_API_URL.Image = null;
            txt_API_URL.IsDerivedStyle = true;
            txt_API_URL.Lines = null;
            txt_API_URL.Location = new System.Drawing.Point(5, 3);
            txt_API_URL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_API_URL.MaxLength = 32767;
            txt_API_URL.Multiline = false;
            txt_API_URL.Name = "txt_API_URL";
            txt_API_URL.ReadOnly = false;
            txt_API_URL.Size = new System.Drawing.Size(464, 35);
            txt_API_URL.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_API_URL.StyleManager = metroStyleManager;
            txt_API_URL.TabIndex = 2;
            txt_API_URL.Text = "https://api.openai.com/v1/";
            txt_API_URL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_API_URL.ThemeAuthor = "Taiizor";
            txt_API_URL.ThemeName = "MetroLight";
            txt_API_URL.UseSystemPasswordChar = false;
            txt_API_URL.WatermarkText = "Open AI URL";
            // 
            // txt_ApiKey
            // 
            txt_ApiKey.AutoCompleteCustomSource = null;
            txt_ApiKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            txt_ApiKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            txt_ApiKey.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_ApiKey.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_ApiKey.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_ApiKey.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_ApiKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_ApiKey.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_ApiKey.Image = null;
            txt_ApiKey.IsDerivedStyle = true;
            txt_ApiKey.Lines = null;
            txt_ApiKey.Location = new System.Drawing.Point(83, 45);
            txt_ApiKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txt_ApiKey.MaxLength = 32767;
            txt_ApiKey.Multiline = false;
            txt_ApiKey.Name = "txt_ApiKey";
            txt_ApiKey.ReadOnly = false;
            txt_ApiKey.Size = new System.Drawing.Size(386, 35);
            txt_ApiKey.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            txt_ApiKey.StyleManager = metroStyleManager;
            txt_ApiKey.TabIndex = 1;
            txt_ApiKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            txt_ApiKey.ThemeAuthor = "Taiizor";
            txt_ApiKey.ThemeName = "MetroLight";
            txt_ApiKey.UseSystemPasswordChar = true;
            txt_ApiKey.WatermarkText = "API Key";
            // 
            // TabPageAbout
            // 
            TabPageAbout.BaseColor = System.Drawing.Color.White;
            TabPageAbout.Controls.Add(metroLinkLabel5);
            TabPageAbout.Controls.Add(metroDivider2);
            TabPageAbout.Controls.Add(lblAboutVersion);
            TabPageAbout.Controls.Add(metroLinkLabel4);
            TabPageAbout.Controls.Add(metroLinkLabel3);
            TabPageAbout.Controls.Add(metroLinkLabel2);
            TabPageAbout.Controls.Add(metroLabel2);
            TabPageAbout.Controls.Add(metroLinkLabel1);
            TabPageAbout.Controls.Add(metroLabel1);
            TabPageAbout.Font = null;
            TabPageAbout.ImageIndex = 0;
            TabPageAbout.ImageKey = null;
            TabPageAbout.IsDerivedStyle = true;
            TabPageAbout.Location = new System.Drawing.Point(4, 42);
            TabPageAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TabPageAbout.Name = "TabPageAbout";
            TabPageAbout.Size = new System.Drawing.Size(473, 615);
            TabPageAbout.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            TabPageAbout.StyleManager = metroStyleManager;
            TabPageAbout.TabIndex = 4;
            TabPageAbout.Text = "About";
            TabPageAbout.ThemeAuthor = "Taiizor";
            TabPageAbout.ThemeName = "MetroLight";
            TabPageAbout.ToolTipText = null;
            // 
            // metroLinkLabel5
            // 
            metroLinkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLinkLabel5.IsDerivedStyle = true;
            metroLinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            metroLinkLabel5.Location = new System.Drawing.Point(5, 5);
            metroLinkLabel5.Name = "metroLinkLabel5";
            metroLinkLabel5.Size = new System.Drawing.Size(282, 23);
            metroLinkLabel5.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLinkLabel5.StyleManager = metroStyleManager;
            metroLinkLabel5.TabIndex = 9;
            metroLinkLabel5.TabStop = true;
            metroLinkLabel5.Text = "https://github.com/exalsch/AiCompanion";
            metroLinkLabel5.ThemeAuthor = "Taiizor";
            metroLinkLabel5.ThemeName = "MetroLight";
            metroLinkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(45, 157, 205);
            // 
            // metroDivider2
            // 
            metroDivider2.IsDerivedStyle = true;
            metroDivider2.Location = new System.Drawing.Point(5, 113);
            metroDivider2.Name = "metroDivider2";
            metroDivider2.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider2.Size = new System.Drawing.Size(461, 4);
            metroDivider2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider2.StyleManager = null;
            metroDivider2.TabIndex = 8;
            metroDivider2.Text = "metroDivider2";
            metroDivider2.ThemeAuthor = "Taiizor";
            metroDivider2.ThemeName = "MetroLight";
            metroDivider2.Thickness = 1;
            // 
            // lblAboutVersion
            // 
            lblAboutVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lblAboutVersion.IsDerivedStyle = true;
            lblAboutVersion.Location = new System.Drawing.Point(5, 28);
            lblAboutVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAboutVersion.Name = "lblAboutVersion";
            lblAboutVersion.Size = new System.Drawing.Size(117, 27);
            lblAboutVersion.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lblAboutVersion.StyleManager = metroStyleManager;
            lblAboutVersion.TabIndex = 6;
            lblAboutVersion.Text = "Version: ";
            lblAboutVersion.ThemeAuthor = "Taiizor";
            lblAboutVersion.ThemeName = "MetroLight";
            // 
            // metroLinkLabel4
            // 
            metroLinkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            metroLinkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLinkLabel4.IsDerivedStyle = true;
            metroLinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            metroLinkLabel4.Location = new System.Drawing.Point(5, 247);
            metroLinkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLinkLabel4.Name = "metroLinkLabel4";
            metroLinkLabel4.Size = new System.Drawing.Size(461, 27);
            metroLinkLabel4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLinkLabel4.StyleManager = metroStyleManager;
            metroLinkLabel4.TabIndex = 5;
            metroLinkLabel4.TabStop = true;
            metroLinkLabel4.Text = "https://github.com/Taiizor/ReaLTaiizor";
            metroLinkLabel4.ThemeAuthor = "Taiizor";
            metroLinkLabel4.ThemeName = "MetroLight";
            metroLinkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(45, 157, 205);
            // 
            // metroLinkLabel3
            // 
            metroLinkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            metroLinkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLinkLabel3.IsDerivedStyle = true;
            metroLinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            metroLinkLabel3.Location = new System.Drawing.Point(5, 216);
            metroLinkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLinkLabel3.Name = "metroLinkLabel3";
            metroLinkLabel3.Size = new System.Drawing.Size(461, 27);
            metroLinkLabel3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLinkLabel3.StyleManager = metroStyleManager;
            metroLinkLabel3.TabIndex = 4;
            metroLinkLabel3.TabStop = true;
            metroLinkLabel3.Text = "https://github.com/openai/openai-dotnet";
            metroLinkLabel3.ThemeAuthor = "Taiizor";
            metroLinkLabel3.ThemeName = "MetroLight";
            metroLinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(45, 157, 205);
            // 
            // metroLinkLabel2
            // 
            metroLinkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            metroLinkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLinkLabel2.IsDerivedStyle = true;
            metroLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            metroLinkLabel2.Location = new System.Drawing.Point(5, 189);
            metroLinkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLinkLabel2.Name = "metroLinkLabel2";
            metroLinkLabel2.Size = new System.Drawing.Size(461, 27);
            metroLinkLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLinkLabel2.StyleManager = metroStyleManager;
            metroLinkLabel2.TabIndex = 3;
            metroLinkLabel2.TabStop = true;
            metroLinkLabel2.Text = "https://github.com/naudio/NAudio";
            metroLinkLabel2.ThemeAuthor = "Taiizor";
            metroLinkLabel2.ThemeName = "MetroLight";
            metroLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(45, 157, 205);
            // 
            // metroLabel2
            // 
            metroLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel2.IsDerivedStyle = true;
            metroLabel2.Location = new System.Drawing.Point(5, 138);
            metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new System.Drawing.Size(201, 27);
            metroLabel2.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel2.StyleManager = metroStyleManager;
            metroLabel2.TabIndex = 2;
            metroLabel2.Text = "Wizard1.ico licensed by ";
            metroLabel2.ThemeAuthor = "Taiizor";
            metroLabel2.ThemeName = "MetroLight";
            // 
            // metroLinkLabel1
            // 
            metroLinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            metroLinkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLinkLabel1.IsDerivedStyle = true;
            metroLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            metroLinkLabel1.Location = new System.Drawing.Point(212, 138);
            metroLinkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLinkLabel1.Name = "metroLinkLabel1";
            metroLinkLabel1.Size = new System.Drawing.Size(218, 27);
            metroLinkLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLinkLabel1.StyleManager = metroStyleManager;
            metroLinkLabel1.TabIndex = 1;
            metroLinkLabel1.TabStop = true;
            metroLinkLabel1.Text = "http://www.icons-land.com";
            metroLinkLabel1.ThemeAuthor = "Taiizor";
            metroLinkLabel1.ThemeName = "MetroLight";
            metroLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(45, 157, 205);
            // 
            // metroLabel1
            // 
            metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            metroLabel1.IsDerivedStyle = true;
            metroLabel1.Location = new System.Drawing.Point(5, 165);
            metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(461, 24);
            metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroLabel1.StyleManager = metroStyleManager;
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "Libraries used";
            metroLabel1.ThemeAuthor = "Taiizor";
            metroLabel1.ThemeName = "MetroLight";
            // 
            // metroPanel1
            // 
            metroPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            metroPanel1.BackgroundColor = System.Drawing.Color.White;
            metroPanel1.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            metroPanel1.BorderThickness = 0;
            metroPanel1.Controls.Add(statusLabel);
            metroPanel1.IsDerivedStyle = true;
            metroPanel1.Location = new System.Drawing.Point(0, 725);
            metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new System.Drawing.Size(481, 38);
            metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroPanel1.StyleManager = metroStyleManager;
            metroPanel1.TabIndex = 2;
            metroPanel1.ThemeAuthor = "Taiizor";
            metroPanel1.ThemeName = "MetroLight";
            // 
            // statusLabel
            // 
            statusLabel.AutoEllipsis = true;
            statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            statusLabel.IsDerivedStyle = true;
            statusLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            statusLabel.Location = new System.Drawing.Point(0, 0);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(481, 38);
            statusLabel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            statusLabel.StyleManager = metroStyleManager;
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Idle";
            statusLabel.ThemeAuthor = "Taiizor";
            statusLabel.ThemeName = "MetroLight";
            // 
            // WindowControlBox
            // 
            WindowControlBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            WindowControlBox.CloseHoverBackColor = System.Drawing.Color.FromArgb(183, 40, 40);
            WindowControlBox.CloseHoverForeColor = System.Drawing.Color.White;
            WindowControlBox.CloseNormalForeColor = System.Drawing.Color.Gray;
            WindowControlBox.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Edge;
            WindowControlBox.DisabledForeColor = System.Drawing.Color.DimGray;
            WindowControlBox.IsDerivedStyle = true;
            WindowControlBox.Location = new System.Drawing.Point(381, 0);
            WindowControlBox.Margin = new System.Windows.Forms.Padding(2);
            WindowControlBox.MaximizeBox = true;
            WindowControlBox.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            WindowControlBox.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            WindowControlBox.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            WindowControlBox.MinimizeBox = true;
            WindowControlBox.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            WindowControlBox.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            WindowControlBox.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            WindowControlBox.Name = "WindowControlBox";
            WindowControlBox.Size = new System.Drawing.Size(100, 25);
            WindowControlBox.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            WindowControlBox.StyleManager = metroStyleManager;
            WindowControlBox.TabIndex = 3;
            WindowControlBox.Text = "WindowControlBox";
            WindowControlBox.ThemeAuthor = "Taiizor";
            WindowControlBox.ThemeName = "MetroLight";
            WindowControlBox.Visible = false;
            // 
            // btn_cancel
            // 
            btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_cancel.Location = new System.Drawing.Point(113, -2);
            btn_cancel.Margin = new System.Windows.Forms.Padding(2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(117, 29);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Hidden Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Visible = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // toolTipMain
            // 
            toolTipMain.BackColor = System.Drawing.Color.White;
            toolTipMain.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            toolTipMain.ForeColor = System.Drawing.Color.FromArgb(170, 170, 170);
            toolTipMain.IsDerivedStyle = true;
            toolTipMain.OwnerDraw = true;
            toolTipMain.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            toolTipMain.StyleManager = null;
            toolTipMain.ThemeAuthor = "Taiizor";
            toolTipMain.ThemeName = "MetroLight";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            CancelButton = btn_cancel;
            ClientSize = new System.Drawing.Size(481, 752);
            Controls.Add(WindowControlBox);
            Controls.Add(btn_cancel);
            Controls.Add(metroPanel1);
            Controls.Add(TabControl);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            MinimumSize = new System.Drawing.Size(481, 752);
            Name = "FormMain";
            Padding = new System.Windows.Forms.Padding(4, 74, 1, 1);
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "AICOMPANION";
            Load += FormMain_Load;
            TabControl.ResumeLayout(false);
            TabPagePrompt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPrompt).EndInit();
            pictPromptContextMenu.ResumeLayout(false);
            txt_resultPromptContextMenu.ResumeLayout(false);
            TabPageTTS.ResumeLayout(false);
            TabPageSTT.ResumeLayout(false);
            TabPageSettings.ResumeLayout(false);
            TabPageAbout.ResumeLayout(false);
            metroPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private ReaLTaiizor.Controls.MetroRichTextBox txt_resultPrompt;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.MetroButton btnRemovePrePromt;
        private ReaLTaiizor.Controls.MetroButton btnAddPrePromt;
        private ReaLTaiizor.Controls.MetroComboBox cmbPrePrompts;
        private ReaLTaiizor.Controls.MetroDefaultButton btn_sendPrompt;
        private ReaLTaiizor.Controls.MetroComboBox cmb_Model;
        private ReaLTaiizor.Controls.MetroButton btn_copyPrompt;
        private ReaLTaiizor.Controls.MetroButton btn_insertPrompt;
        private ReaLTaiizor.Controls.MetroTextBox txt_inputPrompt;
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
        private ReaLTaiizor.Controls.MetroTextBox txt_API_URL;
        private ReaLTaiizor.Controls.MetroLabel metroLabel4;
        private ReaLTaiizor.Controls.MetroLabel metroLabel3;
        private ReaLTaiizor.Controls.MetroComboBox cmbHotKeyMod;
        private ReaLTaiizor.Controls.MetroTextBox txt_HotkeyKey;
        private ReaLTaiizor.Controls.MetroDefaultButton btn_saveSettings;
        private ReaLTaiizor.Controls.MetroLabel metroLabel5;
        private ReaLTaiizor.Controls.MetroLabel metroLabel6;
        private ReaLTaiizor.Controls.MetroSwitch switchDarkMode;
        private ReaLTaiizor.Controls.MetroCheckBox chkAutoStartTTS;
        private ReaLTaiizor.Controls.MetroCheckBox chkAutoStartSTT;
        private ReaLTaiizor.Controls.MetroToolTip toolTipMain;
        private ReaLTaiizor.Controls.MetroContextMenuStrip txt_resultPromptContextMenu;
        private System.Windows.Forms.ToolStripMenuItem sendToTTSToolStripMenuItem;
        private ReaLTaiizor.Controls.MetroCheckBox chkBAutoStartApp;
        private System.Windows.Forms.PictureBox picPrompt;
        private ReaLTaiizor.Controls.MetroContextMenuStrip pictPromptContextMenu;
        private System.Windows.Forms.ToolStripMenuItem picPromptToolStripMenuItemRemove;
        private ReaLTaiizor.Controls.MetroButton btn_asPromptSTT;
        public ReaLTaiizor.Controls.MetroTabControl TabControl;
        private ReaLTaiizor.Controls.MetroDivider metroDivider2;
        private ReaLTaiizor.Controls.MetroTextBox txt_QuickPrompt1;
        private ReaLTaiizor.Controls.MetroLabel metroLabel8;
        private ReaLTaiizor.Controls.MetroLabel metroLabel7;
        private ReaLTaiizor.Controls.MetroDivider metroDivider3;
        private ReaLTaiizor.Controls.MetroComboBox cmb_SettingQuickPromptModel;
        private ReaLTaiizor.Controls.MetroLabel metroLabel9;
        private ReaLTaiizor.Controls.MetroTextBox txt_QuickPrompt5;
        private ReaLTaiizor.Controls.MetroLabel metroLabel13;
        private ReaLTaiizor.Controls.MetroTextBox txt_QuickPrompt4;
        private ReaLTaiizor.Controls.MetroLabel metroLabel12;
        private ReaLTaiizor.Controls.MetroTextBox txt_QuickPrompt3;
        private ReaLTaiizor.Controls.MetroLabel metroLabel11;
        private ReaLTaiizor.Controls.MetroTextBox txt_QuickPrompt2;
        private ReaLTaiizor.Controls.MetroLabel metroLabel10;
        private ReaLTaiizor.Controls.MetroLinkLabel metroLinkLabel5;
        private System.Windows.Forms.ToolStripMenuItem setAsPromptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private ReaLTaiizor.Controls.MetroButton btn_prompt_STTin;
    }
}
namespace MP3Randomizer_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_appTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_inputISO = new DarkUI.Controls.DarkLabel();
            this.btn_inputISO = new DarkUI.Controls.DarkButton();
            this.txtBox_inputISO = new DarkUI.Controls.DarkTextBox();
            this.txtBox_outputPath = new DarkUI.Controls.DarkTextBox();
            this.btn_outputISO = new DarkUI.Controls.DarkButton();
            this.lbl_outputISO = new DarkUI.Controls.DarkLabel();
            this.lbl_seedLayout = new DarkUI.Controls.DarkLabel();
            this.txtBox_seedLayout = new DarkUI.Controls.DarkTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtn_WBFS_Type = new DarkUI.Controls.DarkRadioButton();
            this.radioBtn_CISO_Type = new DarkUI.Controls.DarkRadioButton();
            this.lbl_outputISOType = new DarkUI.Controls.DarkLabel();
            this.radioBtn_ISO_Type = new DarkUI.Controls.DarkRadioButton();
            this.lbl_settings = new DarkUI.Controls.DarkLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chkBox_hyperHints = new DarkUI.Controls.DarkCheckBox();
            this.chkBox_randomWeldingColors = new DarkUI.Controls.DarkCheckBox();
            this.comboBox_startingItems = new DarkUI.Controls.DarkComboBox();
            this.lbl_startingItems = new DarkUI.Controls.DarkLabel();
            this.lbl_startingLocation = new DarkUI.Controls.DarkLabel();
            this.comboBox_startingLocation = new DarkUI.Controls.DarkComboBox();
            this.chkBox_randomDoorColors = new DarkUI.Controls.DarkCheckBox();
            this.chkBox_fastShipFlying = new DarkUI.Controls.DarkCheckBox();
            this.btn_generate = new DarkUI.Controls.DarkButton();
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btn_exit = new DarkUI.Controls.DarkButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.darkStatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_appTitle
            // 
            this.lbl_appTitle.AutoSize = true;
            this.lbl_appTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_appTitle.ForeColor = System.Drawing.Color.Silver;
            this.lbl_appTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_appTitle.Name = "lbl_appTitle";
            this.lbl_appTitle.Size = new System.Drawing.Size(330, 29);
            this.lbl_appTitle.TabIndex = 0;
            this.lbl_appTitle.Text = "MP3 Randomizer GUI v1.0.2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_inputISO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_inputISO, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_inputISO, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_outputPath, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_outputISO, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_outputISO, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_seedLayout, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_seedLayout, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_settings, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btn_generate, 0, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 425);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_inputISO
            // 
            this.lbl_inputISO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_inputISO.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inputISO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_inputISO.Location = new System.Drawing.Point(3, 0);
            this.lbl_inputISO.Name = "lbl_inputISO";
            this.lbl_inputISO.Size = new System.Drawing.Size(719, 24);
            this.lbl_inputISO.TabIndex = 0;
            this.lbl_inputISO.Text = "Input File :";
            this.lbl_inputISO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_inputISO
            // 
            this.btn_inputISO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_inputISO.Location = new System.Drawing.Point(728, 27);
            this.btn_inputISO.Name = "btn_inputISO";
            this.btn_inputISO.Padding = new System.Windows.Forms.Padding(5);
            this.btn_inputISO.Size = new System.Drawing.Size(69, 26);
            this.btn_inputISO.TabIndex = 1;
            this.btn_inputISO.Text = "Browse";
            this.btn_inputISO.Click += new System.EventHandler(this.btn_inputISO_Click);
            // 
            // txtBox_inputISO
            // 
            this.txtBox_inputISO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBox_inputISO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_inputISO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_inputISO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBox_inputISO.Location = new System.Drawing.Point(3, 30);
            this.txtBox_inputISO.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBox_inputISO.MaxLength = 260;
            this.txtBox_inputISO.Name = "txtBox_inputISO";
            this.txtBox_inputISO.Size = new System.Drawing.Size(719, 20);
            this.txtBox_inputISO.TabIndex = 2;
            this.txtBox_inputISO.TextChanged += new System.EventHandler(this.txtBox_inputISO_TextChanged);
            // 
            // txtBox_outputPath
            // 
            this.txtBox_outputPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBox_outputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_outputPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_outputPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBox_outputPath.Location = new System.Drawing.Point(3, 86);
            this.txtBox_outputPath.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBox_outputPath.MaxLength = 260;
            this.txtBox_outputPath.Name = "txtBox_outputPath";
            this.txtBox_outputPath.Size = new System.Drawing.Size(719, 20);
            this.txtBox_outputPath.TabIndex = 3;
            this.txtBox_outputPath.TextChanged += new System.EventHandler(this.txtBox_outputPath_TextChanged);
            // 
            // btn_outputISO
            // 
            this.btn_outputISO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_outputISO.Location = new System.Drawing.Point(728, 83);
            this.btn_outputISO.Name = "btn_outputISO";
            this.btn_outputISO.Padding = new System.Windows.Forms.Padding(5);
            this.btn_outputISO.Size = new System.Drawing.Size(69, 26);
            this.btn_outputISO.TabIndex = 4;
            this.btn_outputISO.Text = "Browse";
            this.btn_outputISO.Click += new System.EventHandler(this.btn_outputISO_Click);
            // 
            // lbl_outputISO
            // 
            this.lbl_outputISO.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outputISO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_outputISO.Location = new System.Drawing.Point(3, 56);
            this.lbl_outputISO.Name = "lbl_outputISO";
            this.lbl_outputISO.Size = new System.Drawing.Size(719, 24);
            this.lbl_outputISO.TabIndex = 5;
            this.lbl_outputISO.Text = "Output Path :";
            this.lbl_outputISO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_seedLayout
            // 
            this.lbl_seedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_seedLayout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seedLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_seedLayout.Location = new System.Drawing.Point(3, 164);
            this.lbl_seedLayout.Name = "lbl_seedLayout";
            this.lbl_seedLayout.Size = new System.Drawing.Size(719, 24);
            this.lbl_seedLayout.TabIndex = 6;
            this.lbl_seedLayout.Text = "Seed Layout :";
            this.lbl_seedLayout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBox_seedLayout
            // 
            this.txtBox_seedLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBox_seedLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_seedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_seedLayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBox_seedLayout.Location = new System.Drawing.Point(3, 194);
            this.txtBox_seedLayout.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtBox_seedLayout.MaxLength = 260;
            this.txtBox_seedLayout.Name = "txtBox_seedLayout";
            this.txtBox_seedLayout.Size = new System.Drawing.Size(719, 20);
            this.txtBox_seedLayout.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioBtn_WBFS_Type, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioBtn_CISO_Type, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_outputISOType, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioBtn_ISO_Type, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 112);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(725, 32);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // radioBtn_WBFS_Type
            // 
            this.radioBtn_WBFS_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtn_WBFS_Type.Location = new System.Drawing.Point(253, 3);
            this.radioBtn_WBFS_Type.Name = "radioBtn_WBFS_Type";
            this.radioBtn_WBFS_Type.Size = new System.Drawing.Size(54, 26);
            this.radioBtn_WBFS_Type.TabIndex = 9;
            this.radioBtn_WBFS_Type.Text = "WBFS";
            this.radioBtn_WBFS_Type.CheckedChanged += new System.EventHandler(this.radioBtn_WBFS_Type_CheckedChanged);
            // 
            // radioBtn_CISO_Type
            // 
            this.radioBtn_CISO_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtn_CISO_Type.Location = new System.Drawing.Point(193, 3);
            this.radioBtn_CISO_Type.Name = "radioBtn_CISO_Type";
            this.radioBtn_CISO_Type.Size = new System.Drawing.Size(54, 26);
            this.radioBtn_CISO_Type.TabIndex = 8;
            this.radioBtn_CISO_Type.Text = "CISO";
            this.radioBtn_CISO_Type.CheckedChanged += new System.EventHandler(this.radioBtn_CISO_Type_CheckedChanged);
            // 
            // lbl_outputISOType
            // 
            this.lbl_outputISOType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_outputISOType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outputISOType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_outputISOType.Location = new System.Drawing.Point(3, 0);
            this.lbl_outputISOType.Name = "lbl_outputISOType";
            this.lbl_outputISOType.Size = new System.Drawing.Size(124, 32);
            this.lbl_outputISOType.TabIndex = 6;
            this.lbl_outputISOType.Text = "Output Type :";
            this.lbl_outputISOType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioBtn_ISO_Type
            // 
            this.radioBtn_ISO_Type.Checked = true;
            this.radioBtn_ISO_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioBtn_ISO_Type.Location = new System.Drawing.Point(133, 3);
            this.radioBtn_ISO_Type.Name = "radioBtn_ISO_Type";
            this.radioBtn_ISO_Type.Size = new System.Drawing.Size(54, 26);
            this.radioBtn_ISO_Type.TabIndex = 7;
            this.radioBtn_ISO_Type.TabStop = true;
            this.radioBtn_ISO_Type.Text = "ISO";
            this.radioBtn_ISO_Type.CheckedChanged += new System.EventHandler(this.radioBtn_ISO_Type_CheckedChanged);
            // 
            // lbl_settings
            // 
            this.lbl_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_settings.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_settings.Location = new System.Drawing.Point(3, 220);
            this.lbl_settings.Name = "lbl_settings";
            this.lbl_settings.Size = new System.Drawing.Size(719, 32);
            this.lbl_settings.TabIndex = 10;
            this.lbl_settings.Text = "Settings :";
            this.lbl_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chkBox_hyperHints, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.chkBox_randomWeldingColors, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_startingItems, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_startingItems, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_startingLocation, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox_startingLocation, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkBox_randomDoorColors, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkBox_fastShipFlying, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 252);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(725, 141);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // chkBox_hyperHints
            // 
            this.chkBox_hyperHints.AutoSize = true;
            this.chkBox_hyperHints.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_hyperHints.Location = new System.Drawing.Point(372, 108);
            this.chkBox_hyperHints.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.chkBox_hyperHints.Name = "chkBox_hyperHints";
            this.chkBox_hyperHints.Size = new System.Drawing.Size(126, 26);
            this.chkBox_hyperHints.TabIndex = 17;
            this.chkBox_hyperHints.Text = "Hyper Hints";
            // 
            // chkBox_randomWeldingColors
            // 
            this.chkBox_randomWeldingColors.AutoSize = true;
            this.chkBox_randomWeldingColors.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_randomWeldingColors.Location = new System.Drawing.Point(372, 73);
            this.chkBox_randomWeldingColors.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.chkBox_randomWeldingColors.Name = "chkBox_randomWeldingColors";
            this.chkBox_randomWeldingColors.Size = new System.Drawing.Size(227, 26);
            this.chkBox_randomWeldingColors.TabIndex = 16;
            this.chkBox_randomWeldingColors.Text = "Random welding colors";
            // 
            // comboBox_startingItems
            // 
            this.comboBox_startingItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_startingItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_startingItems.FormattingEnabled = true;
            this.comboBox_startingItems.Items.AddRange(new object[] {
            "default",
            "default-with-command",
            "post-norion",
            "post-norion-no-lasso",
            "post-norion-no-command",
            "post-norion-no-lasso-no-command",
            "minimal"});
            this.comboBox_startingItems.Location = new System.Drawing.Point(365, 41);
            this.comboBox_startingItems.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.comboBox_startingItems.Name = "comboBox_startingItems";
            this.comboBox_startingItems.Size = new System.Drawing.Size(357, 21);
            this.comboBox_startingItems.TabIndex = 14;
            // 
            // lbl_startingItems
            // 
            this.lbl_startingItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_startingItems.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startingItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_startingItems.Location = new System.Drawing.Point(3, 35);
            this.lbl_startingItems.Name = "lbl_startingItems";
            this.lbl_startingItems.Size = new System.Drawing.Size(356, 35);
            this.lbl_startingItems.TabIndex = 13;
            this.lbl_startingItems.Text = "Starting Items :";
            this.lbl_startingItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_startingLocation
            // 
            this.lbl_startingLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_startingLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startingLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_startingLocation.Location = new System.Drawing.Point(3, 0);
            this.lbl_startingLocation.Name = "lbl_startingLocation";
            this.lbl_startingLocation.Size = new System.Drawing.Size(356, 35);
            this.lbl_startingLocation.TabIndex = 11;
            this.lbl_startingLocation.Text = "Starting Location :";
            this.lbl_startingLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_startingLocation
            // 
            this.comboBox_startingLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_startingLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_startingLocation.FormattingEnabled = true;
            this.comboBox_startingLocation.Items.AddRange(new object[] {
            "default",
            "norion",
            "valhalla"});
            this.comboBox_startingLocation.Location = new System.Drawing.Point(365, 6);
            this.comboBox_startingLocation.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.comboBox_startingLocation.Name = "comboBox_startingLocation";
            this.comboBox_startingLocation.Size = new System.Drawing.Size(357, 21);
            this.comboBox_startingLocation.TabIndex = 12;
            // 
            // chkBox_randomDoorColors
            // 
            this.chkBox_randomDoorColors.AutoSize = true;
            this.chkBox_randomDoorColors.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_randomDoorColors.Location = new System.Drawing.Point(10, 73);
            this.chkBox_randomDoorColors.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.chkBox_randomDoorColors.Name = "chkBox_randomDoorColors";
            this.chkBox_randomDoorColors.Size = new System.Drawing.Size(202, 26);
            this.chkBox_randomDoorColors.TabIndex = 15;
            this.chkBox_randomDoorColors.Text = "Random door colors";
            // 
            // chkBox_fastShipFlying
            // 
            this.chkBox_fastShipFlying.AutoSize = true;
            this.chkBox_fastShipFlying.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBox_fastShipFlying.Location = new System.Drawing.Point(10, 108);
            this.chkBox_fastShipFlying.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.chkBox_fastShipFlying.Name = "chkBox_fastShipFlying";
            this.chkBox_fastShipFlying.Size = new System.Drawing.Size(155, 26);
            this.chkBox_fastShipFlying.TabIndex = 18;
            this.chkBox_fastShipFlying.Text = "Fast ship flying";
            // 
            // btn_generate
            // 
            this.btn_generate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_generate.Location = new System.Drawing.Point(3, 396);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Padding = new System.Windows.Forms.Padding(5);
            this.btn_generate.Size = new System.Drawing.Size(719, 26);
            this.btn_generate.TabIndex = 12;
            this.btn_generate.Text = "Generate";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.AutoSize = false;
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 488);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(800, 28);
            this.darkStatusStrip1.SizingGrip = false;
            this.darkStatusStrip1.TabIndex = 3;
            this.darkStatusStrip1.Text = "darkStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 15);
            this.toolStripStatusLabel1.Text = "Status : Idle";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(480, 14);
            this.toolStripProgressBar1.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(764, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(5);
            this.btn_exit.Size = new System.Drawing.Size(24, 24);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "X";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.darkStatusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_appTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MP3 Randomizer GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.darkStatusStrip1.ResumeLayout(false);
            this.darkStatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_appTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private DarkUI.Controls.DarkLabel lbl_inputISO;
        private DarkUI.Controls.DarkButton btn_inputISO;
        private DarkUI.Controls.DarkTextBox txtBox_inputISO;
        private DarkUI.Controls.DarkTextBox txtBox_outputPath;
        private DarkUI.Controls.DarkButton btn_outputISO;
        private DarkUI.Controls.DarkLabel lbl_outputISO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private DarkUI.Controls.DarkButton btn_exit;
        private DarkUI.Controls.DarkLabel lbl_seedLayout;
        private DarkUI.Controls.DarkTextBox txtBox_seedLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DarkUI.Controls.DarkLabel lbl_outputISOType;
        private DarkUI.Controls.DarkRadioButton radioBtn_WBFS_Type;
        private DarkUI.Controls.DarkRadioButton radioBtn_CISO_Type;
        private DarkUI.Controls.DarkRadioButton radioBtn_ISO_Type;
        private DarkUI.Controls.DarkLabel lbl_settings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DarkUI.Controls.DarkComboBox comboBox_startingItems;
        private DarkUI.Controls.DarkLabel lbl_startingItems;
        private DarkUI.Controls.DarkLabel lbl_startingLocation;
        private DarkUI.Controls.DarkComboBox comboBox_startingLocation;
        private DarkUI.Controls.DarkCheckBox chkBox_randomWeldingColors;
        private DarkUI.Controls.DarkCheckBox chkBox_randomDoorColors;
        private DarkUI.Controls.DarkButton btn_generate;
        private DarkUI.Controls.DarkCheckBox chkBox_hyperHints;
        private DarkUI.Controls.DarkCheckBox chkBox_fastShipFlying;
    }
}


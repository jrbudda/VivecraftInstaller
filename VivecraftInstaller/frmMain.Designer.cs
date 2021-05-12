namespace VivecraftInstaller
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.chkPath = new System.Windows.Forms.CheckBox();
            this.chkProfile = new System.Windows.Forms.CheckBox();
            this.chkadvanced = new System.Windows.Forms.CheckBox();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRAM = new System.Windows.Forms.ComboBox();
            this.btnModDir = new System.Windows.Forms.Button();
            this.txtModDir = new System.Windows.Forms.TextBox();
            this.chkZGC = new System.Windows.Forms.CheckBox();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.chkModDir = new System.Windows.Forms.CheckBox();
            this.chkProfileName = new System.Windows.Forms.CheckBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.chkForge = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.txtForgeVersion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlAdvanced = new System.Windows.Forms.Panel();
            this.grpAdvanced = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkKiosk = new System.Windows.Forms.CheckBox();
            this.chkKatVR = new System.Windows.Forms.CheckBox();
            this.pnlProfileOpt = new System.Windows.Forms.Panel();
            this.pnlForgeOpt = new System.Windows.Forms.Panel();
            this.grpForge = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.grpPath = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlVersion = new System.Windows.Forms.Panel();
            this.lblVersionDetails = new System.Windows.Forms.Label();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.optNonVR = new System.Windows.Forms.RadioButton();
            this.optVR = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlAdvanced.SuspendLayout();
            this.grpAdvanced.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlProfileOpt.SuspendLayout();
            this.pnlForgeOpt.SuspendLayout();
            this.grpForge.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlCustom.SuspendLayout();
            this.grpPath.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.pnlVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VivecraftInstaller.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 239);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnInstall);
            this.groupBox2.Location = new System.Drawing.Point(299, -2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(187, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(15, 16);
            this.btnInstall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkPath
            // 
            this.chkPath.AutoSize = true;
            this.chkPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkPath.Location = new System.Drawing.Point(0, 0);
            this.chkPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPath.Name = "chkPath";
            this.chkPath.Size = new System.Drawing.Size(491, 21);
            this.chkPath.TabIndex = 0;
            this.chkPath.Text = "Custom Path To Minecraft (For MultiMC or Non-standard installs)";
            this.chkPath.UseVisualStyleBackColor = true;
            this.chkPath.CheckedChanged += new System.EventHandler(this.chkPath_CheckedChanged);
            // 
            // chkProfile
            // 
            this.chkProfile.AutoSize = true;
            this.chkProfile.Checked = true;
            this.chkProfile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkProfile.Location = new System.Drawing.Point(0, 0);
            this.chkProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkProfile.Name = "chkProfile";
            this.chkProfile.Size = new System.Drawing.Size(491, 21);
            this.chkProfile.TabIndex = 1;
            this.chkProfile.Text = "Create Launcher Profile";
            this.toolTip1.SetToolTip(this.chkProfile, "Create or update a profile in the Minecraft Launcher");
            this.chkProfile.UseVisualStyleBackColor = true;
            this.chkProfile.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkadvanced
            // 
            this.chkadvanced.AutoSize = true;
            this.chkadvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkadvanced.Location = new System.Drawing.Point(0, 0);
            this.chkadvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkadvanced.Name = "chkadvanced";
            this.chkadvanced.Size = new System.Drawing.Size(491, 21);
            this.chkadvanced.TabIndex = 2;
            this.chkadvanced.Text = "Advanced";
            this.chkadvanced.UseVisualStyleBackColor = true;
            this.chkadvanced.CheckedChanged += new System.EventHandler(this.chkadvanced_CheckedChanged);
            // 
            // grpProfile
            // 
            this.grpProfile.AutoSize = true;
            this.grpProfile.Controls.Add(this.button1);
            this.grpProfile.Controls.Add(this.textBox1);
            this.grpProfile.Controls.Add(this.checkBox1);
            this.grpProfile.Controls.Add(this.label1);
            this.grpProfile.Controls.Add(this.cmbRAM);
            this.grpProfile.Controls.Add(this.btnModDir);
            this.grpProfile.Controls.Add(this.txtModDir);
            this.grpProfile.Controls.Add(this.chkZGC);
            this.grpProfile.Controls.Add(this.txtProfileName);
            this.grpProfile.Controls.Add(this.chkModDir);
            this.grpProfile.Controls.Add(this.chkProfileName);
            this.grpProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpProfile.Location = new System.Drawing.Point(0, 21);
            this.grpProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProfile.Size = new System.Drawing.Size(491, 157);
            this.grpProfile.TabIndex = 2;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Profile Options";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(455, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.toolTip1.SetToolTip(this.button1, "Select Java Runtime...");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(153, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(296, 22);
            this.textBox1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBox1, "Path to Java Runtime");
            this.textBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 117);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Custom Java";
            this.toolTip1.SetToolTip(this.checkBox1, "Check to use a custom Java version for this profile. Required for ZGC.");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "RAM Allocation (GB)";
            // 
            // cmbRAM
            // 
            this.cmbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "8"});
            this.cmbRAM.Location = new System.Drawing.Point(153, 81);
            this.cmbRAM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(47, 24);
            this.cmbRAM.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cmbRAM, "The RAM allocation for the profile. Using more does not increase performance. 2 G" +
        "b is recommened except when using modpacks.");
            // 
            // btnModDir
            // 
            this.btnModDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModDir.Location = new System.Drawing.Point(455, 49);
            this.btnModDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModDir.Name = "btnModDir";
            this.btnModDir.Size = new System.Drawing.Size(29, 23);
            this.btnModDir.TabIndex = 6;
            this.btnModDir.Text = "...";
            this.btnModDir.UseVisualStyleBackColor = true;
            this.btnModDir.Visible = false;
            this.btnModDir.Click += new System.EventHandler(this.btnModDir_Click);
            // 
            // txtModDir
            // 
            this.txtModDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModDir.Location = new System.Drawing.Point(165, 49);
            this.txtModDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModDir.Name = "txtModDir";
            this.txtModDir.ReadOnly = true;
            this.txtModDir.Size = new System.Drawing.Size(284, 22);
            this.txtModDir.TabIndex = 5;
            this.txtModDir.Visible = false;
            // 
            // chkZGC
            // 
            this.chkZGC.AutoSize = true;
            this.chkZGC.Location = new System.Drawing.Point(231, 84);
            this.chkZGC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkZGC.Name = "chkZGC";
            this.chkZGC.Size = new System.Drawing.Size(179, 21);
            this.chkZGC.TabIndex = 3;
            this.chkZGC.Text = "Enable ZGC (Java 14+)";
            this.toolTip1.SetToolTip(this.chkZGC, "Enable the Java14+ Zero Garbage Collector using the profile args.");
            this.chkZGC.UseVisualStyleBackColor = true;
            this.chkZGC.CheckedChanged += new System.EventHandler(this.chkZGC_CheckedChanged);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfileName.Enabled = false;
            this.txtProfileName.Location = new System.Drawing.Point(188, 18);
            this.txtProfileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(297, 22);
            this.txtProfileName.TabIndex = 4;
            // 
            // chkModDir
            // 
            this.chkModDir.AutoSize = true;
            this.chkModDir.Location = new System.Drawing.Point(11, 52);
            this.chkModDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkModDir.Name = "chkModDir";
            this.chkModDir.Size = new System.Drawing.Size(148, 21);
            this.chkModDir.TabIndex = 3;
            this.chkModDir.Text = "Modpack Directory";
            this.toolTip1.SetToolTip(this.chkModDir, "Check to add a \'Game Directory\' to the profile for modpack support.");
            this.chkModDir.UseVisualStyleBackColor = true;
            this.chkModDir.CheckedChanged += new System.EventHandler(this.chkModDir_CheckedChanged);
            // 
            // chkProfileName
            // 
            this.chkProfileName.AutoSize = true;
            this.chkProfileName.Location = new System.Drawing.Point(11, 21);
            this.chkProfileName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkProfileName.Name = "chkProfileName";
            this.chkProfileName.Size = new System.Drawing.Size(162, 21);
            this.chkProfileName.TabIndex = 2;
            this.chkProfileName.Text = "Custom Profile Name";
            this.toolTip1.SetToolTip(this.chkProfileName, "Check to give the profile a custom name");
            this.chkProfileName.UseVisualStyleBackColor = true;
            this.chkProfileName.CheckedChanged += new System.EventHandler(this.chkProfileName_CheckedChanged);
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Location = new System.Drawing.Point(3, 2);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(431, 22);
            this.txtTarget.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(440, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkForge
            // 
            this.chkForge.AutoSize = true;
            this.chkForge.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkForge.Location = new System.Drawing.Point(0, 0);
            this.chkForge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkForge.Name = "chkForge";
            this.chkForge.Size = new System.Drawing.Size(491, 21);
            this.chkForge.TabIndex = 8;
            this.chkForge.Text = "Install Vivecraft With Forge (Mod Support)";
            this.chkForge.UseVisualStyleBackColor = true;
            this.chkForge.CheckedChanged += new System.EventHandler(this.chkForge_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 2);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(170, 21);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Custom Forge Version";
            this.toolTip1.SetToolTip(this.checkBox7, "Check this if a custom Forge version is specified. Note that using a version othe" +
        "r than the tested version may not function.");
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // txtForgeVersion
            // 
            this.txtForgeVersion.Location = new System.Drawing.Point(179, 2);
            this.txtForgeVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForgeVersion.Name = "txtForgeVersion";
            this.txtForgeVersion.ReadOnly = true;
            this.txtForgeVersion.Size = new System.Drawing.Size(100, 22);
            this.txtForgeVersion.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlButtons, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.pnlAdvanced, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pnlProfileOpt, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlForgeOpt, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pnlCustom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlVersion, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 269);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 569);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoSize = true;
            this.pnlButtons.Controls.Add(this.linkLabel2);
            this.pnlButtons.Controls.Add(this.groupBox2);
            this.pnlButtons.Controls.Add(this.linkLabel1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(7, 500);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(493, 46);
            this.pnlButtons.TabIndex = 6;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(0, 28);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(117, 17);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Support Vivecraft";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(0, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vivecraft Homepage";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlAdvanced
            // 
            this.pnlAdvanced.AutoSize = true;
            this.pnlAdvanced.Controls.Add(this.grpAdvanced);
            this.pnlAdvanced.Controls.Add(this.chkadvanced);
            this.pnlAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdvanced.Location = new System.Drawing.Point(8, 429);
            this.pnlAdvanced.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdvanced.Name = "pnlAdvanced";
            this.pnlAdvanced.Size = new System.Drawing.Size(491, 65);
            this.pnlAdvanced.TabIndex = 6;
            // 
            // grpAdvanced
            // 
            this.grpAdvanced.AutoSize = true;
            this.grpAdvanced.Controls.Add(this.flowLayoutPanel1);
            this.grpAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAdvanced.Location = new System.Drawing.Point(0, 21);
            this.grpAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAdvanced.Name = "grpAdvanced";
            this.grpAdvanced.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAdvanced.Size = new System.Drawing.Size(491, 44);
            this.grpAdvanced.TabIndex = 3;
            this.grpAdvanced.TabStop = false;
            this.grpAdvanced.Text = "Advanced Options";
            this.grpAdvanced.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.chkKiosk);
            this.flowLayoutPanel1.Controls.Add(this.chkKatVR);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(485, 25);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkKiosk
            // 
            this.chkKiosk.AutoSize = true;
            this.chkKiosk.Location = new System.Drawing.Point(3, 2);
            this.chkKiosk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkKiosk.Name = "chkKiosk";
            this.chkKiosk.Size = new System.Drawing.Size(103, 21);
            this.chkKiosk.TabIndex = 4;
            this.chkKiosk.Text = "Kiosk Mode";
            this.toolTip1.SetToolTip(this.chkKiosk, "Check to disable controller inputs for this profile");
            this.chkKiosk.UseVisualStyleBackColor = true;
            // 
            // chkKatVR
            // 
            this.chkKatVR.AutoSize = true;
            this.chkKatVR.Location = new System.Drawing.Point(112, 2);
            this.chkKatVR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkKatVR.Name = "chkKatVR";
            this.chkKatVR.Size = new System.Drawing.Size(180, 21);
            this.chkKatVR.TabIndex = 5;
            this.chkKatVR.Text = "KATVR Treadmill Driver";
            this.toolTip1.SetToolTip(this.chkKatVR, "Check to install and activate the KATVR treadmill driver for this profile");
            this.chkKatVR.UseVisualStyleBackColor = true;
            // 
            // pnlProfileOpt
            // 
            this.pnlProfileOpt.AutoSize = true;
            this.pnlProfileOpt.Controls.Add(this.grpProfile);
            this.pnlProfileOpt.Controls.Add(this.chkProfile);
            this.pnlProfileOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfileOpt.Location = new System.Drawing.Point(8, 169);
            this.pnlProfileOpt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProfileOpt.Name = "pnlProfileOpt";
            this.pnlProfileOpt.Size = new System.Drawing.Size(491, 178);
            this.pnlProfileOpt.TabIndex = 4;
            // 
            // pnlForgeOpt
            // 
            this.pnlForgeOpt.AutoSize = true;
            this.pnlForgeOpt.Controls.Add(this.grpForge);
            this.pnlForgeOpt.Controls.Add(this.chkForge);
            this.pnlForgeOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForgeOpt.Location = new System.Drawing.Point(8, 355);
            this.pnlForgeOpt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlForgeOpt.Name = "pnlForgeOpt";
            this.pnlForgeOpt.Size = new System.Drawing.Size(491, 66);
            this.pnlForgeOpt.TabIndex = 2;
            // 
            // grpForge
            // 
            this.grpForge.AutoSize = true;
            this.grpForge.Controls.Add(this.flowLayoutPanel2);
            this.grpForge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpForge.Location = new System.Drawing.Point(0, 21);
            this.grpForge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpForge.Name = "grpForge";
            this.grpForge.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpForge.Size = new System.Drawing.Size(491, 45);
            this.grpForge.TabIndex = 9;
            this.grpForge.TabStop = false;
            this.grpForge.Text = "Forge Options";
            this.grpForge.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.checkBox7);
            this.flowLayoutPanel2.Controls.Add(this.txtForgeVersion);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(485, 26);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // pnlCustom
            // 
            this.pnlCustom.AutoSize = true;
            this.pnlCustom.Controls.Add(this.grpPath);
            this.pnlCustom.Controls.Add(this.chkPath);
            this.pnlCustom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustom.Location = new System.Drawing.Point(8, 94);
            this.pnlCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(491, 67);
            this.pnlCustom.TabIndex = 0;
            // 
            // grpPath
            // 
            this.grpPath.AutoSize = true;
            this.grpPath.Controls.Add(this.flowLayoutPanel3);
            this.grpPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPath.Location = new System.Drawing.Point(0, 21);
            this.grpPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPath.Name = "grpPath";
            this.grpPath.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPath.Size = new System.Drawing.Size(491, 46);
            this.grpPath.TabIndex = 10;
            this.grpPath.TabStop = false;
            this.grpPath.Text = "Path Options";
            this.grpPath.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.txtTarget);
            this.flowLayoutPanel3.Controls.Add(this.button4);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(485, 27);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // pnlVersion
            // 
            this.pnlVersion.AutoSize = true;
            this.pnlVersion.Controls.Add(this.lblVersionDetails);
            this.pnlVersion.Controls.Add(this.cmbVersion);
            this.pnlVersion.Controls.Add(this.optNonVR);
            this.pnlVersion.Controls.Add(this.optVR);
            this.pnlVersion.Controls.Add(this.label2);
            this.pnlVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVersion.Location = new System.Drawing.Point(8, 8);
            this.pnlVersion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlVersion.Name = "pnlVersion";
            this.pnlVersion.Size = new System.Drawing.Size(491, 78);
            this.pnlVersion.TabIndex = 8;
            // 
            // lblVersionDetails
            // 
            this.lblVersionDetails.AutoSize = true;
            this.lblVersionDetails.Location = new System.Drawing.Point(167, 57);
            this.lblVersionDetails.Name = "lblVersionDetails";
            this.lblVersionDetails.Size = new System.Drawing.Size(0, 17);
            this.lblVersionDetails.TabIndex = 13;
            // 
            // cmbVersion
            // 
            this.cmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Location = new System.Drawing.Point(13, 52);
            this.cmbVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(136, 24);
            this.cmbVersion.TabIndex = 12;
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // optNonVR
            // 
            this.optNonVR.AutoSize = true;
            this.optNonVR.Location = new System.Drawing.Point(141, 25);
            this.optNonVR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optNonVR.Name = "optNonVR";
            this.optNonVR.Size = new System.Drawing.Size(79, 21);
            this.optNonVR.TabIndex = 11;
            this.optNonVR.Text = "Non-VR";
            this.toolTip1.SetToolTip(this.optNonVR, "Non-VR vivecraft is for 2D desktop players to see VR animations and host LAN game" +
        "s.");
            this.optNonVR.UseVisualStyleBackColor = true;
            this.optNonVR.CheckedChanged += new System.EventHandler(this.optNonVR_CheckedChanged);
            // 
            // optVR
            // 
            this.optVR.AutoSize = true;
            this.optVR.Checked = true;
            this.optVR.Location = new System.Drawing.Point(13, 25);
            this.optVR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optVR.Name = "optVR";
            this.optVR.Size = new System.Drawing.Size(121, 21);
            this.optVR.TabIndex = 10;
            this.optVR.TabStop = true;
            this.optVR.Text = "VR (SteamVR)";
            this.toolTip1.SetToolTip(this.optVR, "The VR mod using SteamVR runtime.");
            this.optVR.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select VR type and Minecraft Version";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Virtual Reality for Minecraft: Java Edition";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 838);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vivecraft Installer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlAdvanced.ResumeLayout(false);
            this.pnlAdvanced.PerformLayout();
            this.grpAdvanced.ResumeLayout(false);
            this.grpAdvanced.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlProfileOpt.ResumeLayout(false);
            this.pnlProfileOpt.PerformLayout();
            this.pnlForgeOpt.ResumeLayout(false);
            this.pnlForgeOpt.PerformLayout();
            this.grpForge.ResumeLayout(false);
            this.grpForge.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.pnlCustom.ResumeLayout(false);
            this.pnlCustom.PerformLayout();
            this.grpPath.ResumeLayout(false);
            this.grpPath.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.pnlVersion.ResumeLayout(false);
            this.pnlVersion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.CheckBox chkPath;
        private System.Windows.Forms.CheckBox chkProfile;
        private System.Windows.Forms.CheckBox chkadvanced;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRAM;
        private System.Windows.Forms.Button btnModDir;
        private System.Windows.Forms.TextBox txtModDir;
        private System.Windows.Forms.CheckBox chkZGC;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.CheckBox chkModDir;
        private System.Windows.Forms.CheckBox chkProfileName;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox chkForge;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.TextBox txtForgeVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkKatVR;
        private System.Windows.Forms.CheckBox chkKiosk;
        private System.Windows.Forms.Panel pnlAdvanced;
        private System.Windows.Forms.Panel pnlProfileOpt;
        private System.Windows.Forms.Panel pnlForgeOpt;
        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel pnlVersion;
        private System.Windows.Forms.Label lblVersionDetails;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.RadioButton optNonVR;
        private System.Windows.Forms.RadioButton optVR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAdvanced;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox grpForge;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox grpPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


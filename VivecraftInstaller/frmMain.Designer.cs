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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkPath = new System.Windows.Forms.CheckBox();
            this.chkProfile = new System.Windows.Forms.CheckBox();
            this.chkadvanced = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAdvanced = new System.Windows.Forms.Panel();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlForge = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlPath = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlAdvanced.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlForge.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPath.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VivecraftInstaller.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(328, 677);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkPath
            // 
            this.chkPath.AutoSize = true;
            this.chkPath.Location = new System.Drawing.Point(7, 12);
            this.chkPath.Name = "chkPath";
            this.chkPath.Size = new System.Drawing.Size(436, 21);
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
            this.chkProfile.Location = new System.Drawing.Point(7, 9);
            this.chkProfile.Name = "chkProfile";
            this.chkProfile.Size = new System.Drawing.Size(180, 21);
            this.chkProfile.TabIndex = 1;
            this.chkProfile.Text = "Create Launcher Profile";
            this.chkProfile.UseVisualStyleBackColor = true;
            this.chkProfile.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkadvanced
            // 
            this.chkadvanced.AutoSize = true;
            this.chkadvanced.Location = new System.Drawing.Point(7, 7);
            this.chkadvanced.Name = "chkadvanced";
            this.chkadvanced.Size = new System.Drawing.Size(93, 21);
            this.chkadvanced.TabIndex = 2;
            this.chkadvanced.Text = "Advanced";
            this.chkadvanced.UseVisualStyleBackColor = true;
            this.chkadvanced.CheckedChanged += new System.EventHandler(this.chkadvanced_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbRAM);
            this.groupBox3.Controls.Add(this.btnModDir);
            this.groupBox3.Controls.Add(this.txtModDir);
            this.groupBox3.Controls.Add(this.chkZGC);
            this.groupBox3.Controls.Add(this.txtProfileName);
            this.groupBox3.Controls.Add(this.chkModDir);
            this.groupBox3.Controls.Add(this.chkProfileName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Profile Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ram Allocation (GB)";
            // 
            // cmbRAM
            // 
            this.cmbRAM.FormattingEnabled = true;
            this.cmbRAM.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "8"});
            this.cmbRAM.Location = new System.Drawing.Point(153, 100);
            this.cmbRAM.Name = "cmbRAM";
            this.cmbRAM.Size = new System.Drawing.Size(37, 24);
            this.cmbRAM.TabIndex = 7;
            this.cmbRAM.Text = "4";
            // 
            // btnModDir
            // 
            this.btnModDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModDir.Location = new System.Drawing.Point(465, 45);
            this.btnModDir.Name = "btnModDir";
            this.btnModDir.Size = new System.Drawing.Size(30, 23);
            this.btnModDir.TabIndex = 6;
            this.btnModDir.Text = "...";
            this.btnModDir.UseVisualStyleBackColor = true;
            this.btnModDir.Visible = false;
            // 
            // txtModDir
            // 
            this.txtModDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModDir.Location = new System.Drawing.Point(165, 45);
            this.txtModDir.Name = "txtModDir";
            this.txtModDir.ReadOnly = true;
            this.txtModDir.Size = new System.Drawing.Size(294, 22);
            this.txtModDir.TabIndex = 5;
            this.txtModDir.Visible = false;
            // 
            // chkZGC
            // 
            this.chkZGC.AutoSize = true;
            this.chkZGC.Location = new System.Drawing.Point(11, 75);
            this.chkZGC.Name = "chkZGC";
            this.chkZGC.Size = new System.Drawing.Size(179, 21);
            this.chkZGC.TabIndex = 3;
            this.chkZGC.Text = "Enable ZGC (Java 14+)";
            this.chkZGC.UseVisualStyleBackColor = true;
            // 
            // txtProfileName
            // 
            this.txtProfileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProfileName.Enabled = false;
            this.txtProfileName.Location = new System.Drawing.Point(188, 19);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(307, 22);
            this.txtProfileName.TabIndex = 4;
            // 
            // chkModDir
            // 
            this.chkModDir.AutoSize = true;
            this.chkModDir.Location = new System.Drawing.Point(11, 48);
            this.chkModDir.Name = "chkModDir";
            this.chkModDir.Size = new System.Drawing.Size(148, 21);
            this.chkModDir.TabIndex = 3;
            this.chkModDir.Text = "Modpack Directory";
            this.chkModDir.UseVisualStyleBackColor = true;
            this.chkModDir.CheckedChanged += new System.EventHandler(this.chkModDir_CheckedChanged);
            // 
            // chkProfileName
            // 
            this.chkProfileName.AutoSize = true;
            this.chkProfileName.Location = new System.Drawing.Point(11, 21);
            this.chkProfileName.Name = "chkProfileName";
            this.chkProfileName.Size = new System.Drawing.Size(162, 21);
            this.chkProfileName.TabIndex = 2;
            this.chkProfileName.Text = "Custom Profile Name";
            this.chkProfileName.UseVisualStyleBackColor = true;
            this.chkProfileName.CheckedChanged += new System.EventHandler(this.chkProfileName_CheckedChanged);
            // 
            // txtTarget
            // 
            this.txtTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTarget.Location = new System.Drawing.Point(39, 7);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.Size = new System.Drawing.Size(429, 22);
            this.txtTarget.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(474, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // chkForge
            // 
            this.chkForge.AutoSize = true;
            this.chkForge.Location = new System.Drawing.Point(3, 9);
            this.chkForge.Name = "chkForge";
            this.chkForge.Size = new System.Drawing.Size(198, 21);
            this.chkForge.TabIndex = 8;
            this.chkForge.Text = "Install Vivecraft With Forge";
            this.chkForge.UseVisualStyleBackColor = true;
            this.chkForge.CheckedChanged += new System.EventHandler(this.chkForge_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(39, 9);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(129, 21);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Custom Version";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlAdvanced, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pnlProfile, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pnlForge, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlPath, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 249);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 426);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlAdvanced
            // 
            this.pnlAdvanced.Controls.Add(this.checkBox10);
            this.pnlAdvanced.Controls.Add(this.checkBox9);
            this.pnlAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdvanced.Location = new System.Drawing.Point(0, 350);
            this.pnlAdvanced.Margin = new System.Windows.Forms.Padding(0);
            this.pnlAdvanced.Name = "pnlAdvanced";
            this.pnlAdvanced.Size = new System.Drawing.Size(507, 76);
            this.pnlAdvanced.TabIndex = 7;
            this.pnlAdvanced.Visible = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(36, 26);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(180, 21);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "KATVR Treadmill Driver";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(36, 3);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(103, 21);
            this.checkBox9.TabIndex = 4;
            this.checkBox9.Text = "Kiosk Mode";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.Controls.Add(this.chkadvanced);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 319);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(507, 31);
            this.panel7.TabIndex = 6;
            // 
            // pnlProfile
            // 
            this.pnlProfile.AutoSize = true;
            this.pnlProfile.Controls.Add(this.groupBox3);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProfile.Location = new System.Drawing.Point(3, 171);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(501, 145);
            this.pnlProfile.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.chkProfile);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 135);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(507, 33);
            this.panel5.TabIndex = 4;
            // 
            // pnlForge
            // 
            this.pnlForge.AutoSize = true;
            this.pnlForge.Controls.Add(this.textBox4);
            this.pnlForge.Controls.Add(this.checkBox7);
            this.pnlForge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForge.Location = new System.Drawing.Point(0, 102);
            this.pnlForge.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForge.Name = "pnlForge";
            this.pnlForge.Size = new System.Drawing.Size(507, 33);
            this.pnlForge.TabIndex = 3;
            this.pnlForge.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.chkForge);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 33);
            this.panel3.TabIndex = 2;
            // 
            // pnlPath
            // 
            this.pnlPath.AutoSize = true;
            this.pnlPath.Controls.Add(this.txtTarget);
            this.pnlPath.Controls.Add(this.button4);
            this.pnlPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPath.Location = new System.Drawing.Point(0, 36);
            this.pnlPath.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPath.Name = "pnlPath";
            this.pnlPath.Size = new System.Drawing.Size(507, 33);
            this.pnlPath.TabIndex = 1;
            this.pnlPath.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.chkPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 36);
            this.panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(4, 691);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(136, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Vivecraft Homepage";
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(4, 710);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(117, 17);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Support Vivecraft";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(526, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vivecraft Installer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlAdvanced.ResumeLayout(false);
            this.pnlAdvanced.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlForge.ResumeLayout(false);
            this.pnlForge.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlPath.ResumeLayout(false);
            this.pnlPath.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkPath;
        private System.Windows.Forms.CheckBox chkProfile;
        private System.Windows.Forms.CheckBox chkadvanced;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlAdvanced;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlForge;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}


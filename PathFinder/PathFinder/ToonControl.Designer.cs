// ***********************************************************************
// Assembly         : PathFinder
// Author           : xenonsmurf
// Created          : 03-16-2020
//
// Last Modified By : xenonsmurf
// Last Modified On : 04-12-2020
// ***********************************************************************
// <copyright file="ToonControl.Designer.cs" company="Xenonsmurf">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace PathFinder
{
    /// <summary>
    /// Class ToonControl.
    /// Implements the <see cref="System.Windows.Forms.UserControl" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    partial class ToonControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RunBtn = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.PointNametb = new System.Windows.Forms.TextBox();
            this.PointsComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadHitPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHitPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mapLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TSTB = new System.Windows.Forms.TextBox();
            this.MSTB = new System.Windows.Forms.TextBox();
            this.MCTB = new System.Windows.Forms.TextBox();
            this.ARTB = new System.Windows.Forms.TextBox();
            this.AHTB = new System.Windows.Forms.TextBox();
            this.CHTB = new System.Windows.Forms.TextBox();
            this.CSTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.DumpMeshes = new System.ComponentModel.BackgroundWorker();
            this.tabPage7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(792, 254);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Path Test To Points Of Interest";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.RunBtn);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.PointNametb);
            this.groupBox2.Controls.Add(this.PointsComboBox);
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 254);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 23);
            this.button6.TabIndex = 30;
            this.button6.Text = "Unload Mesh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(3, 159);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(154, 23);
            this.button15.TabIndex = 29;
            this.button15.Text = "Is navmesh enabled?";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(3, 130);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(154, 23);
            this.button14.TabIndex = 28;
            this.button14.Text = "Load Mesh file";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(327, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "hit start";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Select Point of interest";
            // 
            // RunBtn
            // 
            this.RunBtn.Location = new System.Drawing.Point(374, 80);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(75, 23);
            this.RunBtn.TabIndex = 15;
            this.RunBtn.Text = "Start";
            this.RunBtn.UseVisualStyleBackColor = true;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(454, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Point of interest name = ";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(314, 43);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 23);
            this.button13.TabIndex = 12;
            this.button13.Text = "Add Point of Interest";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // PointNametb
            // 
            this.PointNametb.Location = new System.Drawing.Point(133, 46);
            this.PointNametb.Name = "PointNametb";
            this.PointNametb.Size = new System.Drawing.Size(175, 20);
            this.PointNametb.TabIndex = 11;
            // 
            // PointsComboBox
            // 
            this.PointsComboBox.FormattingEnabled = true;
            this.PointsComboBox.Location = new System.Drawing.Point(125, 82);
            this.PointsComboBox.Name = "PointsComboBox";
            this.PointsComboBox.Size = new System.Drawing.Size(183, 21);
            this.PointsComboBox.TabIndex = 10;
            this.PointsComboBox.SelectedIndexChanged += new System.EventHandler(this.PointsComboBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadHitPointToolStripMenuItem,
            this.saveHitPointsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadHitPointToolStripMenuItem
            // 
            this.loadHitPointToolStripMenuItem.Name = "loadHitPointToolStripMenuItem";
            this.loadHitPointToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.loadHitPointToolStripMenuItem.Text = "Load Points of intrest";
            this.loadHitPointToolStripMenuItem.Click += new System.EventHandler(this.loadHitPointToolStripMenuItem_Click);
            // 
            // saveHitPointsToolStripMenuItem
            // 
            this.saveHitPointsToolStripMenuItem.Name = "saveHitPointsToolStripMenuItem";
            this.saveHitPointsToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.saveHitPointsToolStripMenuItem.Text = "Save Points of intrest";
            this.saveHitPointsToolStripMenuItem.Click += new System.EventHandler(this.saveHitPointsToolStripMenuItem_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(800, 280);
            this.tabControl2.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.mapLB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.menuStrip2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 254);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Dat";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(129, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "<-- Load zonelist.xml first.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(184, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "<-- Use this if you only want to dump selected file from the listbox";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Dump selected map.dat ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mapLB
            // 
            this.mapLB.FormattingEnabled = true;
            this.mapLB.Location = new System.Drawing.Point(7, 90);
            this.mapLB.Name = "mapLB";
            this.mapLB.Size = new System.Drawing.Size(171, 160);
            this.mapLB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(184, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "<-- This will take a few min and around 10gb of storage.  ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(786, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem1.Text = "Load Zones";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dump all map.dats ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TSTB);
            this.tabPage2.Controls.Add(this.MSTB);
            this.tabPage2.Controls.Add(this.MCTB);
            this.tabPage2.Controls.Add(this.ARTB);
            this.tabPage2.Controls.Add(this.AHTB);
            this.tabPage2.Controls.Add(this.CHTB);
            this.tabPage2.Controls.Add(this.CSTB);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 254);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "NavMesh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(273, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(504, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "<-- This will build and dump navmeshes for all obj files in the Map Collision obj" +
    " folder... this will take hours!! ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Start dumping all zone.obj file navmeshes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(398, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(213, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "<-- These are the default NavMesh Settings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(169, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(540, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "<-- Click to change NavMesh Settings to the above settings.  you don\'t need to do" +
    " this. just added it as an option.";
            // 
            // TSTB
            // 
            this.TSTB.Location = new System.Drawing.Point(321, 67);
            this.TSTB.MaxLength = 6;
            this.TSTB.Name = "TSTB";
            this.TSTB.Size = new System.Drawing.Size(46, 20);
            this.TSTB.TabIndex = 30;
            this.TSTB.Text = "48";
            this.TSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TSTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSTB_KeyPress);
            // 
            // MSTB
            // 
            this.MSTB.Location = new System.Drawing.Point(321, 41);
            this.MSTB.MaxLength = 6;
            this.MSTB.Name = "MSTB";
            this.MSTB.Size = new System.Drawing.Size(46, 20);
            this.MSTB.TabIndex = 29;
            this.MSTB.Text = "46";
            this.MSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MSTB_KeyPress);
            // 
            // MCTB
            // 
            this.MCTB.Location = new System.Drawing.Point(321, 15);
            this.MCTB.MaxLength = 6;
            this.MCTB.Name = "MCTB";
            this.MCTB.Size = new System.Drawing.Size(46, 20);
            this.MCTB.TabIndex = 28;
            this.MCTB.Text = "0.4";
            this.MCTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MCTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MCTB_KeyPress);
            // 
            // ARTB
            // 
            this.ARTB.Location = new System.Drawing.Point(102, 96);
            this.ARTB.MaxLength = 6;
            this.ARTB.Name = "ARTB";
            this.ARTB.Size = new System.Drawing.Size(46, 20);
            this.ARTB.TabIndex = 27;
            this.ARTB.Text = "0.6";
            this.ARTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ARTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ARTB_KeyPress);
            // 
            // AHTB
            // 
            this.AHTB.Location = new System.Drawing.Point(102, 70);
            this.AHTB.MaxLength = 6;
            this.AHTB.Name = "AHTB";
            this.AHTB.Size = new System.Drawing.Size(46, 20);
            this.AHTB.TabIndex = 26;
            this.AHTB.Text = "1.8";
            this.AHTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AHTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AHTB_KeyPress);
            // 
            // CHTB
            // 
            this.CHTB.Location = new System.Drawing.Point(102, 44);
            this.CHTB.MaxLength = 6;
            this.CHTB.Name = "CHTB";
            this.CHTB.Size = new System.Drawing.Size(46, 20);
            this.CHTB.TabIndex = 25;
            this.CHTB.Text = "0.075";
            this.CHTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CHTB_KeyPress);
            // 
            // CSTB
            // 
            this.CSTB.Location = new System.Drawing.Point(102, 18);
            this.CSTB.MaxLength = 6;
            this.CSTB.Name = "CSTB";
            this.CSTB.Size = new System.Drawing.Size(46, 20);
            this.CSTB.TabIndex = 24;
            this.CSTB.Text = "0.15";
            this.CSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CSTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CSTB_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "TileSize = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "MaxSlope = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "MaxClimb =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "AgentRadius = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "AgentHeight = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "CellHeight = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "CellSize = ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Change NavMesh Settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(285, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "<-- This will take a couple of min depending on size of zone.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Select an OBJ file to build and dump a NavMesh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rtbDebug
            // 
            this.rtbDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtbDebug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDebug.CausesValidation = false;
            this.rtbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDebug.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDebug.ForeColor = System.Drawing.Color.Yellow;
            this.rtbDebug.Location = new System.Drawing.Point(0, 280);
            this.rtbDebug.Margin = new System.Windows.Forms.Padding(4);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(800, 204);
            this.rtbDebug.TabIndex = 3;
            this.rtbDebug.Text = "";
            // 
            // DumpMeshes
            // 
            this.DumpMeshes.WorkerSupportsCancellation = true;
            this.DumpMeshes.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DumpMeshes_DoWork);
            this.DumpMeshes.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DumpMeshes_RunWorkerCompleted);
            // 
            // ToonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbDebug);
            this.Controls.Add(this.tabControl2);
            this.Name = "ToonControl";
            this.Size = new System.Drawing.Size(800, 484);
            this.tabPage7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// The timer
        /// </summary>
        public System.Windows.Forms.Timer timer;
        /// <summary>
        /// The tab page7
        /// </summary>
        public System.Windows.Forms.TabPage tabPage7;
        /// <summary>
        /// The group box2
        /// </summary>
        public System.Windows.Forms.GroupBox groupBox2;
        /// <summary>
        /// The points ComboBox
        /// </summary>
        public System.Windows.Forms.ComboBox PointsComboBox;
        /// <summary>
        /// The menu strip1
        /// </summary>
        public System.Windows.Forms.MenuStrip menuStrip1;
        /// <summary>
        /// The load hit point tool strip menu item
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem loadHitPointToolStripMenuItem;
        /// <summary>
        /// The save hit points tool strip menu item
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem saveHitPointsToolStripMenuItem;
        /// <summary>
        /// The tab control2
        /// </summary>
        public System.Windows.Forms.TabControl tabControl2;
        /// <summary>
        /// The label9
        /// </summary>
        public System.Windows.Forms.Label label9;
        /// <summary>
        /// The button13
        /// </summary>
        public System.Windows.Forms.Button button13;
        /// <summary>
        /// The point nametb
        /// </summary>
        public System.Windows.Forms.TextBox PointNametb;
        /// <summary>
        /// The button15
        /// </summary>
        public System.Windows.Forms.Button button15;
        /// <summary>
        /// The button14
        /// </summary>
        public System.Windows.Forms.Button button14;
        /// <summary>
        /// The button9
        /// </summary>
        public System.Windows.Forms.Button button9;
        /// <summary>
        /// The run BTN
        /// </summary>
        public System.Windows.Forms.Button RunBtn;
        /// <summary>
        /// The label14
        /// </summary>
        public System.Windows.Forms.Label label14;
        /// <summary>
        /// The label13
        /// </summary>
        public System.Windows.Forms.Label label13;
        /// <summary>
        /// The RTB debug
        /// </summary>
        public System.Windows.Forms.RichTextBox rtbDebug;
        /// <summary>
        /// The menu strip2
        /// </summary>
        public System.Windows.Forms.MenuStrip menuStrip2;
        /// <summary>
        /// The tool strip menu item1
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        /// <summary>
        /// The map lb
        /// </summary>
        public System.Windows.Forms.ListBox mapLB;
        /// <summary>
        /// The label1
        /// </summary>
        public System.Windows.Forms.Label label1;
        /// <summary>
        /// The tab page1
        /// </summary>
        public System.Windows.Forms.TabPage tabPage1;
        /// <summary>
        /// The button1
        /// </summary>
        public System.Windows.Forms.Button button1;
        /// <summary>
        /// The button2
        /// </summary>
        private System.Windows.Forms.Button button2;
        /// <summary>
        /// The label2
        /// </summary>
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ARTB;
        private System.Windows.Forms.TextBox AHTB;
        private System.Windows.Forms.TextBox CHTB;
        private System.Windows.Forms.TextBox CSTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TSTB;
        private System.Windows.Forms.TextBox MSTB;
        private System.Windows.Forms.TextBox MCTB;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label17;
        private System.ComponentModel.BackgroundWorker DumpMeshes;
        private System.Windows.Forms.Button button6;
    }
}

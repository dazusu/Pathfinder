// ***********************************************************************
// Assembly         : PathFinder
// Author           : xenonsmurf
// Created          : 03-16-2020
//
// Last Modified By : xenonsmurf
// Last Modified On : 07-04-2020
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DsM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DSD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.vPP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.EmE = new System.Windows.Forms.TextBox();
            this.CSTB = new System.Windows.Forms.TextBox();
            this.EMaxL = new System.Windows.Forms.TextBox();
            this.CHTB = new System.Windows.Forms.TextBox();
            this.RMS = new System.Windows.Forms.TextBox();
            this.AHTB = new System.Windows.Forms.TextBox();
            this.RMinS = new System.Windows.Forms.TextBox();
            this.ARTB = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.MCTB = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.MSTB = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TSTB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.button5);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DsM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DSD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.vPP);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.EmE);
            this.groupBox1.Controls.Add(this.CSTB);
            this.groupBox1.Controls.Add(this.EMaxL);
            this.groupBox1.Controls.Add(this.CHTB);
            this.groupBox1.Controls.Add(this.RMS);
            this.groupBox1.Controls.Add(this.AHTB);
            this.groupBox1.Controls.Add(this.RMinS);
            this.groupBox1.Controls.Add(this.ARTB);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.MCTB);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.MSTB);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.TSTB);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 177);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "These are the default settings i dumped meshes with";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "CellSize     = ";
            // 
            // DsM
            // 
            this.DsM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DsM.ForeColor = System.Drawing.Color.Black;
            this.DsM.Location = new System.Drawing.Point(667, 48);
            this.DsM.MaxLength = 6;
            this.DsM.Name = "DsM";
            this.DsM.Size = new System.Drawing.Size(46, 20);
            this.DsM.TabIndex = 48;
            this.DsM.Text = "1.0";
            this.DsM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "CellHeight = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(160, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(422, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "<< click this button to change the Navmesh settings,  the above settings are the " +
    "default.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(523, 49);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Detail Sample MaxError    = ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(9, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Change NavMesh Settings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(157, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "AgentHeight  = ";
            // 
            // DSD
            // 
            this.DSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSD.ForeColor = System.Drawing.Color.Black;
            this.DSD.Location = new System.Drawing.Point(667, 24);
            this.DSD.MaxLength = 6;
            this.DSD.Name = "DSD";
            this.DSD.Size = new System.Drawing.Size(46, 20);
            this.DSD.TabIndex = 46;
            this.DSD.Text = "6.0";
            this.DSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(158, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "AgentRadius = ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(523, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "Detail Sample Distance    = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(158, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "MaxClimb      =";
            // 
            // vPP
            // 
            this.vPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vPP.ForeColor = System.Drawing.Color.Black;
            this.vPP.Location = new System.Drawing.Point(457, 123);
            this.vPP.MaxLength = 6;
            this.vPP.Name = "vPP";
            this.vPP.Size = new System.Drawing.Size(46, 20);
            this.vPP.TabIndex = 44;
            this.vPP.Text = "6.0";
            this.vPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(160, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "MaxSlope    = ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(329, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Verts Per Poly        = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "TileSize     = ";
            // 
            // EmE
            // 
            this.EmE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmE.ForeColor = System.Drawing.Color.Black;
            this.EmE.Location = new System.Drawing.Point(457, 98);
            this.EmE.MaxLength = 6;
            this.EmE.Name = "EmE";
            this.EmE.Size = new System.Drawing.Size(46, 20);
            this.EmE.TabIndex = 42;
            this.EmE.Text = "1.3";
            this.EmE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CSTB
            // 
            this.CSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSTB.ForeColor = System.Drawing.Color.Black;
            this.CSTB.Location = new System.Drawing.Point(78, 23);
            this.CSTB.MaxLength = 6;
            this.CSTB.Name = "CSTB";
            this.CSTB.Size = new System.Drawing.Size(46, 20);
            this.CSTB.TabIndex = 24;
            this.CSTB.Text = "0.20";
            this.CSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CSTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CSTB_KeyPress);
            // 
            // EMaxL
            // 
            this.EMaxL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMaxL.ForeColor = System.Drawing.Color.Black;
            this.EMaxL.Location = new System.Drawing.Point(457, 74);
            this.EMaxL.MaxLength = 6;
            this.EMaxL.Name = "EMaxL";
            this.EMaxL.Size = new System.Drawing.Size(46, 20);
            this.EMaxL.TabIndex = 41;
            this.EMaxL.Text = "12.0";
            this.EMaxL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CHTB
            // 
            this.CHTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHTB.ForeColor = System.Drawing.Color.Black;
            this.CHTB.Location = new System.Drawing.Point(78, 49);
            this.CHTB.MaxLength = 6;
            this.CHTB.Name = "CHTB";
            this.CHTB.Size = new System.Drawing.Size(46, 20);
            this.CHTB.TabIndex = 25;
            this.CHTB.Text = "0.10";
            this.CHTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CHTB_KeyPress);
            // 
            // RMS
            // 
            this.RMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMS.ForeColor = System.Drawing.Color.Black;
            this.RMS.Location = new System.Drawing.Point(457, 49);
            this.RMS.MaxLength = 6;
            this.RMS.Name = "RMS";
            this.RMS.Size = new System.Drawing.Size(46, 20);
            this.RMS.TabIndex = 40;
            this.RMS.Text = "20";
            this.RMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AHTB
            // 
            this.AHTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AHTB.ForeColor = System.Drawing.Color.Black;
            this.AHTB.Location = new System.Drawing.Point(244, 23);
            this.AHTB.MaxLength = 6;
            this.AHTB.Name = "AHTB";
            this.AHTB.Size = new System.Drawing.Size(46, 20);
            this.AHTB.TabIndex = 26;
            this.AHTB.Text = "1.8";
            this.AHTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AHTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AHTB_KeyPress);
            // 
            // RMinS
            // 
            this.RMinS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMinS.ForeColor = System.Drawing.Color.Black;
            this.RMinS.Location = new System.Drawing.Point(457, 23);
            this.RMinS.MaxLength = 6;
            this.RMinS.Name = "RMinS";
            this.RMinS.Size = new System.Drawing.Size(46, 20);
            this.RMinS.TabIndex = 39;
            this.RMinS.Text = "8";
            this.RMinS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ARTB
            // 
            this.ARTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARTB.ForeColor = System.Drawing.Color.Black;
            this.ARTB.Location = new System.Drawing.Point(244, 49);
            this.ARTB.MaxLength = 5;
            this.ARTB.Name = "ARTB";
            this.ARTB.Size = new System.Drawing.Size(46, 20);
            this.ARTB.TabIndex = 27;
            this.ARTB.Text = "0.7";
            this.ARTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ARTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ARTB_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(327, 102);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Edge MaxError          = ";
            // 
            // MCTB
            // 
            this.MCTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MCTB.ForeColor = System.Drawing.Color.Black;
            this.MCTB.Location = new System.Drawing.Point(244, 75);
            this.MCTB.MaxLength = 6;
            this.MCTB.Name = "MCTB";
            this.MCTB.Size = new System.Drawing.Size(46, 20);
            this.MCTB.TabIndex = 28;
            this.MCTB.Text = "0.5";
            this.MCTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MCTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MCTB_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(327, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Edge MaxLen           = ";
            // 
            // MSTB
            // 
            this.MSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSTB.ForeColor = System.Drawing.Color.Black;
            this.MSTB.Location = new System.Drawing.Point(244, 101);
            this.MSTB.MaxLength = 6;
            this.MSTB.Name = "MSTB";
            this.MSTB.Size = new System.Drawing.Size(46, 20);
            this.MSTB.TabIndex = 29;
            this.MSTB.Text = "46";
            this.MSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MSTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MSTB_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(327, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Region Merge Size   = ";
            // 
            // TSTB
            // 
            this.TSTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSTB.ForeColor = System.Drawing.Color.Black;
            this.TSTB.Location = new System.Drawing.Point(78, 75);
            this.TSTB.MaxLength = 6;
            this.TSTB.Name = "TSTB";
            this.TSTB.Size = new System.Drawing.Size(46, 20);
            this.TSTB.TabIndex = 30;
            this.TSTB.Text = "64";
            this.TSTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TSTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TSTB_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(327, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(114, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Region MinSize        = ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(264, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(504, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "<-- This will build and dump navmeshes for all obj files in the Map Collision obj" +
    " folder... this will take hours!! ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Start dumping all zone.obj file navmeshes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(285, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "<-- This will take a couple of min depending on size of zone.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 196);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        /// <summary>
        /// The tab page2
        /// </summary>
        private System.Windows.Forms.TabPage tabPage2;
        /// <summary>
        /// The button3
        /// </summary>
        private System.Windows.Forms.Button button3;
        /// <summary>
        /// The button4
        /// </summary>
        private System.Windows.Forms.Button button4;
        /// <summary>
        /// The label3
        /// </summary>
        public System.Windows.Forms.Label label3;
        /// <summary>
        /// The label6
        /// </summary>
        private System.Windows.Forms.Label label6;
        /// <summary>
        /// The label5
        /// </summary>
        private System.Windows.Forms.Label label5;
        /// <summary>
        /// The label4
        /// </summary>
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// The artb
        /// </summary>
        private System.Windows.Forms.TextBox ARTB;
        /// <summary>
        /// The ahtb
        /// </summary>
        private System.Windows.Forms.TextBox AHTB;
        /// <summary>
        /// The CHTB
        /// </summary>
        private System.Windows.Forms.TextBox CHTB;
        /// <summary>
        /// The CSTB
        /// </summary>
        private System.Windows.Forms.TextBox CSTB;
        /// <summary>
        /// The label11
        /// </summary>
        private System.Windows.Forms.Label label11;
        /// <summary>
        /// The label10
        /// </summary>
        private System.Windows.Forms.Label label10;
        /// <summary>
        /// The label8
        /// </summary>
        private System.Windows.Forms.Label label8;
        /// <summary>
        /// The label7
        /// </summary>
        private System.Windows.Forms.Label label7;
        /// <summary>
        /// The TSTB
        /// </summary>
        private System.Windows.Forms.TextBox TSTB;
        /// <summary>
        /// The MSTB
        /// </summary>
        private System.Windows.Forms.TextBox MSTB;
        /// <summary>
        /// The MCTB
        /// </summary>
        private System.Windows.Forms.TextBox MCTB;
        /// <summary>
        /// The label12
        /// </summary>
        public System.Windows.Forms.Label label12;
        /// <summary>
        /// The label16
        /// </summary>
        public System.Windows.Forms.Label label16;
        /// <summary>
        /// The button5
        /// </summary>
        private System.Windows.Forms.Button button5;
        /// <summary>
        /// The label17
        /// </summary>
        private System.Windows.Forms.Label label17;
        /// <summary>
        /// The dump meshes
        /// </summary>
        private System.ComponentModel.BackgroundWorker DumpMeshes;
        /// <summary>
        /// The button6
        /// </summary>
        private System.Windows.Forms.Button button6;
        /// <summary>
        /// The group box1
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;
        /// <summary>
        /// The ds m
        /// </summary>
        private System.Windows.Forms.TextBox DsM;
        /// <summary>
        /// The label23
        /// </summary>
        private System.Windows.Forms.Label label23;
        /// <summary>
        /// The DSD
        /// </summary>
        private System.Windows.Forms.TextBox DSD;
        /// <summary>
        /// The label22
        /// </summary>
        private System.Windows.Forms.Label label22;
        /// <summary>
        /// The v pp
        /// </summary>
        private System.Windows.Forms.TextBox vPP;
        /// <summary>
        /// The label15
        /// </summary>
        private System.Windows.Forms.Label label15;
        /// <summary>
        /// The em e
        /// </summary>
        private System.Windows.Forms.TextBox EmE;
        /// <summary>
        /// The e maximum l
        /// </summary>
        private System.Windows.Forms.TextBox EMaxL;
        /// <summary>
        /// The RMS
        /// </summary>
        private System.Windows.Forms.TextBox RMS;
        /// <summary>
        /// The r minimum s
        /// </summary>
        private System.Windows.Forms.TextBox RMinS;
        /// <summary>
        /// The label21
        /// </summary>
        private System.Windows.Forms.Label label21;
        /// <summary>
        /// The label20
        /// </summary>
        private System.Windows.Forms.Label label20;
        /// <summary>
        /// The label19
        /// </summary>
        private System.Windows.Forms.Label label19;
        /// <summary>
        /// The label18
        /// </summary>
        private System.Windows.Forms.Label label18;
    }
}

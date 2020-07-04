// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created :
// 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020
//
// Last Modified By : xenonsmurf Last Modified On : 04-04-2020 Last Modified On : 04-12-2020
// *********************************************************************** Last Modified On :
// 07-04-2020 ***********************************************************************
// <copyright file="ToonControl.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************
using EliteMMO.API;
using PathFinder.Characters;
using PathFinder.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace PathFinder
{
    /// <summary>
    /// Class ToonControl. Implements the <see cref="System.Windows.Forms.UserControl"/>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl"/>
    public partial class ToonControl : UserControl
    {
        /// <summary>
        /// Gets or sets the character.
        /// </summary>
        /// <value>The character.</value>
        public Character Character { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToonControl"/> class.
        /// </summary>
        /// <param name="mf">The mf.</param>
        /// <param name="chars">The chars.</param>
        /// <param name="api">The API.</param>
        public ToonControl(MainForm mf, Dictionary<string, EliteAPI> chars, EliteAPI api)
        {
            InitializeComponent();
            Character = new Character(mf.Logger, this, chars, api);
        }

        /// <summary>
        /// Handles the TextChanged event of the rtbDebug control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rtbDebug_TextChanged(object sender, EventArgs e)
        {
            rtbDebug.SelectionStart = rtbDebug.Text.Length;
            rtbDebug.ScrollToCaret();
        }

        /// <summary>
        /// Gets or sets the selected point.
        /// </summary>
        /// <value>The selected point.</value>
        public string SelectedPoint { get; set; }

        /// <summary>
        /// Handles the Click event of the button13 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button13_Click(object sender, EventArgs e)
        {
            Character.Tasks.NavTask.Options.Ppoint.ID = Character.Api.Player.ZoneId;
            Character.Tasks.NavTask.Options.Ppoint.Name = PointNametb.Text;
            Character.Tasks.NavTask.Options.Ppoint.X = Character.Api.Player.X;
            Character.Tasks.NavTask.Options.Ppoint.Y = Character.Api.Player.Y;
            Character.Tasks.NavTask.Options.Ppoint.Z = Character.Api.Player.Z;
            Character.Tasks.NavTask.Options.Points.Add(Character.Tasks.NavTask.Options.Ppoint);
            PointsComboBox.Items.Add(Character.Tasks.NavTask.Options.Ppoint.Name);
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"{0} Added to Points of interest list", Character.Tasks.NavTask.Options.Ppoint.Name));
            PointsComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the Click event of the saveHitPointsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveHitPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.SavePointsOfInterest();
        }

        /// <summary>
        /// Handles the Click event of the loadHitPointToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void loadHitPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.LoadPointsOfInterest();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the PointsComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Character.Tasks.NavTask.Options.Points.Count > 0)
            {
                SelectedPoint = PointsComboBox.SelectedItem.ToString();
                Character.Api.AutoFollow.IsAutoFollowing = false;
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.NavTask.Options.WayPoints.Clear();
                foreach (var item in Character.Tasks.NavTask.Options.Points)
                {
                    if (item.ID == Character.Api.Player.ZoneId && item.Name == SelectedPoint)
                    {
                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Point Set {0} x = {1} z = {2}",
                        item.Name, item.X.ToString(), item.Z.ToString()));
                        Character.Tasks.NavTask.Options.KeepMovingStartPosi.X = Character.Api.Player.X;
                        Character.Tasks.NavTask.Options.KeepMovingStartPosi.Y = Character.Api.Player.Y;
                        Character.Tasks.NavTask.Options.KeepMovingStartPosi.Z = Character.Api.Player.Z;
                        Character.Tasks.NavTask.Options.Posi.X = item.X;
                        Character.Tasks.NavTask.Options.Posi.Y = item.Y;
                        Character.Tasks.NavTask.Options.Posi.Z = item.Z;
                        SelectedPoint = item.Name;
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the RunBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RunBtn_Click(object sender, EventArgs e)
        {
            if (RunBtn.Text == "Start" && !Character.Tasks.NavTask.IsBusy)
            {
                RunBtn.Text = "Stop";
                Thread.Sleep(100);
                Character.Tasks.NavTask.Start();
                Character.Tasks.NavTask.Options.StopRunning = false;
            }
            else if (RunBtn.Text == "Stop")
            {
                Character.Tasks.NavTask.Stop();
                Character.Navi.Reset();
                Character.Tasks.Stop();
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.NavTask.Options.WayPoints.Clear();
                Character.Tasks.NavTask.Options.StopRunning = true;
                Character.Api.AutoFollow.IsAutoFollowing = false;
                // Character.Api.AutoFollow.SetAutoFollowCoords(0, 0, 0);
                RunBtn.Text = "Start";
                Thread.Sleep(200);
                Character.Navi.Reset();
            }
            else if (RunBtn.Text == "Start" && Character.Tasks.NavTask.IsBusy)
            {
                RunBtn.Text = "Stop";
                Thread.Sleep(100);
                Character.Tasks.NavTask.Stop();
                Character.Tasks.Stop();
                Character.Api.AutoFollow.SetAutoFollowCoords(0, 0, 0);
                Character.FFxiNAV.Waypoints.Clear();
                Character.Tasks.NavTask.Options.WayPoints.Clear();
                Character.Tasks.NavTask.Options.StopRunning = true;
                Character.Api.AutoFollow.IsAutoFollowing = false;
                Character.Logger.AddDebugText(rtbDebug, "NavTask is busy. attempting to stop");
            }
        }

        /// <summary>
        /// Handles the Click event of the button16 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button16_Click(object sender, EventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"Points in navmesh path = {0}", Character.Tasks.NavTask.FFxiNav.PathCount().ToString()));
        }

        /// <summary>
        /// Handles the Click event of the button14 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button14_Click(object sender, EventArgs e)
        {
            Character.LoadNavMesh();
        }

        /// <summary>
        /// Handles the Click event of the button15 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button15_Click(object sender, EventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"NavMesh is enabled = {0}", Character.Tasks.NavTask.FFxiNav.IsNavMeshEnabled().ToString()));
        }

        /// <summary>
        /// Handles the Click event of the button12 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button12_Click(object sender, EventArgs e)
        {
            Character.FFxiNAV.GetWaypoints();
            if (Character.FFxiNAV.Waypoints.Count > 0)
            {
                foreach (var item in Character.FFxiNAV.Waypoints)
                {
                    Character.Logger.AddDebugText(rtbDebug, string.Format(@"waypoint list x = {0} z = {1}", item.X.ToString(), item.Z.ToString()));
                }
            }
            else
                Character.Logger.AddDebugText(rtbDebug, "No Waypoints");
        }

        /// <summary>
        /// Handles the Click event of the button17 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button17_Click(object sender, EventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format("Looking for path"));
            Character.Tasks.NavTask.Options.KeepMovingStartPosi.X = Character.Api.Player.X;
            Character.Tasks.NavTask.Options.KeepMovingStartPosi.Y = Character.Api.Player.Y;
            Character.Tasks.NavTask.Options.KeepMovingStartPosi.Z = Character.Api.Player.Z;
            Character.Tasks.NavTask.FFxiNav.FindPathToPosi(Character.Tasks.NavTask.Options.KeepMovingStartPosi, Character.Tasks.NavTask.Options.Posi, false);
        }

        /// <summary>
        /// Handles the 1 event of the button1_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            Character.ExportMapData();
        }

        /// <summary>
        /// Handles the Click event of the toolStripMenuItem1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Character.LoadZones();
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            Character.ExportSingleMapData(mapLB.SelectedItem.ToString());
        }

        /// <summary>
        /// The old string
        /// </summary>
        private string OldString;

        /// <summary>
        /// Creates new string.
        /// </summary>
        private string NewString;

        /// <summary>
        /// The old zone
        /// </summary>
        private string OldZone;

        /// <summary>
        /// Creates new zone.
        /// </summary>
        private string NewZone;

        /// <summary>
        /// The old mesh edge distance
        /// </summary>
        public double OldMeshEdgeDistance;

        /// <summary>
        /// Creates new meshedgedistance.
        /// </summary>
        public double NewMeshEdgeDistance;

        private bool ShowMsg { get; set; } = true;

        /// <summary>
        /// Handles the Tick event of the timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                NewString = Character.FFxiNAV.GetErrorMessage();
                if (OldString != NewString)
                {
                    Character.Logger.AddDebugText(this.rtbDebug, NewString);
                    OldString = Character.FFxiNAV.GetErrorMessage();
                }
                if (Character.FFxiNAV.Waypoints.Count > 0 && Character.Tasks.NavTask.IsBusy)
                {
                    var PlayerPos = new position_t { X = Character.Api.Player.X, Y = Character.Api.Player.Y, Z = Character.Api.Player.Z, Moving = 0, Rotation = 0 };
                    NewMeshEdgeDistance = Character.FFxiNAV.DistanceToWall(PlayerPos);
                    if (OldMeshEdgeDistance != NewMeshEdgeDistance)
                    {
                        OldMeshEdgeDistance = Character.FFxiNAV.DistanceToWall(PlayerPos);
                        Character.Logger.AddDebugText(this.rtbDebug, string.Format(@"Player Distance from NavMesh Edge = {0}", OldMeshEdgeDistance.ToString()));
                    }
                }

                var path = string.Format(Application.StartupPath + "\\Dumped NavMeshes\\");
                int fCount = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;

                if (fCount == 0)
                {
                    if (ShowMsg)
                    {
                        ShowMsg = false;
                        if (MessageBox.Show("NavMesh files are missing!, do you want to download them from GitHub?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Character.Logger.AddDebugText(this.rtbDebug, "No NavMesh files found... Downloading...");

                            // https://github.com/xenonsmurf/FFXINavMeshes/archive/master.zip

                            WebClient webClient = new WebClient();
                            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                            webClient.DownloadFileAsync(new Uri("https://github.com/xenonsmurf/FFXINavMeshes/archive/master.zip"),
                                string.Format(@"{0}\\master.zip", path));
                        }
                    }
                }

                if (fCount > 1 && !Character.Zoning() && Character.Api.Player.ZoneId != 0)
                {
                    NewZone = string.Format(@"Zone id = {0}", Character.Api.Player.ZoneId.ToString());
                    if (OldZone != NewZone)
                    {
                        Character.Logger.AddDebugText(this.rtbDebug, NewZone);
                        OldZone = string.Format(@"Zone id = {0}", Character.Api.Player.ZoneId.ToString());
                        if (fCount > 0)
                        {
                            Character.FFxiNAV.Unload();

                            var NavFile = string.Format(Application.StartupPath + "\\Dumped NavMeshes\\{0}.nav", Character.Api.Player.ZoneId);
                            if (File.Exists(NavFile))
                            {
                                Character.FFxiNAV.Load(NavFile);
                            }
                            else
                                Character.Logger.AddDebugText(this.rtbDebug, "Unable to load NavMesh for current Zone");
                        }

                        if (PointsComboBox.Items.Count > 0)
                        {
                            PointsComboBox.Items.Clear();

                            foreach (var item in Character.Tasks.NavTask.Options.Points)
                            {
                                if (item.ID == Character.Api.Player.ZoneId)
                                {
                                    PointsComboBox.Items.Add(item.Name);
                                }
                            }
                            PointsComboBox.SelectedIndex = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Character.Logger.AddDebugText(rtbDebug, ex.ToString());
            }
        }

        /// <summary>
        /// Completeds the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="AsyncCompletedEventArgs"/> instance containing the event data.
        /// </param>
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                Character.Logger.AddDebugText(this.rtbDebug, "Download completed!");
                Character.Logger.AddDebugText(this.rtbDebug, "Extracting Nav files");
                var path = string.Format(Application.StartupPath + "\\Dumped NavMeshes\\");
                string startPath = path;
                string zipPath = string.Format(@"{0}master.zip", path);
                string extractPath = path;
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                Character.Logger.AddDebugText(this.rtbDebug, "Extraction complete");
                Character.Logger.AddDebugText(this.rtbDebug, "Moving files to NavMesh folder");
                foreach (var file in Directory.EnumerateFiles(string.Format(@"{0}{1}", path, "FFXINavMeshes-master")))
                {
                    string destFile = Path.Combine(path, Path.GetFileName(file));

                    if (!File.Exists(destFile))
                        File.Move(file, destFile);
                }
                Character.Logger.AddDebugText(this.rtbDebug, "Moved files, Deleting crap.");
                foreach (string file in Directory.GetFiles(path))
                {
                    if (!file.EndsWith(".nav"))
                    {
                        File.Delete(file);
                    }
                }
                if (File.Exists(string.Format(@"{0}FFXINavMeshes-master", path)))
                {
                    File.Delete(string.Format(@"{0}FFXINavMeshes-master", path));
                }
                Character.Logger.AddDebugText(this.rtbDebug, "good to go.");
            }
            catch (Exception ex)
            {
                Character.Logger.AddDebugText(this.rtbDebug, ex.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialog = new OpenFileDialog();
            string PATH = (string.Format(Application.StartupPath + "\\Map Collision obj\\"));
            OpenDialog.InitialDirectory = PATH;
            OpenDialog.FilterIndex = 0;

            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                string ZoneFilename = OpenDialog.FileName;
                Character.Logger.AddDebugText(rtbDebug, string.Format(@"Obj File Selected = {0}", ZoneFilename));
                try
                {
                    Stopwatch stopWatch = new Stopwatch();

                    string result;
                    result = Path.GetFileName(ZoneFilename);
                    string result2 = result.Substring(0, result.LastIndexOf(".") + 1);
                    if (File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                    {
                        if (MessageBox.Show(string.Format(@"Are you sure you want to overwrite {0}.nav", result2.ToString()), "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Character.Logger.AddDebugText(rtbDebug, string.Format(@"Dumping NavMesh for {0}", result));
                            Thread.Sleep(100);
                            if (!Character.FFxiNAV.DumpingMesh)
                            {
                                Stopwatch stopWatch2 = new Stopwatch();
                                stopWatch.Start();
                                Character.FFxiNAV.Dump_NavMesh(ZoneFilename);
                                stopWatch.Stop();
                                TimeSpan ts2 = stopWatch.Elapsed;

                                // Format and display the TimeSpan value.
                                string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                    ts2.Hours, ts2.Minutes, ts2.Seconds,
                                    ts2.Milliseconds / 10);
                                Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump mesh = " + elapsedTime2));
                            }
                        }
                    }
                    if (!File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                    {
                        stopWatch.Start();
                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Dumping NavMesh for {0}", ZoneFilename));
                        Character.FFxiNAV.Dump_NavMesh(ZoneFilename);

                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;

                        // Format and display the TimeSpan value.
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);

                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Finished dumping NavMesh for {0}", ZoneFilename));
                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump NavMesh = " + elapsedTime));
                    }
                }
                catch (Exception ex)
                {
                    Character.Logger.AddDebugText(rtbDebug, string.Format(ex.ToString()));
                }
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the CSTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void CSTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the CHTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void CHTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the AHTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void AHTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the ARTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void ARTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the MCTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void MCTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the MSTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void MSTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the TSTB control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TSTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double CS = Convert.ToDouble(CSTB.Text);
                double CH = Convert.ToDouble(CHTB.Text);
                double AH = Convert.ToDouble(AHTB.Text);
                double AR = Convert.ToDouble(ARTB.Text);
                double MC = Convert.ToDouble(MCTB.Text);
                double MS = Convert.ToDouble(MSTB.Text);
                double TS = Convert.ToDouble(TSTB.Text);
                double Rs = Convert.ToDouble(RMinS.Text);
                double Rms = Convert.ToDouble(RMS.Text);
                double EML = Convert.ToDouble(EMaxL.Text);
                double Em = Convert.ToDouble(EmE.Text);
                double Vpp = Convert.ToDouble(vPP.Text);
                double Dsd = Convert.ToDouble(DSD.Text);
                double Dsm = Convert.ToDouble(DsM.Text);
                Character.FFxiNAV.ChangeNavMeshSettings(CS, CH, AH, AR, MC, MS, TS, Rs, Rms, EML, Em, Vpp, Dsd, Dsm);
                Character.Logger.AddDebugText(rtbDebug, "NavMesh Settings changed.");
            }
            catch (Exception es)
            {
                Character.Logger.AddDebugText(rtbDebug, es.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the button5 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Start dumping all zone.obj file navmeshes" && !DumpMeshes.IsBusy)
            {
                button5.Text = "Stop dumping all zone.obj file navmeshes";
                Thread.Sleep(100);
                DumpMeshes.RunWorkerAsync();
            }
            else if (button5.Text == "Stop dumping all zone.obj file navmeshes")
            {
                DumpMeshes.CancelAsync();
                Thread.Sleep(200);
                button5.Text = "Start dumping all zone.obj file navmeshes";
                Thread.Sleep(200);
            }
            else if (button5.Text == "Stop dumping all zone.obj file navmeshes" && DumpMeshes.IsBusy)
            {
                DumpMeshes.CancelAsync();
                Thread.Sleep(200);
                button5.Text = "Start dumping all zone.obj file navmeshes";
                Thread.Sleep(200);
            }
        }

        /// <summary>
        /// Handles the DoWork event of the DumpMeshes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.
        /// </param>
        private void DumpMeshes_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                {
                    while (!DumpMeshes.CancellationPending)
                    {
                        string path = string.Format("{0}\\Map Collision obj\\", Application.StartupPath);
                        int fileCount = Directory.GetFiles(path, "*.obj", SearchOption.AllDirectories).Length;
                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"{0}.obj files fould in Map Collision obj folder", fileCount.ToString()));
                        foreach (var file in Directory.EnumerateFiles(string.Format(path, "*.obj")))
                        {
                            string result;
                            result = Path.GetFileName(file);
                            string result2 = result.Substring(0, result.LastIndexOf(".") + 1);
                            if (File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                            {
                                if (MessageBox.Show(string.Format(@"Are you sure you want to overwrite {0}.nav", result2.ToString()), "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Character.Logger.AddDebugText(rtbDebug, string.Format(@"Dumping NavMesh for {0}", result));
                                    Thread.Sleep(100);
                                    if (!Character.FFxiNAV.DumpingMesh)
                                    {
                                        Stopwatch stopWatch = new Stopwatch();
                                        stopWatch.Start();
                                        Character.FFxiNAV.Dump_NavMesh(file);
                                        stopWatch.Stop();
                                        TimeSpan ts = stopWatch.Elapsed;

                                        // Format and display the TimeSpan value.
                                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                            ts.Hours, ts.Minutes, ts.Seconds,
                                            ts.Milliseconds / 10);
                                        Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump mesh = " + elapsedTime));
                                    }
                                }
                            }
                            if (!File.Exists(string.Format(@"{0}\\Dumped NavMeshes\\{1}nav", Application.StartupPath, result2)))
                            {
                                Character.Logger.AddDebugText(rtbDebug, string.Format(@"Dumping NavMesh for {0}", result));
                                Thread.Sleep(100);
                                if (!Character.FFxiNAV.DumpingMesh)
                                {
                                    Stopwatch stopWatch = new Stopwatch();
                                    stopWatch.Start();
                                    Character.FFxiNAV.Dump_NavMesh(file);
                                    stopWatch.Stop();
                                    TimeSpan ts = stopWatch.Elapsed;

                                    // Format and display the TimeSpan value.
                                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                        ts.Hours, ts.Minutes, ts.Seconds,
                                        ts.Milliseconds / 10);
                                    Character.Logger.AddDebugText(rtbDebug, string.Format(@"Time Taken to dump mesh = " + elapsedTime));
                                }
                            }
                        }

                        DumpMeshes.CancelAsync();
                    }
                }
            }
            catch (Exception es)
            {
                Character.Logger.AddDebugText(rtbDebug, es.ToString());
            }
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the DumpMeshes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing
        /// the event data.
        /// </param>
        private void DumpMeshes_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Character.Logger.AddDebugText(rtbDebug, string.Format(@"No zone.obj files to dump meshes for, lets stop background worker."));
            button5.Text = "Start dumping all zone.obj file navmeshes";
            Thread.Sleep(200);
            DumpMeshes.CancelAsync();
        }

        /// <summary>
        /// Handles the Click event of the button6 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button6_Click(object sender, EventArgs e)
        {
            Character.FFxiNAV.Unload();
        }
    }
}
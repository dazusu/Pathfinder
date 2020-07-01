// *********************************************************************** Assembly : PathFinder
// Author : xenonsmurf Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020 Created : 03-16-2020
//
// Last Modified By : xenonsmurf Last Modified On : 03-29-2020 Last Modified On : 04-12-2020 ***********************************************************************
// <copyright file="MainForm.cs" company="Xenonsmurf">
//     Copyright © 2020
// </copyright>
// <summary>
// </summary>
// ***********************************************************************

using PathFinder.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using PathFinder.Common;
using System.Linq;
using System.Globalization;
using System.Xml.Serialization;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PathFinder
{
    /// <summary>
    /// Class MainForm. Implements the <see cref="System.Windows.Forms.Form"/>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form"/>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Gets or sets the ffxiprocess.
        /// </summary>
        /// <value>The ffxiprocess.</value>
        public ffxiProcess ffxiprocess { get; set; }

        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        /// <value>The logger.</value>
        public Log Logger { get; set; }

        /// <summary>
        /// Gets the client.
        /// </summary>
        /// <value>The client.</value>
        private WebClient Client { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            try
            {
                InitializeComponent();
                Logger = new Log();
                ffxiprocess = new ffxiProcess(this);
                Client = new WebClient();
                Check();
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(CheckedItemsRTB, ex.ToString());
                Logger.LogFile(ex.Message, FindForm().Name);
            }
        }

        /// <summary>
        /// Checks this instance.
        /// </summary>
        public void Check()
        {
            try
            {
                if (DoWeHaveAllNeededFiles())
                {
                    ffxiprocess.GetProcess();
                }
            }
            catch (Exception ex)
            {
                Logger.AddDebugText(CheckedItemsRTB, ex.ToString());
            }
        }

        /// <summary>
        /// Does the we have all needed files.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool DoWeHaveAllNeededFiles()
        {
            try
            {
                string NetVersion = Environment.Version.ToString();
                Logger.AddDebugText(CheckedItemsRTB, string.Format(@".NetFramework v  = ({0})", NetVersion));
                if (!NetVersion.Contains("4."))
                {
                    Logger.AddDebugText(CheckedItemsRTB, "Please Update your .Net framework, https://www.microsoft.com/en-us/download/details.aspx?id=53344");
                    return false;
                }

                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                string version = fvi.FileVersion;
                Logger.AddDebugText(CheckedItemsRTB, string.Format(@"Servus Version ({0})", version));

                if (File.Exists("EliteAPI.dll"))
                {
                    FileVersionInfo EliteAPIVersion = FileVersionInfo.GetVersionInfo("EliteAPI.dll");
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"EliteAPI Found: Version: ({0})", EliteAPIVersion.FileVersion));
                }
                if (!File.Exists("EliteAPI.dll"))
                {
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"EliteAPI Missing"));
                    Logger.AddDebugText(CheckedItemsRTB, "Getting Latest EliteAPI.dll");
                    Client.DownloadFile("http://ext.elitemmonetwork.com/downloads/eliteapi/EliteAPI.dll", "EliteAPI.dll");
                }
                if (File.Exists("FFXINAV.dll"))
                {
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"FFXINAV.dll Found"));
                }
                else if (!File.Exists("FFXINAV.dll"))
                {
                    Logger.AddDebugText(CheckedItemsRTB, @"FFXINAV.dll is missing");
                }

                if (File.Exists("EliteMMO.API.dll"))
                {
                    FileVersionInfo EliteAPIVersion = FileVersionInfo.GetVersionInfo("EliteMMO.API.dll");
                    Logger.AddDebugText(CheckedItemsRTB, string.Format(@"EliteMMO.API Found: Version: ({0})", EliteAPIVersion.FileVersion));
                }
                else if (!File.Exists("EliteMMO.API.dll"))
                {
                    Logger.AddDebugText(CheckedItemsRTB, "EliteMMO.API MISSING");
                    Logger.AddDebugText(CheckedItemsRTB, "Getting Latest EliteMMO.API.dll");
                    Client.DownloadFile("http://ext.elitemmonetwork.com/downloads/elitemmo_api/EliteMMO.API.dll", "EliteMMO.API.dll");
                }

                Logger.AddDebugText(CheckedItemsRTB, @"Finished checking files");
            }
            catch (Exception ex)
            {
                Logger.LogFile(ex.Message, "CheckNeededFiles");
                Logger.AddDebugText(CheckedItemsRTB, ex.ToString());
                return false;
            }
            Client.Dispose();
            return true;
        }

        /// <summary>
        /// Handles the Click event of the NextBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ffxiprocess._CharacterDictionary.Count < 1 && NextBtn.Text == "Refresh")
                {
                    NextBtn.Text = "Next";
                    ffxiprocess.GetProcess();
                }
                if (ffxiprocess._CharacterDictionary.Count > 0 && NextBtn.Text == "Next")
                {
                    ffxiprocess.AddToons();
                    NextBtn.Visible = false;
                    CheckedItemsRTB.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Logger.LogFile(ex.Message, FindForm().Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var dats =  ToPath(ftable, vtable, 192);
        }


        private static byte[] ftable =
        {
    0xE2, 0xE5, 0x06, 0xA9, 0xED, 0x26, 0xF4, 0x42, 0x15, 0xF4, 0x81, 0x7F, 0xDE, 0x9A, 0xDE, 0xD0,
    0x1A, 0x98, 0x20, 0x91, 0x39, 0x49, 0x48, 0xA4, 0x0A, 0x9F, 0x40, 0x69, 0xEC, 0xBD, 0x81, 0x81,
    0x8D, 0xAD, 0x10, 0xB8, 0xC1, 0x88, 0x15, 0x05, 0x11, 0xB1, 0xAA, 0xF0, 0x0F, 0x1E, 0x34, 0xE6,
    0x81, 0xAA, 0xCD, 0xAC, 0x02, 0x84, 0x33, 0x0A, 0x19, 0x38, 0x9E, 0xE6, 0x73, 0x4A, 0x11, 0x5D,
    0xBF, 0x85, 0x77, 0x08, 0xCD, 0xD9, 0x96, 0x0D, 0x79, 0x78, 0xCC, 0x35, 0x06, 0x8E, 0xF9, 0xFE,
    0x66, 0xB9, 0x21, 0x03, 0x20, 0x29, 0x1E, 0x27, 0xCA, 0x86, 0x82, 0xE6, 0x45, 0x07, 0xDD, 0xA9,
    0xB6, 0xD5, 0xA2, 0x03, 0xEC, 0xAD, 0x62, 0x45, 0x2D, 0xCE, 0x79, 0xBD, 0x8F, 0x2D, 0x10, 0x18,
    0xE6, 0x0A, 0x6F, 0xAA, 0x6F, 0x46, 0x84, 0x32, 0x9F, 0x29, 0x2C, 0xC2, 0xF0, 0xEB, 0x18, 0x6F,
    0xF2, 0x3A, 0xDC, 0xEA, 0x7B, 0x0C, 0x81, 0x2D, 0xCC, 0xEB, 0xA1, 0x51, 0x77, 0x2C, 0xFB, 0x49,
    0xE8, 0x90, 0xF7, 0x90, 0xCE, 0x5C, 0x01, 0xF3, 0x5C, 0xF4, 0x41, 0xAB, 0x04, 0xE7, 0x16, 0xCC,
    0x3A, 0x05, 0x54, 0x55, 0xDC, 0xED, 0xA4, 0xD6, 0xBF, 0x3F, 0x9E, 0x08, 0x93, 0xB5, 0x63, 0x38,
    0x90, 0xF7, 0x5A, 0xF0, 0xA2, 0x5F, 0x56, 0xC8, 0x08, 0x70, 0xCB, 0x24, 0x16, 0xDD, 0xD2, 0x74,
    0x95, 0x3A, 0x1A, 0x2A, 0x74, 0xC4, 0x9D, 0xEB, 0xAF, 0x69, 0xAA, 0x51, 0x39, 0x65, 0x94, 0xA2,
    0x4B, 0x1F, 0x1A, 0x60, 0x52, 0x39, 0xE8, 0x23, 0xEE, 0x58, 0x39, 0x06, 0x3D, 0x22, 0x6A, 0x2D,
    0xD2, 0x91, 0x25, 0xA5, 0x2E, 0x71, 0x62, 0xA5, 0x0B, 0xC1, 0xE5, 0x6E, 0x43, 0x49, 0x7C, 0x58,
    0x46, 0x19, 0x9F, 0x45, 0x49, 0xC6, 0x40, 0x09, 0xA2, 0x99, 0x5B, 0x7B, 0x98, 0x7F, 0xA0, 0xD0,
};

        /************************************************************************
        *																		*
        *																		*
        *																		*
        ************************************************************************/

        private static byte[] vtable =
        {
    0xB8, 0xC5, 0xF7, 0x84, 0xE4, 0x5A, 0x23, 0x7B, 0xC8, 0x90, 0x1D, 0xF6, 0x5D, 0x09, 0x51, 0xC1,
    0x07, 0x24, 0xEF, 0x5B, 0x1D, 0x73, 0x90, 0x08, 0xA5, 0x70, 0x1C, 0x22, 0x5F, 0x6B, 0xEB, 0xB0,
    0x06, 0xC7, 0x2A, 0x3A, 0xD2, 0x66, 0x81, 0xDB, 0x41, 0x62, 0xF2, 0x97, 0x17, 0xFE, 0x05, 0xEF,
    0xA3, 0xDC, 0x22, 0xB3, 0x45, 0x70, 0x3E, 0x18, 0x2D, 0xB4, 0xBA, 0x0A, 0x65, 0x1D, 0x87, 0xC3,
    0x12, 0xCE, 0x8F, 0x9D, 0xF7, 0x0D, 0x50, 0x24, 0x3A, 0xF3, 0xCA, 0x70, 0x6B, 0x67, 0x9C, 0xB2,
    0xC2, 0x4D, 0x6A, 0x0C, 0xA8, 0xFA, 0x81, 0xA6, 0x79, 0xEB, 0xBE, 0xFE, 0x89, 0xB7, 0xAC, 0x7F,
    0x65, 0x43, 0xEC, 0x56, 0x5B, 0x35, 0xDA, 0x81, 0x3C, 0xAB, 0x6D, 0x28, 0x60, 0x2C, 0x5F, 0x31,
    0xEB, 0xDF, 0x8E, 0x0F, 0x4F, 0xFA, 0xA3, 0xDA, 0x12, 0x7E, 0xF1, 0xA5, 0xD2, 0x22, 0xA0, 0x0C,
    0x86, 0x8C, 0x0A, 0x0C, 0x06, 0xC7, 0x65, 0x18, 0xCE, 0xF2, 0xA3, 0x68, 0xFE, 0x35, 0x96, 0x95,
    0xA6, 0xFA, 0x58, 0x63, 0x41, 0x59, 0xEA, 0xDD, 0x7F, 0xD3, 0x1B, 0xA8, 0x48, 0x44, 0xAB, 0x91,
    0xFD, 0x13, 0xB1, 0x68, 0x01, 0xAC, 0x3A, 0x11, 0x78, 0x30, 0x33, 0xD8, 0x4E, 0x6A, 0x89, 0x05,
    0x7B, 0x06, 0x8E, 0xB0, 0x86, 0xFD, 0x9F, 0xD7, 0x48, 0x54, 0x04, 0xAE, 0xF3, 0x06, 0x17, 0x36,
    0x53, 0x3F, 0xA8, 0x11, 0x53, 0xCA, 0xA1, 0x95, 0xC2, 0xCD, 0xE6, 0x1F, 0x57, 0xB4, 0x7F, 0xAA,
    0xF3, 0x6B, 0xF9, 0xA0, 0x27, 0xD0, 0x09, 0xEF, 0xF6, 0x68, 0x73, 0x60, 0xDC, 0x50, 0x2A, 0x25,
    0x0F, 0x77, 0xB9, 0xB0, 0x04, 0x0B, 0xE1, 0xCC, 0x35, 0x31, 0x84, 0xE6, 0x22, 0xF9, 0xC2, 0xAB,
    0x95, 0x91, 0x61, 0xD9, 0x2B, 0xB9, 0x72, 0x4E, 0x10, 0x76, 0x31, 0x66, 0x0A, 0x0B, 0x2E, 0x83,
};
        private void button7_Click(object sender, EventArgs e)
        {
            ToPath(ftable, vtable, 192);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe string? ToPath(ReadOnlySpan<byte> ftable, ReadOnlySpan<byte> vtable, int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            fixed (byte* pFtable = &MemoryMarshal.GetReference(ftable))
            fixed (byte* pVtable = &MemoryMarshal.GetReference(vtable))
            {
                ushort v7; // ax
                byte v8; // cl

                string? result = null;

                if (index >= vtable.Length)
                    return result;

                v7 = *(ushort*)(pFtable + 2 * index);
                v8 = *(index + pVtable);

                if (v8 == 0)
                    return result;

                if (v8 == 1)
                    result = $"\\ROM\\{(uint)v7 >> 7}\\{v7 & 0x7F}.DAT";
                else
                    result = $"\\ROM{v8}\\{(uint)v7 >> 7}\\{v7 & 0x7F}.DAT";

                return result;
            }
        }

        private void onTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onTopToolStripMenuItem.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                MainForm.ActiveForm.TopMost = true;
            }
            else
                MainForm.ActiveForm.TopMost = false;
        }

        private void transparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transparentToolStripMenuItem.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                MainForm.ActiveForm.Opacity = 0.50;
            }
            else
                MainForm.ActiveForm.Opacity = 1;
        }
    }
}
﻿using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MediaplayerOverlay
{
    public partial class MediaplayerOverlay : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int WS_EX_TRANSPARENT = 0x20;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;

        public MediaplayerOverlay()
        {
            InitializeComponent();
            SetWindowLong(this.Handle, GWL_EXSTYLE,
            (IntPtr)(GetWindowLong(this.Handle, GWL_EXSTYLE) ^ WS_EX_LAYERED ^ WS_EX_TRANSPARENT));
            SetLayeredWindowAttributes(this.Handle, 0, 223, LWA_ALPHA);
            TrayIconContext();
        }

        private void TrayIconContext()
        {
            trayIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            trayIcon.ContextMenuStrip.Items.Add("Exit", null, MenuExit_Click);
        }

        void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Overlay_Load(object sender, EventArgs e)
        {
            trayIcon.Icon = new Icon(SystemIcons.Application, 40, 40);
            string windowLocation = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\playingoverlay.cfg";
            if (!File.Exists(windowLocation))
            {
                // Create a file to write to with basic settings on first run. 
                string location = "500|500";
                File.WriteAllText(windowLocation, location, Encoding.UTF8);
            }
            else
                if (File.Exists(windowLocation))
                {
                // Read config and parse it to something usable
                    string rawlocation = File.ReadAllText(windowLocation);
                    string[] tokens = rawlocation.Split('|');
                    int[] location = Array.ConvertAll<string, int>(tokens, int.Parse);
                // Set window location to parsed data. 
                    this.Left = location[0];
                    this.Top = location[1];
                }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            // Getting path to now playing data. 
            string nowPlaying = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "\\np.txt";
            if (File.Exists(nowPlaying))
            {
                // Read file
                string rawplaying = File.ReadAllText(nowPlaying);
                // Split result
                string[] delimiters = { "|" };
                string[] playing = rawplaying.Split(delimiters, StringSplitOptions.None);
                // Write results to labels
                Artist.Text = playing[0];
                Track.Text = playing[1];
            }
        }
    }
}

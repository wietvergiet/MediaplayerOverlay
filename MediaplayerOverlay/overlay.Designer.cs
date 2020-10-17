using System;

namespace MediaplayerOverlay
{
    partial class MediaplayerOverlay
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
            this.text = new System.Windows.Forms.Label();
            this.Artist = new System.Windows.Forms.Label();
            this.Track = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.Lime;
            this.text.Location = new System.Drawing.Point(12, 7);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(323, 24);
            this.text.TabIndex = 0;
            this.text.Text = "Now playing";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Artist
            // 
            this.Artist.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.Lime;
            this.Artist.Location = new System.Drawing.Point(12, 50);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(323, 37);
            this.Artist.TabIndex = 1;
            this.Artist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Artist.UseMnemonic = false;
            // 
            // Track
            // 
            this.Track.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Track.ForeColor = System.Drawing.Color.Lime;
            this.Track.Location = new System.Drawing.Point(12, 87);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(323, 36);
            this.Track.TabIndex = 2;
            this.Track.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Track.UseMnemonic = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.line.ForeColor = System.Drawing.SystemColors.ControlText;
            this.line.Location = new System.Drawing.Point(0, 36);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(347, 1);
            this.line.TabIndex = 3;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 2500;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "Mediaplayer overlay active";
            this.trayIcon.Visible = true;
            // 
            // MediaplayerOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(347, 136);
            this.ControlBox = false;
            this.Controls.Add(this.line);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.Artist);
            this.Controls.Add(this.text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(2800, 150);
            this.Name = "MediaplayerOverlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MediaplayerOverlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}


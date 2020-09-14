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
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Liberation Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.Lime;
            this.text.Location = new System.Drawing.Point(128, 14);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(82, 12);
            this.text.TabIndex = 0;
            this.text.Text = "Now playing";
            // 
            // Artist
            // 
            this.Artist.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.Lime;
            this.Artist.Location = new System.Drawing.Point(12, 50);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(323, 33);
            this.Artist.TabIndex = 1;
            this.Artist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Track
            // 
            this.Track.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Track.ForeColor = System.Drawing.Color.Lime;
            this.Track.Location = new System.Drawing.Point(12, 87);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(323, 36);
            this.Track.TabIndex = 2;
            this.Track.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 2500;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
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
            this.Text = "overlay";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.overlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label Track;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Timer refreshTimer;
    }
}


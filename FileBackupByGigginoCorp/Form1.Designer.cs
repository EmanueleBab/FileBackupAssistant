using System;

namespace FileBackupByGigginoCorp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TargetStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DestinationStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplyStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.NotifyIcon(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TargetStrip,
            this.DestinationStrip,
            this.ApplyStrip,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // TargetStrip
            // 
            this.TargetStrip.Name = "TargetStrip";
            this.TargetStrip.Size = new System.Drawing.Size(180, 22);
            this.TargetStrip.Text = "Directory to save";
            this.TargetStrip.Click += new System.EventHandler(this.DirToSave);
            // 
            // DestinationStrip
            // 
            this.DestinationStrip.Name = "DestinationStrip";
            this.DestinationStrip.Size = new System.Drawing.Size(180, 22);
            this.DestinationStrip.Text = "Destination folder ";
            this.DestinationStrip.Click += new System.EventHandler(this.TargetDir);
            // 
            // ApplyStrip
            // 
            this.ApplyStrip.Name = "ApplyStrip";
            this.ApplyStrip.Size = new System.Drawing.Size(180, 22);
            this.ApplyStrip.Text = "Apply ";
            this.ApplyStrip.Click += new System.EventHandler(this.applicamodificheToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.Menu.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Menu.BalloonTipText = "a";
            this.Menu.BalloonTipTitle = "a";
            this.Menu.ContextMenuStrip = this.contextMenuStrip1;
            this.Menu.Icon = ((System.Drawing.Icon)(resources.GetObject("Menu.Icon")));
            this.Menu.Text = "FileBackupper";
            this.Menu.Visible = true;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 325);
            this.ControlBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GIGGICORP";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

   

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TargetStrip;
        private System.Windows.Forms.ToolStripMenuItem DestinationStrip;
        private System.Windows.Forms.ToolStripMenuItem ApplyStrip;
        private System.Windows.Forms.NotifyIcon Menu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


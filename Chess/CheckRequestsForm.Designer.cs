﻿namespace Chess
{
    partial class CheckRequestsForm
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
            listBoxRequests = new ListBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            acceptToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem1 = new ToolStripMenuItem();
            buttonAccept = new Button();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxRequests
            // 
            listBoxRequests.FormattingEnabled = true;
            listBoxRequests.Location = new Point(12, 65);
            listBoxRequests.Name = "listBoxRequests";
            listBoxRequests.Size = new Size(412, 344);
            listBoxRequests.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(436, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acceptToolStripMenuItem, refreshToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // acceptToolStripMenuItem
            // 
            acceptToolStripMenuItem.Name = "acceptToolStripMenuItem";
            acceptToolStripMenuItem.Size = new Size(141, 26);
            acceptToolStripMenuItem.Text = "Accept";
            acceptToolStripMenuItem.Click += AcceptToolStripMenuItem_Click;
            // 
            // refreshToolStripMenuItem1
            // 
            refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            refreshToolStripMenuItem1.Size = new Size(141, 26);
            refreshToolStripMenuItem1.Text = "Refresh";
            refreshToolStripMenuItem1.Click += RefreshToolStripMenuItem1_Click;
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(209, 31);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(215, 29);
            buttonAccept.TabIndex = 2;
            buttonAccept.Text = "Accept selected request";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += ButtonAccept_Click;
            // 
            // CheckRequestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 422);
            Controls.Add(buttonAccept);
            Controls.Add(listBoxRequests);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Name = "CheckRequestsForm";
            Text = "Join Requests";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRequests;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem acceptToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem1;
        private Button buttonAccept;
    }
}
//IncidentWatcher - This program retrieves incident information for emergency services via Incident Source plugins and displays it
//Copyright (C) 2011  comicalcow

//This program is free software; you can redistribute it and/or
//modify it under the terms of the GNU General Public License
//as published by the Free Software Foundation; either version 2
//of the License, or (at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program; if not, write to the Free Software
//Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
namespace InciWatch
{
    partial class CurrentIncidentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentIncidentsForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.incidentListView = new System.Windows.Forms.ListView();
            this.lvhdSuburb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdWordbackTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdAppliances = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhdWatch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilImageList = new System.Windows.Forms.ImageList(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addWatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.listenToStreamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locateInGoogleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ntfyCurrentIncidents = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewCurrentIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.Button();
            this.rightClickMenu.SuspendLayout();
            this.notifyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(711, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Minimize";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(635, 423);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // incidentListView
            // 
            this.incidentListView.AllowColumnReorder = true;
            this.incidentListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.incidentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvhdSuburb,
            this.lvhdAddress,
            this.lvhdType,
            this.lvhdStatus,
            this.lvhdRegion,
            this.lvhdWordbackTime,
            this.lvhdAppliances,
            this.lvhdSize,
            this.lvhdWatch});
            this.incidentListView.FullRowSelect = true;
            this.incidentListView.GridLines = true;
            this.incidentListView.Location = new System.Drawing.Point(-2, 0);
            this.incidentListView.MultiSelect = false;
            this.incidentListView.Name = "incidentListView";
            this.incidentListView.ShowGroups = false;
            this.incidentListView.Size = new System.Drawing.Size(788, 417);
            this.incidentListView.SmallImageList = this.ilImageList;
            this.incidentListView.TabIndex = 3;
            this.incidentListView.UseCompatibleStateImageBehavior = false;
            this.incidentListView.View = System.Windows.Forms.View.Details;
            this.incidentListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.incidentListView_ColumnClick);
            this.incidentListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.incidentListView_MouseClick);
            // 
            // lvhdSuburb
            // 
            this.lvhdSuburb.Text = "Suburb";
            this.lvhdSuburb.Width = 106;
            // 
            // lvhdAddress
            // 
            this.lvhdAddress.Text = "Address";
            // 
            // lvhdType
            // 
            this.lvhdType.Text = "Type";
            // 
            // lvhdStatus
            // 
            this.lvhdStatus.Text = "Status";
            // 
            // lvhdRegion
            // 
            this.lvhdRegion.Text = "Region";
            this.lvhdRegion.Width = 68;
            // 
            // lvhdWordbackTime
            // 
            this.lvhdWordbackTime.Text = "Last Update";
            this.lvhdWordbackTime.Width = 81;
            // 
            // lvhdAppliances
            // 
            this.lvhdAppliances.Text = "";
            this.lvhdAppliances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvhdAppliances.Width = 41;
            // 
            // lvhdSize
            // 
            this.lvhdSize.Text = "Size";
            this.lvhdSize.Width = 46;
            // 
            // lvhdWatch
            // 
            this.lvhdWatch.Text = "";
            this.lvhdWatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvhdWatch.Width = 35;
            // 
            // ilImageList
            // 
            this.ilImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImageList.ImageStream")));
            this.ilImageList.TransparentColor = System.Drawing.Color.Fuchsia;
            this.ilImageList.Images.SetKeyName(0, "apps.bmp");
            this.ilImageList.Images.SetKeyName(1, "Flag_red.bmp");
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 30000;
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWatchToolStripMenuItem,
            this.toolStripMenuItem1,
            this.listenToStreamToolStripMenuItem,
            this.locateInGoogleMapsToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.rightClickMenu.ShowImageMargin = false;
            this.rightClickMenu.Size = new System.Drawing.Size(171, 76);
            // 
            // addWatchToolStripMenuItem
            // 
            this.addWatchToolStripMenuItem.Name = "addWatchToolStripMenuItem";
            this.addWatchToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addWatchToolStripMenuItem.Text = "Add Watch";
            this.addWatchToolStripMenuItem.Click += new System.EventHandler(this.addWatchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // listenToStreamToolStripMenuItem
            // 
            this.listenToStreamToolStripMenuItem.Name = "listenToStreamToolStripMenuItem";
            this.listenToStreamToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.listenToStreamToolStripMenuItem.Text = "Listen to Stream";
            this.listenToStreamToolStripMenuItem.Click += new System.EventHandler(this.listenToStreamToolStripMenuItem_Click);
            // 
            // locateInGoogleMapsToolStripMenuItem
            // 
            this.locateInGoogleMapsToolStripMenuItem.Name = "locateInGoogleMapsToolStripMenuItem";
            this.locateInGoogleMapsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.locateInGoogleMapsToolStripMenuItem.Text = "Locate in Google Maps";
            this.locateInGoogleMapsToolStripMenuItem.Click += new System.EventHandler(this.locateInGoogleMapsToolStripMenuItem_Click);
            // 
            // ntfyCurrentIncidents
            // 
            this.ntfyCurrentIncidents.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfyCurrentIncidents.BalloonTipTitle = "Incident Watch";
            this.ntfyCurrentIncidents.ContextMenuStrip = this.notifyContextMenu;
            this.ntfyCurrentIncidents.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyCurrentIncidents.Icon")));
            this.ntfyCurrentIncidents.Text = "Incident Watch";
            this.ntfyCurrentIncidents.Visible = true;
            this.ntfyCurrentIncidents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfyCurrentIncidents_MouseDoubleClick);
            // 
            // notifyContextMenu
            // 
            this.notifyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCurrentIncidentsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.notifyContextMenu.Name = "notifyContextMenu";
            this.notifyContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.notifyContextMenu.ShowImageMargin = false;
            this.notifyContextMenu.Size = new System.Drawing.Size(169, 54);
            // 
            // viewCurrentIncidentsToolStripMenuItem
            // 
            this.viewCurrentIncidentsToolStripMenuItem.Name = "viewCurrentIncidentsToolStripMenuItem";
            this.viewCurrentIncidentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.viewCurrentIncidentsToolStripMenuItem.Text = "View Current Incidents";
            this.viewCurrentIncidentsToolStripMenuItem.Click += new System.EventHandler(this.viewCurrentIncidentsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.Location = new System.Drawing.Point(3, 423);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // CurrentIncidentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 448);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.incidentListView);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CurrentIncidentsForm";
            this.Text = "Current Incidents";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CurrentIncidentsForm_FormClosing);
            this.Load += new System.EventHandler(this.CurrentIncidentsForm_Load);
            this.SizeChanged += new System.EventHandler(this.CurrentIncidentsForm_SizeChanged);
            this.rightClickMenu.ResumeLayout(false);
            this.notifyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ListView incidentListView;
        private System.Windows.Forms.ColumnHeader lvhdSuburb;
        private System.Windows.Forms.ColumnHeader lvhdAddress;
        private System.Windows.Forms.ColumnHeader lvhdType;
        private System.Windows.Forms.ColumnHeader lvhdStatus;
        private System.Windows.Forms.ColumnHeader lvhdRegion;
        private System.Windows.Forms.ColumnHeader lvhdWordbackTime;
        private System.Windows.Forms.ColumnHeader lvhdAppliances;
        private System.Windows.Forms.ImageList ilImageList;
        private System.Windows.Forms.ColumnHeader lvhdSize;
        private System.Windows.Forms.ColumnHeader lvhdWatch;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem addWatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon ntfyCurrentIncidents;
        private System.Windows.Forms.ContextMenuStrip notifyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem viewCurrentIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listenToStreamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locateInGoogleMapsToolStripMenuItem;
        private System.Windows.Forms.Button btnAbout;
    }
}


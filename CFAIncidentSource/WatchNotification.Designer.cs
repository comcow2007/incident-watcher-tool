//OSOMIncidentSource - This incident source reads the OSOM public feed for Incident Watcher
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
namespace CFAIncidentSource
{
    partial class WatchNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchNotification));
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUpdateTime = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblApplianceCount = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.lblRegion = new System.Windows.Forms.Label();
            this.ttDisplay = new System.Windows.Forms.ToolTip(this.components);
            this.tmrNotification = new System.Windows.Forms.Timer(this.components);
            this.tmrFadeout = new System.Windows.Forms.Timer(this.components);
            this.pbShowZone = new System.Windows.Forms.PictureBox();
            this.dseImageDummy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dseImageDummy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(38, 2);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(190, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "<address>";
            this.ttDisplay.SetToolTip(this.lblAddress, "Address");
            this.lblAddress.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblAddress.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // lblSuburb
            // 
            this.lblSuburb.BackColor = System.Drawing.Color.Transparent;
            this.lblSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.ForeColor = System.Drawing.Color.White;
            this.lblSuburb.Location = new System.Drawing.Point(38, 15);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(92, 16);
            this.lblSuburb.TabIndex = 2;
            this.lblSuburb.Text = "<Suburb>";
            this.lblSuburb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttDisplay.SetToolTip(this.lblSuburb, "Suburb");
            this.lblSuburb.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblSuburb.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(130, 17);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "<TYPE>";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttDisplay.SetToolTip(this.lblType, "Type");
            this.lblType.UseMnemonic = false;
            this.lblType.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblType.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(177, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 14);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "STATUS";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttDisplay.SetToolTip(this.lblStatus, "Status");
            this.lblStatus.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblStatus.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // lblUpdateTime
            // 
            this.lblUpdateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateTime.ForeColor = System.Drawing.Color.White;
            this.lblUpdateTime.Location = new System.Drawing.Point(39, 32);
            this.lblUpdateTime.Name = "lblUpdateTime";
            this.lblUpdateTime.Size = new System.Drawing.Size(37, 15);
            this.lblUpdateTime.TabIndex = 5;
            this.lblUpdateTime.Text = "<tme>";
            this.lblUpdateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttDisplay.SetToolTip(this.lblUpdateTime, "Last Update");
            this.lblUpdateTime.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblUpdateTime.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.Color.Transparent;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(70, 32);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 16);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "<sze>";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttDisplay.SetToolTip(this.lblSize, "Size");
            this.lblSize.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblSize.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // lblApplianceCount
            // 
            this.lblApplianceCount.BackColor = System.Drawing.Color.Transparent;
            this.lblApplianceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplianceCount.ForeColor = System.Drawing.Color.White;
            this.lblApplianceCount.Location = new System.Drawing.Point(114, 33);
            this.lblApplianceCount.Name = "lblApplianceCount";
            this.lblApplianceCount.Size = new System.Drawing.Size(32, 15);
            this.lblApplianceCount.TabIndex = 7;
            this.lblApplianceCount.Text = "<APPS>";
            this.lblApplianceCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ttDisplay.SetToolTip(this.lblApplianceCount, "Appliance Count");
            this.lblApplianceCount.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblApplianceCount.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImage = global::CFAIncidentSource.Properties.Resources.unwatch;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(216, 35);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(12, 12);
            this.btn1.TabIndex = 8;
            this.ttDisplay.SetToolTip(this.btn1, "Remove Watch");
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImage = global::CFAIncidentSource.Properties.Resources.listen;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(202, 35);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(12, 12);
            this.btn2.TabIndex = 9;
            this.ttDisplay.SetToolTip(this.btn2, "Listen");
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImage = global::CFAIncidentSource.Properties.Resources.map;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(188, 35);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(12, 12);
            this.btn3.TabIndex = 10;
            this.ttDisplay.SetToolTip(this.btn3, "Show Map");
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.BackgroundImage = global::CFAIncidentSource.Properties.Resources.circle;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(174, 35);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(12, 12);
            this.btn4.TabIndex = 11;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.BackgroundImage = global::CFAIncidentSource.Properties.Resources.square;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(160, 35);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(12, 12);
            this.btn5.TabIndex = 12;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.BackgroundImage = global::CFAIncidentSource.Properties.Resources.diamond;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(146, 35);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(12, 12);
            this.btn6.TabIndex = 13;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // lblRegion
            // 
            this.lblRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblRegion.ForeColor = System.Drawing.Color.White;
            this.lblRegion.Location = new System.Drawing.Point(102, 32);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(30, 16);
            this.lblRegion.TabIndex = 14;
            this.lblRegion.Text = "R01";
            this.lblRegion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttDisplay.SetToolTip(this.lblRegion, "Region");
            this.lblRegion.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.lblRegion.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // tmrNotification
            // 
            this.tmrNotification.Interval = 1000;
            this.tmrNotification.Tick += new System.EventHandler(this.tmrNotification_Tick);
            // 
            // tmrFadeout
            // 
            this.tmrFadeout.Interval = 50;
            this.tmrFadeout.Tick += new System.EventHandler(this.tmrFadeout_Tick);
            // 
            // pbShowZone
            // 
            this.pbShowZone.BackColor = System.Drawing.Color.Transparent;
            this.pbShowZone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowZone.Location = new System.Drawing.Point(3, 9);
            this.pbShowZone.Name = "pbShowZone";
            this.pbShowZone.Size = new System.Drawing.Size(33, 32);
            this.pbShowZone.TabIndex = 15;
            this.pbShowZone.TabStop = false;
            this.pbShowZone.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            this.pbShowZone.Click += new System.EventHandler(this.pbShowZone_Click);
            this.pbShowZone.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            // 
            // dseImageDummy
            // 
            this.dseImageDummy.BackgroundImage = global::CFAIncidentSource.Properties.Resources.dse_notify_tran;
            this.dseImageDummy.Enabled = false;
            this.dseImageDummy.Location = new System.Drawing.Point(208, 3);
            this.dseImageDummy.Name = "dseImageDummy";
            this.dseImageDummy.Size = new System.Drawing.Size(10, 10);
            this.dseImageDummy.TabIndex = 16;
            this.dseImageDummy.TabStop = false;
            this.dseImageDummy.Visible = false;
            // 
            // WatchNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(230, 50);
            this.ControlBox = false;
            this.Controls.Add(this.dseImageDummy);
            this.Controls.Add(this.pbShowZone);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblApplianceCount);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblUpdateTime);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WatchNotification";
            this.Opacity = 0.25;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.Load += new System.EventHandler(this.WatchNotification_Load);
            this.MouseEnter += new System.EventHandler(this.WatchNotification_MouseEnter);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WatchNotification_FormClosed);
            this.MouseLeave += new System.EventHandler(this.WatchNotification_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dseImageDummy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUpdateTime;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblApplianceCount;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ToolTip ttDisplay;
        private System.Windows.Forms.Timer tmrNotification;
        private System.Windows.Forms.Timer tmrFadeout;
        private System.Windows.Forms.PictureBox pbShowZone;
        private System.Windows.Forms.PictureBox dseImageDummy;
    }
}
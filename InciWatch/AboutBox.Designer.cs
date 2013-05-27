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
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFattymanSite = new System.Windows.Forms.LinkLabel();
            this.lblGoogleCode = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(9, 9);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(75, 13);
            this.labelProductName.TabIndex = 25;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(9, 50);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(42, 13);
            this.labelVersion.TabIndex = 24;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetail
            // 
            this.txtDetail.CausesValidation = false;
            this.txtDetail.Location = new System.Drawing.Point(12, 121);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.ReadOnly = true;
            this.txtDetail.Size = new System.Drawing.Size(274, 261);
            this.txtDetail.TabIndex = 28;
            this.txtDetail.TabStop = false;
            this.txtDetail.Text = resources.GetString("txtDetail.Text");
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(118, 388);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblFattymanSite
            // 
            this.lblFattymanSite.AutoSize = true;
            this.lblFattymanSite.Location = new System.Drawing.Point(9, 69);
            this.lblFattymanSite.Name = "lblFattymanSite";
            this.lblFattymanSite.Size = new System.Drawing.Size(184, 13);
            this.lblFattymanSite.TabIndex = 30;
            this.lblFattymanSite.TabStop = true;
            this.lblFattymanSite.Text = "Originally coded by www.fattyman.net";
            this.lblFattymanSite.UseMnemonic = false;
            this.lblFattymanSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFattymanSite_LinkClicked);
            // 
            // lblGoogleCode
            // 
            this.lblGoogleCode.AutoSize = true;
            this.lblGoogleCode.Location = new System.Drawing.Point(9, 27);
            this.lblGoogleCode.Name = "lblGoogleCode";
            this.lblGoogleCode.Size = new System.Drawing.Size(244, 13);
            this.lblGoogleCode.TabIndex = 31;
            this.lblGoogleCode.TabStop = true;
            this.lblGoogleCode.Text = "https://code.google.com/p/incident-watcher-tool/";
            this.lblGoogleCode.UseMnemonic = false;
            this.lblGoogleCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoogleCode_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Additional contributions from James Baird";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGoogleCode);
            this.Controls.Add(this.lblFattymanSite);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel lblFattymanSite;
        private System.Windows.Forms.LinkLabel lblGoogleCode;
        private System.Windows.Forms.Label label1;

    }
}

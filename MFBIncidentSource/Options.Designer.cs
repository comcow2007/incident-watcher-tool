//MFBIncidentSource - This incident source reads the MFB public feed for Incident Watcher
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
namespace MFBIncidentSource
{
    partial class Options
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
            this.btnResetToDefaults = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbctlOptions = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiamondActionArgs = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSquareActionArgs = new System.Windows.Forms.TextBox();
            this.txtCircleActionArgs = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnCircleBrowse = new System.Windows.Forms.Button();
            this.txtCircleActionPath = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSquareBrowse = new System.Windows.Forms.Button();
            this.txtSquareActionPath = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnTriangleBrowse = new System.Windows.Forms.Button();
            this.txtDiamondActionPath = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tabAutowatch = new System.Windows.Forms.TabPage();
            this.chkAutowatchEnabled = new System.Windows.Forms.CheckBox();
            this.grpAutoWatchOptions = new System.Windows.Forms.GroupBox();
            this.grpAWType = new System.Windows.Forms.GroupBox();
            this.chkListType = new System.Windows.Forms.CheckedListBox();
            this.grpAWStatus = new System.Windows.Forms.GroupBox();
            this.chkListStatus = new System.Windows.Forms.CheckedListBox();
            this.grpAWAppliances = new System.Windows.Forms.GroupBox();
            this.lblTotalAppliances = new System.Windows.Forms.Label();
            this.txtAWMinAppliances = new System.Windows.Forms.TextBox();
            this.txtAWAppliances = new System.Windows.Forms.TextBox();
            this.grpAWLocations = new System.Windows.Forms.GroupBox();
            this.txtAWLocations = new System.Windows.Forms.TextBox();
            this.grpAWSuburbs = new System.Windows.Forms.GroupBox();
            this.txtAWSuburbs = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRadioStream = new System.Windows.Forms.TextBox();
            this.tbctlOptions.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAutowatch.SuspendLayout();
            this.grpAutoWatchOptions.SuspendLayout();
            this.grpAWType.SuspendLayout();
            this.grpAWStatus.SuspendLayout();
            this.grpAWAppliances.SuspendLayout();
            this.grpAWLocations.SuspendLayout();
            this.grpAWSuburbs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnResetToDefaults
            // 
            this.btnResetToDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetToDefaults.Location = new System.Drawing.Point(4, 297);
            this.btnResetToDefaults.Name = "btnResetToDefaults";
            this.btnResetToDefaults.Size = new System.Drawing.Size(100, 23);
            this.btnResetToDefaults.TabIndex = 8;
            this.btnResetToDefaults.Text = "Reset to Defaults";
            this.btnResetToDefaults.UseVisualStyleBackColor = true;
            this.btnResetToDefaults.Click += new System.EventHandler(this.btnResetToDefaults_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(289, 297);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(370, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(451, 297);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbctlOptions
            // 
            this.tbctlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctlOptions.Controls.Add(this.tabGeneral);
            this.tbctlOptions.Controls.Add(this.tabAutowatch);
            this.tbctlOptions.Location = new System.Drawing.Point(0, 0);
            this.tbctlOptions.Name = "tbctlOptions";
            this.tbctlOptions.SelectedIndex = 0;
            this.tbctlOptions.Size = new System.Drawing.Size(526, 295);
            this.tbctlOptions.TabIndex = 9;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupBox2);
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(518, 269);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiamondActionArgs);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtSquareActionArgs);
            this.groupBox1.Controls.Add(this.txtCircleActionArgs);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.btnCircleBrowse);
            this.groupBox1.Controls.Add(this.txtCircleActionPath);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.btnSquareBrowse);
            this.groupBox1.Controls.Add(this.txtSquareActionPath);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.btnTriangleBrowse);
            this.groupBox1.Controls.Add(this.txtDiamondActionPath);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(8, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 210);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Defined Watch Actions";
            // 
            // txtDiamondActionArgs
            // 
            this.txtDiamondActionArgs.Location = new System.Drawing.Point(114, 150);
            this.txtDiamondActionArgs.Name = "txtDiamondActionArgs";
            this.txtDiamondActionArgs.Size = new System.Drawing.Size(381, 20);
            this.txtDiamondActionArgs.TabIndex = 15;
            this.txtDiamondActionArgs.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 153);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Diamond Action Args:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Square Action Args:";
            // 
            // txtSquareActionArgs
            // 
            this.txtSquareActionArgs.Location = new System.Drawing.Point(109, 94);
            this.txtSquareActionArgs.Name = "txtSquareActionArgs";
            this.txtSquareActionArgs.Size = new System.Drawing.Size(386, 20);
            this.txtSquareActionArgs.TabIndex = 12;
            this.txtSquareActionArgs.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtCircleActionArgs
            // 
            this.txtCircleActionArgs.Location = new System.Drawing.Point(101, 39);
            this.txtCircleActionArgs.Name = "txtCircleActionArgs";
            this.txtCircleActionArgs.Size = new System.Drawing.Size(394, 20);
            this.txtCircleActionArgs.TabIndex = 11;
            this.txtCircleActionArgs.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 16);
            this.label19.TabIndex = 10;
            this.label19.Text = "Circle Action Args:";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(6, 176);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(489, 29);
            this.label26.TabIndex = 9;
            this.label26.Text = "For actions the arguments that will be replaced are %ID% %SUBURB% %REGION% %ADDR%" +
                " %TYPE% %STREAM% %STATUS% %SIZE% %LASTUP% %APPLIANCES% and %CURTIME%";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCircleBrowse
            // 
            this.btnCircleBrowse.Location = new System.Drawing.Point(420, 14);
            this.btnCircleBrowse.Name = "btnCircleBrowse";
            this.btnCircleBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnCircleBrowse.TabIndex = 8;
            this.btnCircleBrowse.Text = "Browse";
            this.btnCircleBrowse.UseVisualStyleBackColor = true;
            this.btnCircleBrowse.Click += new System.EventHandler(this.btnCircleBrowse_Click);
            // 
            // txtCircleActionPath
            // 
            this.txtCircleActionPath.Location = new System.Drawing.Point(101, 16);
            this.txtCircleActionPath.Name = "txtCircleActionPath";
            this.txtCircleActionPath.Size = new System.Drawing.Size(313, 20);
            this.txtCircleActionPath.TabIndex = 7;
            this.txtCircleActionPath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(6, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 16);
            this.label25.TabIndex = 6;
            this.label25.Text = "Circle Action Path:";
            // 
            // btnSquareBrowse
            // 
            this.btnSquareBrowse.Location = new System.Drawing.Point(420, 69);
            this.btnSquareBrowse.Name = "btnSquareBrowse";
            this.btnSquareBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSquareBrowse.TabIndex = 5;
            this.btnSquareBrowse.Text = "Browse";
            this.btnSquareBrowse.UseVisualStyleBackColor = true;
            this.btnSquareBrowse.Click += new System.EventHandler(this.btnSquareBrowse_Click);
            // 
            // txtSquareActionPath
            // 
            this.txtSquareActionPath.Location = new System.Drawing.Point(109, 71);
            this.txtSquareActionPath.Name = "txtSquareActionPath";
            this.txtSquareActionPath.Size = new System.Drawing.Size(305, 20);
            this.txtSquareActionPath.TabIndex = 4;
            this.txtSquareActionPath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Square Action Path:";
            // 
            // btnTriangleBrowse
            // 
            this.btnTriangleBrowse.Location = new System.Drawing.Point(420, 125);
            this.btnTriangleBrowse.Name = "btnTriangleBrowse";
            this.btnTriangleBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnTriangleBrowse.TabIndex = 2;
            this.btnTriangleBrowse.Text = "Browse";
            this.btnTriangleBrowse.UseVisualStyleBackColor = true;
            this.btnTriangleBrowse.Click += new System.EventHandler(this.btnTriangleBrowse_Click);
            // 
            // txtDiamondActionPath
            // 
            this.txtDiamondActionPath.Location = new System.Drawing.Point(114, 127);
            this.txtDiamondActionPath.Name = "txtDiamondActionPath";
            this.txtDiamondActionPath.Size = new System.Drawing.Size(300, 20);
            this.txtDiamondActionPath.TabIndex = 1;
            this.txtDiamondActionPath.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Diamond Action Path:";
            // 
            // tabAutowatch
            // 
            this.tabAutowatch.Controls.Add(this.chkAutowatchEnabled);
            this.tabAutowatch.Controls.Add(this.grpAutoWatchOptions);
            this.tabAutowatch.Location = new System.Drawing.Point(4, 22);
            this.tabAutowatch.Name = "tabAutowatch";
            this.tabAutowatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutowatch.Size = new System.Drawing.Size(518, 269);
            this.tabAutowatch.TabIndex = 1;
            this.tabAutowatch.Text = "Auto-Watch";
            this.tabAutowatch.UseVisualStyleBackColor = true;
            // 
            // chkAutowatchEnabled
            // 
            this.chkAutowatchEnabled.AutoSize = true;
            this.chkAutowatchEnabled.Location = new System.Drawing.Point(118, 5);
            this.chkAutowatchEnabled.Name = "chkAutowatchEnabled";
            this.chkAutowatchEnabled.Size = new System.Drawing.Size(131, 17);
            this.chkAutowatchEnabled.TabIndex = 1;
            this.chkAutowatchEnabled.Text = "Auto-Watch Enabled?";
            this.chkAutowatchEnabled.UseVisualStyleBackColor = true;
            this.chkAutowatchEnabled.CheckedChanged += new System.EventHandler(this.chkAutowatchEnabled_CheckedChanged);
            // 
            // grpAutoWatchOptions
            // 
            this.grpAutoWatchOptions.Controls.Add(this.grpAWType);
            this.grpAutoWatchOptions.Controls.Add(this.grpAWStatus);
            this.grpAutoWatchOptions.Controls.Add(this.grpAWAppliances);
            this.grpAutoWatchOptions.Controls.Add(this.grpAWLocations);
            this.grpAutoWatchOptions.Controls.Add(this.grpAWSuburbs);
            this.grpAutoWatchOptions.Location = new System.Drawing.Point(6, 6);
            this.grpAutoWatchOptions.Name = "grpAutoWatchOptions";
            this.grpAutoWatchOptions.Size = new System.Drawing.Size(506, 257);
            this.grpAutoWatchOptions.TabIndex = 0;
            this.grpAutoWatchOptions.TabStop = false;
            this.grpAutoWatchOptions.Text = "Auto Watch Options";
            // 
            // grpAWType
            // 
            this.grpAWType.Controls.Add(this.chkListType);
            this.grpAWType.Location = new System.Drawing.Point(149, 151);
            this.grpAWType.Name = "grpAWType";
            this.grpAWType.Size = new System.Drawing.Size(136, 100);
            this.grpAWType.TabIndex = 4;
            this.grpAWType.TabStop = false;
            this.grpAWType.Text = "Type";
            // 
            // chkListType
            // 
            this.chkListType.CheckOnClick = true;
            this.chkListType.FormattingEnabled = true;
            this.chkListType.Location = new System.Drawing.Point(6, 15);
            this.chkListType.Name = "chkListType";
            this.chkListType.Size = new System.Drawing.Size(123, 79);
            this.chkListType.TabIndex = 1;
            this.chkListType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckList_ItemCheck);
            // 
            // grpAWStatus
            // 
            this.grpAWStatus.Controls.Add(this.chkListStatus);
            this.grpAWStatus.Location = new System.Drawing.Point(6, 151);
            this.grpAWStatus.Name = "grpAWStatus";
            this.grpAWStatus.Size = new System.Drawing.Size(137, 100);
            this.grpAWStatus.TabIndex = 3;
            this.grpAWStatus.TabStop = false;
            this.grpAWStatus.Text = "Status";
            // 
            // chkListStatus
            // 
            this.chkListStatus.CheckOnClick = true;
            this.chkListStatus.FormattingEnabled = true;
            this.chkListStatus.Location = new System.Drawing.Point(6, 15);
            this.chkListStatus.Name = "chkListStatus";
            this.chkListStatus.Size = new System.Drawing.Size(125, 79);
            this.chkListStatus.TabIndex = 0;
            this.chkListStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckList_ItemCheck);
            // 
            // grpAWAppliances
            // 
            this.grpAWAppliances.Controls.Add(this.lblTotalAppliances);
            this.grpAWAppliances.Controls.Add(this.txtAWMinAppliances);
            this.grpAWAppliances.Controls.Add(this.txtAWAppliances);
            this.grpAWAppliances.Location = new System.Drawing.Point(291, 151);
            this.grpAWAppliances.Name = "grpAWAppliances";
            this.grpAWAppliances.Size = new System.Drawing.Size(209, 100);
            this.grpAWAppliances.TabIndex = 2;
            this.grpAWAppliances.TabStop = false;
            this.grpAWAppliances.Text = "Appliances";
            // 
            // lblTotalAppliances
            // 
            this.lblTotalAppliances.Location = new System.Drawing.Point(140, 27);
            this.lblTotalAppliances.Name = "lblTotalAppliances";
            this.lblTotalAppliances.Size = new System.Drawing.Size(64, 43);
            this.lblTotalAppliances.TabIndex = 4;
            this.lblTotalAppliances.Text = "Appliance Count Trigger:";
            this.lblTotalAppliances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAWMinAppliances
            // 
            this.txtAWMinAppliances.Location = new System.Drawing.Point(140, 73);
            this.txtAWMinAppliances.Name = "txtAWMinAppliances";
            this.txtAWMinAppliances.Size = new System.Drawing.Size(61, 20);
            this.txtAWMinAppliances.TabIndex = 3;
            this.txtAWMinAppliances.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.txtAWMinAppliances.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAWMinAppliances_KeyPress);
            // 
            // txtAWAppliances
            // 
            this.txtAWAppliances.Location = new System.Drawing.Point(9, 19);
            this.txtAWAppliances.Multiline = true;
            this.txtAWAppliances.Name = "txtAWAppliances";
            this.txtAWAppliances.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAWAppliances.Size = new System.Drawing.Size(125, 74);
            this.txtAWAppliances.TabIndex = 2;
            this.txtAWAppliances.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // grpAWLocations
            // 
            this.grpAWLocations.Controls.Add(this.txtAWLocations);
            this.grpAWLocations.Location = new System.Drawing.Point(253, 22);
            this.grpAWLocations.Name = "grpAWLocations";
            this.grpAWLocations.Size = new System.Drawing.Size(247, 123);
            this.grpAWLocations.TabIndex = 1;
            this.grpAWLocations.TabStop = false;
            this.grpAWLocations.Text = "Locations";
            // 
            // txtAWLocations
            // 
            this.txtAWLocations.Location = new System.Drawing.Point(6, 14);
            this.txtAWLocations.Multiline = true;
            this.txtAWLocations.Name = "txtAWLocations";
            this.txtAWLocations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAWLocations.Size = new System.Drawing.Size(237, 103);
            this.txtAWLocations.TabIndex = 1;
            this.txtAWLocations.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // grpAWSuburbs
            // 
            this.grpAWSuburbs.Controls.Add(this.txtAWSuburbs);
            this.grpAWSuburbs.Location = new System.Drawing.Point(6, 22);
            this.grpAWSuburbs.Name = "grpAWSuburbs";
            this.grpAWSuburbs.Size = new System.Drawing.Size(244, 123);
            this.grpAWSuburbs.TabIndex = 0;
            this.grpAWSuburbs.TabStop = false;
            this.grpAWSuburbs.Text = "Suburbs";
            // 
            // txtAWSuburbs
            // 
            this.txtAWSuburbs.Location = new System.Drawing.Point(6, 14);
            this.txtAWSuburbs.Multiline = true;
            this.txtAWSuburbs.Name = "txtAWSuburbs";
            this.txtAWSuburbs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAWSuburbs.Size = new System.Drawing.Size(231, 103);
            this.txtAWSuburbs.TabIndex = 0;
            this.txtAWSuburbs.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "EXE Files|*.exe";
            this.openFileDialog.Title = "Please select a listener application";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRadioStream);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 43);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Radio Stream";
            // 
            // txtRadioStream
            // 
            this.txtRadioStream.Location = new System.Drawing.Point(6, 15);
            this.txtRadioStream.Name = "txtRadioStream";
            this.txtRadioStream.Size = new System.Drawing.Size(489, 20);
            this.txtRadioStream.TabIndex = 8;
            this.txtRadioStream.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(529, 323);
            this.Controls.Add(this.tbctlOptions);
            this.Controls.Add(this.btnResetToDefaults);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MFB Public Feed Options";
            this.tbctlOptions.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAutowatch.ResumeLayout(false);
            this.tabAutowatch.PerformLayout();
            this.grpAutoWatchOptions.ResumeLayout(false);
            this.grpAWType.ResumeLayout(false);
            this.grpAWStatus.ResumeLayout(false);
            this.grpAWAppliances.ResumeLayout(false);
            this.grpAWAppliances.PerformLayout();
            this.grpAWLocations.ResumeLayout(false);
            this.grpAWLocations.PerformLayout();
            this.grpAWSuburbs.ResumeLayout(false);
            this.grpAWSuburbs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResetToDefaults;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabControl tbctlOptions;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabAutowatch;
        private System.Windows.Forms.CheckBox chkAutowatchEnabled;
        private System.Windows.Forms.GroupBox grpAutoWatchOptions;
        private System.Windows.Forms.GroupBox grpAWAppliances;
        private System.Windows.Forms.GroupBox grpAWLocations;
        private System.Windows.Forms.GroupBox grpAWSuburbs;
        private System.Windows.Forms.TextBox txtAWSuburbs;
        private System.Windows.Forms.Label lblTotalAppliances;
        private System.Windows.Forms.TextBox txtAWMinAppliances;
        private System.Windows.Forms.TextBox txtAWAppliances;
        private System.Windows.Forms.TextBox txtAWLocations;
        private System.Windows.Forms.GroupBox grpAWType;
        private System.Windows.Forms.GroupBox grpAWStatus;
        private System.Windows.Forms.CheckedListBox chkListType;
        private System.Windows.Forms.CheckedListBox chkListStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiamondActionArgs;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSquareActionArgs;
        private System.Windows.Forms.TextBox txtCircleActionArgs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnCircleBrowse;
        private System.Windows.Forms.TextBox txtCircleActionPath;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnSquareBrowse;
        private System.Windows.Forms.TextBox txtSquareActionPath;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnTriangleBrowse;
        private System.Windows.Forms.TextBox txtDiamondActionPath;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRadioStream;
    }
}
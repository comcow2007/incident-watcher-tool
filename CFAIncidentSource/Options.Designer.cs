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
    partial class OptionsForm
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
            this.tabAutoWatch = new System.Windows.Forms.TabPage();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.chkSafe = new System.Windows.Forms.CheckBox();
            this.chkControlled = new System.Windows.Forms.CheckBox();
            this.chkContained = new System.Windows.Forms.CheckBox();
            this.chkGoing = new System.Windows.Forms.CheckBox();
            this.cmbMinSize = new System.Windows.Forms.ComboBox();
            this.txtMinimumAppliances = new System.Windows.Forms.TextBox();
            this.grpRegions = new System.Windows.Forms.GroupBox();
            this.txtRegions = new System.Windows.Forms.TextBox();
            this.lblRegions = new System.Windows.Forms.Label();
            this.grpTypes = new System.Windows.Forms.GroupBox();
            this.chkTypeScrub = new System.Windows.Forms.CheckBox();
            this.chkTypeHazmat = new System.Windows.Forms.CheckBox();
            this.chkTypeWildfire = new System.Windows.Forms.CheckBox();
            this.chkTypeFalseAlarm = new System.Windows.Forms.CheckBox();
            this.chkTypeOther = new System.Windows.Forms.CheckBox();
            this.chkTypeIncident = new System.Windows.Forms.CheckBox();
            this.chkTypeRescue = new System.Windows.Forms.CheckBox();
            this.chkTypeStru = new System.Windows.Forms.CheckBox();
            this.chkTypeNost = new System.Windows.Forms.CheckBox();
            this.chkTypeGandS = new System.Windows.Forms.CheckBox();
            this.lblInciTypes = new System.Windows.Forms.Label();
            this.grpAddresses = new System.Windows.Forms.GroupBox();
            this.txtAddresses = new System.Windows.Forms.TextBox();
            this.lblAddresses = new System.Windows.Forms.Label();
            this.grpSuburbs = new System.Windows.Forms.GroupBox();
            this.txtSuburbs = new System.Windows.Forms.TextBox();
            this.lblSuburbs = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblMinApplicances = new System.Windows.Forms.Label();
            this.tabRadioStreams = new System.Windows.Forms.TabPage();
            this.txtStream2 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtStream4 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.grpStreamAppSettings = new System.Windows.Forms.GroupBox();
            this.chkRunStreamOnWatch = new System.Windows.Forms.CheckBox();
            this.btnListenerPathBrowse = new System.Windows.Forms.Button();
            this.lblArgumentDescriptions = new System.Windows.Forms.Label();
            this.txtStreamListenerArgs = new System.Windows.Forms.TextBox();
            this.lblListenerArguments = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtStreamListenerPath = new System.Windows.Forms.TextBox();
            this.txtStream10 = new System.Windows.Forms.TextBox();
            this.txtStream9 = new System.Windows.Forms.TextBox();
            this.txtStream8 = new System.Windows.Forms.TextBox();
            this.txtStream7 = new System.Windows.Forms.TextBox();
            this.txtStream6 = new System.Windows.Forms.TextBox();
            this.txtStream5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStrRegion5 = new System.Windows.Forms.Label();
            this.tabMoreRadioStreams = new System.Windows.Forms.TabPage();
            this.txtStream11 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStream12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStream14 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStream13 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStream18 = new System.Windows.Forms.TextBox();
            this.txtStream17 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStream16 = new System.Windows.Forms.TextBox();
            this.txtStream15 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStream24 = new System.Windows.Forms.TextBox();
            this.txtStream23 = new System.Windows.Forms.TextBox();
            this.txtStream22 = new System.Windows.Forms.TextBox();
            this.txtStream20 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnResetToDefaults = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chkTypeWashaway = new System.Windows.Forms.CheckBox();
            this.chkTypeAssist = new System.Windows.Forms.CheckBox();
            this.tbctlOptions.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAutoWatch.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpRegions.SuspendLayout();
            this.grpTypes.SuspendLayout();
            this.grpAddresses.SuspendLayout();
            this.grpSuburbs.SuspendLayout();
            this.tabRadioStreams.SuspendLayout();
            this.grpStreamAppSettings.SuspendLayout();
            this.tabMoreRadioStreams.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctlOptions
            // 
            this.tbctlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctlOptions.Controls.Add(this.tabGeneral);
            this.tbctlOptions.Controls.Add(this.tabAutoWatch);
            this.tbctlOptions.Controls.Add(this.tabRadioStreams);
            this.tbctlOptions.Controls.Add(this.tabMoreRadioStreams);
            this.tbctlOptions.Location = new System.Drawing.Point(0, 0);
            this.tbctlOptions.Name = "tbctlOptions";
            this.tbctlOptions.SelectedIndex = 0;
            this.tbctlOptions.Size = new System.Drawing.Size(539, 360);
            this.tbctlOptions.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.groupBox1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(531, 334);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Defined Actions";
            // 
            // txtDiamondActionArgs
            // 
            this.txtDiamondActionArgs.Location = new System.Drawing.Point(114, 167);
            this.txtDiamondActionArgs.Name = "txtDiamondActionArgs";
            this.txtDiamondActionArgs.Size = new System.Drawing.Size(393, 20);
            this.txtDiamondActionArgs.TabIndex = 15;
            this.txtDiamondActionArgs.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 170);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(109, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Diamond Action Args:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 107);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 13);
            this.label21.TabIndex = 13;
            this.label21.Text = "Square Action Args:";
            // 
            // txtSquareActionArgs
            // 
            this.txtSquareActionArgs.Location = new System.Drawing.Point(109, 104);
            this.txtSquareActionArgs.Name = "txtSquareActionArgs";
            this.txtSquareActionArgs.Size = new System.Drawing.Size(398, 20);
            this.txtSquareActionArgs.TabIndex = 12;
            this.txtSquareActionArgs.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtCircleActionArgs
            // 
            this.txtCircleActionArgs.Location = new System.Drawing.Point(101, 42);
            this.txtCircleActionArgs.Name = "txtCircleActionArgs";
            this.txtCircleActionArgs.Size = new System.Drawing.Size(406, 20);
            this.txtCircleActionArgs.TabIndex = 11;
            this.txtCircleActionArgs.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 16);
            this.label19.TabIndex = 10;
            this.label19.Text = "Circle Action Args:";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(6, 200);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(499, 29);
            this.label26.TabIndex = 9;
            this.label26.Text = "For actions the arguments that will be replaced are %ID% %SUBURB% %REGION% %ADDR%" +
                " %TYPE% %STREAM% %STATUS% %SIZE% %LASTUP% %APPLIANCES% and %CURTIME%";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCircleBrowse
            // 
            this.btnCircleBrowse.Location = new System.Drawing.Point(433, 14);
            this.btnCircleBrowse.Name = "btnCircleBrowse";
            this.btnCircleBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnCircleBrowse.TabIndex = 8;
            this.btnCircleBrowse.Text = "Browse";
            this.btnCircleBrowse.UseVisualStyleBackColor = true;
            this.btnCircleBrowse.Click += new System.EventHandler(this.BtnCircleBrowseClick);
            // 
            // txtCircleActionPath
            // 
            this.txtCircleActionPath.Location = new System.Drawing.Point(101, 16);
            this.txtCircleActionPath.Name = "txtCircleActionPath";
            this.txtCircleActionPath.Size = new System.Drawing.Size(326, 20);
            this.txtCircleActionPath.TabIndex = 7;
            this.txtCircleActionPath.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
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
            this.btnSquareBrowse.Location = new System.Drawing.Point(433, 76);
            this.btnSquareBrowse.Name = "btnSquareBrowse";
            this.btnSquareBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSquareBrowse.TabIndex = 5;
            this.btnSquareBrowse.Text = "Browse";
            this.btnSquareBrowse.UseVisualStyleBackColor = true;
            this.btnSquareBrowse.Click += new System.EventHandler(this.BtnSquareBrowseClick);
            // 
            // txtSquareActionPath
            // 
            this.txtSquareActionPath.Location = new System.Drawing.Point(109, 78);
            this.txtSquareActionPath.Name = "txtSquareActionPath";
            this.txtSquareActionPath.Size = new System.Drawing.Size(318, 20);
            this.txtSquareActionPath.TabIndex = 4;
            this.txtSquareActionPath.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 81);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Square Action Path:";
            // 
            // btnTriangleBrowse
            // 
            this.btnTriangleBrowse.Location = new System.Drawing.Point(433, 138);
            this.btnTriangleBrowse.Name = "btnTriangleBrowse";
            this.btnTriangleBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnTriangleBrowse.TabIndex = 2;
            this.btnTriangleBrowse.Text = "Browse";
            this.btnTriangleBrowse.UseVisualStyleBackColor = true;
            this.btnTriangleBrowse.Click += new System.EventHandler(this.BtnTriangleBrowseClick);
            // 
            // txtDiamondActionPath
            // 
            this.txtDiamondActionPath.Location = new System.Drawing.Point(114, 141);
            this.txtDiamondActionPath.Name = "txtDiamondActionPath";
            this.txtDiamondActionPath.Size = new System.Drawing.Size(313, 20);
            this.txtDiamondActionPath.TabIndex = 1;
            this.txtDiamondActionPath.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(110, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Diamond Action Path:";
            // 
            // tabAutoWatch
            // 
            this.tabAutoWatch.Controls.Add(this.grpStatus);
            this.tabAutoWatch.Controls.Add(this.cmbMinSize);
            this.tabAutoWatch.Controls.Add(this.txtMinimumAppliances);
            this.tabAutoWatch.Controls.Add(this.grpRegions);
            this.tabAutoWatch.Controls.Add(this.grpTypes);
            this.tabAutoWatch.Controls.Add(this.grpAddresses);
            this.tabAutoWatch.Controls.Add(this.grpSuburbs);
            this.tabAutoWatch.Controls.Add(this.lblSize);
            this.tabAutoWatch.Controls.Add(this.lblMinApplicances);
            this.tabAutoWatch.Location = new System.Drawing.Point(4, 22);
            this.tabAutoWatch.Name = "tabAutoWatch";
            this.tabAutoWatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutoWatch.Size = new System.Drawing.Size(531, 334);
            this.tabAutoWatch.TabIndex = 1;
            this.tabAutoWatch.Text = "Auto Watch";
            this.tabAutoWatch.UseVisualStyleBackColor = true;
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.chkSafe);
            this.grpStatus.Controls.Add(this.chkControlled);
            this.grpStatus.Controls.Add(this.chkContained);
            this.grpStatus.Controls.Add(this.chkGoing);
            this.grpStatus.Location = new System.Drawing.Point(8, 282);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(275, 43);
            this.grpStatus.TabIndex = 13;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // chkSafe
            // 
            this.chkSafe.AutoSize = true;
            this.chkSafe.Location = new System.Drawing.Point(225, 19);
            this.chkSafe.Name = "chkSafe";
            this.chkSafe.Size = new System.Drawing.Size(48, 17);
            this.chkSafe.TabIndex = 3;
            this.chkSafe.Text = "Safe";
            this.chkSafe.UseVisualStyleBackColor = true;
            this.chkSafe.CheckedChanged += new System.EventHandler(this.chkGoing_CheckedChanged);
            // 
            // chkControlled
            // 
            this.chkControlled.AutoSize = true;
            this.chkControlled.Location = new System.Drawing.Point(146, 19);
            this.chkControlled.Name = "chkControlled";
            this.chkControlled.Size = new System.Drawing.Size(73, 17);
            this.chkControlled.TabIndex = 2;
            this.chkControlled.Text = "Controlled";
            this.chkControlled.UseVisualStyleBackColor = true;
            this.chkControlled.CheckedChanged += new System.EventHandler(this.chkGoing_CheckedChanged);
            // 
            // chkContained
            // 
            this.chkContained.AutoSize = true;
            this.chkContained.Location = new System.Drawing.Point(66, 19);
            this.chkContained.Name = "chkContained";
            this.chkContained.Size = new System.Drawing.Size(74, 17);
            this.chkContained.TabIndex = 1;
            this.chkContained.Text = "Contained";
            this.chkContained.UseVisualStyleBackColor = true;
            this.chkContained.CheckedChanged += new System.EventHandler(this.chkGoing_CheckedChanged);
            // 
            // chkGoing
            // 
            this.chkGoing.AutoSize = true;
            this.chkGoing.Location = new System.Drawing.Point(6, 19);
            this.chkGoing.Name = "chkGoing";
            this.chkGoing.Size = new System.Drawing.Size(54, 17);
            this.chkGoing.TabIndex = 0;
            this.chkGoing.Text = "Going";
            this.chkGoing.UseVisualStyleBackColor = true;
            this.chkGoing.CheckedChanged += new System.EventHandler(this.chkGoing_CheckedChanged);
            // 
            // cmbMinSize
            // 
            this.cmbMinSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinSize.FormattingEnabled = true;
            this.cmbMinSize.Items.AddRange(new object[] {
            "Ignore",
            "Spot",
            "Small",
            "Medium",
            "Large"});
            this.cmbMinSize.Location = new System.Drawing.Point(396, 282);
            this.cmbMinSize.Name = "cmbMinSize";
            this.cmbMinSize.Size = new System.Drawing.Size(121, 21);
            this.cmbMinSize.TabIndex = 12;
            this.cmbMinSize.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // txtMinimumAppliances
            // 
            this.txtMinimumAppliances.Location = new System.Drawing.Point(488, 309);
            this.txtMinimumAppliances.Name = "txtMinimumAppliances";
            this.txtMinimumAppliances.Size = new System.Drawing.Size(29, 20);
            this.txtMinimumAppliances.TabIndex = 11;
            this.txtMinimumAppliances.TextChanged += new System.EventHandler(this.txtMinimumAppliances_TextChanged);
            this.txtMinimumAppliances.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // grpRegions
            // 
            this.grpRegions.Controls.Add(this.txtRegions);
            this.grpRegions.Controls.Add(this.lblRegions);
            this.grpRegions.Location = new System.Drawing.Point(270, 140);
            this.grpRegions.Name = "grpRegions";
            this.grpRegions.Size = new System.Drawing.Size(254, 136);
            this.grpRegions.TabIndex = 10;
            this.grpRegions.TabStop = false;
            this.grpRegions.Text = "Regions";
            // 
            // txtRegions
            // 
            this.txtRegions.Location = new System.Drawing.Point(6, 44);
            this.txtRegions.Multiline = true;
            this.txtRegions.Name = "txtRegions";
            this.txtRegions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegions.Size = new System.Drawing.Size(241, 86);
            this.txtRegions.TabIndex = 5;
            this.txtRegions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegions_KeyPress);
            this.txtRegions.ModifiedChanged += new System.EventHandler(this.txtRegions_ModifiedChanged);
            // 
            // lblRegions
            // 
            this.lblRegions.Location = new System.Drawing.Point(3, 16);
            this.lblRegions.Name = "lblRegions";
            this.lblRegions.Size = new System.Drawing.Size(245, 27);
            this.lblRegions.TabIndex = 4;
            this.lblRegions.Text = "One region number per line.                              Leave empty to ignore:";
            // 
            // grpTypes
            // 
            this.grpTypes.Controls.Add(this.chkTypeAssist);
            this.grpTypes.Controls.Add(this.chkTypeWashaway);
            this.grpTypes.Controls.Add(this.chkTypeScrub);
            this.grpTypes.Controls.Add(this.chkTypeHazmat);
            this.grpTypes.Controls.Add(this.chkTypeWildfire);
            this.grpTypes.Controls.Add(this.chkTypeFalseAlarm);
            this.grpTypes.Controls.Add(this.chkTypeOther);
            this.grpTypes.Controls.Add(this.chkTypeIncident);
            this.grpTypes.Controls.Add(this.chkTypeRescue);
            this.grpTypes.Controls.Add(this.chkTypeStru);
            this.grpTypes.Controls.Add(this.chkTypeNost);
            this.grpTypes.Controls.Add(this.chkTypeGandS);
            this.grpTypes.Controls.Add(this.lblInciTypes);
            this.grpTypes.Location = new System.Drawing.Point(8, 140);
            this.grpTypes.Name = "grpTypes";
            this.grpTypes.Size = new System.Drawing.Size(254, 136);
            this.grpTypes.TabIndex = 9;
            this.grpTypes.TabStop = false;
            this.grpTypes.Text = "Types";
            // 
            // chkTypeScrub
            // 
            this.chkTypeScrub.AutoSize = true;
            this.chkTypeScrub.Location = new System.Drawing.Point(179, 70);
            this.chkTypeScrub.Name = "chkTypeScrub";
            this.chkTypeScrub.Size = new System.Drawing.Size(54, 17);
            this.chkTypeScrub.TabIndex = 12;
            this.chkTypeScrub.Text = "Scrub";
            this.chkTypeScrub.UseVisualStyleBackColor = true;
            this.chkTypeScrub.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeHazmat
            // 
            this.chkTypeHazmat.AutoSize = true;
            this.chkTypeHazmat.Location = new System.Drawing.Point(179, 47);
            this.chkTypeHazmat.Name = "chkTypeHazmat";
            this.chkTypeHazmat.Size = new System.Drawing.Size(62, 17);
            this.chkTypeHazmat.TabIndex = 11;
            this.chkTypeHazmat.Text = "Hazmat";
            this.chkTypeHazmat.UseVisualStyleBackColor = true;
            this.chkTypeHazmat.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeWildfire
            // 
            this.chkTypeWildfire.AutoSize = true;
            this.chkTypeWildfire.Location = new System.Drawing.Point(99, 116);
            this.chkTypeWildfire.Name = "chkTypeWildfire";
            this.chkTypeWildfire.Size = new System.Drawing.Size(61, 17);
            this.chkTypeWildfire.TabIndex = 10;
            this.chkTypeWildfire.Text = "Wildfire";
            this.chkTypeWildfire.UseVisualStyleBackColor = true;
            this.chkTypeWildfire.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeFalseAlarm
            // 
            this.chkTypeFalseAlarm.AutoSize = true;
            this.chkTypeFalseAlarm.Location = new System.Drawing.Point(99, 93);
            this.chkTypeFalseAlarm.Name = "chkTypeFalseAlarm";
            this.chkTypeFalseAlarm.Size = new System.Drawing.Size(80, 17);
            this.chkTypeFalseAlarm.TabIndex = 9;
            this.chkTypeFalseAlarm.Text = "False Alarm";
            this.chkTypeFalseAlarm.UseVisualStyleBackColor = true;
            this.chkTypeFalseAlarm.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeOther
            // 
            this.chkTypeOther.AutoSize = true;
            this.chkTypeOther.Location = new System.Drawing.Point(99, 70);
            this.chkTypeOther.Name = "chkTypeOther";
            this.chkTypeOther.Size = new System.Drawing.Size(52, 17);
            this.chkTypeOther.TabIndex = 8;
            this.chkTypeOther.Text = "Other";
            this.chkTypeOther.UseVisualStyleBackColor = true;
            this.chkTypeOther.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeIncident
            // 
            this.chkTypeIncident.AutoSize = true;
            this.chkTypeIncident.Location = new System.Drawing.Point(99, 46);
            this.chkTypeIncident.Name = "chkTypeIncident";
            this.chkTypeIncident.Size = new System.Drawing.Size(64, 17);
            this.chkTypeIncident.TabIndex = 7;
            this.chkTypeIncident.Text = "Incident";
            this.chkTypeIncident.UseVisualStyleBackColor = true;
            this.chkTypeIncident.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeRescue
            // 
            this.chkTypeRescue.AutoSize = true;
            this.chkTypeRescue.Location = new System.Drawing.Point(6, 116);
            this.chkTypeRescue.Name = "chkTypeRescue";
            this.chkTypeRescue.Size = new System.Drawing.Size(63, 17);
            this.chkTypeRescue.TabIndex = 6;
            this.chkTypeRescue.Text = "Rescue";
            this.chkTypeRescue.UseVisualStyleBackColor = true;
            this.chkTypeRescue.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeStru
            // 
            this.chkTypeStru.AutoSize = true;
            this.chkTypeStru.Location = new System.Drawing.Point(6, 93);
            this.chkTypeStru.Name = "chkTypeStru";
            this.chkTypeStru.Size = new System.Drawing.Size(69, 17);
            this.chkTypeStru.TabIndex = 5;
            this.chkTypeStru.Text = "Structure";
            this.chkTypeStru.UseVisualStyleBackColor = true;
            this.chkTypeStru.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeNost
            // 
            this.chkTypeNost.AutoSize = true;
            this.chkTypeNost.Location = new System.Drawing.Point(6, 70);
            this.chkTypeNost.Name = "chkTypeNost";
            this.chkTypeNost.Size = new System.Drawing.Size(92, 17);
            this.chkTypeNost.TabIndex = 4;
            this.chkTypeNost.Text = "Non-Structure";
            this.chkTypeNost.UseVisualStyleBackColor = true;
            this.chkTypeNost.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeGandS
            // 
            this.chkTypeGandS.AutoSize = true;
            this.chkTypeGandS.Location = new System.Drawing.Point(6, 47);
            this.chkTypeGandS.Name = "chkTypeGandS";
            this.chkTypeGandS.Size = new System.Drawing.Size(47, 17);
            this.chkTypeGandS.TabIndex = 3;
            this.chkTypeGandS.Text = "G&S";
            this.chkTypeGandS.UseMnemonic = false;
            this.chkTypeGandS.UseVisualStyleBackColor = true;
            this.chkTypeGandS.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // lblInciTypes
            // 
            this.lblInciTypes.Location = new System.Drawing.Point(3, 16);
            this.lblInciTypes.Name = "lblInciTypes";
            this.lblInciTypes.Size = new System.Drawing.Size(244, 27);
            this.lblInciTypes.TabIndex = 2;
            this.lblInciTypes.Text = "Check all the incident types to AutoWatch. Uncheck all to ignore:";
            // 
            // grpAddresses
            // 
            this.grpAddresses.Controls.Add(this.txtAddresses);
            this.grpAddresses.Controls.Add(this.lblAddresses);
            this.grpAddresses.Location = new System.Drawing.Point(270, 6);
            this.grpAddresses.Name = "grpAddresses";
            this.grpAddresses.Size = new System.Drawing.Size(254, 128);
            this.grpAddresses.TabIndex = 8;
            this.grpAddresses.TabStop = false;
            this.grpAddresses.Text = "Addresses";
            // 
            // txtAddresses
            // 
            this.txtAddresses.Location = new System.Drawing.Point(6, 46);
            this.txtAddresses.Multiline = true;
            this.txtAddresses.Name = "txtAddresses";
            this.txtAddresses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddresses.Size = new System.Drawing.Size(241, 72);
            this.txtAddresses.TabIndex = 2;
            this.txtAddresses.ModifiedChanged += new System.EventHandler(this.txtAddresses_ModifiedChanged);
            // 
            // lblAddresses
            // 
            this.lblAddresses.Location = new System.Drawing.Point(3, 16);
            this.lblAddresses.Name = "lblAddresses";
            this.lblAddresses.Size = new System.Drawing.Size(244, 26);
            this.lblAddresses.TabIndex = 1;
            this.lblAddresses.Text = "One per line, you can add wildcard * to the start and/or end of the address. Leav" +
                "e empty to ignore:";
            // 
            // grpSuburbs
            // 
            this.grpSuburbs.Controls.Add(this.txtSuburbs);
            this.grpSuburbs.Controls.Add(this.lblSuburbs);
            this.grpSuburbs.Location = new System.Drawing.Point(8, 6);
            this.grpSuburbs.Name = "grpSuburbs";
            this.grpSuburbs.Size = new System.Drawing.Size(254, 128);
            this.grpSuburbs.TabIndex = 7;
            this.grpSuburbs.TabStop = false;
            this.grpSuburbs.Text = "Suburbs";
            // 
            // txtSuburbs
            // 
            this.txtSuburbs.Location = new System.Drawing.Point(6, 46);
            this.txtSuburbs.Multiline = true;
            this.txtSuburbs.Name = "txtSuburbs";
            this.txtSuburbs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSuburbs.Size = new System.Drawing.Size(241, 72);
            this.txtSuburbs.TabIndex = 1;
            this.txtSuburbs.ModifiedChanged += new System.EventHandler(this.txtSuburbs_ModifiedChanged);
            // 
            // lblSuburbs
            // 
            this.lblSuburbs.Location = new System.Drawing.Point(9, 16);
            this.lblSuburbs.Name = "lblSuburbs";
            this.lblSuburbs.Size = new System.Drawing.Size(241, 26);
            this.lblSuburbs.TabIndex = 0;
            this.lblSuburbs.Text = "One per line, you can add wildcard * to the start and/or end of the suburb. Leave" +
                " empty to ignore:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(340, 285);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(50, 13);
            this.lblSize.TabIndex = 6;
            this.lblSize.Text = "Min Size:";
            // 
            // lblMinApplicances
            // 
            this.lblMinApplicances.AutoSize = true;
            this.lblMinApplicances.Location = new System.Drawing.Point(349, 312);
            this.lblMinApplicances.Name = "lblMinApplicances";
            this.lblMinApplicances.Size = new System.Drawing.Size(133, 13);
            this.lblMinApplicances.TabIndex = 5;
            this.lblMinApplicances.Text = "Min Appliances (0=Ignore):";
            // 
            // tabRadioStreams
            // 
            this.tabRadioStreams.Controls.Add(this.txtStream2);
            this.tabRadioStreams.Controls.Add(this.label28);
            this.tabRadioStreams.Controls.Add(this.txtStream4);
            this.tabRadioStreams.Controls.Add(this.label27);
            this.tabRadioStreams.Controls.Add(this.grpStreamAppSettings);
            this.tabRadioStreams.Controls.Add(this.txtStream10);
            this.tabRadioStreams.Controls.Add(this.txtStream9);
            this.tabRadioStreams.Controls.Add(this.txtStream8);
            this.tabRadioStreams.Controls.Add(this.txtStream7);
            this.tabRadioStreams.Controls.Add(this.txtStream6);
            this.tabRadioStreams.Controls.Add(this.txtStream5);
            this.tabRadioStreams.Controls.Add(this.label7);
            this.tabRadioStreams.Controls.Add(this.label6);
            this.tabRadioStreams.Controls.Add(this.label5);
            this.tabRadioStreams.Controls.Add(this.label4);
            this.tabRadioStreams.Controls.Add(this.label3);
            this.tabRadioStreams.Controls.Add(this.lblStrRegion5);
            this.tabRadioStreams.Location = new System.Drawing.Point(4, 22);
            this.tabRadioStreams.Name = "tabRadioStreams";
            this.tabRadioStreams.Padding = new System.Windows.Forms.Padding(3);
            this.tabRadioStreams.Size = new System.Drawing.Size(531, 334);
            this.tabRadioStreams.TabIndex = 2;
            this.tabRadioStreams.Text = "Radio Streams";
            this.tabRadioStreams.UseVisualStyleBackColor = true;
            // 
            // txtStream2
            // 
            this.txtStream2.Location = new System.Drawing.Point(66, 118);
            this.txtStream2.Name = "txtStream2";
            this.txtStream2.Size = new System.Drawing.Size(455, 20);
            this.txtStream2.TabIndex = 38;
            this.txtStream2.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 121);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 13);
            this.label28.TabIndex = 37;
            this.label28.Text = "Region 2:";
            // 
            // txtStream4
            // 
            this.txtStream4.Location = new System.Drawing.Point(66, 144);
            this.txtStream4.Name = "txtStream4";
            this.txtStream4.Size = new System.Drawing.Size(455, 20);
            this.txtStream4.TabIndex = 36;
            this.txtStream4.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 147);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 35;
            this.label27.Text = "Region 4:";
            // 
            // grpStreamAppSettings
            // 
            this.grpStreamAppSettings.Controls.Add(this.chkRunStreamOnWatch);
            this.grpStreamAppSettings.Controls.Add(this.btnListenerPathBrowse);
            this.grpStreamAppSettings.Controls.Add(this.lblArgumentDescriptions);
            this.grpStreamAppSettings.Controls.Add(this.txtStreamListenerArgs);
            this.grpStreamAppSettings.Controls.Add(this.lblListenerArguments);
            this.grpStreamAppSettings.Controls.Add(this.label22);
            this.grpStreamAppSettings.Controls.Add(this.txtStreamListenerPath);
            this.grpStreamAppSettings.Location = new System.Drawing.Point(8, 6);
            this.grpStreamAppSettings.Name = "grpStreamAppSettings";
            this.grpStreamAppSettings.Size = new System.Drawing.Size(513, 100);
            this.grpStreamAppSettings.TabIndex = 34;
            this.grpStreamAppSettings.TabStop = false;
            this.grpStreamAppSettings.Text = "Stream Listener Application";
            // 
            // chkRunStreamOnWatch
            // 
            this.chkRunStreamOnWatch.AutoSize = true;
            this.chkRunStreamOnWatch.Location = new System.Drawing.Point(372, 78);
            this.chkRunStreamOnWatch.Name = "chkRunStreamOnWatch";
            this.chkRunStreamOnWatch.Size = new System.Drawing.Size(133, 17);
            this.chkRunStreamOnWatch.TabIndex = 6;
            this.chkRunStreamOnWatch.Text = "Run stream on watch?";
            this.chkRunStreamOnWatch.UseVisualStyleBackColor = true;
            this.chkRunStreamOnWatch.CheckedChanged += new System.EventHandler(this.chkRunStreamOnWatch_CheckedChanged);
            // 
            // btnListenerPathBrowse
            // 
            this.btnListenerPathBrowse.Location = new System.Drawing.Point(448, 14);
            this.btnListenerPathBrowse.Name = "btnListenerPathBrowse";
            this.btnListenerPathBrowse.Size = new System.Drawing.Size(57, 23);
            this.btnListenerPathBrowse.TabIndex = 5;
            this.btnListenerPathBrowse.Text = "Browse";
            this.btnListenerPathBrowse.UseVisualStyleBackColor = true;
            this.btnListenerPathBrowse.Click += new System.EventHandler(this.BtnListenerPathBrowseClick);
            // 
            // lblArgumentDescriptions
            // 
            this.lblArgumentDescriptions.Location = new System.Drawing.Point(8, 66);
            this.lblArgumentDescriptions.Name = "lblArgumentDescriptions";
            this.lblArgumentDescriptions.Size = new System.Drawing.Size(499, 29);
            this.lblArgumentDescriptions.TabIndex = 4;
            this.lblArgumentDescriptions.Text = "Arguments that will be replaced are %ID% %SUBURB% %REGION% %ADDR% %TYPE% %STREAM%" +
                " %STATUS% %SIZE% %LASTUP% %APPLIANCES% and %CURTIME%";
            // 
            // txtStreamListenerArgs
            // 
            this.txtStreamListenerArgs.Location = new System.Drawing.Point(112, 43);
            this.txtStreamListenerArgs.Name = "txtStreamListenerArgs";
            this.txtStreamListenerArgs.Size = new System.Drawing.Size(393, 20);
            this.txtStreamListenerArgs.TabIndex = 3;
            this.txtStreamListenerArgs.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // lblListenerArguments
            // 
            this.lblListenerArguments.AutoSize = true;
            this.lblListenerArguments.Location = new System.Drawing.Point(6, 46);
            this.lblListenerArguments.Name = "lblListenerArguments";
            this.lblListenerArguments.Size = new System.Drawing.Size(100, 13);
            this.lblListenerArguments.TabIndex = 2;
            this.lblListenerArguments.Text = "Listener Arguments:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Listener Path:";
            // 
            // txtStreamListenerPath
            // 
            this.txtStreamListenerPath.Location = new System.Drawing.Point(84, 17);
            this.txtStreamListenerPath.Name = "txtStreamListenerPath";
            this.txtStreamListenerPath.Size = new System.Drawing.Size(358, 20);
            this.txtStreamListenerPath.TabIndex = 0;
            this.txtStreamListenerPath.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream10
            // 
            this.txtStream10.Location = new System.Drawing.Point(66, 300);
            this.txtStream10.Name = "txtStream10";
            this.txtStream10.Size = new System.Drawing.Size(455, 20);
            this.txtStream10.TabIndex = 16;
            this.txtStream10.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream9
            // 
            this.txtStream9.Location = new System.Drawing.Point(66, 274);
            this.txtStream9.Name = "txtStream9";
            this.txtStream9.Size = new System.Drawing.Size(455, 20);
            this.txtStream9.TabIndex = 15;
            this.txtStream9.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream8
            // 
            this.txtStream8.Location = new System.Drawing.Point(66, 248);
            this.txtStream8.Name = "txtStream8";
            this.txtStream8.Size = new System.Drawing.Size(455, 20);
            this.txtStream8.TabIndex = 14;
            this.txtStream8.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream7
            // 
            this.txtStream7.Location = new System.Drawing.Point(66, 222);
            this.txtStream7.Name = "txtStream7";
            this.txtStream7.Size = new System.Drawing.Size(455, 20);
            this.txtStream7.TabIndex = 13;
            this.txtStream7.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream6
            // 
            this.txtStream6.Location = new System.Drawing.Point(66, 196);
            this.txtStream6.Name = "txtStream6";
            this.txtStream6.Size = new System.Drawing.Size(455, 20);
            this.txtStream6.TabIndex = 12;
            this.txtStream6.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream5
            // 
            this.txtStream5.Location = new System.Drawing.Point(66, 170);
            this.txtStream5.Name = "txtStream5";
            this.txtStream5.Size = new System.Drawing.Size(455, 20);
            this.txtStream5.TabIndex = 11;
            this.txtStream5.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Region 10:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Region 9:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Region 8:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Region 7:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Region 6:";
            // 
            // lblStrRegion5
            // 
            this.lblStrRegion5.AutoSize = true;
            this.lblStrRegion5.Location = new System.Drawing.Point(8, 173);
            this.lblStrRegion5.Name = "lblStrRegion5";
            this.lblStrRegion5.Size = new System.Drawing.Size(53, 13);
            this.lblStrRegion5.TabIndex = 0;
            this.lblStrRegion5.Text = "Region 5:";
            // 
            // tabMoreRadioStreams
            // 
            this.tabMoreRadioStreams.Controls.Add(this.txtStream11);
            this.tabMoreRadioStreams.Controls.Add(this.label8);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream12);
            this.tabMoreRadioStreams.Controls.Add(this.label9);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream14);
            this.tabMoreRadioStreams.Controls.Add(this.label11);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream13);
            this.tabMoreRadioStreams.Controls.Add(this.label10);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream18);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream17);
            this.tabMoreRadioStreams.Controls.Add(this.label15);
            this.tabMoreRadioStreams.Controls.Add(this.label14);
            this.tabMoreRadioStreams.Controls.Add(this.label13);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream16);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream15);
            this.tabMoreRadioStreams.Controls.Add(this.label12);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream24);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream23);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream22);
            this.tabMoreRadioStreams.Controls.Add(this.txtStream20);
            this.tabMoreRadioStreams.Controls.Add(this.label16);
            this.tabMoreRadioStreams.Controls.Add(this.label17);
            this.tabMoreRadioStreams.Controls.Add(this.label18);
            this.tabMoreRadioStreams.Controls.Add(this.label20);
            this.tabMoreRadioStreams.Location = new System.Drawing.Point(4, 22);
            this.tabMoreRadioStreams.Name = "tabMoreRadioStreams";
            this.tabMoreRadioStreams.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoreRadioStreams.Size = new System.Drawing.Size(531, 334);
            this.tabMoreRadioStreams.TabIndex = 3;
            this.tabMoreRadioStreams.Text = "More Radio Streams";
            this.tabMoreRadioStreams.UseVisualStyleBackColor = true;
            // 
            // txtStream11
            // 
            this.txtStream11.Location = new System.Drawing.Point(64, 6);
            this.txtStream11.Name = "txtStream11";
            this.txtStream11.Size = new System.Drawing.Size(455, 20);
            this.txtStream11.TabIndex = 46;
            this.txtStream11.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Region 11:";
            // 
            // txtStream12
            // 
            this.txtStream12.Location = new System.Drawing.Point(64, 32);
            this.txtStream12.Name = "txtStream12";
            this.txtStream12.Size = new System.Drawing.Size(455, 20);
            this.txtStream12.TabIndex = 44;
            this.txtStream12.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Region 12:";
            // 
            // txtStream14
            // 
            this.txtStream14.Location = new System.Drawing.Point(64, 84);
            this.txtStream14.Name = "txtStream14";
            this.txtStream14.Size = new System.Drawing.Size(455, 20);
            this.txtStream14.TabIndex = 42;
            this.txtStream14.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Region 14:";
            // 
            // txtStream13
            // 
            this.txtStream13.Location = new System.Drawing.Point(64, 58);
            this.txtStream13.Name = "txtStream13";
            this.txtStream13.Size = new System.Drawing.Size(455, 20);
            this.txtStream13.TabIndex = 40;
            this.txtStream13.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Region 13:";
            // 
            // txtStream18
            // 
            this.txtStream18.Location = new System.Drawing.Point(64, 188);
            this.txtStream18.Name = "txtStream18";
            this.txtStream18.Size = new System.Drawing.Size(455, 20);
            this.txtStream18.TabIndex = 38;
            this.txtStream18.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream17
            // 
            this.txtStream17.Location = new System.Drawing.Point(64, 162);
            this.txtStream17.Name = "txtStream17";
            this.txtStream17.Size = new System.Drawing.Size(455, 20);
            this.txtStream17.TabIndex = 37;
            this.txtStream17.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Region 18:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Region 17:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Region 16:";
            // 
            // txtStream16
            // 
            this.txtStream16.Location = new System.Drawing.Point(64, 136);
            this.txtStream16.Name = "txtStream16";
            this.txtStream16.Size = new System.Drawing.Size(455, 20);
            this.txtStream16.TabIndex = 33;
            this.txtStream16.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream15
            // 
            this.txtStream15.Location = new System.Drawing.Point(64, 110);
            this.txtStream15.Name = "txtStream15";
            this.txtStream15.Size = new System.Drawing.Size(455, 20);
            this.txtStream15.TabIndex = 32;
            this.txtStream15.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Region 15:";
            // 
            // txtStream24
            // 
            this.txtStream24.Location = new System.Drawing.Point(64, 292);
            this.txtStream24.Name = "txtStream24";
            this.txtStream24.Size = new System.Drawing.Size(455, 20);
            this.txtStream24.TabIndex = 28;
            this.txtStream24.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream23
            // 
            this.txtStream23.Location = new System.Drawing.Point(64, 266);
            this.txtStream23.Name = "txtStream23";
            this.txtStream23.Size = new System.Drawing.Size(455, 20);
            this.txtStream23.TabIndex = 27;
            this.txtStream23.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream22
            // 
            this.txtStream22.Location = new System.Drawing.Point(64, 240);
            this.txtStream22.Name = "txtStream22";
            this.txtStream22.Size = new System.Drawing.Size(455, 20);
            this.txtStream22.TabIndex = 26;
            this.txtStream22.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtStream20
            // 
            this.txtStream20.Location = new System.Drawing.Point(64, 214);
            this.txtStream20.Name = "txtStream20";
            this.txtStream20.Size = new System.Drawing.Size(455, 20);
            this.txtStream20.TabIndex = 24;
            this.txtStream20.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Region 24:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Region 23:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 243);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Region 22:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 217);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "Region 20:";
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(460, 364);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(379, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(298, 364);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnResetToDefaults
            // 
            this.btnResetToDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetToDefaults.Location = new System.Drawing.Point(4, 364);
            this.btnResetToDefaults.Name = "btnResetToDefaults";
            this.btnResetToDefaults.Size = new System.Drawing.Size(100, 23);
            this.btnResetToDefaults.TabIndex = 4;
            this.btnResetToDefaults.Text = "Reset to Defaults";
            this.btnResetToDefaults.UseVisualStyleBackColor = true;
            this.btnResetToDefaults.Click += new System.EventHandler(this.btnResetToDefaults_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "EXE Files|*.exe";
            this.openFileDialog.Title = "Please select a listener application";
            // 
            // chkTypeWashaway
            // 
            this.chkTypeWashaway.AutoSize = true;
            this.chkTypeWashaway.Location = new System.Drawing.Point(179, 93);
            this.chkTypeWashaway.Name = "chkTypeWashaway";
            this.chkTypeWashaway.Size = new System.Drawing.Size(79, 17);
            this.chkTypeWashaway.TabIndex = 13;
            this.chkTypeWashaway.Text = "Washaway";
            this.chkTypeWashaway.UseVisualStyleBackColor = true;
            this.chkTypeWashaway.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // chkTypeAssist
            // 
            this.chkTypeAssist.AutoSize = true;
            this.chkTypeAssist.Location = new System.Drawing.Point(179, 116);
            this.chkTypeAssist.Name = "chkTypeAssist";
            this.chkTypeAssist.Size = new System.Drawing.Size(53, 17);
            this.chkTypeAssist.TabIndex = 14;
            this.chkTypeAssist.Text = "Assist";
            this.chkTypeAssist.UseVisualStyleBackColor = true;
            this.chkTypeAssist.CheckedChanged += new System.EventHandler(this.chkType_CheckedChanged);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 392);
            this.Controls.Add(this.btnResetToDefaults);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbctlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "OSOM Public Feed Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tbctlOptions.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAutoWatch.ResumeLayout(false);
            this.tabAutoWatch.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.grpRegions.ResumeLayout(false);
            this.grpRegions.PerformLayout();
            this.grpTypes.ResumeLayout(false);
            this.grpTypes.PerformLayout();
            this.grpAddresses.ResumeLayout(false);
            this.grpAddresses.PerformLayout();
            this.grpSuburbs.ResumeLayout(false);
            this.grpSuburbs.PerformLayout();
            this.tabRadioStreams.ResumeLayout(false);
            this.tabRadioStreams.PerformLayout();
            this.grpStreamAppSettings.ResumeLayout(false);
            this.grpStreamAppSettings.PerformLayout();
            this.tabMoreRadioStreams.ResumeLayout(false);
            this.tabMoreRadioStreams.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtDiamondActionPath;
        private System.Windows.Forms.Button btnTriangleBrowse;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtSquareActionPath;
        private System.Windows.Forms.Button btnSquareBrowse;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtCircleActionPath;
        private System.Windows.Forms.Button btnCircleBrowse;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStream20;
        private System.Windows.Forms.TextBox txtStream22;
        private System.Windows.Forms.TextBox txtStream23;
        private System.Windows.Forms.TextBox txtStream24;
        private System.Windows.Forms.TabPage tabMoreRadioStreams;
        private System.Windows.Forms.TextBox txtStream17;
        private System.Windows.Forms.TextBox txtStream18;
        private System.Windows.Forms.TextBox txtStream16;
        private System.Windows.Forms.TextBox txtStream15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;

        #endregion

        private System.Windows.Forms.TabControl tbctlOptions;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabAutoWatch;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnResetToDefaults;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblMinApplicances;
        private System.Windows.Forms.Label lblRegions;
        private System.Windows.Forms.Label lblInciTypes;
        private System.Windows.Forms.Label lblAddresses;
        private System.Windows.Forms.Label lblSuburbs;
        private System.Windows.Forms.GroupBox grpSuburbs;
        private System.Windows.Forms.TextBox txtSuburbs;
        private System.Windows.Forms.GroupBox grpAddresses;
        private System.Windows.Forms.TextBox txtAddresses;
        private System.Windows.Forms.GroupBox grpTypes;
        private System.Windows.Forms.CheckBox chkTypeScrub;
        private System.Windows.Forms.CheckBox chkTypeHazmat;
        private System.Windows.Forms.CheckBox chkTypeWildfire;
        private System.Windows.Forms.CheckBox chkTypeFalseAlarm;
        private System.Windows.Forms.CheckBox chkTypeOther;
        private System.Windows.Forms.CheckBox chkTypeIncident;
        private System.Windows.Forms.CheckBox chkTypeRescue;
        private System.Windows.Forms.CheckBox chkTypeStru;
        private System.Windows.Forms.CheckBox chkTypeNost;
        private System.Windows.Forms.CheckBox chkTypeGandS;
        private System.Windows.Forms.GroupBox grpRegions;
        private System.Windows.Forms.TextBox txtRegions;
        private System.Windows.Forms.TextBox txtMinimumAppliances;
        private System.Windows.Forms.ComboBox cmbMinSize;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.CheckBox chkContained;
        private System.Windows.Forms.CheckBox chkGoing;
        private System.Windows.Forms.CheckBox chkSafe;
        private System.Windows.Forms.CheckBox chkControlled;
        private System.Windows.Forms.TextBox txtStream14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStream13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabRadioStreams;
        private System.Windows.Forms.TextBox txtStream2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtStream4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox grpStreamAppSettings;
        private System.Windows.Forms.Button btnListenerPathBrowse;
        private System.Windows.Forms.Label lblArgumentDescriptions;
        private System.Windows.Forms.TextBox txtStreamListenerArgs;
        private System.Windows.Forms.Label lblListenerArguments;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtStreamListenerPath;
        private System.Windows.Forms.TextBox txtStream10;
        private System.Windows.Forms.TextBox txtStream9;
        private System.Windows.Forms.TextBox txtStream8;
        private System.Windows.Forms.TextBox txtStream7;
        private System.Windows.Forms.TextBox txtStream6;
        private System.Windows.Forms.TextBox txtStream5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStrRegion5;
        private System.Windows.Forms.TextBox txtStream12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCircleActionArgs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDiamondActionArgs;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtSquareActionArgs;
        private System.Windows.Forms.CheckBox chkRunStreamOnWatch;
        private System.Windows.Forms.TextBox txtStream11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkTypeAssist;
        private System.Windows.Forms.CheckBox chkTypeWashaway;
    }
}
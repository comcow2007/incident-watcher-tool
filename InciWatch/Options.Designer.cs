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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.tbctlOptions = new System.Windows.Forms.TabControl();
            this.tabGeneralSettings = new System.Windows.Forms.TabPage();
            this.grpOldJobCutoff = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldJobCutoffHours = new System.Windows.Forms.TextBox();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.grpProxySettings = new System.Windows.Forms.GroupBox();
            this.btnTestProxy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProxyPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProxyUsername = new System.Windows.Forms.TextBox();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.lblProxyAddress = new System.Windows.Forms.Label();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.grpStreamAppSettings = new System.Windows.Forms.GroupBox();
            this.chkRunStreamOnWatch = new System.Windows.Forms.CheckBox();
            this.btnListenerPathBrowse = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtStreamListenerPath = new System.Windows.Forms.TextBox();
            this.grpAutoCloseWatch = new System.Windows.Forms.GroupBox();
            this.txtAutoCloseDelay = new System.Windows.Forms.TextBox();
            this.lblAutoCloseDelay = new System.Windows.Forms.Label();
            this.chkCloseWatchOnSafe = new System.Windows.Forms.CheckBox();
            this.tabIncidentSources = new System.Windows.Forms.TabPage();
            this.grpInformationSources = new System.Windows.Forms.GroupBox();
            this.lblSettingsDesc = new System.Windows.Forms.Label();
            this.btnCurrentSourceSettings = new System.Windows.Forms.Button();
            this.lstLoadedSources = new System.Windows.Forms.ListView();
            this.imgLrgLoadedSources = new System.Windows.Forms.ImageList(this.components);
            this.imgSmlLoadedSources = new System.Windows.Forms.ImageList(this.components);
            this.grpInformationSource = new System.Windows.Forms.GroupBox();
            this.chkShowCantUpdateMessage = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGathererRefreshInterval = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnResetToDefaults = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbctlOptions.SuspendLayout();
            this.tabGeneralSettings.SuspendLayout();
            this.grpOldJobCutoff.SuspendLayout();
            this.grpProxySettings.SuspendLayout();
            this.grpStreamAppSettings.SuspendLayout();
            this.grpAutoCloseWatch.SuspendLayout();
            this.tabIncidentSources.SuspendLayout();
            this.grpInformationSources.SuspendLayout();
            this.grpInformationSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbctlOptions
            // 
            this.tbctlOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbctlOptions.Controls.Add(this.tabGeneralSettings);
            this.tbctlOptions.Controls.Add(this.tabIncidentSources);
            this.tbctlOptions.Location = new System.Drawing.Point(0, 0);
            this.tbctlOptions.Name = "tbctlOptions";
            this.tbctlOptions.SelectedIndex = 0;
            this.tbctlOptions.Size = new System.Drawing.Size(539, 327);
            this.tbctlOptions.TabIndex = 0;
            // 
            // tabGeneralSettings
            // 
            this.tabGeneralSettings.Controls.Add(this.grpOldJobCutoff);
            this.tabGeneralSettings.Controls.Add(this.chkUseProxy);
            this.tabGeneralSettings.Controls.Add(this.grpProxySettings);
            this.tabGeneralSettings.Controls.Add(this.grpStreamAppSettings);
            this.tabGeneralSettings.Controls.Add(this.grpAutoCloseWatch);
            this.tabGeneralSettings.Location = new System.Drawing.Point(4, 22);
            this.tabGeneralSettings.Name = "tabGeneralSettings";
            this.tabGeneralSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneralSettings.Size = new System.Drawing.Size(531, 301);
            this.tabGeneralSettings.TabIndex = 5;
            this.tabGeneralSettings.Text = "General Settings";
            this.tabGeneralSettings.UseVisualStyleBackColor = true;
            // 
            // grpOldJobCutoff
            // 
            this.grpOldJobCutoff.Controls.Add(this.label4);
            this.grpOldJobCutoff.Controls.Add(this.txtOldJobCutoffHours);
            this.grpOldJobCutoff.Location = new System.Drawing.Point(8, 6);
            this.grpOldJobCutoff.Name = "grpOldJobCutoff";
            this.grpOldJobCutoff.Size = new System.Drawing.Size(513, 41);
            this.grpOldJobCutoff.TabIndex = 38;
            this.grpOldJobCutoff.TabStop = false;
            this.grpOldJobCutoff.Text = "Old Job Cutoff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hide incidents older than (hours)";
            // 
            // txtOldJobCutoffHours
            // 
            this.txtOldJobCutoffHours.Location = new System.Drawing.Point(283, 15);
            this.txtOldJobCutoffHours.Name = "txtOldJobCutoffHours";
            this.txtOldJobCutoffHours.Size = new System.Drawing.Size(78, 20);
            this.txtOldJobCutoffHours.TabIndex = 0;
            this.txtOldJobCutoffHours.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            this.txtOldJobCutoffHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            this.txtOldJobCutoffHours.Validating += new System.ComponentModel.CancelEventHandler(this.txtOldJobCutoffHours_Validating);
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(93, 166);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(79, 17);
            this.chkUseProxy.TabIndex = 0;
            this.chkUseProxy.Text = "Use proxy?";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // grpProxySettings
            // 
            this.grpProxySettings.Controls.Add(this.btnTestProxy);
            this.grpProxySettings.Controls.Add(this.label3);
            this.grpProxySettings.Controls.Add(this.txtProxyPassword);
            this.grpProxySettings.Controls.Add(this.label1);
            this.grpProxySettings.Controls.Add(this.txtProxyUsername);
            this.grpProxySettings.Controls.Add(this.txtProxyPort);
            this.grpProxySettings.Controls.Add(this.lblProxyPort);
            this.grpProxySettings.Controls.Add(this.lblProxyAddress);
            this.grpProxySettings.Controls.Add(this.txtProxyAddress);
            this.grpProxySettings.Enabled = false;
            this.grpProxySettings.Location = new System.Drawing.Point(8, 168);
            this.grpProxySettings.Name = "grpProxySettings";
            this.grpProxySettings.Size = new System.Drawing.Size(513, 74);
            this.grpProxySettings.TabIndex = 37;
            this.grpProxySettings.TabStop = false;
            this.grpProxySettings.Text = "Proxy Settings";
            // 
            // btnTestProxy
            // 
            this.btnTestProxy.Location = new System.Drawing.Point(367, 45);
            this.btnTestProxy.Name = "btnTestProxy";
            this.btnTestProxy.Size = new System.Drawing.Size(138, 20);
            this.btnTestProxy.TabIndex = 8;
            this.btnTestProxy.Text = "Test";
            this.btnTestProxy.UseVisualStyleBackColor = true;
            this.btnTestProxy.Click += new System.EventHandler(this.btnTestProxy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // txtProxyPassword
            // 
            this.txtProxyPassword.Location = new System.Drawing.Point(248, 46);
            this.txtProxyPassword.Name = "txtProxyPassword";
            this.txtProxyPassword.Size = new System.Drawing.Size(113, 20);
            this.txtProxyPassword.TabIndex = 6;
            this.txtProxyPassword.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // txtProxyUsername
            // 
            this.txtProxyUsername.Location = new System.Drawing.Point(70, 46);
            this.txtProxyUsername.Name = "txtProxyUsername";
            this.txtProxyUsername.Size = new System.Drawing.Size(110, 20);
            this.txtProxyUsername.TabIndex = 4;
            this.txtProxyUsername.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Location = new System.Drawing.Point(433, 19);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.Size = new System.Drawing.Size(72, 20);
            this.txtProxyPort.TabIndex = 3;
            this.txtProxyPort.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            this.txtProxyPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            this.txtProxyPort.Validating += new System.ComponentModel.CancelEventHandler(this.txtProxyPort_Validating);
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.AutoSize = true;
            this.lblProxyPort.Location = new System.Drawing.Point(369, 22);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(58, 13);
            this.lblProxyPort.TabIndex = 2;
            this.lblProxyPort.Text = "Proxy Port:";
            // 
            // lblProxyAddress
            // 
            this.lblProxyAddress.AutoSize = true;
            this.lblProxyAddress.Location = new System.Drawing.Point(6, 22);
            this.lblProxyAddress.Name = "lblProxyAddress";
            this.lblProxyAddress.Size = new System.Drawing.Size(77, 13);
            this.lblProxyAddress.TabIndex = 1;
            this.lblProxyAddress.Text = "Proxy Address:";
            // 
            // txtProxyAddress
            // 
            this.txtProxyAddress.Location = new System.Drawing.Point(89, 19);
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.Size = new System.Drawing.Size(272, 20);
            this.txtProxyAddress.TabIndex = 0;
            this.txtProxyAddress.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            // 
            // grpStreamAppSettings
            // 
            this.grpStreamAppSettings.Controls.Add(this.chkRunStreamOnWatch);
            this.grpStreamAppSettings.Controls.Add(this.btnListenerPathBrowse);
            this.grpStreamAppSettings.Controls.Add(this.label22);
            this.grpStreamAppSettings.Controls.Add(this.txtStreamListenerPath);
            this.grpStreamAppSettings.Location = new System.Drawing.Point(8, 99);
            this.grpStreamAppSettings.Name = "grpStreamAppSettings";
            this.grpStreamAppSettings.Size = new System.Drawing.Size(513, 63);
            this.grpStreamAppSettings.TabIndex = 35;
            this.grpStreamAppSettings.TabStop = false;
            this.grpStreamAppSettings.Text = "Stream Listener Application";
            // 
            // chkRunStreamOnWatch
            // 
            this.chkRunStreamOnWatch.AutoSize = true;
            this.chkRunStreamOnWatch.Location = new System.Drawing.Point(372, 43);
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
            this.btnListenerPathBrowse.Text = "Browse:";
            this.btnListenerPathBrowse.UseVisualStyleBackColor = true;
            this.btnListenerPathBrowse.Click += new System.EventHandler(this.BtnListenerPathBrowseClick);
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
            // grpAutoCloseWatch
            // 
            this.grpAutoCloseWatch.Controls.Add(this.txtAutoCloseDelay);
            this.grpAutoCloseWatch.Controls.Add(this.lblAutoCloseDelay);
            this.grpAutoCloseWatch.Controls.Add(this.chkCloseWatchOnSafe);
            this.grpAutoCloseWatch.Location = new System.Drawing.Point(8, 50);
            this.grpAutoCloseWatch.Name = "grpAutoCloseWatch";
            this.grpAutoCloseWatch.Size = new System.Drawing.Size(513, 43);
            this.grpAutoCloseWatch.TabIndex = 1;
            this.grpAutoCloseWatch.TabStop = false;
            this.grpAutoCloseWatch.Text = "Auto Close Watch";
            // 
            // txtAutoCloseDelay
            // 
            this.txtAutoCloseDelay.Location = new System.Drawing.Point(414, 16);
            this.txtAutoCloseDelay.Name = "txtAutoCloseDelay";
            this.txtAutoCloseDelay.Size = new System.Drawing.Size(91, 20);
            this.txtAutoCloseDelay.TabIndex = 2;
            this.txtAutoCloseDelay.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            this.txtAutoCloseDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            this.txtAutoCloseDelay.Validating += new System.ComponentModel.CancelEventHandler(this.txtAutoCloseDelay_Validating);
            // 
            // lblAutoCloseDelay
            // 
            this.lblAutoCloseDelay.AutoSize = true;
            this.lblAutoCloseDelay.Location = new System.Drawing.Point(311, 19);
            this.lblAutoCloseDelay.Name = "lblAutoCloseDelay";
            this.lblAutoCloseDelay.Size = new System.Drawing.Size(97, 13);
            this.lblAutoCloseDelay.TabIndex = 1;
            this.lblAutoCloseDelay.Text = "Close Delay (secs):";
            // 
            // chkCloseWatchOnSafe
            // 
            this.chkCloseWatchOnSafe.AutoSize = true;
            this.chkCloseWatchOnSafe.Location = new System.Drawing.Point(9, 18);
            this.chkCloseWatchOnSafe.Name = "chkCloseWatchOnSafe";
            this.chkCloseWatchOnSafe.Size = new System.Drawing.Size(161, 17);
            this.chkCloseWatchOnSafe.TabIndex = 0;
            this.chkCloseWatchOnSafe.Text = "Close watch if incident safe?";
            this.chkCloseWatchOnSafe.UseVisualStyleBackColor = true;
            this.chkCloseWatchOnSafe.CheckedChanged += new System.EventHandler(this.chkCloseWatchOnSafe_CheckedChanged);
            // 
            // tabIncidentSources
            // 
            this.tabIncidentSources.Controls.Add(this.grpInformationSources);
            this.tabIncidentSources.Controls.Add(this.grpInformationSource);
            this.tabIncidentSources.Location = new System.Drawing.Point(4, 22);
            this.tabIncidentSources.Name = "tabIncidentSources";
            this.tabIncidentSources.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncidentSources.Size = new System.Drawing.Size(531, 301);
            this.tabIncidentSources.TabIndex = 6;
            this.tabIncidentSources.Text = "Incident Sources";
            this.tabIncidentSources.UseVisualStyleBackColor = true;
            // 
            // grpInformationSources
            // 
            this.grpInformationSources.Controls.Add(this.lblSettingsDesc);
            this.grpInformationSources.Controls.Add(this.btnCurrentSourceSettings);
            this.grpInformationSources.Controls.Add(this.lstLoadedSources);
            this.grpInformationSources.Location = new System.Drawing.Point(8, 77);
            this.grpInformationSources.Name = "grpInformationSources";
            this.grpInformationSources.Size = new System.Drawing.Size(513, 213);
            this.grpInformationSources.TabIndex = 6;
            this.grpInformationSources.TabStop = false;
            this.grpInformationSources.Text = "Loaded Information Sources";
            // 
            // lblSettingsDesc
            // 
            this.lblSettingsDesc.AutoSize = true;
            this.lblSettingsDesc.Location = new System.Drawing.Point(6, 180);
            this.lblSettingsDesc.Name = "lblSettingsDesc";
            this.lblSettingsDesc.Size = new System.Drawing.Size(399, 26);
            this.lblSettingsDesc.TabIndex = 2;
            this.lblSettingsDesc.Text = "To change the settings of a Information Source double click it, or click it once " +
                "then \r\nclick settings.";
            // 
            // btnCurrentSourceSettings
            // 
            this.btnCurrentSourceSettings.Enabled = false;
            this.btnCurrentSourceSettings.Location = new System.Drawing.Point(404, 183);
            this.btnCurrentSourceSettings.Name = "btnCurrentSourceSettings";
            this.btnCurrentSourceSettings.Size = new System.Drawing.Size(103, 24);
            this.btnCurrentSourceSettings.TabIndex = 1;
            this.btnCurrentSourceSettings.Text = "Settings";
            this.btnCurrentSourceSettings.UseVisualStyleBackColor = true;
            this.btnCurrentSourceSettings.Click += new System.EventHandler(this.btnCurrentSourceSettings_Click);
            // 
            // lstLoadedSources
            // 
            this.lstLoadedSources.GridLines = true;
            this.lstLoadedSources.HideSelection = false;
            this.lstLoadedSources.LargeImageList = this.imgLrgLoadedSources;
            this.lstLoadedSources.Location = new System.Drawing.Point(9, 21);
            this.lstLoadedSources.MultiSelect = false;
            this.lstLoadedSources.Name = "lstLoadedSources";
            this.lstLoadedSources.ShowGroups = false;
            this.lstLoadedSources.Size = new System.Drawing.Size(498, 156);
            this.lstLoadedSources.SmallImageList = this.imgSmlLoadedSources;
            this.lstLoadedSources.TabIndex = 0;
            this.lstLoadedSources.UseCompatibleStateImageBehavior = false;
            this.lstLoadedSources.SelectedIndexChanged += new System.EventHandler(this.lstLoadedSources_SelectedIndexChanged);
            this.lstLoadedSources.DoubleClick += new System.EventHandler(this.lstLoadedSources_DoubleClick);
            // 
            // imgLrgLoadedSources
            // 
            this.imgLrgLoadedSources.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLrgLoadedSources.ImageStream")));
            this.imgLrgLoadedSources.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLrgLoadedSources.Images.SetKeyName(0, "default_src_icon_lrg.PNG");
            // 
            // imgSmlLoadedSources
            // 
            this.imgSmlLoadedSources.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSmlLoadedSources.ImageStream")));
            this.imgSmlLoadedSources.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSmlLoadedSources.Images.SetKeyName(0, "default_src_icon_sml.PNG");
            // 
            // grpInformationSource
            // 
            this.grpInformationSource.Controls.Add(this.chkShowCantUpdateMessage);
            this.grpInformationSource.Controls.Add(this.label30);
            this.grpInformationSource.Controls.Add(this.label2);
            this.grpInformationSource.Controls.Add(this.txtGathererRefreshInterval);
            this.grpInformationSource.Location = new System.Drawing.Point(8, 6);
            this.grpInformationSource.Name = "grpInformationSource";
            this.grpInformationSource.Size = new System.Drawing.Size(513, 65);
            this.grpInformationSource.TabIndex = 1;
            this.grpInformationSource.TabStop = false;
            this.grpInformationSource.Text = "Information Retrieval";
            // 
            // chkShowCantUpdateMessage
            // 
            this.chkShowCantUpdateMessage.AutoSize = true;
            this.chkShowCantUpdateMessage.Checked = true;
            this.chkShowCantUpdateMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowCantUpdateMessage.Location = new System.Drawing.Point(9, 39);
            this.chkShowCantUpdateMessage.Name = "chkShowCantUpdateMessage";
            this.chkShowCantUpdateMessage.Size = new System.Drawing.Size(209, 17);
            this.chkShowCantUpdateMessage.TabIndex = 5;
            this.chkShowCantUpdateMessage.Text = "Show warning message if update fails?";
            this.chkShowCantUpdateMessage.UseVisualStyleBackColor = true;
            this.chkShowCantUpdateMessage.CheckedChanged += new System.EventHandler(this.chkCloseWatchOnSafe_CheckedChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(229, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(118, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Minimum is 90 Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Refresh Interval (secs):";
            // 
            // txtGathererRefreshInterval
            // 
            this.txtGathererRefreshInterval.Location = new System.Drawing.Point(128, 13);
            this.txtGathererRefreshInterval.Name = "txtGathererRefreshInterval";
            this.txtGathererRefreshInterval.Size = new System.Drawing.Size(95, 20);
            this.txtGathererRefreshInterval.TabIndex = 1;
            this.txtGathererRefreshInterval.TextChanged += new System.EventHandler(this.txtTextbox_TextChanged);
            this.txtGathererRefreshInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbersOnly_KeyPress);
            this.txtGathererRefreshInterval.Validating += new System.ComponentModel.CancelEventHandler(this.txtGathererRefreshInterval_Validating);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(460, 331);
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
            this.btnCancel.Location = new System.Drawing.Point(379, 331);
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
            this.btnOK.Location = new System.Drawing.Point(298, 331);
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
            this.btnResetToDefaults.Location = new System.Drawing.Point(4, 331);
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
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 359);
            this.Controls.Add(this.btnResetToDefaults);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbctlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.tbctlOptions.ResumeLayout(false);
            this.tabGeneralSettings.ResumeLayout(false);
            this.tabGeneralSettings.PerformLayout();
            this.grpOldJobCutoff.ResumeLayout(false);
            this.grpOldJobCutoff.PerformLayout();
            this.grpProxySettings.ResumeLayout(false);
            this.grpProxySettings.PerformLayout();
            this.grpStreamAppSettings.ResumeLayout(false);
            this.grpStreamAppSettings.PerformLayout();
            this.grpAutoCloseWatch.ResumeLayout(false);
            this.grpAutoCloseWatch.PerformLayout();
            this.tabIncidentSources.ResumeLayout(false);
            this.grpInformationSources.ResumeLayout(false);
            this.grpInformationSources.PerformLayout();
            this.grpInformationSource.ResumeLayout(false);
            this.grpInformationSource.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        #endregion

        private System.Windows.Forms.TabControl tbctlOptions;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnResetToDefaults;
        private System.Windows.Forms.TabPage tabGeneralSettings;
        private System.Windows.Forms.GroupBox grpStreamAppSettings;
        private System.Windows.Forms.CheckBox chkRunStreamOnWatch;
        private System.Windows.Forms.Button btnListenerPathBrowse;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtStreamListenerPath;
        private System.Windows.Forms.GroupBox grpAutoCloseWatch;
        private System.Windows.Forms.TextBox txtAutoCloseDelay;
        private System.Windows.Forms.Label lblAutoCloseDelay;
        private System.Windows.Forms.CheckBox chkCloseWatchOnSafe;
        private System.Windows.Forms.TabPage tabIncidentSources;
        private System.Windows.Forms.GroupBox grpInformationSource;
        private System.Windows.Forms.CheckBox chkShowCantUpdateMessage;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGathererRefreshInterval;
        private System.Windows.Forms.GroupBox grpInformationSources;
        private System.Windows.Forms.ListView lstLoadedSources;
        private System.Windows.Forms.Button btnCurrentSourceSettings;
        private System.Windows.Forms.Label lblSettingsDesc;
        private System.Windows.Forms.ImageList imgLrgLoadedSources;
        private System.Windows.Forms.ImageList imgSmlLoadedSources;
        private System.Windows.Forms.GroupBox grpProxySettings;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.TextBox txtProxyPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.Label lblProxyAddress;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.Button btnTestProxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProxyPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProxyUsername;
        private System.Windows.Forms.GroupBox grpOldJobCutoff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldJobCutoffHours;
    }
}
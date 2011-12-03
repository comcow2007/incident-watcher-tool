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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;

namespace InciWatch
{
    internal partial class OptionsForm : Form
    {

        InciWatchOptions mProgramOptions;
        CurrentIncidentsForm mParentForm;


        public OptionsForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowOptions(InciWatchOptions progOptions, CurrentIncidentsForm parentForm)
        {
            mProgramOptions = progOptions;
            mParentForm = parentForm;

            return this.ShowDialog();
        }

        private void btnResetToDefaults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset to defaults?", AppConstants.ApplicationFriendlyName, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mProgramOptions.Reset();
                mProgramOptions.Save();
                SetupOptions();
            }           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Move the control values into the program options class
            GetDialogData();

            //Save the changes
            mProgramOptions.Save();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            SetupOptions();
            btnApply.Enabled = false;
             
            //Fill in the Incident Source list
            PopulateLoadedSourceListView();

        }

        private void PopulateLoadedSourceListView()
        {

            //Clear the list
            lstLoadedSources.Items.Clear();

            //Get the incident source list
            List<IIncidentSource> loadedSources = mParentForm.IncidentSources;

            int imageIndex = 1;

            //foreach (IIncidentSource inciSource in loadedSources)
            for(int index = 0; index<loadedSources.Count;index++)
            {
                IIncidentSource inciSource = loadedSources[index];

                //Create a new list view item
                ListViewItem newLVI = new ListViewItem();

                //Load the large and small image
                Image largeImage = inciSource.GetLargeImage();
                Image smallImage = inciSource.GetSmallImage();
                if (largeImage == null || smallImage == null)
                {
                    //This large image index = nothing use the default
                    newLVI.ImageIndex = 0;

                    //Dispose of the large and small images if they did actually load
                    if (largeImage != null)
                        largeImage.Dispose();
                    if (smallImage != null)
                        smallImage.Dispose();
                }
                else 
                { 
                    //Add the images to the image lists
                    imgLrgLoadedSources.Images.Add(largeImage);
                    imgSmlLoadedSources.Images.Add(smallImage);
                    newLVI.ImageIndex = imageIndex;
                    imageIndex += 1;
                    
                }

                //Set the rest of the values
                newLVI.Text = inciSource.GetSourceName();

                //Set the tag to the loaded source index
                newLVI.Tag = index;

                //Add the listview item to the list
                lstLoadedSources.Items.Add(newLVI);
            }
            
        }

        private void SetupOptions()
        {
            txtOldJobCutoffHours.Text = mProgramOptions.HideIncidentsAfterHours.ToString();

            SetupGathererOptions();
            SetupStreamOptions();
            SetupWatchOptions();
            SetupProxyOptions();
        }

        private void SetupProxyOptions()
        {
            //Set the values
            chkUseProxy.Checked = mProgramOptions.UseProxy;
            grpProxySettings.Enabled = mProgramOptions.UseProxy;

            txtProxyAddress.Text = mProgramOptions.ProxyAddress;
            txtProxyPort.Text = mProgramOptions.ProxyPort.ToString();
            txtProxyUsername.Text = mProgramOptions.ProxyUsername;
            txtProxyPassword.Text = mProgramOptions.ProxyPassword;
        }

        private void SetupWatchOptions()
        {
            chkCloseWatchOnSafe.Checked = mProgramOptions.AutoCloseWatchOnSafe;
            txtAutoCloseDelay.Text = mProgramOptions.AutoCloseWatchOnSafeDelay.ToString();
        }

        private void SetupGathererOptions()
        {
            txtGathererRefreshInterval.Text = mProgramOptions.GathererRefreshInterval.ToString() ;
            chkShowCantUpdateMessage.Checked = mProgramOptions.ShowCantUpdateMessage;
        }

        private void SetupStreamOptions()
        {
            //Program and arguments
            txtStreamListenerPath.Text = mProgramOptions.StreamListenerPath;
            chkRunStreamOnWatch.Checked = mProgramOptions.OpenStreamOnWatch;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Move the control values into the program options class
            GetDialogData();

            mProgramOptions.Save();
            btnApply.Enabled = false;
        }
        

        private void GetDialogData()
        {
            mProgramOptions.HideIncidentsAfterHours = int.Parse(txtOldJobCutoffHours.Text);

            GetGathererData();
            GetStreamData();
            GetWatchData();
            GetProxyData();
        }

        private void GetProxyData()
        {
            //Get the values
            mProgramOptions.UseProxy = chkUseProxy.Checked;
            mProgramOptions.ProxyAddress = txtProxyAddress.Text;
            mProgramOptions.ProxyPort = int.Parse(txtProxyPort.Text);
            mProgramOptions.ProxyUsername = txtProxyUsername.Text;
            mProgramOptions.ProxyPassword = txtProxyPassword.Text;
        }

        private void GetWatchData()
        {
            mProgramOptions.AutoCloseWatchOnSafe = chkCloseWatchOnSafe.Checked;
            mProgramOptions.AutoCloseWatchOnSafeDelay = int.Parse(txtAutoCloseDelay.Text);
        }

        private void GetGathererData()
        {
            mProgramOptions.GathererRefreshInterval = int.Parse(txtGathererRefreshInterval.Text);
            mProgramOptions.ShowCantUpdateMessage = chkShowCantUpdateMessage.Checked;
        }

        private void GetStreamData()
        {
            //Program and arguments
            mProgramOptions.StreamListenerPath = txtStreamListenerPath.Text;
            mProgramOptions.OpenStreamOnWatch = chkRunStreamOnWatch.Checked;
        }

        void BtnListenerPathBrowseClick(object sender, EventArgs e)
        {
        	if( openFileDialog.ShowDialog() == DialogResult.OK )
        	{
        		//Set the text box to the filename
        		txtStreamListenerPath.Text = openFileDialog.FileName;        	
        	}
        }

        private void txtTextbox_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkRunStreamOnWatch_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void txtGathererRefreshInterval_Validating(object sender, CancelEventArgs e)
        {
            int BoxVal = 0;
            if (int.TryParse(txtGathererRefreshInterval.Text, out BoxVal) == true)
            {
                if (BoxVal < 90 )
                {
                    //90 Seconds is the minimum refresh time
                    MessageBox.Show("Minimum refresh time is 90 Seconds. Lower than that could cause excessive server load on TFB and busy days and will not give any better results", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    txtGathererRefreshInterval.SelectAll();
                }
            }
            else
            {
                //Value is not an int
                MessageBox.Show("Refresh interval must be a number", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtGathererRefreshInterval.SelectAll();
            }
        }

        private void chkCloseWatchOnSafe_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void btnCurrentSourceSettings_Click(object sender, EventArgs e)
        {
            ShowSettingsOfCurrentSelectedSource();
        }

        private void ShowSettingsOfCurrentSelectedSource()
        {
            //Is an item selected?
            if (lstLoadedSources.SelectedItems.Count > 0)
            {
                if (mParentForm.IncidentSources[(int)lstLoadedSources.SelectedItems[0].Tag].HasOptionsDialog() == true)
                {
                    //Yes, so open the settings
                    if (mParentForm.IncidentSources[(int)lstLoadedSources.SelectedItems[0].Tag].OpenOptionDialog() == false)
                    {
                        //an errror occurred when trying to open the settings
                        MessageBox.Show("An error occurred when trying to open the selected items settings", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lstLoadedSources_DoubleClick(object sender, EventArgs e)
        {
            ShowSettingsOfCurrentSelectedSource();
        }

        private void lstLoadedSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Is an item selected?
            if (lstLoadedSources.SelectedItems.Count > 0)
            {
                //We have at least 1 item selected
                if (mParentForm.IncidentSources[(int)lstLoadedSources.SelectedItems[0].Tag].HasOptionsDialog() == true)
                {

                    btnCurrentSourceSettings.Enabled = true;
                }
            }
            else
            {
                //We have no items selected
                btnCurrentSourceSettings.Enabled = false;
            }
        }

        private void chkUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            //Set the enabled state of the proxy group = to the checked state of this control
            grpProxySettings.Enabled = chkUseProxy.Checked;
            btnApply.Enabled = true;
        }

        private void txtProxyPort_Validating(object sender, CancelEventArgs e)
        {
            //Do the validation
            int portVal = 0;
            if (int.TryParse(txtProxyPort.Text, out portVal) == false)
            {
                //Invalid Data
                e.Cancel = true;
            }
            else
            {
                if (portVal < 0 || portVal > 65535)
                {
                    //Invalid Date
                    e.Cancel = true;
                }
            }
            if (e.Cancel == true)
            {
                //Show message box
                MessageBox.Show("Port value must be a number between 0-65535", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProxyPort.SelectAll();
            }
        }

        private void txtNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only Allow Numbers
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' ||
                e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' ||
                e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtAutoCloseDelay_Validating(object sender, CancelEventArgs e)
        {
            int BoxVal = 0;
            //Text cant be empty
            if (txtAutoCloseDelay.Text.Length < 1)
            {
                //Value is not an int
                MessageBox.Show("Auto close delay interval must be a number ", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtGathererRefreshInterval.SelectAll();
            }
            else
            {
                if (int.TryParse(txtAutoCloseDelay.Text, out BoxVal) == false)
                {
                    //Value is not an int
                    MessageBox.Show("Auto close delay interval must be a number ", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    txtGathererRefreshInterval.SelectAll();
                }
            }
        }

        private void btnTestProxy_Click(object sender, EventArgs e)
        {
            bool testSuccess = false;
            string failInfo = "";
            try
            {
            //Test the proxy with a request to www.google.com
                HttpWebRequest testRequest = (HttpWebRequest)HttpWebRequest.Create("http://www.google.com.au");

                WebProxy proxy = new WebProxy(txtProxyAddress.Text, int.Parse(txtProxyPort.Text));

                //Get the credentials if they exist
                if( string.IsNullOrEmpty(txtProxyUsername.Text) == false ||
                    string.IsNullOrEmpty(txtProxyPassword.Text) == false)
                {
                    //Create the credentials
                    NetworkCredential proxyCredentials = new NetworkCredential(txtProxyUsername.Text,txtProxyPassword.Text);
                    
                    //Set the credentials
                    proxy.Credentials = proxyCredentials;
                }

                //Set the proxy
                testRequest.Proxy = proxy;

                //Try get the response
                HttpWebResponse testResponse = (HttpWebResponse)testRequest.GetResponse();

                //Is it a success
                if (testResponse.StatusCode == HttpStatusCode.OK)
                    testSuccess = true;
            }
            catch (Exception ex)
            {
                //Proxy Test Failed.
                testSuccess = false;
                failInfo = ex.Message;
            }

            //Show some feedback
            if (testSuccess == true)
            {
                //Test failed
                MessageBox.Show("Proxy Test Succeeded", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Test failed
                MessageBox.Show("Proxy Test Failed. Reason: '"+failInfo+"'", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtOldJobCutoffHours_Validating(object sender, CancelEventArgs e)
        {
            int BoxVal = 0;
            //Text cant be empty
            if (txtOldJobCutoffHours.Text.Length < 1)
            {
                //Value is not an int
                MessageBox.Show("Hide after hours value must be a number ", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                txtOldJobCutoffHours.SelectAll();
            }
            else
            {
                if (int.TryParse(txtOldJobCutoffHours.Text, out BoxVal) == false)
                {
                    //Value is not an int
                    MessageBox.Show("Hide after hours value must be a number ", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    txtOldJobCutoffHours.SelectAll();
                }
            }
        }
    }
}

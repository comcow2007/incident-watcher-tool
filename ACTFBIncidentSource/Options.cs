//ACTFBIncidentSource - This incident source reads the ACTFB public feed for Incident Watcher
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

namespace ACTFBIncidentSource
{
    internal partial class Options : Form
    {
        ACTFBIncidentSourceOptions mOptions;

        public Options()
        {
            InitializeComponent();
        }

        public DialogResult ShowOptions(ACTFBIncidentSourceOptions SourceOptions)
        {
            mOptions = SourceOptions;

            SetupOptions();

            //Disable apply
            btnApply.Enabled = false;

            return this.ShowDialog();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            //Save the options and close the dialog
            GetOptions();
            mOptions.Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close the dialog
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //Apply the options
            GetOptions();
            mOptions.Save();
            btnApply.Enabled = false;
        }

        private void GetOptions()
        {
            //Get the General Options
            GetGeneralOptions();

            //Get the autowatch options
            GetAutowatchOptions();

            //Get the custom actions options
            GetCustomActionOptions();
        }

        private void GetCustomActionOptions()
        {
            //Get Circle path + Args
            mOptions.ActionCircle = txtCircleActionPath.Text;
            mOptions.ActionCircleArgs = txtCircleActionArgs.Text;

            //Get Square path + Args
            mOptions.ActionSquare = txtSquareActionPath.Text;
            mOptions.ActionSquareArgs = txtSquareActionArgs.Text;

            //Get Diamond path + Args
            mOptions.ActionDiamond = txtDiamondActionPath.Text;
            mOptions.ActionDiamondArgs = txtDiamondActionArgs.Text;
        }

        private void GetAutowatchOptions()
        {
            //Get the enabled status
            mOptions.AutoWatchEnabled = chkAutowatchEnabled.Checked;

            //Get the suburb lines
            mOptions.AutoWatchSuburbs = new List<string>(txtAWSuburbs.Lines);
            
            //Locations
            mOptions.AutoWatchLocations = new List<string>(txtAWLocations.Lines);

            //Statuses
            List<string> mStatuses = new List<string>();
            foreach (int sel in chkListStatus.CheckedIndices)
            {
                //Get the strings
                mStatuses.Add(ACTFBIncidentItem.StringToIncidentStatus(chkListStatus.Items[sel].ToString()).ToString()); 
            }
            mOptions.AutoWatchStatuses = mStatuses;

            //Types
            List<string> mTypes = new List<string>();
            foreach (int sel in chkListType.CheckedIndices)
            {
                //Get the strings
                mTypes.Add(ACTFBIncidentItem.StringToIncidentType(chkListType.Items[sel].ToString()).ToString());
            }
            mOptions.AutoWatchTypes = mTypes;

        }

        private void GetGeneralOptions()
        {
            //Get the radio stream
            mOptions.StreamURL = txtRadioStream.Text;
        }

        private void btnResetToDefaults_Click(object sender, EventArgs e)
        {
            //Reset the options
            mOptions.Reset();
            SetupOptions();
        }

        private void SetupOptions()
        {
            //Set the general Options
            SetGeneralOptions();

            //Set the autowatch options
            SetAutoWatchOptions();

            //Set the custom action buttons
            SetCustomActionButtons();
        }

        private void SetCustomActionButtons()
        {
            //Set the Circle Command + Args
            txtCircleActionPath.Text = mOptions.ActionCircle;
            txtCircleActionArgs.Text = mOptions.ActionCircleArgs;

            //Set the Square Command + Args
            txtSquareActionPath.Text = mOptions.ActionSquare ;
            txtSquareActionArgs.Text = mOptions.ActionSquareArgs;

            //Set the Diamond Command + Args
            txtDiamondActionPath.Text = mOptions.ActionDiamond;
            txtDiamondActionArgs.Text = mOptions.ActionDiamondArgs;
        }

        private void SetAutoWatchOptions()
        {
            //Enable/Disable the autowatch enabled
            chkAutowatchEnabled.Checked = mOptions.AutoWatchEnabled;
            grpAutoWatchOptions.Enabled = chkAutowatchEnabled.Checked;

            //Suburb list
            txtAWSuburbs.Lines = mOptions.AutoWatchSuburbs.ToArray();

            //Location list
            txtAWLocations.Lines = mOptions.AutoWatchLocations.ToArray() ;

            //Fill Status List
            //Get unknown type
            string unknownStatusString = ACTFBIncidentItem.IncidentStatusToString(ACTFBIncidentItem.ACTFBStatus.Unknown);

            //Get list
            chkListStatus.Items.Clear();
            for (int i = 0; i < 25; i++)
            {
                string statusString = ACTFBIncidentItem.IncidentStatusToString(((ACTFBIncidentItem.ACTFBStatus)i));
                if (statusString != unknownStatusString)
                {
                    //Add to the list, and check if we should check it
                    bool fCheckIt = false;
                    fCheckIt = mOptions.AutoWatchStatuses.Contains(((ACTFBIncidentItem.ACTFBStatus)i).ToString());
                    chkListStatus.Items.Add(statusString, fCheckIt);
                    
                }
            }

            //Fill Type List
            //Get unknown type
            //Clear list
            chkListType.Items.Clear();
            string unknownTypeString = ACTFBIncidentItem.IncidentTypeToString(ACTFBIncidentItem.ACTFBTypes.Unknown);
            for (int i = 0; i < 25; i++ )
            {
                string typeString = ACTFBIncidentItem.IncidentTypeToString(((ACTFBIncidentItem.ACTFBTypes)i));
                if (typeString != unknownTypeString)
                {
                    //Add to the list, and check if we should check it
                    bool fCheckIt = false;
                    fCheckIt = mOptions.AutoWatchTypes.Contains(((ACTFBIncidentItem.ACTFBTypes)i).ToString());
                    chkListType.Items.Add(typeString, fCheckIt);
                }
            }

            
        }

        private void SetGeneralOptions()
        {
            //Set the radio stream
            txtRadioStream.Text = mOptions.StreamURL;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //Enable Apply
            btnApply.Enabled = true;
        }

        private void chkAutowatchEnabled_CheckedChanged(object sender, EventArgs e)
        {
            grpAutoWatchOptions.Enabled = chkAutowatchEnabled.Checked;
            //Enable apply
            btnApply.Enabled = true;
        }

        private void CheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Enable Apply
            btnApply.Enabled = true;
        }

        private void btnCircleBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Set the text box to the filename
                txtCircleActionPath.Text = openFileDialog.FileName;
            }
        }

        private void btnSquareBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Set the text box to the filename
                txtSquareActionPath.Text = openFileDialog.FileName;
            }
        }

        private void btnTriangleBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Set the text box to the filename
                txtDiamondActionPath.Text = openFileDialog.FileName;
            }
        }
    }
}

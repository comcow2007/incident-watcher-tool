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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace CFAIncidentSource
{
    public partial class OptionsForm : Form
    {

        CFAIncidentSourceOptions mProgramOptions;


        public OptionsForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowOptions(CFAIncidentSourceOptions progOptions)
        {
            mProgramOptions = progOptions;

            return this.ShowDialog();
        }

        private void btnResetToDefaults_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reset to defaults?", "OSOM Incident Watch", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        }

        private void SetupOptions()
        {
            SetupActionOptions();
            SetupStreamOptions();
            SetupAutoWatchOptions();
        }

        private void SetupStreamOptions()
        {
            //Program and arguments
            txtStreamListenerArgs.Text = mProgramOptions.StreamListenerArgs;

            //Streams
            txtStream2.Text = mProgramOptions.Region2Stream;
            txtStream4.Text = mProgramOptions.Region4Stream;
            txtStream5.Text = mProgramOptions.Region5Stream;
            txtStream6.Text = mProgramOptions.Region6Stream;
            txtStream7.Text = mProgramOptions.Region7Stream;
            txtStream8.Text = mProgramOptions.Region8Stream;

            txtStream9.Text = mProgramOptions.Region9Stream;
            txtStream10.Text = mProgramOptions.Region10Stream;
            txtStream11.Text = mProgramOptions.Region11Stream;
            txtStream12.Text = mProgramOptions.Region12Stream;
            txtStream13.Text = mProgramOptions.Region13Stream;
            txtStream14.Text = mProgramOptions.Region14Stream;

            txtStream15.Text = mProgramOptions.Region15Stream;
            txtStream16.Text = mProgramOptions.Region16Stream;
            txtStream17.Text = mProgramOptions.Region17Stream;
            txtStream18.Text = mProgramOptions.Region18Stream;
            txtStream20.Text = mProgramOptions.Region20Stream;
            txtStream22.Text = mProgramOptions.Region22Stream;
            txtStream23.Text = mProgramOptions.Region23Stream;
            txtStream24.Text = mProgramOptions.Region24Stream;

        }

        private void SetupActionOptions()
        {
            txtDiamondActionPath.Text = mProgramOptions.ActionDiamond;
            txtSquareActionPath.Text = mProgramOptions.ActionSquare;
            txtCircleActionPath.Text = mProgramOptions.ActionCircle;

            txtCircleActionArgs.Text = mProgramOptions.ActionCircleArgs;
            txtSquareActionArgs.Text = mProgramOptions.ActionSquareArgs;
            txtDiamondActionArgs.Text = mProgramOptions.ActionDiamondArgs;

        }

        private String[] GetArrayFromStringCollection(StringCollection strCollection)
        {
            String[] returnString;
            if (strCollection == null)
            {
                returnString = new String[0];
            }
            else
            {
               returnString = new String[strCollection.Count];

                strCollection.CopyTo(returnString, 0);
            }


            return returnString;
        }

        private void txtSuburbs_ModifiedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
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
            GetActionData();
            GetStreamData();
            GetAutoWatchData();
        }

        private void GetActionData()
        {
            mProgramOptions.ActionDiamond = txtDiamondActionPath.Text;
            mProgramOptions.ActionSquare = txtSquareActionPath.Text;
            mProgramOptions.ActionCircle = txtCircleActionPath.Text;

            mProgramOptions.ActionCircleArgs = txtCircleActionArgs.Text;
            mProgramOptions.ActionSquareArgs = txtSquareActionArgs.Text;
            mProgramOptions.ActionDiamondArgs = txtDiamondActionArgs.Text;
        }

        private void GetStreamData()
        {
            //Program and arguments
            mProgramOptions.StreamListenerArgs = txtStreamListenerArgs.Text;

            //Streams
             mProgramOptions.Region2Stream=txtStream2.Text;
             mProgramOptions.Region4Stream=txtStream4.Text;
             mProgramOptions.Region5Stream=txtStream5.Text;
             mProgramOptions.Region6Stream=txtStream6.Text;
             mProgramOptions.Region7Stream=txtStream7.Text;
             mProgramOptions.Region8Stream=txtStream8.Text;

             mProgramOptions.Region9Stream=txtStream9.Text;
             mProgramOptions.Region10Stream=txtStream10.Text;
             mProgramOptions.Region11Stream=txtStream11.Text;
             mProgramOptions.Region12Stream=txtStream12.Text;
             mProgramOptions.Region13Stream=txtStream13.Text;
             mProgramOptions.Region14Stream=txtStream14.Text;

             mProgramOptions.Region15Stream=txtStream15.Text;
             mProgramOptions.Region16Stream=txtStream16.Text;
             mProgramOptions.Region17Stream=txtStream17.Text;
             mProgramOptions.Region18Stream=txtStream18.Text;
             mProgramOptions.Region20Stream=txtStream20.Text;
             mProgramOptions.Region22Stream=txtStream22.Text;
             mProgramOptions.Region23Stream=txtStream23.Text;
             mProgramOptions.Region24Stream = txtStream24.Text;
        }

        

        private void txtAddresses_ModifiedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void txtRegions_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' ||
                e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' ||
                e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == '\r'|| e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' ||
                e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' ||
                e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtRegions_ModifiedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkGoing_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }
        
        
        void BtnListenerPathBrowseClick(object sender, EventArgs e)
        {
        	if( openFileDialog.ShowDialog() == DialogResult.OK )
        	{
        		//Set the text box to the filename
        		txtStreamListenerPath.Text = openFileDialog.FileName;        	
        	}
        }
        
        
        void BtnTriangleBrowseClick(object sender, EventArgs e)
        {
        	if( openFileDialog.ShowDialog() == DialogResult.OK )
        	{
        		//Set the text box to the filename
        		txtDiamondActionPath.Text = openFileDialog.FileName;        	
        	}
        }
        
        void BtnSquareBrowseClick(object sender, EventArgs e)
        {
        	if( openFileDialog.ShowDialog() == DialogResult.OK )
        	{
        		//Set the text box to the filename
        		txtSquareActionPath.Text = openFileDialog.FileName;        	
        	}
        }
        
        void BtnCircleBrowseClick(object sender, EventArgs e)
        {
        	if( openFileDialog.ShowDialog() == DialogResult.OK )
        	{
        		//Set the text box to the filename
        		txtCircleActionPath.Text = openFileDialog.FileName;        	
        	}
        }

        private void txtTextbox_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void txtMinimumAppliances_TextChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkRunStreamOnWatch_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void chkCloseWatchOnSafe_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        private void SetupAutoWatchOptions()
        {
            //Setup the text boxes

            txtSuburbs.Lines = GetArrayFromStringCollection(mProgramOptions.AutoWatchSuburbs);
            txtAddresses.Lines = GetArrayFromStringCollection(mProgramOptions.AutoWatchAddresses);
            txtRegions.Lines = GetArrayFromStringCollection(mProgramOptions.AutoWatchRegions);
            txtMinimumAppliances.Text = mProgramOptions.AutoWatchApplianceCount.ToString();


            //Clear all check boxes
            chkContained.Checked = false;
            chkControlled.Checked = false;
            chkGoing.Checked = false;
            chkSafe.Checked = false;

            chkTypeFalseAlarm.Checked = false;
            chkTypeGandS.Checked = false;
            chkTypeHazmat.Checked = false;
            chkTypeIncident.Checked = false;
            chkTypeNost.Checked = false;
            chkTypeOther.Checked = false;
            chkTypeRescue.Checked = false;
            chkTypeScrub.Checked = false;
            chkTypeStru.Checked = false;
            chkTypeWildfire.Checked = false;



            //Set up the type check boxes
            if (mProgramOptions.AutoWatchTypes != null)
            {
                foreach (string s in mProgramOptions.AutoWatchTypes)
                {
                    switch (IncidentItem.ParseIncidentType(s))
                    {
                        case IncidentItem.IncidentType.FalseAlarm:
                            chkTypeFalseAlarm.Checked = true;
                            break;
                        case IncidentItem.IncidentType.GrassAndScrub:
                            chkTypeGandS.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Hazmat:
                            chkTypeHazmat.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Incident:
                            chkTypeIncident.Checked = true;
                            break;
                        case IncidentItem.IncidentType.NonStructure:
                            chkTypeNost.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Other:
                            chkTypeOther.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Rescue:
                            chkTypeRescue.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Scrub:
                            chkTypeScrub.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Structure:
                            chkTypeStru.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Wildfire:
                            chkTypeWildfire.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Assist:
                            chkTypeAssist.Checked = true;
                            break;
                        case IncidentItem.IncidentType.Washaway:
                            chkTypeWashaway.Checked = true;
                            break;
                    }
                }
            }

            //Set up the status check boxes
            if (mProgramOptions.AutoWatchStatuses != null)
            {
                foreach (string s in mProgramOptions.AutoWatchStatuses)
                {
                    switch (IncidentItem.ParseIncidentStatus(s))
                    {
                        case IncidentItem.IncidentStatus.Contained:
                            chkContained.Checked = true;
                            break;
                        case IncidentItem.IncidentStatus.Controlled:
                            chkControlled.Checked = true;
                            break;
                        case IncidentItem.IncidentStatus.Going:
                            chkGoing.Checked = true;
                            break;
                        case IncidentItem.IncidentStatus.Safe:
                            chkSafe.Checked = true;
                            break;
                    }
                }
            }

            //Set up the incident size
            if (mProgramOptions.AutoWatchIncidentSize != null)
            {
                switch (IncidentItem.ParseIncidentSize(mProgramOptions.AutoWatchIncidentSize))
                {
                    case IncidentItem.IncidentSize.Large:
                        cmbMinSize.SelectedIndex = 4;
                        break;
                    case IncidentItem.IncidentSize.Medium:
                        cmbMinSize.SelectedIndex = 3;
                        break;
                    case IncidentItem.IncidentSize.Small:
                        cmbMinSize.SelectedIndex = 2;
                        break;
                    case IncidentItem.IncidentSize.Spot:
                        cmbMinSize.SelectedIndex = 1;
                        break;
                    default:
                        cmbMinSize.SelectedIndex = 0;
                        break;
                }
            }
        }

        private void GetAutoWatchData()
        {
            //Update Suburbs
            mProgramOptions.AutoWatchSuburbs = new StringCollection();
            foreach (String suburb in txtSuburbs.Lines)
            {
                mProgramOptions.AutoWatchSuburbs.Add(suburb);
            }

            //Update Addresses
            mProgramOptions.AutoWatchAddresses = new StringCollection();
            foreach (String address in txtAddresses.Lines)
            {
                mProgramOptions.AutoWatchAddresses.Add(address);
            }

            //Update Addresses
            mProgramOptions.AutoWatchRegions = new StringCollection();
            foreach (String region in txtRegions.Lines)
            {
                mProgramOptions.AutoWatchRegions.Add(region);
            }

            //Update minimum appliances
            mProgramOptions.AutoWatchApplianceCount = int.Parse(txtMinimumAppliances.Text);

            //Job Type
            //Clear the setting            
            mProgramOptions.AutoWatchTypes = new StringCollection();
            #region Type Setting Generation Checks
            if (chkTypeGandS.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.GrassAndScrub));
            }
            if (chkTypeIncident.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Incident));
            }
            if (chkTypeHazmat.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Hazmat));
            }
            if (chkTypeNost.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.NonStructure));
            }
            if (chkTypeOther.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Other));
            }
            if (chkTypeStru.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Structure));
            }
            if (chkTypeFalseAlarm.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.FalseAlarm));
            }
            if (chkTypeRescue.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Rescue));
            }
            if (chkTypeWildfire.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Wildfire));
            }
            if (chkTypeScrub.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Scrub));
            }
            if (chkTypeWashaway.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Washaway));
            }
            if (chkTypeAssist.Checked)
            {
                mProgramOptions.AutoWatchTypes.Add(IncidentItem.UnparseIncidentType(IncidentItem.IncidentType.Assist));
            }
            #endregion

            //Job Status
            mProgramOptions.AutoWatchStatuses = new StringCollection();
            if (chkGoing.Checked)
                mProgramOptions.AutoWatchStatuses.Add(IncidentItem.IncidentStatusToString(IncidentItem.IncidentStatus.Going));
            if (chkContained.Checked)
                mProgramOptions.AutoWatchStatuses.Add(IncidentItem.IncidentStatusToString(IncidentItem.IncidentStatus.Contained));
            if (chkControlled.Checked)
                mProgramOptions.AutoWatchStatuses.Add(IncidentItem.IncidentStatusToString(IncidentItem.IncidentStatus.Controlled));
            if (chkSafe.Checked)
                mProgramOptions.AutoWatchStatuses.Add(IncidentItem.IncidentStatusToString(IncidentItem.IncidentStatus.Safe));


            //Job Size
            mProgramOptions.AutoWatchIncidentSize = cmbMinSize.Text;
        }
    }
}

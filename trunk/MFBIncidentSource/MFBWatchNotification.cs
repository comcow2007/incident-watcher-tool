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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InciWatch;

namespace MFBIncidentSource
{
    internal partial class MFBWatchNotification : Form, IWatchNotification
    {
        private MFBIncidentItem mIncidentItem;
        private IWatchList mParent;
        private MFBIncidentSourceOptions mOptions;
        private MFBIncidentSource mParentSource;

        private bool mfFadeOut;
        public MFBWatchNotification(MFBIncidentItem IncidentItem, IWatchList Parent, MFBIncidentSourceOptions Options, MFBIncidentSource ParentSource)
        {
            InitializeComponent();

            mIncidentItem = IncidentItem;
            mParent = Parent;
            mOptions = Options;
            mParentSource = ParentSource;

            mfFadeOut = true;

            UpdateDialog();

            //Check if a stream exists for this region
            if (String.IsNullOrEmpty(mOptions.StreamURL) == false &&
                String.IsNullOrEmpty(mParentSource.GetIncidentWatcher().GetStreamListenerPath()) == false)
            {
                //If we have it set to open the stream
                if (mParentSource.GetIncidentWatcher().GetAutoOpenStreamOnWatch() == true)
                {
                    OpenStream();
                }
            }
        }

        private bool UpdateDialog()
        {
            bool returnCode = false;

            //Check if a stream exists for this region
            if (String.IsNullOrEmpty(mOptions.StreamURL) == true ||
                String.IsNullOrEmpty(mParentSource.GetIncidentWatcher().GetStreamListenerPath()) == true)
            {
                btn2.Visible = false;
            }
            else
            {
                btn2.Visible = true;
            }

            //Set the values.
            //Address
            lblAddress.Text = mIncidentItem.Location;
            ttDisplay.SetToolTip(lblAddress, "Address: "+mIncidentItem.Location);
            //Suburb
            lblSuburb.Text = mIncidentItem.Suburb;
            ttDisplay.SetToolTip(lblSuburb, "Suburb: "+mIncidentItem.Suburb);

            lblUpdateTime.Text = mIncidentItem.LastUpdate.ToString("HH:mm");

            //Appliance Count
            lblApplianceCount.Text = mIncidentItem.ApplianceCount_GENERIC.ToString();
            ttDisplay.SetToolTip(lblApplianceCount, "Appliances: \n" + BuildApplianceToolTip(mIncidentItem.Appliances));
            
            //Has the incident stopped?
            returnCode = CheckForJustSafeCheck();
            

            UpdateIncidentStatus();
            UpdateIncidentType();

            //Hide or UN-Hide the circle square and diamond depending on the values in them
            if (String.IsNullOrEmpty(mOptions.ActionDiamond) == true)
            {
                //Hide the diamond button
                btn6.Visible = false;
            }
            if (String.IsNullOrEmpty(mOptions.ActionSquare) == true)
            {
                //Hide the diamond button
                btn5.Visible = false;
            }
            if (String.IsNullOrEmpty(mOptions.ActionCircle) == true)
            {
                //Hide the diamond button
                btn4.Visible = false;
            }

            return returnCode;
        }

        private string BuildApplianceToolTip(string[] Appliances)
        {
            //Init the return string.
            string returnString = "";

            if (Appliances.Length == 0)
            {
                //There arn't any appliances on scene.
                return "No Appliances";
            }
            else
            {
                //We have at least 1 Appliance, build the string.
                foreach (string appliance in Appliances)
                {
                    if (returnString.Length != 0)
                        returnString += Environment.NewLine;   //Add a newline, only if it isnt the first appliance.
                    returnString += DecodeApplianceCode(appliance);                
                }                
            }

            //Return the string.
            return returnString;
        }

        public static string DecodeApplianceCode(string appliance)
        {
            string returnString = "";

            //Start with the longer strings and work our way down
            if (appliance.StartsWith("EMRMB") == true)
            {
                returnString = appliance.Replace("EMRMB", "Emergency Medical Unit ");
            }
            #region Commander Codes
            else if (appliance.StartsWith("BIBB") == true)
            {
                returnString = appliance.Replace("BIBB", "Commander A");
            }
            else if (appliance.StartsWith("CMAT") == true)
            {
                returnString = appliance.Replace("CMAT", "Commander B");
            }
            else if (appliance.StartsWith("DDAV") == true)
            {
                returnString = appliance.Replace("DDAV", "Commander C");
            }
            else if (appliance.StartsWith("GBRO") == true)
            {
                returnString = appliance.Replace("GBRO", "Commander D");
            }
            else if (appliance.StartsWith("MSWI") == true)
            {
                returnString = appliance.Replace("MSWI", "Commander E");
            }
            else if (appliance.StartsWith("TKIM") == true)
            {
                returnString = appliance.Replace("TKIM", "Commander F");
            }
            else if (appliance.StartsWith("TRIM") == true)
            {
                returnString = appliance.Replace("TRIM", "Commander G");
            }
            else if (appliance.StartsWith("KBRO") == true)
            {
                returnString = appliance.Replace("KBRO", "Commander H");
            }
            else if (appliance.StartsWith("RDEA") == true)
            {
                returnString = appliance.Replace("RDEA", "Commander I");
            }
            else if (appliance.StartsWith("DMIL") == true)
            {
                returnString = appliance.Replace("DMIL", "Commander J");
            }
            else if (appliance.StartsWith("UNDY") == true)
            {
                returnString = appliance.Replace("UNDY", "Commander K");
            }
            else if (appliance.StartsWith("DYOU") == true)
            {
                returnString = appliance.Replace("DYOU", "Commander L");
            }
            else if (appliance.StartsWith("PATT") == true)
            {
                returnString = appliance.Replace("PATT", "Commander M");
            }
            else if (appliance.StartsWith("MCOO") == true)
            {
                returnString = appliance.Replace("MCOO", "Commander N");
            }
            else if (appliance.StartsWith("MOCO") == true)
            {
                returnString = appliance.Replace("MOCO", "Commander O");
            }
            else if (appliance.StartsWith("MSWY") == true)
            {
                returnString = appliance.Replace("MSWY", "Commander P");
            }
            else if (appliance.StartsWith("DARB") == true)
            {
                returnString = appliance.Replace("DARB", "Commander Q");
            }
            else if (appliance.StartsWith("ZAMM") == true)
            {
                returnString = appliance.Replace("ZAMM", "Commander R");
            }
            else if (appliance.StartsWith("MELE") == true)
            {
                returnString = appliance.Replace("MELE", "Commander S");
            }
            else if (appliance.StartsWith("HUNT") == true)
            {
                returnString = appliance.Replace("HUNT", "Commander T");
            }
            else if (appliance.StartsWith("NZAC") == true)
            {
                returnString = appliance.Replace("NZAC", "Commander U");
            }
            else if (appliance.StartsWith("DMCC") == true)
            {
                returnString = appliance.Replace("DMCC", "Commander V");
            }
            else if (appliance.StartsWith("GARR") == true)
            {
                returnString = appliance.Replace("GARR", "Commander W");
            }    
            #endregion
            #region Executive Commander (DCO & ACO)
            else if (appliance.StartsWith("AMQ") == true)
            {
                returnString = appliance.Replace("AMQ", "Executive A");
            }
            else if (appliance.StartsWith("SKW") == true)
            {
                returnString = appliance.Replace("SKW", "Executive B");
            }
            else if (appliance.StartsWith("RIC") == true)
            {
                returnString = appliance.Replace("RIC", "Executive C");
            }
            else if (appliance.StartsWith("PLS") == true)
            {
                returnString = appliance.Replace("PLS", "Executive D");
            }
            #endregion
            #region 3 Character Prefixes
            else if (appliance.StartsWith("AOC") == true)
            {
                returnString = appliance.Replace("AOC", "Acting Operations Commander ");
            }
            else if (appliance.StartsWith("FIU") == true)
            {
                returnString = appliance.Replace("FIU", "Fire Investigation Unit ");
            }
            else if (appliance.StartsWith("SCI") == true)
            {
                returnString = appliance.Replace("SCI", "Scientific Officer ");
            }
            else if (appliance.StartsWith("RAC") == true)
            {
                returnString = appliance.Replace("RAC", "Acting Commander ");
            }
            #endregion
            #region 2 Character Prefixes
            else if (appliance.StartsWith("BA") == true)
            {
                returnString = appliance.Replace("BA", "BA Bus ");
            }
            else if (appliance.StartsWith("BS") == true)
            {
                returnString = appliance.Replace("BS", "BA Support ");
            }
            else if (appliance.StartsWith("CU") == true)
            {
                returnString = appliance.Replace("CU", "Control Unit ");
            }
            else if (appliance.StartsWith("DU") == true)
            {
                returnString = appliance.Replace("DU", "Decontamination Unit ");
            }
            else if (appliance.StartsWith("LP") == true)
            {
                returnString = appliance.Replace("LP", "Ladder Platform ");
            }
            else if (appliance.StartsWith("PT") == true)
            {
                returnString = appliance.Replace("PT", "Pumper Tanker ");
            }
            else if (appliance.StartsWith("TB") == true)
            {
                returnString = appliance.Replace("TB", "Teleboom ");
            }
            else if (appliance.StartsWith("UP") == true)
            {
                returnString = appliance.Replace("UP", "Ultra Large Pump ");
            }
            else if (appliance.StartsWith("WT") == true)
            {
                returnString = appliance.Replace("WT", "Water Tanker ");
            }
            else if (appliance.StartsWith("ZC") == true)
            {
                returnString = appliance.Replace("ZC", "Zone Car ");
            }
            #endregion
            #region 1 Character Prefixes
            else if (appliance.StartsWith("P") == true)
            {
                returnString = appliance.Replace("P", "Pumper ");
            }
            else if (appliance.StartsWith("R") == true)
            {
                returnString = appliance.Replace("R", "Rescue ");
            }
            else if (appliance.StartsWith("T") == true)
            {
                returnString = appliance.Replace("T", "Modular Transporter ");
            }
            #endregion

            //Did we get any hits
            if (returnString == "")
            {
                //Nope, this is an unknown appliance.
                returnString = "Unknown Appliance(" + appliance + ")";
            }
            //Finally check for Suffix
            returnString = returnString.Replace("-FS", " FROM STATION ");

            return returnString;
        }

        private bool CheckForJustSafeCheck()
        {
            if (lblStatus.Text != "STATUS" && lblStatus.Text != "SAFE")
            {
                //Wasn't Safe before update, Is the incident now safe?
                if (mIncidentItem.Status == MFBIncidentItem.MFBStatus.Stop)
                {
                    //Just became Safe
                    //Do we want to auto close?
                    if (mParentSource.GetIncidentWatcher().GetAutoCloseWatchOnSafe() == true)
                    {
                        //Is there a time delay
                        if (mParentSource.GetIncidentWatcher().GetAutoCloseWatchOnSafeDelay() > 0)
                        {
                            //Start the timer
                            tmrNotification.Interval = mParentSource.GetIncidentWatcher().GetAutoCloseWatchOnSafeDelay() * 1000;
                            tmrNotification.Start();
                        }
                        else
                        {
                            //Otherwise Remove this incident item from watch
                            if (mParent.IsKeyBeingWatched(mIncidentItem.ID_GENERIC) == true)
                            {
                                //Return true which says that we should close this watch immediately
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void UpdateIncidentType()
        {
            //Set the tooptip
            ttDisplay.SetToolTip(lblType, "Type: " +MFBIncidentItem.IncidentTypeToString(mIncidentItem.Type));
            switch (mIncidentItem.Type)
            {
                case MFBIncidentItem.MFBTypes.FalseAlarm:
                    lblType.Text = "FALS";
                    lblType.ForeColor = Color.White;
                    break;
                case MFBIncidentItem.MFBTypes.Fire:
                    lblType.Text = "FIRE";
                    lblType.ForeColor = Color.White;
                    break;
                case MFBIncidentItem.MFBTypes.FullCall:
                    lblType.Text = "ALRM";
                    lblType.ForeColor = Color.White;
                    break;
                case MFBIncidentItem.MFBTypes.HazardousIncident:
                    lblType.Text = "HZMT";
                    lblType.ForeColor = Color.White;
                    break;
                case MFBIncidentItem.MFBTypes.Incident:
                    lblType.Text = "INCI";
                    lblType.ForeColor = Color.White;
                    break;
                case MFBIncidentItem.MFBTypes.MedicalEmergency:
                    lblType.Text = "EMR";
                    lblType.ForeColor = Color.White;
                    break;
                case MFBIncidentItem.MFBTypes.NonStructureFire:
                    lblType.Text = "NOST";
                    lblType.ForeColor = Color.White;
                    break;
                case MFBIncidentItem.MFBTypes.StructureFire:
                    lblType.Text = "STRU";
                    lblType.ForeColor = Color.White;
                    break;
                default:
                    lblType.Text = "UNKN";
                    lblType.ForeColor = Color.White;
                    break;
            }
        }

        private void UpdateIncidentStatus()
        {
            //Set the tooptip
            ttDisplay.SetToolTip(lblStatus, "Status: "+MFBIncidentItem.IncidentStatusToString(mIncidentItem.Status));

            switch (mIncidentItem.Status)
            {
                case MFBIncidentItem.MFBStatus.AlarmEscalated:
                    lblStatus.Text = "ALMES";
                    lblStatus.ForeColor = Color.Red;
                    break;
                case MFBIncidentItem.MFBStatus.Initiated:
                    lblStatus.Text = "INIT";
                    lblStatus.ForeColor = Color.Red;
                    break;
                case MFBIncidentItem.MFBStatus.Investigating:
                    lblStatus.Text = "INVES";
                    lblStatus.ForeColor = Color.Orange;
                    break;
                case MFBIncidentItem.MFBStatus.NotYetUnderControl:
                    lblStatus.Text = "GOING";
                    lblStatus.ForeColor = Color.Red;
                    break;
                case MFBIncidentItem.MFBStatus.Stop:
                    lblStatus.Text = "SAFE";
                    lblStatus.ForeColor = Color.LimeGreen;
                    break;
                case MFBIncidentItem.MFBStatus.UnderControl:
                    lblStatus.Text = "CNTRL";
                    lblStatus.ForeColor = Color.Orange;
                    break;
                default:
                    lblStatus.Text = "UNKN";
                    lblStatus.ForeColor = Color.White;
                    break;
            }
        }
      
        private void btn1_Click(object sender, EventArgs e)
        {
            //Close this watch notification
            mParent.Remove(mIncidentItem.ID_GENERIC);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenStream();
        }

        private void OpenStream()
        {
            //Listen to Stream
            try
            {
                //Replace Values in args string
                String argsString = mOptions.StreamURL;
                argsString = mOptions.ReplaceInciWatchVarsInString(argsString, mIncidentItem);

                System.Diagnostics.Process.Start(mParentSource.GetIncidentWatcher().GetStreamListenerPath(), argsString);
            }
            catch
            {
                MessageBox.Show("Unable to start stream application.");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(mIncidentItem.GetMapURL());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //Circle button
            try
            {
                if (String.IsNullOrEmpty(mOptions.ActionCircle) == false)
                {
                    //Replace constants in the string
                    String execString = mOptions.ActionCircleArgs;

                    execString = mOptions.ReplaceInciWatchVarsInString(execString, mIncidentItem);

                    //Execute the command
                    System.Diagnostics.Process.Start(mOptions.ActionCircle, execString);
                }
            }
            catch
            {
                MessageBox.Show("Unable to run command assigned to the circle action button.");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //Square button
            try
            {
                if (String.IsNullOrEmpty(mOptions.ActionSquare) == false)
                {
                    //Replace constants in the string
                    String execString = mOptions.ActionSquareArgs;

                    execString = mOptions.ReplaceInciWatchVarsInString(execString, mIncidentItem);

                    //Execute the command
                    System.Diagnostics.Process.Start(mOptions.ActionSquare, execString);
                }
            }
            catch
            {
                MessageBox.Show("Unable to run command assigned to the square action button.");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //Diamond button
            try
            {
                if (String.IsNullOrEmpty(mOptions.ActionDiamond) == false)
                {
                    //Replace constants in the string
                    String execString = mOptions.ActionDiamondArgs;

                    execString = mOptions.ReplaceInciWatchVarsInString(execString, mIncidentItem);

                    //Execute the command
                    System.Diagnostics.Process.Start(mOptions.ActionDiamond, execString);
                }
            }
            catch
            {
                MessageBox.Show("Unable to run command assigned to the diamond action button.");
            }
        }

        #region Interface Functions
        public Point GetPosition()
        {
            return this.Location;
        }

        public void SetPosition(Point newPosition)
        {
            this.Location = newPosition;
        }

        public int GetWidth()
        {
            return this.Width;
        }

        public int GetHeight()
        {
            return this.Height;
        }

        public void SetDimensions(int newWidth, int newHeight)
        {
            this.Width = newWidth;
            this.Height = newHeight;
        }

        public void ShowNotification()
        {
            this.Show();
        }

        public void CloseNotification()
        {
            this.Close();
        }

        public bool RefreshNotification()
        {
            bool returnCode = UpdateDialog();
            //Redraw
            this.Refresh();
            return returnCode;
        }

        #endregion

        private void tmrNotification_Tick(object sender, EventArgs e)
        {
            //Stop the timer
            tmrNotification.Stop();
            //Remove the watch from the parent list
            if (mParent.IsKeyBeingWatched(mIncidentItem.ID_GENERIC) == true)
            {
                mParent.Remove(mIncidentItem.ID_GENERIC);
            }     
        }

        private void MFBWatchNotification_MouseEnter(object sender, EventArgs e)
        {
            tmrFadeout.Stop();
            //Set opacity to 100%
            this.Opacity = 1;
        }

        private void MFBWatchNotification_MouseLeave(object sender, EventArgs e)
        {
            if (mfFadeOut == true)
            {
                tmrFadeout.Start();
            }
        }

        private void tmrFadeout_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > .25)
            {
                this.Opacity -= .025;
            }
            else
            {
                tmrFadeout.Stop();
            }
        }

        private void pbShowZone_Click(object sender, EventArgs e)
        {
            if (mfFadeOut == true)
                mfFadeOut = false;
            else
                mfFadeOut = true;
        }
    }
}

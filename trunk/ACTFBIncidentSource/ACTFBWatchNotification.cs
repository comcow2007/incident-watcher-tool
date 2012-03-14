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
using InciWatch;

namespace ACTFBIncidentSource
{
    internal partial class ACTFBWatchNotification : Form, IWatchNotification
    {
        private ACTFBIncidentItem mIncidentItem;
        private IWatchList mParent;
        private ACTFBIncidentSourceOptions mOptions;
        private ACTFBIncidentSource mParentSource;

        private bool mfFadeOut;
        public ACTFBWatchNotification(ACTFBIncidentItem IncidentItem, IWatchList Parent, ACTFBIncidentSourceOptions Options, ACTFBIncidentSource ParentSource)
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

        private bool CheckForJustSafeCheck()
        {
            if (lblStatus.Text != "STATUS" && lblStatus.Text != "SAFE" )
            {
                //Wasn't Safe before update, Is the incident now safe?
                if (mIncidentItem.Status == ACTFBIncidentItem.ACTFBStatus.Stop)
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
            ttDisplay.SetToolTip(lblType, "Type: " +ACTFBIncidentItem.IncidentTypeToString(mIncidentItem.Type));
            switch (mIncidentItem.Type)
            {
                case ACTFBIncidentItem.ACTFBTypes.CarFire:
                    lblType.Text = "CARF";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.MVA:
                    lblType.Text = "MVA";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.RubbishFire:
                    lblType.Text = "RUBF";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.StructureFire13:
                    lblType.Text = "LSTR";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.GasPiplineNoInj:
                    lblType.Text = "GSLK";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.PowerlinesDown:
                    lblType.Text = "PLDN";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.GrassAndBush:
                    lblType.Text = "G&B";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.HouseFireInj:
                    lblType.Text = "HFWI";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.HouseFireNoInj:
                    lblType.Text = "HFNI";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.HazmatNoCBR:
                    lblType.Text = "HZMT";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.StructureBelowGround:
                    lblType.Text = "SFBG";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.TransportFireBusTruck:
                    lblType.Text = "TFBT";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.StructuralCollapseMinor:
                    lblType.Text = "SCMI";
                    lblType.ForeColor = Color.White;
                    break;
                case ACTFBIncidentItem.ACTFBTypes.LPGCylinderNoInj:
                    lblType.Text = "LFNI";
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
            ttDisplay.SetToolTip(lblStatus, "Status: "+ACTFBIncidentItem.IncidentStatusToString(mIncidentItem.Status));

            switch (mIncidentItem.Status)
            {
                case ACTFBIncidentItem.ACTFBStatus.Stop:
                    lblStatus.Text = "SAFE";
                    lblStatus.ForeColor = Color.LimeGreen;
                    break;
                case ACTFBIncidentItem.ACTFBStatus.OnRoute:
                    lblStatus.Text = "ONWAY";
                    lblStatus.ForeColor = Color.Red;
                    break;
                case ACTFBIncidentItem.ACTFBStatus.OnScene:
                    lblStatus.Text = "GOING";
                    lblStatus.ForeColor = Color.Red;
                    break;
                case ACTFBIncidentItem.ACTFBStatus.ResourcesPending:
                    lblStatus.Text = "INIT";
                    lblStatus.ForeColor = Color.Orange;
                    break;
                case ACTFBIncidentItem.ACTFBStatus.Finished:
                    lblStatus.Text = "FNSH";
                    lblStatus.ForeColor = Color.LimeGreen;
                    break;
                case ACTFBIncidentItem.ACTFBStatus.UnderControl:
                    lblStatus.Text = "UCTL";
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

        private void ACTFBWatchNotification_MouseEnter(object sender, EventArgs e)
        {
            tmrFadeout.Stop();
            //Set opacity to 100%
            this.Opacity = 1;
        }

        private void ACTFBWatchNotification_MouseLeave(object sender, EventArgs e)
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

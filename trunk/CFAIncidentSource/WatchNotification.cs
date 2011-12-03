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
using InciWatch;
using System.IO;
using System.Reflection;

namespace CFAIncidentSource
{
    public partial class WatchNotification : Form, IWatchNotification
    {
        private IncidentItem mIncidentItem;
        private IWatchList mParent;
        private CFAIncidentSourceOptions mProgramOptions;
        private CFAIncidentSource mParentSource;

        private bool mfFadeOut;

        public WatchNotification(IncidentItem inciItem, IWatchList parent, CFAIncidentSourceOptions progOptions, CFAIncidentSource ParentSource)
        {
            InitializeComponent();

            mIncidentItem = inciItem;
            mParent = parent;
            mProgramOptions = progOptions;
            mParentSource = ParentSource;

            mfFadeOut = true;

            if (inciItem.Responsible == "DSE")
            {
                //Swap the background image
                this.BackgroundImage = dseImageDummy.BackgroundImage;
            }
               

            //Check if a stream exists for this region
            if (String.IsNullOrEmpty(mProgramOptions.GetRegionStream(mIncidentItem.Region)) == true ||
                String.IsNullOrEmpty(mParentSource.GetIncidentWatcher().GetStreamListenerPath()) == true)
            {
                btn2.Visible = false;
            }
            else
            {
                btn2.Visible = true;

                //If we have it set to open the stream
                if (mParentSource.GetIncidentWatcher().GetAutoOpenStreamOnWatch() == true)
                {
                    OpenStream();
                }
            }

        }

        private void OpenStream()
        {
            //Listen to Stream
            try
            {
                //Replace Values in args string
                String argsString = mProgramOptions.StreamListenerArgs;
                argsString = mProgramOptions.ReplaceInciWatchVarsInString(argsString, mIncidentItem);

                System.Diagnostics.Process.Start(mParentSource.GetIncidentWatcher().GetStreamListenerPath(), argsString);
            }
            catch
            {
                MessageBox.Show("Unable to start stream application.");
            }
        }

        private bool UpdateDialog()
        {
            bool returnValue = false;

            lblAddress.Text = mIncidentItem.Location;
            ttDisplay.SetToolTip(lblAddress, "Location: "+mIncidentItem.Location);

            lblSuburb.Text = mIncidentItem.Suburb;
            ttDisplay.SetToolTip(lblSuburb, "Suburb: " + mIncidentItem.Suburb);

            lblApplianceCount.Text = mIncidentItem.ApplianceCount.ToString();
            ttDisplay.SetToolTip(lblApplianceCount, "Appliance Count: "+mIncidentItem.ApplianceCount.ToString());

            lblUpdateTime.Text = mIncidentItem.LastUpdate.ToString("HH:mm");
            ttDisplay.SetToolTip(lblUpdateTime,"Last Update: " + mIncidentItem.LastUpdate.ToString("HH:mm"));

            int regionInt = 0;
            if (int.TryParse(mIncidentItem.Region, out regionInt) == true)
            {
                lblRegion.Text = "R" + mIncidentItem.Region;
                ttDisplay.SetToolTip(lblRegion, "Region: " + mIncidentItem.Region);
            }
            else
            {
                lblRegion.Text = "DSE";
                ttDisplay.SetToolTip(lblRegion, "DSE Region: " + mIncidentItem.Region);
            }
            
            //HACK: Filthy hack that checks the text of status to see if it is about to change to safe.
            if (mIncidentItem.Status == IncidentItem.IncidentStatus.Safe && lblStatus.Text != "SAFE")
                returnValue = true;

            UpdateIncidentSize();
            UpdateIncidentStatus();
            UpdateIncidentType();
            
            //Check if a stream exists for this region
            if (String.IsNullOrEmpty(mProgramOptions.GetRegionStream(mIncidentItem.Region)) == true ||
                String.IsNullOrEmpty(mParentSource.GetIncidentWatcher().GetStreamListenerPath()) == true)
            {
                btn2.Visible = false;
            }
            else
            {
                btn2.Visible = true;
            }

            return returnValue;

        }

        private void UpdateIncidentType()
        {
            switch (mIncidentItem.Type)
            {
                case IncidentItem.IncidentType.FalseAlarm:
                    lblType.Text = "FALS";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.GrassAndScrub:
                    lblType.Text = "G&S";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Incident:
                    lblType.Text = "INCI";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.NonStructure:
                    lblType.Text = "NOST";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Other:
                    lblType.Text = "OTHE";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Rescue:
                    lblType.Text = "RESC";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Structure:
                    lblType.Text = "STRU";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Unknown:
                    lblType.Text = "UNK";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Wildfire:
                    lblType.Text = "WDFR";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Hazmat:
                    lblType.Text = "HZMT";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Scrub:
                    lblType.Text = "SCRB";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Washaway:
                    lblType.Text = "WASH";
                    lblType.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentType.Assist:
                    lblType.Text = "ASST";
                    lblType.ForeColor = Color.White;
                    break;
            }
            ttDisplay.SetToolTip(lblType, "Type: "+IncidentItem.IncidentTypeToString(mIncidentItem.Type));
        }

        private void UpdateIncidentStatus()
        {
            switch (mIncidentItem.Status)
            {
                case IncidentItem.IncidentStatus.Completed:
                    lblStatus.Text = "COMPL";
                    lblStatus.ForeColor = Color.White;
                    break;
                case IncidentItem.IncidentStatus.Contained:
                    lblStatus.Text = "CONTN";
                    lblStatus.ForeColor = Color.OrangeRed;
                    break;
                case IncidentItem.IncidentStatus.Controlled:
                    lblStatus.Text = "CNTRL";
                    lblStatus.ForeColor = Color.Orange;
                    break;
                case IncidentItem.IncidentStatus.Going:
                    lblStatus.Text = "GOING";
                    lblStatus.ForeColor = Color.Red;
                    break;
                case IncidentItem.IncidentStatus.Safe:
                    lblStatus.Text = "SAFE";
                    lblStatus.ForeColor = Color.LimeGreen;
                    break;
                case IncidentItem.IncidentStatus.Unknown:
                    lblStatus.Text = "UNKN";
                    lblStatus.ForeColor = Color.White;
                    break;
            }
            ttDisplay.SetToolTip(lblStatus, "Status: " + IncidentItem.IncidentStatusToString(mIncidentItem.Status));
        }

        private void UpdateIncidentSize()
        {
            //Get text
            switch (IncidentItem.ParseIncidentSize(mIncidentItem.Size))
            {
                case IncidentItem.IncidentSize.Large:
                    lblSize.Text = "LRG";
                    lblSize.ForeColor = Color.Red;
                    break;
                case IncidentItem.IncidentSize.Medium:
                    lblSize.Text = "MED";
                    lblSize.ForeColor = Color.Orange;
                    break;
                case IncidentItem.IncidentSize.Small:
                    lblSize.Text = "SML";
                    lblSize.ForeColor = Color.LimeGreen;
                    break;
                case IncidentItem.IncidentSize.Spot:
                    lblSize.Text = "SPT";
                    lblSize.ForeColor = Color.LimeGreen;
                    break;
                case IncidentItem.IncidentSize.Nofire:
                    lblSize.Text = "NFR";
                    lblSize.ForeColor = Color.LimeGreen;
                    break;
                default:
                    lblSize.Text = mIncidentItem.Size_GENERIC;
                    lblSize.ForeColor = Color.White;
                    break;
            }
            ttDisplay.SetToolTip(lblSize, "Size: " + mIncidentItem.Size_GENERIC);
        }

        private void WatchNotification_Load(object sender, EventArgs e)
        {
            UpdateDialog();

            //Hide or UN-Hide the circle square and diamond depending on the values in them
            if (String.IsNullOrEmpty(mProgramOptions.ActionDiamond) == true)
            {
                //Hide the diamond button
                btn6.Visible = false;
            }
            if (String.IsNullOrEmpty(mProgramOptions.ActionSquare) == true)
            {
                //Hide the diamond button
                btn5.Visible = false;
            }
            if (String.IsNullOrEmpty(mProgramOptions.ActionCircle) == true)
            {
                //Hide the diamond button
                btn4.Visible = false;
            }


            //Register Events
            mIncidentItem.OnApplianceCountChanged += new IncidentItem.ApplianceCountChanged(InciApplianceChanged);
            mIncidentItem.OnLastUpdateChanged += new IncidentItem.UpdateChanged(InciLastUpdateChanged);
            mIncidentItem.OnLocationChanged += new IncidentItem.LocationChanged(InciLocationChanged);
            mIncidentItem.OnRegionChanged += new IncidentItem.RegionChanged(InciRegionChanged);
            mIncidentItem.OnSizeChanged += new IncidentItem.SizeChanged(InciSizeChanged);
            mIncidentItem.OnStatusChanged += new IncidentItem.StatusChanged(InciStatusChanged);
            mIncidentItem.OnSuburbChanged += new IncidentItem.SuburbChanged(InciSuburbChanged);
            mIncidentItem.OnTypeChanged +=new IncidentItem.TypeChanged(InciTypeChanged);
        }

        private void InciApplianceChanged( IncidentItem incidentItem, int oldValue )
        {
            UpdateDialog();
        }
        private void InciLastUpdateChanged(IncidentItem incidentItem, DateTime oldValue)
        {
            UpdateDialog();
        }
        private void InciLocationChanged(IncidentItem incidentItem, string oldValue)
        {
            UpdateDialog();
        }
        private void InciRegionChanged(IncidentItem incidentItem, string oldValue)
        {
            UpdateDialog();
        }
        private void InciSizeChanged(IncidentItem incidentItem, string oldValue)
        {
            UpdateDialog();
        }
        private void InciStatusChanged(IncidentItem incidentItem, IncidentItem.IncidentStatus oldValue)
        {
            //Is it now safe??
            if (incidentItem.Status == IncidentItem.IncidentStatus.Safe)
            {
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
                        /*if (mParent.IsKeyBeingWatched(mIncidentItem.ID_GENERIC) == true)
                        {
                            mParent.Remove(mIncidentItem.ID_GENERIC);
                        }*/
                    }
                }
            }
            UpdateDialog();
        }
        private void InciSuburbChanged(IncidentItem incidentItem, string oldValue)
        {
            UpdateDialog();
        }
        private void InciTypeChanged(IncidentItem incidentItem, IncidentItem.IncidentType oldValue)
        {
            UpdateDialog();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Remove this incident item from watch
            mParent.Remove(mIncidentItem.ID_GENERIC);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenStream();
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
                if (String.IsNullOrEmpty(mProgramOptions.ActionCircle) == false)
                {
                    //Replace constants in the string
                    String execString = mProgramOptions.ActionCircleArgs;

                    execString = mProgramOptions.ReplaceInciWatchVarsInString(execString, mIncidentItem);

                    //Execute the command
                    System.Diagnostics.Process.Start(mProgramOptions.ActionCircle,execString);
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
                if (String.IsNullOrEmpty(mProgramOptions.ActionSquare) == false)
                {
                    //Replace constants in the string
                    String execString = mProgramOptions.ActionSquareArgs;

                    execString = mProgramOptions.ReplaceInciWatchVarsInString(execString, mIncidentItem);

                    //Execute the command
                    System.Diagnostics.Process.Start(mProgramOptions.ActionSquare,execString);
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
                if (String.IsNullOrEmpty(mProgramOptions.ActionDiamond) == false)
                {
                    //Replace constants in the string
                    String execString = mProgramOptions.ActionDiamondArgs;

                    execString = mProgramOptions.ReplaceInciWatchVarsInString(execString, mIncidentItem);

                    //Execute the command
                    System.Diagnostics.Process.Start(mProgramOptions.ActionDiamond,execString);
                }
            }
            catch
            {
                MessageBox.Show("Unable to run command assigned to the diamond action button.");
            }
        }

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

        private void WatchNotification_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Un-Register Events
            mIncidentItem.OnApplianceCountChanged -= new IncidentItem.ApplianceCountChanged(InciApplianceChanged);
            mIncidentItem.OnLastUpdateChanged -= new IncidentItem.UpdateChanged(InciLastUpdateChanged);
            mIncidentItem.OnLocationChanged -= new IncidentItem.LocationChanged(InciLocationChanged);
            mIncidentItem.OnRegionChanged -= new IncidentItem.RegionChanged(InciRegionChanged);
            mIncidentItem.OnSizeChanged -= new IncidentItem.SizeChanged(InciSizeChanged);
            mIncidentItem.OnStatusChanged -= new IncidentItem.StatusChanged(InciStatusChanged);
            mIncidentItem.OnSuburbChanged -= new IncidentItem.SuburbChanged(InciSuburbChanged);
            mIncidentItem.OnTypeChanged -= new IncidentItem.TypeChanged(InciTypeChanged);
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
            bool returnValue = UpdateDialog();
            //Redraw
            this.Refresh();

            return returnValue;
        }

        #endregion

        private void WatchNotification_MouseEnter(object sender, EventArgs e)
        {
            tmrFadeout.Stop();
            //Set opacity to 100%
            this.Opacity = 1;
        }

        private void WatchNotification_MouseLeave(object sender, EventArgs e)
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

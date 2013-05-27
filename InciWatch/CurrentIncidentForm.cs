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
using System.Collections;
using System.Reflection;
using System.IO;
using System.Net;

namespace InciWatch
{
    internal struct AppConstants
    {
        public static String ApplicationFriendlyName = "Incident Watch";
    }

    internal partial class CurrentIncidentsForm : Form, IIncidentWatcher
    {
        

        private Dictionary<string,GenericIncidentItem> mIncidentList;
        private WatchList mWatchList;
        private InciWatchOptions mProgramOptions;
        private List<IIncidentSource> mIncidentSources;

        private int mSortColumn = 5;

        //Events        
        public CurrentIncidentsForm()
        {
            InitializeComponent();
            //Create a new Options object
            mProgramOptions = new InciWatchOptions();


            mWatchList = new WatchList(this, mProgramOptions);   

            //Sources
            mIncidentSources = new List<IIncidentSource>();
            //Load Sources
            LoadIncidentSourcesFromPath();

            //If we have no sources it wont be very interesting
            if (mIncidentSources.Count == 0)
            {
                //hide and dispose the notification icon
                ntfyCurrentIncidents.Visible = false;
                ntfyCurrentIncidents.Dispose();

                MessageBox.Show("No Incident Sources were able to be loaded. Please add some Incident Source Dlls into the program folder.", AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Close us
                throw new ArgumentException("No Incident Sources Loaded");
            }

            //Update incident Sources
            foreach (IIncidentSource inciSource in mIncidentSources)
            {
                if (inciSource.UpdateSource() == false)
                {
                    //Should we show an error message?
                    if (mProgramOptions.ShowCantUpdateMessage == true)
                    {
                        //Show Error Message Box
                        MessageBox.Show("Error updating source " + inciSource.GetSourceName(), AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            //Update Notify Text
            ntfyCurrentIncidents.Text = "Incident Watcher - Updated " + DateTime.Now.ToLongTimeString();
            this.Text = "Current Incidents - Updated " + DateTime.Now.ToLongTimeString();

            //Set the timer interval
            refreshTimer.Interval = mProgramOptions.GathererRefreshInterval * 1000;


        }

        private void LoadIncidentSourcesFromPath()
        {
            LoadPlugins(Directory.GetCurrentDirectory(), typeof(IIncidentSource).ToString());
        }

        private void LoadPlugins(string Path, string PluginInterface)
        {
            String[] strDLLs;
            Assembly objDLL;

            //Go through all DLLs in the directory, attempting to load them
            strDLLs = Directory.GetFileSystemEntries(Path, "*.dll");
        
            //Return all plugins found
            List<string> Results = new List<string>();

            for (int intIndex = 0;intIndex<strDLLs.Length;intIndex++)
            {
                try
                {
                    objDLL = Assembly.LoadFrom(strDLLs[intIndex]);
                    ExamineAndLoadAssembly(objDLL, PluginInterface);
                }
                catch( Exception e )
                {
                    //Error loading DLL, we don't need to do anything special
                }
            }
        }

        private void ExamineAndLoadAssembly(Assembly ObjDLL, string InterfaceName)
        {
            //Loop through each type in the DLL
            foreach(Type objectType in ObjDLL.GetTypes())
            {
                //Only look at public types
                if (objectType.IsPublic == true)
                {
                    //Ignore abstract classes
                    if (!((objectType.Attributes & TypeAttributes.Abstract) == TypeAttributes.Abstract))
                    {
                        //See if this type implements our interface
                        Type objInterface = objectType.GetInterface(InterfaceName, true);

                        if( objInterface != null)
                        {
                            //It does, Load It
                            IIncidentSource pluginInstance = (IIncidentSource)LoadPluginFromDLL( ObjDLL.Location, objectType.FullName);
                            if (pluginInstance != null)
                            {
                                //Success loading this plugin, add to the Incident Sources
                                if (pluginInstance.Initialize(this, mWatchList) == true)
                                {
                                    mIncidentSources.Add(pluginInstance);
                                }
                                else
                                {
                                    //Failed initialization
                                    MessageBox.Show("Plugin from " + ObjDLL.Location, AppConstants.ApplicationFriendlyName +" Failed its initialization", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                
                                
                            }
                            else
                            {
                                MessageBox.Show("Error loading Plugin from " + ObjDLL.Location, AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        
                        }

                    }
                }
            }
        }

        private static object LoadPluginFromDLL(string AssemblyPath, string ClassName)
        {
            Assembly objDLL;
            Object objPlugin;

            try
            {
                //Load DLL
                objDLL = Assembly.LoadFrom(AssemblyPath);

                //Create and return class instance
                objPlugin = objDLL.CreateInstance(ClassName);
                return objPlugin;
            }
            catch
            {
                return null;
            }

        }
    
        private Dictionary<string,GenericIncidentItem> GetGenericIncidentsFromIncidentSources()
        {
            //Create the return list
            Dictionary<string, GenericIncidentItem> returnList = new Dictionary<string, GenericIncidentItem>();

            

            //For each Incident Source, get the incidents
            foreach (IIncidentSource inciSource in mIncidentSources)
            {
                //Get the incident lists
                List<GenericIncidentItem> sourceIncidents = inciSource.GetIncidents();
                
                //Add all the incidents to the dictionary
                foreach (GenericIncidentItem genericInci in sourceIncidents)
                {
                    returnList.Add(genericInci.ID_GENERIC, genericInci);
                }

                //Clear out tool tip stuff
                inciSource.GetToolTipText();
            }

            return returnList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void UpdateIncidentList()
        {

            //Get the dictionary of Items
            Dictionary<string,GenericIncidentItem> incidentList = GetGenericIncidentsFromIncidentSources();

            if (incidentList != null)
            {
                //Set the main dictionary to this new one
                mIncidentList = incidentList;

                //Clear old list view
                incidentListView.Items.Clear();

                //Suspend layout to stop flicker
                incidentListView.SuspendLayout();
                foreach (KeyValuePair<string,GenericIncidentItem> inci in incidentList)
                {
                    //Dont add to list if its older than the set hours.
                    if ((DateTime.Now - inci.Value.LastUpdate_GENERIC).TotalHours > mProgramOptions.HideIncidentsAfterHours)
                        continue;

                    //Create a new List view item 
                    ListViewItem newLvi = new ListViewItem();

                    //Set the values
                    newLvi.Text = inci.Value.Suburb_GENERIC;
                    if (mProgramOptions.DisplayUppercase)
                    {
                        inci.Value.Location_GENERIC = inci.Value.Location_GENERIC.ToUpper();
                    }
                    newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, inci.Value.Location_GENERIC));
                    newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, inci.Value.Type_GENERIC));
                    newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, inci.Value.Status_GENERIC));
                    newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, inci.Value.Region_GENERIC));
                    newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, GenericIncidentItem.DateTimeToString(inci.Value.LastUpdate_GENERIC)));
                    newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, inci.Value.ApplianceCount_GENERIC.ToString()));
                    newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, inci.Value.Size_GENERIC));

                    if (mWatchList.IsKeyBeingWatched(inci.Key))
                    {
                        //Add a X in the Watched box
                        newLvi.SubItems.Add(new ListViewItem.ListViewSubItem(newLvi, "X"));
                    }

                    //Set the Tag, (Important, we use this as our Key)
                    newLvi.Tag = inci.Key;

                    //No icon
                    newLvi.ImageIndex = mIncidentSources.IndexOf(inci.Value.GetSource()) + 2;
                    newLvi.IndentCount = 0;

                    //Add to list view
                    incidentListView.Items.Add(newLvi);

                    //Sort
                    incidentListView.Sort();
                }
                //Cant forget to resumt
                incidentListView.ResumeLayout();
                if (mProgramOptions.AutoSizeColumns)
                {
                    lvhdAddress.Width = -1;
                    lvhdSuburb.Width = -1;
                }
            }

            //Update the watch windows
            mWatchList.Update();

        }

        private void CurrentIncidentsForm_Load(object sender, EventArgs e)
        {
            //----Update the List View Icons----
            //Create a new Image List
            ImageList il = new ImageList();
            il.ColorDepth = ilImageList.ColorDepth;
            il.ImageSize = ilImageList.ImageSize;
            il.TransparentColor = ilImageList.TransparentColor;
            //Get the first 2 entries
            il.Images.Add(ilImageList.Images[0]); //Appliance Icon
            il.Images.Add(ilImageList.Images[1]); //Watch Icon

            //Get the icons for the sources
            for (int i = 0; i < mIncidentSources.Count; i++)
            {
                il.Images.Add(mIncidentSources[i].GetSmallImage());
            }
            //Set the list view to use the new image list
            incidentListView.SmallImageList = il;


            UpdateIncidentList();
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            incidentListView.ListViewItemSorter = new ListViewItemComparer(mSortColumn,
                                                               SortOrder.Descending);

            
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            //Get the tooltip stuff
            string toolTipText = "";

            //Update incident Sources
            foreach (IIncidentSource inciSource in mIncidentSources)
            {
                if (inciSource.UpdateSource() == false)
                {
                    //Should we show an error message?
                    if (mProgramOptions.ShowCantUpdateMessage == true)
                    {
                        //Show Error Message Box
                        MessageBox.Show("Error updating source " + inciSource.GetSourceName(), AppConstants.ApplicationFriendlyName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                toolTipText += inciSource.GetToolTipText();

            }

            //Update Notify Text
            ntfyCurrentIncidents.Text = "Incident Watcher - Updated " + DateTime.Now.ToLongTimeString();
            this.Text = "Current Incidents - Updated " + DateTime.Now.ToLongTimeString();

            //Check for Tooltip stuff
            if (toolTipText != "")
                //Show the tooltip
                ntfyCurrentIncidents.ShowBalloonTip(5 * 1000, "Incident Watcher", toolTipText, ToolTipIcon.None);

            UpdateIncidentList();

            //Reupdate the timer interval
            refreshTimer.Interval = mProgramOptions.GathererRefreshInterval * 1000;
            refreshTimer.Stop();
            refreshTimer.Start();

        }
        private void incidentListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //Show Context menu
                ListViewItem selectedListViewItem = null;
                selectedListViewItem = incidentListView.GetItemAt(e.X, e.Y);
                
                if(selectedListViewItem != null)
                {
                    //Clear other selections
                    foreach (ListViewItem selIndex in incidentListView.SelectedItems)
                        selIndex.Selected = false;

                    //Select this item
                    selectedListViewItem.Selected = true;

                    //Build context menu
                    if( mWatchList.IsKeyBeingWatched( (string)selectedListViewItem.Tag ))
                    {
                        addWatchToolStripMenuItem.Text = "Remove Watch";
                    }else{
                        addWatchToolStripMenuItem.Text = "Add Watch";
                    }

                    //Get the item 
                    GenericIncidentItem currentItem = mIncidentList[(string)selectedListViewItem.Tag];

                  
                    //Check if we can get a stream
                    if ( currentItem.IsStreamAvailable() == false)
                    {
                        listenToStreamToolStripMenuItem.Enabled = false;                        
                    } else {
                        listenToStreamToolStripMenuItem.Enabled = true;
                    }

                    //Check if we can get a map location
                    if (currentItem.IsMapAvailable() == false)
                    {
                        locateInGoogleMapsToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        locateInGoogleMapsToolStripMenuItem.Enabled = true;
                    }

                    //Display the context menu
                    Point contextPoint = new Point(e.X, e.Y);

                    rightClickMenu.Show(this.PointToScreen(contextPoint));

                }
            }
        }

        private void addWatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (mWatchList.IsKeyBeingWatched((string)incidentListView.SelectedItems[0].Tag))
                {
                    //Remove from watch list
                    mWatchList.Remove((string)incidentListView.SelectedItems[0].Tag);
                }
                else
                {
                    //Add to watch
                    mWatchList.Add(mIncidentList[(string)incidentListView.SelectedItems[0].Tag]);
                }

            }
            catch
            {
            }
        }

        private void viewCurrentIncidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mWatchList.Clear();
            this.Close();
            this.Dispose();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            //Create a new OPtions form
            OptionsForm newOptionsForm = new OptionsForm();

            newOptionsForm.ShowOptions(mProgramOptions,this);

            //Dispose form
            newOptionsForm.Dispose();
        }

        private void CurrentIncidentsForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //Override and hide
                this.Hide();
                this.WindowState = FormWindowState.Normal;
                
            }
        }

        private void incidentListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // if the column is > 7 then ignore it
            if (e.Column < 7)
            {
                // Determine whether the column is the same as the last column clicked.
                if (e.Column != mSortColumn)
                {
                    // Set the sort column to the new column.
                    mSortColumn = e.Column;
                    // Set the sort order to ascending by default.
                    incidentListView.Sorting = SortOrder.Ascending;
                }
                else
                {
                    // Determine what the last sort order was and change it.
                    if (incidentListView.Sorting == SortOrder.Ascending)
                        incidentListView.Sorting = SortOrder.Descending;
                    else
                        incidentListView.Sorting = SortOrder.Ascending;
                }

                // Call the sort method to manually sort.
                incidentListView.Sort();
                // Set the ListViewItemSorter property to a new ListViewItemComparer
                // object.
                incidentListView.ListViewItemSorter = new ListViewItemComparer(e.Column,
                                                                   incidentListView.Sorting);
            }


        }

        private void listenToStreamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listen to Stream
            try
            {
                //Replace Values in args string
                String argsString = mIncidentList[(string)incidentListView.SelectedItems[0].Tag].GetStreamURL();

                System.Diagnostics.Process.Start(mProgramOptions.StreamListenerPath, argsString);
            }
            catch
            {
                MessageBox.Show("Unable to start stream application.");
            }
        }

        private void locateInGoogleMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Build Street string
            try
            {
                GenericIncidentItem incidentItem = mIncidentList[(string)incidentListView.SelectedItems[0].Tag];
                string locString = "";

                locString = incidentItem.GetMapURL();

                System.Diagnostics.Process.Start(locString);

            }
            catch
            {
                MessageBox.Show("Unable to open browser to Google maps.");
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            (new AboutBox(mProgramOptions.CheckForApplicationUpdatesOnAbout)).ShowDialog();
        }

        private void ntfyCurrentIncidents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        #region Plugin Interface Methods
        public void PlayNoise(NoiseType Noise)
        {
            //try Make A noise
            try
            {
                if (Noise == NoiseType.NewIncident)
                {
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer("newjob.wav");
                    sp.Play();
                    sp.Dispose();
                }
                if (Noise == NoiseType.NewAutowatch)
                {
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer("autowatch.wav");
                    sp.Play();
                    sp.Dispose();
                }
            }
            catch
            {
                //Ahwell, no sound
            }
        }

        public bool GetAutoCloseWatchOnSafe()
        {
            //Get the settings object
            return mProgramOptions.AutoCloseWatchOnSafe;
        }

        public string GetStreamListenerPath()
        {
            return mProgramOptions.StreamListenerPath;
        }

        public bool GetShowCantUpdateMessage()
        {
            return mProgramOptions.ShowCantUpdateMessage;
        }

        public bool GetAutoOpenStreamOnWatch()
        {
            return mProgramOptions.OpenStreamOnWatch;
        }

        public int GetAutoCloseWatchOnSafeDelay()
        {
            return mProgramOptions.AutoCloseWatchOnSafeDelay;
        }

        public bool UsesProxy()
        {
            return mProgramOptions.UseProxy;
        }

        public WebProxy GetProxy()
        {
            //Create a new Return Proxy
            WebProxy returnProxy = new WebProxy(mProgramOptions.ProxyAddress, mProgramOptions.ProxyPort);
            
            //Do we add credentials?
            if (string.IsNullOrEmpty(mProgramOptions.ProxyUsername) == false ||
                string.IsNullOrEmpty(mProgramOptions.ProxyPassword) == false)
            {
                //We need to add credentials
                NetworkCredential networkCreds = new NetworkCredential(mProgramOptions.ProxyUsername, mProgramOptions.ProxyPassword);

                returnProxy.Credentials = networkCreds;
            }

            return returnProxy;
        }

        #endregion

        public List<IIncidentSource> IncidentSources
        {
            get
            {
                return mIncidentSources;
            }
        }

        private void CurrentIncidentsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Clear out the watches
            mWatchList.Clear();
        }

    }
}

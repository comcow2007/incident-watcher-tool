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
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace InciWatch
{
    internal class WatchList : IWatchList
    {
        private Dictionary<string, IWatchNotification> mWatchWindows = new Dictionary<string,IWatchNotification>();
        private CurrentIncidentsForm mParent;
        private object mProgramOptions;

        public WatchList(CurrentIncidentsForm parent, object progOptions)
        {
            mParent = parent;
            mProgramOptions = progOptions;
        }
        public bool IsKeyBeingWatched(string Key)
        {
            return mWatchWindows.ContainsKey(Key);
        }

        public void Add(GenericIncidentItem incidentItem)
        {
            //Create a new Watch notification window
            IWatchNotification newWatchNotify = incidentItem.GetSource().GetWatchWindow(incidentItem.ID_GENERIC,this);

            //Calculate Position of new window
            Rectangle windowRect = Screen.PrimaryScreen.WorkingArea;

            //PositionX = width - widthOfWindow
            
            int X = windowRect.Width - newWatchNotify.GetWidth();

            //PositionY = height - (the current stack height+this window height)

            int Y = windowRect.Height - (GetCurrentStackHeight()+newWatchNotify.GetHeight());

            newWatchNotify.SetPosition(new Point(X, Y));

            //Add a new Watch window
            mWatchWindows.Add(incidentItem.ID_GENERIC, newWatchNotify);
            //Show window
            newWatchNotify.ShowNotification();

            //Update Parent list
            mParent.UpdateIncidentList();          
        }

        public void Add(IWatchNotification incidentWatch, GenericIncidentItem incidentItem)
        {
            //Create a new Watch notification window
            IWatchNotification newWatchNotify = incidentWatch;

            //Calculate Position of new window
            Rectangle windowRect = Screen.PrimaryScreen.WorkingArea;

            //PositionX = width - widthOfWindow

            int X = windowRect.Width - newWatchNotify.GetWidth();

            //PositionY = height - (the current stack height+this window height)

            int Y = windowRect.Height - (GetCurrentStackHeight() + newWatchNotify.GetHeight());

            newWatchNotify.SetPosition(new Point(X, Y));

            //Add a new Watch window
            mWatchWindows.Add(incidentItem.ID_GENERIC, newWatchNotify);
            //Show window
            newWatchNotify.ShowNotification();

            //Update Parent list
            //mParent.UpdateIncidentList();
        }
        private int GetCurrentStackHeight()
        {
            int returnValue = 0;

            //Loop through the Entries
            foreach (KeyValuePair<string,IWatchNotification> watchNotification in mWatchWindows)
            {
                //Tally this height
                returnValue += watchNotification.Value.GetHeight();
            }

            //Return the sum
            return returnValue;
        }

        public void Remove(string Key)
        {
            //Get location
            Point removeWatchLocation = mWatchWindows[Key].GetPosition();
            //Get the height
            int removedWatchHeight = mWatchWindows[Key].GetHeight();

            //Remove watch and adjust positions
            mWatchWindows[Key].CloseNotification();
            mWatchWindows.Remove(Key);

            //Update window locations
            foreach (KeyValuePair<string,IWatchNotification> wn in mWatchWindows)
            {
                //Get the location
                Point currentWindowLocation = wn.Value.GetPosition();
                //Is it higher than the removed notify
                if (currentWindowLocation.Y < removeWatchLocation.Y)
                {
                    //Work out if it should be refreshed
                    bool fRefresh = false;

                    //We should refresh
                    if (currentWindowLocation.Y < 0)
                        fRefresh = true;

                    //Move it up by the removed item size (toward the bottom)
                    wn.Value.SetPosition(new Point(currentWindowLocation.X, currentWindowLocation.Y + removedWatchHeight));

                    //Was it higher than the current screen
                    if (fRefresh == true)
                        wn.Value.RefreshNotification();
                }
            }

            //Update Parent list
            mParent.UpdateIncidentList();
        }


        internal void Update()
        {
            //Build a instant remove dictionary
            List<String> removeKeyList = new List<string>();
            //Update all the watches
            foreach (KeyValuePair<string, IWatchNotification> wn in mWatchWindows)
            {
                if (wn.Value.RefreshNotification() == true)
                    removeKeyList.Add(wn.Key);
            }

            //Loop through the remove key list.
            foreach (string removeKey in removeKeyList)
            {
                //Remove the notifier
                this.Remove(removeKey);
            }
        }

        internal void Clear()
        {
            foreach (KeyValuePair<string, IWatchNotification> wn in mWatchWindows)
            {
                //Close all
                wn.Value.CloseNotification();
            }

            //Clear dictionary
            mWatchWindows.Clear();
        }
    }
}

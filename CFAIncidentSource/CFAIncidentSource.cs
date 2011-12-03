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
using System.Text;
using InciWatch;
using System.Drawing;

namespace CFAIncidentSource
{
    static class SourceConstants
    {
        public const string ID_PREFIX = "PCFA";
    }
    

    public class CFAIncidentSource : InciWatch.IIncidentSource 
    {      

        private IWatchList mWatches;
        private IncidentItemList mIncidentList;
        private CFAIncidentSourceOptions mOptions = new CFAIncidentSourceOptions();

        private IIncidentWatcher mIncidentWatcher;

        private bool mFirstRun;

        public CFAIncidentSource()
        {
            mFirstRun = true;
            mIncidentList = new IncidentItemList(new Gatherer(mOptions, this), this, mOptions);
        }

        public string GetSourceName()
        {
            return "One Source One Message";
        }

        public bool HasOptionsDialog()
        {
            return true;
        }

        public string GetToolTipText()
        {
            return mIncidentList.GetToolTipText();
        }

        public List<GenericIncidentItem> GetIncidents()
        {
            List<GenericIncidentItem> returnList = new List<GenericIncidentItem>();

            //Get the incidents, convert them to Generic Incident Items
            foreach (KeyValuePair<string, IncidentItem> inci in mIncidentList.GetIncidentDictionary())
            {
                //Add this generic incident to the return list
                returnList.Add(inci.Value);
            }

            //If it is the first Run, clear the tooltips
            if (mFirstRun == true)
            {
                mFirstRun = false;
                this.GetToolTipText();
            }

            return returnList;
        }

        public bool OpenOptionDialog()
        {
            OptionsForm options = new OptionsForm();
            options.ShowOptions(mOptions);

            return true;
        }

        public IWatchNotification GetWatchWindow(string ID, IWatchList parent)
        {
            //Create a new Watch Window
            //Does the supplied ID match this source
            if (ID.StartsWith(SourceConstants.ID_PREFIX) == true)
            {
                string actualID = ID.Remove(0, SourceConstants.ID_PREFIX.Length);

                return new WatchNotification(mIncidentList.GetIncidentDictionary()[actualID], parent, mOptions, this);
            }
            else
            {
                return null;
            }
        }

        public Image GetLargeImage()
        {
            return Properties.Resources.largeimage;
        }

        public Image GetSmallImage()
        {
            return Properties.Resources.smallimage;
        }

        public bool UpdateSource()
        {
            return mIncidentList.UpdateDictionary();
        }

        public bool Initialize(IIncidentWatcher IncidentWatcher, IWatchList Watches)
        {
            mIncidentWatcher = IncidentWatcher;
            mWatches = Watches;
            return true;
        }

        public IIncidentWatcher GetIncidentWatcher()
        {
            return mIncidentWatcher;
        }

        internal IWatchList GetWatchList()
        {
            return mWatches;
        }

    }
}

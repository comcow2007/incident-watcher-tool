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
using System.Text;
using InciWatch;
using System.Drawing;

namespace MFBIncidentSource
{
    static class SourceConstants
    {
        public const string ID_PREFIX = "PMFB";
    }

    public class MFBIncidentSource : IIncidentSource
    {
        IIncidentWatcher mIncidentWatcher;
        IWatchList mWatchList;
        MFBIncidentSourceOptions mOptions;
        MFBIncidentItemList mIncidentList;

        #region Interface Functions
        public bool Initialize(IIncidentWatcher IncidentWatcher, IWatchList Watches)
        {
            mIncidentWatcher = IncidentWatcher;
            mWatchList = Watches;
            mOptions = new MFBIncidentSourceOptions();

            //Create a new Incident List
            mIncidentList = new MFBIncidentItemList(this);

            return true;
        }

        public string GetToolTipText()
        {
            return mIncidentList.GetToolTipText();
        }

        public Image GetLargeImage()
        {
            return Properties.Resources.large_icon;
        }

        public Image GetSmallImage()
        {
            return Properties.Resources.small_icon;
        }

        public string GetSourceName()
        {
            return "MFB Public Feed";
        }

        public bool HasOptionsDialog()
        {
            return true;
        }

        public bool UpdateSource()
        {
            //Update the incidents list
            return mIncidentList.UpdateList();
        }

        public IWatchNotification GetWatchWindow(string ID, IWatchList Watches)
        {
            string ActualID = ID.Remove(0, SourceConstants.ID_PREFIX.Length);

            //create a watch window
            return new MFBWatchNotification(mIncidentList.GetIncidentDictionary()[ActualID], Watches, mOptions, this);
            
        }

        public bool OpenOptionDialog()
        {
            try
            {
                //Actually open the options dialog.
                Options newOptionsDialog = new Options();
                newOptionsDialog.ShowOptions(mOptions);
                //Close the options dialog
                newOptionsDialog.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public List<GenericIncidentItem> GetIncidents()
        {
            //Return the incidents
            return mIncidentList.GetIncidents();
        }


        internal MFBIncidentSourceOptions GetOptions()
        {
            return mOptions;
        }

        internal IWatchList GetWatchList()
        {
            return mWatchList;
        }

        internal IIncidentWatcher GetIncidentWatcher()
        {
            return mIncidentWatcher;
        }

        #endregion
    }
}

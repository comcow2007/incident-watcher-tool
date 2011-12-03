//SimpleSource - This incident source is an example of how to create a source plugin using the interfaces provided by Incident Watcher
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


namespace SimpleSource
{
    internal class SimpleConstants
    {
        public const string ID_PREFIX = "SIMP";
    }

    public class SimpleSource : IIncidentSource
    {
        SimpleOptions mOptions = new SimpleOptions();

        public Image GetLargeImage()
        {
            return Properties.Resources.sourceicon;
        }

        public Image GetSmallImage()
        {
            //Resize down to 16x16           
            return new Bitmap(Properties.Resources.sourceicon, new Size(16,16));
        }

        public string GetSourceName()
        {
            return "Simple Source";
        }

        public bool UpdateSource()
        {
            return true;
        }

        public List<GenericIncidentItem> GetIncidents()
        {
            List<GenericIncidentItem> returnList = new List<GenericIncidentItem> ();

            //Create a new incident
            SimpleIncident newListItem = mOptions.GenerateSimpleIncident(this);

            returnList.Add(newListItem);

            return returnList;
        }

        public bool HasOptionsDialog()
        {
            return true;
        }

        public bool OpenOptionDialog()
        {
            mOptions.ShowDialog();
            return true;
        }

        public IWatchNotification GetWatchWindow(string ID, IWatchList Watches)
        {
            string ActualID = ID.Remove(0, SimpleConstants.ID_PREFIX.Length);

            return new SimpleWatcher(mOptions.GenerateSimpleIncident(this), Watches);   
        }

        public bool Initialize(IIncidentWatcher IncidentWatcher, IWatchList Watches)
        {
            return true;
        }

        public string GetToolTipText()
        {
            return "SIMPLE: Line 1" + "\n" + "SIMPLE: Line 2";
        }
    }
}

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

namespace InciWatch
{
    public abstract class GenericIncidentItem
    {
        public abstract IIncidentSource GetSource();

        public abstract bool IsMapAvailable();
        public abstract string GetMapURL();

        public abstract bool IsStreamAvailable();
        public abstract string GetStreamURL();

        private string mID = null;
        private string mType = null;
        private string mStatus = null;
        private string mSize = null;
        private string mRegion = null;
        private string mSuburb = null;
        private string mLocation = null;
        private DateTime mLastUpdate = DateTime.MinValue;
        private int mApplianceCount = 0;

        public string ID_GENERIC
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public string Type_GENERIC
        {
            get
            {
                return mType;
            }
            set
            {
                mType= value;
            }
        }

        public string Status_GENERIC
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }

        public string Size_GENERIC
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }

        public string Region_GENERIC
        {
            get
            {
                return mRegion;
            }
            set
            {
                mRegion = value;
            }
        }

        public string Suburb_GENERIC
        {
            get
            {
                return mSuburb;
            }
            set
            {
                mSuburb = value;
            }
        }

        public string Location_GENERIC
        {
            get
            {
                return mLocation;
            }
            set
            {
                mLocation = value;
            }
        }

        public DateTime LastUpdate_GENERIC
        {
            get
            {
                return mLastUpdate;
            }
            set
            {
                mLastUpdate  = value;
            }
        }

        public int ApplianceCount_GENERIC
        {
            get
            {
                return mApplianceCount;
            }
            set
            {
                mApplianceCount = value;
            }
        }


        public static DateTime DateStringToDate(string rawString)
        {
            //Inciwatch uses time strings "HH:mm:ss dd/MM/yy"
            //Get the hour string
            string hour = rawString.Substring(0, 2);
            string minute = rawString.Substring(3, 2);
            string second = rawString.Substring(6, 2);

            string day = rawString.Substring(9, 2);
            string month = rawString.Substring(12, 2);
            string year = rawString.Substring(15, 2);

            return new DateTime(int.Parse(year), int.Parse(month), int.Parse(day), int.Parse(hour), int.Parse(minute), int.Parse(second));
        }

        public static String DateTimeToString(DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss dd/MM/yy");
        }


    }
}

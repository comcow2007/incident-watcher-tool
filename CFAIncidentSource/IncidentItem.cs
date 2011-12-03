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
using System.ComponentModel;
using InciWatch;

namespace CFAIncidentSource
{
    public class IncidentItem : GenericIncidentItem
    {
        public enum IncidentType
        {
            Unknown=-1,
            GrassAndScrub=0,
            NonStructure=1,
            Structure=2,
            Rescue=3,
            Incident=4,
            Other=5,
            FalseAlarm=6,
            Wildfire=7,
            Hazmat=8,
            Scrub=9,
            Washaway=10,
            Assist=11
        }

        public enum IncidentStatus
        {
            Unknown=-1,
            Going=0,
            Contained=1,
            Controlled=2,
            Safe=3,
            Completed=4
        }

        public enum IncidentSize
        {
            Unknown=-1,
            Small=0,
            Medium=1,
            Large=2,
            Spot=3,
            Nofire=4
        }

        private string mRegion;

        public string Region
        {
            get { return mRegion; }
            set 
            {
                string oldValue = mRegion;
                mRegion = value;

                Region_GENERIC = mRegion;

                if (OnRegionChanged != null)
                    OnRegionChanged(this, oldValue);
            }
        }
        private string mSuburb;

        public string Suburb
        {
            get { return mSuburb; }
            set 
            {
                string oldValue = mSuburb;
                mSuburb = value;
                Suburb_GENERIC = mSuburb;
                if (OnSuburbChanged != null)
                    OnSuburbChanged(this, oldValue);
            }
        }
        private string mLocation;

        public string Location
        {
            get { return mLocation; }
            set 
            {
                string oldValue = mLocation;
                mLocation = value;
                Location_GENERIC = mLocation;
                if (OnLocationChanged != null)
                    OnLocationChanged(this, oldValue);
            }
        }

        private string mLatitude;

        public string Latitude
        {
            get { return mLatitude; }
            set { mLocation = value; }
        }

        private string mLongitude;

        public string Longitude
        {
            get { return mLongitude; }
            set { mLongitude = value; }
        }

        private string mResponsible;

        public string Responsible
        {
            get { return mResponsible; }
            set { mResponsible = value; }
        }

        private DateTime mLastUpdate;

        public DateTime LastUpdate
        {
            get { return mLastUpdate; }
            set 
            {
                DateTime oldValue = mLastUpdate;
                mLastUpdate = value;
                LastUpdate_GENERIC = mLastUpdate;
                if (OnLastUpdateChanged != null)
                    OnLastUpdateChanged(this, oldValue);
            }
        }
        private IncidentType mIncidentType;

        internal IncidentType Type
        {
            get { return mIncidentType; }
            set 
            {
                IncidentType oldValue = mIncidentType;
                mIncidentType = value;
                Type_GENERIC = IncidentItem.IncidentTypeToString(mIncidentType);
                if (OnTypeChanged != null)
                    OnTypeChanged(this, oldValue);
            }
        }
        private IncidentStatus mIncidentStatus;

        internal IncidentStatus Status
        {
            get { return mIncidentStatus; }
            set 
            {
                IncidentStatus oldValue = mIncidentStatus;
                mIncidentStatus = value;
                Status_GENERIC = IncidentItem.IncidentStatusToString(mIncidentStatus);
                if (OnStatusChanged != null)
                    OnStatusChanged(this, oldValue);
            }
        }
        private int mApplianceCount;

        public int ApplianceCount
        {
            get { return mApplianceCount; }
            set 
            {
                int oldValue = mApplianceCount;
                mApplianceCount = value;
                ApplianceCount_GENERIC = mApplianceCount;
                if (OnApplianceCountChanged != null)
                    OnApplianceCountChanged(this, oldValue);
            }
        }
        private string mIncidentSize;

        internal string Size
        {
            get { return mIncidentSize; }
            set 
            {
                string oldValue = mIncidentSize;
                mIncidentSize = value;
                Size_GENERIC = mIncidentSize;
                if (OnSizeChanged != null)
                    OnSizeChanged(this, oldValue);
            }
        }
        private string mIncidentID;

        public string ID
        {
            get { return mIncidentID; }
            set 
            {
                string oldValue = mIncidentID;
                mIncidentID = value;
                ID_GENERIC = SourceConstants.ID_PREFIX + mIncidentID;
                if (OnIDChanged != null)
                    OnIDChanged(this, oldValue);
            }
        }

        private CFAIncidentSource mParent;
        private CFAIncidentSourceOptions mOptions;

        //Events
        public delegate void RegionChanged(IncidentItem sourceItem, string oldValue);
        public event RegionChanged OnRegionChanged;

        public delegate void SuburbChanged(IncidentItem sourceItem, string oldValue);
        public event SuburbChanged OnSuburbChanged;

        public delegate void LocationChanged(IncidentItem sourceItem, string oldValue);
        public event LocationChanged OnLocationChanged;

        public delegate void UpdateChanged(IncidentItem sourceItem, DateTime oldValue);
        public event UpdateChanged OnLastUpdateChanged;

        public delegate void TypeChanged(IncidentItem sourceItem, IncidentType oldValue);
        public event TypeChanged OnTypeChanged;

        public delegate void StatusChanged(IncidentItem sourceItem, IncidentStatus oldValue);
        public event StatusChanged OnStatusChanged;

        public delegate void ApplianceCountChanged(IncidentItem sourceItem, int oldValue);
        public event ApplianceCountChanged OnApplianceCountChanged;

        public delegate void SizeChanged(IncidentItem sourceItem, string oldValue);
        public event SizeChanged OnSizeChanged;

        public delegate void IDChanged(IncidentItem sourceItem, string oldValue);
        public event IDChanged OnIDChanged;

        public IncidentItem(string Region, string Suburb, string Location, DateTime LastUpdate,
                            IncidentType Type, IncidentStatus Status, int ApplianceCount, string Size,
                            string ID, string Latitude, string Longitude, string AgencyResponsible, CFAIncidentSource parent, CFAIncidentSourceOptions options)
        {
            mRegion = Region;
            Region_GENERIC = Region.ToString();

            mSuburb = Suburb;
            Suburb_GENERIC = Suburb;

            mLocation = Location;
            Location_GENERIC = Location;

            mLatitude = Latitude;
            mLongitude = Longitude;

            mLastUpdate = LastUpdate;
            LastUpdate_GENERIC = LastUpdate;

            mResponsible = AgencyResponsible;

            mIncidentType = Type;
            Type_GENERIC = IncidentItem.IncidentTypeToString(Type);

            mIncidentStatus = Status;
            Status_GENERIC = IncidentItem.IncidentStatusToString(Status);

            mApplianceCount = ApplianceCount;
            ApplianceCount_GENERIC = ApplianceCount;

            mIncidentSize = Size;
            Size_GENERIC = Size;

            mIncidentID = ID;
            ID_GENERIC = SourceConstants.ID_PREFIX + ID;

            mParent = parent;
            mOptions = options;
        }

        public static IncidentType ParseIncidentType(string parseString)
        {
            string tempString = parseString.Trim().ToUpper();
            if (tempString == "FALSE ALARM")
                return IncidentType.FalseAlarm;
            if (tempString == "OTHER")
                return IncidentType.Other;
            if (tempString == "NON STRUCTURE")
                return IncidentType.NonStructure;
            if (tempString == "STRUCTURE")
                return IncidentType.Structure;
            if (tempString == "GRASS")
                return IncidentType.GrassAndScrub;
            if (tempString == "RESCUE")
                return IncidentType.Rescue;
            if (tempString == "INCIDENT")
                return IncidentType.Incident;
            if (tempString == "HAZMAT INCIDENT")
                return IncidentType.Hazmat;
            if (tempString == "WILD FIRE")
                return IncidentType.Wildfire;
            if (tempString == "SCRUB")
                return IncidentType.Scrub;
            if (tempString == "WASHAWAY")
                return IncidentType.Washaway;
            if (tempString == "ASSIST OTHER AGENCY")
                return IncidentType.Assist;

            return IncidentType.Unknown;
        }

        public static string UnparseIncidentType(IncidentType type)
        {
            if (type == IncidentType.FalseAlarm)
                return "FALSE ALARM";
            if (type == IncidentType.Other)
                return "OTHER";
            if (type == IncidentType.NonStructure)
                return "NON STRUCTURE";
            if (type == IncidentType.Structure)
                return "STRUCTURE";
            if (type == IncidentType.GrassAndScrub)
                return "GRASS";
            if (type == IncidentType.Rescue)
                return "RESCUE";
            if (type == IncidentType.Incident)
                return "INCIDENT";
            if (type == IncidentType.Hazmat)
                return "HAZMAT INCIDENT";
            if (type == IncidentType.Wildfire)
                return "WILD FIRE";
            if (type == IncidentType.Scrub)
                return "SCRUB";
            if (type == IncidentType.Washaway)
                return "WASHAWAY";
            if (type == IncidentType.Assist)
                return "ASSIST OTHER AGENCY";

            return "UNKNOWN";
        }

        public static string IncidentTypeToString(IncidentType type)
        {
            if (type == IncidentType.FalseAlarm)
                return "False Alarm";
            if (type == IncidentType.Other)
                return "Other";
            if (type == IncidentType.NonStructure)
                return "Non-Structure";
            if (type == IncidentType.Structure)
                return "Structure";
            if (type == IncidentType.GrassAndScrub)
                return "Grass and Scrub";
            if (type == IncidentType.Rescue)
                return "Rescue";
            if (type == IncidentType.Incident)
                return "Incident";
            if (type == IncidentType.Hazmat)
                return "Hazmat";
            if (type == IncidentType.Wildfire)
                return "Wildfire";
            if (type == IncidentType.Scrub)
                return "Scrub";
            if (type == IncidentType.Washaway)
                return "Washaway";
            if (type == IncidentType.Assist)
                return "Assist Other Agency";

            return "Unknown";
        }

        public static IncidentStatus ParseIncidentStatus(string parseString)
        {
            if (parseString.ToUpper() == "GOING")
                return IncidentStatus.Going;
            if (parseString.ToUpper() == "SAFE")
                return IncidentStatus.Safe;
            if (parseString.ToUpper() == "CONTROLLED")
                return IncidentStatus.Controlled;
            if (parseString.ToUpper() == "CONTAINED")
                return IncidentStatus.Contained;
            if (parseString.ToUpper() == "COMPLETED")
                return IncidentStatus.Completed;

            return IncidentStatus.Unknown;
        }

        public static IncidentSize ParseIncidentSize(string parseString)
        {
            if (parseString.ToUpper() == "SMALL")
                return IncidentSize.Small;
            if (parseString.ToUpper() == "MEDIUM")
                return IncidentSize.Medium;
            if (parseString.ToUpper() == "LARGE")
                return IncidentSize.Large;
            if (parseString.ToUpper() == "SPOT")
                return IncidentSize.Spot;
            if (parseString.ToUpper() == "NOFIRE")
                return IncidentSize.Nofire;

            return IncidentSize.Unknown;
        }


        internal static string IncidentStatusToString(IncidentStatus incidentStatus)
        {
            if (incidentStatus == IncidentStatus.Going)
                return "Going";
            if (incidentStatus == IncidentStatus.Safe)
                return "Safe";
            if (incidentStatus == IncidentStatus.Controlled)
                return "Controlled";
            if (incidentStatus == IncidentStatus.Contained)
                return "Contained";
            if (incidentStatus == IncidentStatus.Completed)
                return "Completed";

            return "Unknown";
        }

        public override string GetMapURL()
        {
            if (String.IsNullOrEmpty(mLongitude) == false && String.IsNullOrEmpty(mLatitude) == false)
            {
                return "http://maps.google.com.au/maps?hl=en&tab=wl&q=" + mLatitude + " " + mLongitude;
            }
            return null;
        }

        public override bool IsMapAvailable()
        {
            return true;
        }

        public override bool IsStreamAvailable()
        {
            if (String.IsNullOrEmpty(mOptions.GetRegionStream(this.Region)) == true)
                return false;
            else
                return true;
        }

        public override string GetStreamURL()
        {
            return mOptions.GetRegionStream(this.Region);
        }

        public override IIncidentSource GetSource()
        {
            return mParent;
        }

    }
}

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
using System.Xml;
using System.IO;

namespace MFBIncidentSource
{
    class MFBIncidentItem : GenericIncidentItem
    {
        #region Class Enums

        public enum MFBTypes
        {
            Unknown=-1,
            StructureFire=1,
            NonStructureFire=2,
            Fire=3,
            Incident=4,
            HazardousIncident=5,
            FullCall=6, //Alarm
            FalseAlarm=10,
            MedicalEmergency=17
        }

        public enum MFBStatus
        {
            Unknown = -1,
            Initiated = 1,
            Investigating = 2,
            NotYetUnderControl = 3,
            UnderControl = 5,
            Stop = 6,
            AlarmEscalated = 7
        }

        #endregion

        #region Class Variables

        //Other Values
        MFBIncidentSource mParentSource;

        //Incident Information
        private string mID;      
        private string mSuburb;
        private string mLocation;        
        private MFBTypes mType;        
        private MFBStatus mStatus;        
        private string mLatitude;        
        private string mLongitude;        
        private DateTime mLastUpdate;        
        private List<string> mAppliances;

        #endregion

        #region Class Functions
        public MFBIncidentItem(MFBIncidentSource ParentSource, XmlNode xmlNode)
        {
            mParentSource = ParentSource;

            Region_GENERIC = "MFB";
            Size_GENERIC = "Small";

            //Init Appliance String
            mAppliances = new List<string>();

            ProcessXmlNode(xmlNode);

        }

        private void ProcessXmlNode(XmlNode xmlNode)
        {
            //Get the values from the xmlNode

            //Get the Id
            ID = xmlNode.Attributes.GetNamedItem("id").Value;

            //Get the Status
            Status = MFBIncidentItem.StringToIncidentStatus(xmlNode.Attributes.GetNamedItem("status_code").Value);            

            //Get the type
            Type = MFBIncidentItem.StringToIncidentType(xmlNode.Attributes.GetNamedItem("type_code").Value);

            //Get the location
            Latitude = xmlNode.Attributes.GetNamedItem("lat").Value;
            Longitude = xmlNode.Attributes.GetNamedItem("lng").Value;

            //Get the appliance string
            ApplicanceString = xmlNode.Attributes.GetNamedItem("appliances").Value;

            //Get the suburb + Location
            string addressString = xmlNode.Attributes.GetNamedItem("address").Value;

            //Split into suburb + location
            string suburbString = "";
            string locationString = "";

            int suburbEnd = addressString.IndexOf(',');
            suburbString = addressString.Substring(0, suburbEnd);

            //Extract the location String
            locationString = addressString.Substring(suburbEnd + 2);

            //if the user does not want to view cross streets
            if (!mParentSource.GetOptions().CrossStreets)
            {
                //Remove the closest cross streets (there will be a space before the / if the actual address isnt on a corner)
                if (locationString.Contains(" /") == true)
                {
                    //There is a ' /', the last / = the start of the cross refs, so remove them
                    locationString = locationString.Remove(locationString.LastIndexOf('/') - 1);
                }
            }
            Suburb = suburbString;
            Location = locationString;
        }

        public override bool IsMapAvailable()
        {
            if (String.IsNullOrEmpty(mLatitude) == false && String.IsNullOrEmpty(mLongitude) == false)
            {
                //We can get a map location
                //http://maps.google.com.au/maps?f=q&source=s_q&hl=en&geocode=&q=-37.80269+145.00018&sll=-38.079987,144.438629&sspn=0.42645,0.891953&ie=UTF8&z=17
                return true;
            }
            else
            {
                //We can't get a map location.
                return false;
            }
        }

        public override string GetMapURL()
        {
            if (String.IsNullOrEmpty(mLongitude) == false && String.IsNullOrEmpty(mLatitude) == false)
            {
                return "http://maps.google.com.au/maps?hl=en&tab=wl&q=" + mLatitude + " " + mLongitude;
            }
            return null;
        }

        public override bool IsStreamAvailable()
        {
            if (String.IsNullOrEmpty(mParentSource.GetOptions().StreamURL) == false)
            {
                //We have a stream URL
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string GetStreamURL()
        {
            if (String.IsNullOrEmpty(mParentSource.GetOptions().StreamURL) == false)
            {
                //We have a stream URL
                return mParentSource.GetOptions().StreamURL;
            }
            else
            {
                return null;
            }
        }

        public override IIncidentSource GetSource()
        {
            return mParentSource;
        }

        public static string IncidentTypeToString(MFBTypes Type)
        {
            string returnString = "";

            switch (Type)
            {
                case MFBTypes.Fire:
                    returnString = "Fire";
                    break;
                case MFBTypes.FullCall:
                    returnString = "Alarm";
                    break;
                case MFBTypes.HazardousIncident:
                    returnString = "Hazmat";
                    break;
                case MFBTypes.Incident:
                    returnString = "Incident";
                    break;
                case MFBTypes.MedicalEmergency:
                    returnString = "EMR";
                    break;
                case MFBTypes.NonStructureFire:
                    returnString = "Non Structure Fire";
                    break;
                case MFBTypes.StructureFire:
                    returnString = "Structure Fire";
                    break;
                case MFBTypes.FalseAlarm:
                    returnString = "False Alarm";
                    break;
                default:
                    returnString = "Unknown";
                    break;
            }

            return returnString;
        }

        public static MFBTypes StringToIncidentType(string TypeString)
        {
            //This takes a number string, and returns the type
            MFBTypes returnType = MFBTypes.Unknown;

            try{
                switch( int.Parse(TypeString))
                {
                    case 1:
                        returnType = MFBTypes.StructureFire;
                        break;
                    case 2:
                        returnType = MFBTypes.NonStructureFire;
                        break;
                    case 3:
                        returnType = MFBTypes.Fire;
                        break;
                    case 4:                        
                        returnType = MFBTypes.Incident;
                        break;
                    case 5:
                        returnType = MFBTypes.HazardousIncident;
                        break;
                    case 6:
                        returnType = MFBTypes.FullCall;
                        break;
                    case 10:
                        returnType = MFBTypes.FalseAlarm;
                        break;
                    case 17:
                        returnType = MFBTypes.MedicalEmergency;
                        break;
                }
            }
            catch{
                //Try the values output from the above function
                if (TypeString == IncidentTypeToString(MFBTypes.FalseAlarm))
                {
                    returnType = MFBTypes.FalseAlarm;
                }
                else if (TypeString == IncidentTypeToString(MFBTypes.Fire))
                {
                    returnType = MFBTypes.Fire;
                }
                else if (TypeString == IncidentTypeToString(MFBTypes.FullCall))
                {
                    returnType = MFBTypes.FullCall;
                }
                else if (TypeString == IncidentTypeToString(MFBTypes.HazardousIncident))
                {
                    returnType = MFBTypes.HazardousIncident;
                }
                else if (TypeString == IncidentTypeToString(MFBTypes.Incident))
                {
                    returnType = MFBTypes.Incident;
                }
                else if (TypeString == IncidentTypeToString(MFBTypes.MedicalEmergency))
                {
                    returnType = MFBTypes.MedicalEmergency;
                }
                else if (TypeString == IncidentTypeToString(MFBTypes.NonStructureFire))
                {
                    returnType = MFBTypes.NonStructureFire;
                }
                else if (TypeString == IncidentTypeToString(MFBTypes.StructureFire))
                {
                    returnType = MFBTypes.StructureFire;
                }
            }

            return returnType;
        }

        public static string IncidentStatusToString(MFBStatus Status)
        {
            string returnString = "";

            switch (Status)
            {
                case MFBStatus.Initiated:
                    returnString = "Initiated";
                    break;
                case MFBStatus.Investigating:
                    returnString = "Investigating";
                    break;
                case MFBStatus.NotYetUnderControl:
                    returnString = "Not Yet Under Control";
                    break;
                case MFBStatus.UnderControl:
                    returnString = "Under Control";
                    break;
                case MFBStatus.AlarmEscalated:
                    returnString = "Alarm Escalated";
                    break;
                case MFBStatus.Stop:
                    returnString = "Stop";
                    break;
                default:
                    returnString = "Unknown";
                    break;

            }

            return returnString;
        }

        public static MFBStatus StringToIncidentStatus(string StatusString)
        {
            //This takes a number string, and returns the type
            MFBStatus returnType = MFBStatus.Unknown;

            try
            {
                switch (int.Parse(StatusString))
                {
                    case 1:
                        returnType = MFBStatus.Initiated;
                        break;
                    case 2:
                        returnType = MFBStatus.Investigating;
                        break;
                    case 3:
                        returnType = MFBStatus.NotYetUnderControl;
                        break;
                    case 5:
                        returnType = MFBStatus.UnderControl;
                        break;
                    case 6:
                        returnType = MFBStatus.Stop;
                        break;
                    case 7:
                        returnType = MFBStatus.AlarmEscalated;
                        break;
                }
            }
            catch
            {
                //Try the values output from the above function
                    if(StatusString == IncidentStatusToString(MFBStatus.AlarmEscalated))
                    {
                        returnType = MFBStatus.AlarmEscalated;
                    }
                    else if (StatusString == IncidentStatusToString(MFBStatus.Initiated))
                    {
                        returnType = MFBStatus.Initiated;
                    }
                    else if (StatusString == IncidentStatusToString(MFBStatus.Investigating))
                    {
                        returnType = MFBStatus.Investigating;
                    }
                    else if (StatusString == IncidentStatusToString(MFBStatus.NotYetUnderControl))
                    {
                        returnType = MFBStatus.NotYetUnderControl;
                    }
                    else if (StatusString == IncidentStatusToString(MFBStatus.Stop))
                    {
                        returnType = MFBStatus.Stop;
                    }
                    else if (StatusString == IncidentStatusToString(MFBStatus.UnderControl))
                    {
                        returnType = MFBStatus.UnderControl;
                    }
            }

            return returnType;
        }

        #endregion

        #region Class Properties
        public string ID
        {
            get { return mID; }
            set 
            { 
                mID = value;
                ID_GENERIC = SourceConstants.ID_PREFIX + mID;
            }
        }

        public string Suburb
        {
            get { return mSuburb; }
            set
            {
                mSuburb = FirstCaps(value);
                Suburb_GENERIC = mSuburb;
            }
        }

        public string Location
        {
            get { return mLocation; }
            set 
            { 
                mLocation = FirstCaps(value);
                Location_GENERIC = mLocation;
            }
        }

        internal MFBTypes Type
        {
            get { return mType; }
            set 
            { 
                mType = value;
                Type_GENERIC = MFBIncidentItem.IncidentTypeToString(mType);
            }
        }

        internal MFBStatus Status
        {
            get { return mStatus; }
            set 
            {
                if (value != mStatus)
                {
                    //Are we escalating the alarm/making the incident bigger
                    if( value == MFBStatus.AlarmEscalated)
                        Size_GENERIC = "Medium";

                    //Value is actually going to change
                    LastUpdate = DateTime.Now;
                }
                mStatus = value;
                Status_GENERIC = MFBIncidentItem.IncidentStatusToString(mStatus);
            }
        }

        public string Latitude
        {
            get { return mLatitude; }
            set { mLatitude = value; }
        }

        public string Longitude
        {
            get { return mLongitude; }
            set { mLongitude = value; }
        }

        public DateTime LastUpdate
        {
            get { return mLastUpdate; }
            set
            {
                mLastUpdate = value;
                LastUpdate_GENERIC = mLastUpdate;
            }
        }

        public string ApplicanceString
        {
            get
            {
                //The return value
                string returnString = "[";

                for (int i = 0; i<mAppliances.Count;i++)
                {
                    returnString += mAppliances[i];
                    if( (i+1) < mAppliances.Count) //Add a comma if it isnt the last entry.
                        returnString += ",";
                }

                returnString += "]";
                return returnString;
            }
            set
            {
                int fireGroundChannels = 0;
                //Process the appliance string
                if (value.StartsWith("[") == true && value.EndsWith("]") == true)
                {
                    //Clear the appliance list
                    mAppliances.Clear();

                    //Get the new Values
                    string processString = value.TrimStart('[').TrimEnd(']');

                    string[] appliances = processString.Split(',');
                    foreach (string appliance in appliances)
                    {
                        if (String.IsNullOrEmpty(appliance) == false)
                        {
                            if (appliance.Trim().StartsWith("FGD") == true)
                            {
                                fireGroundChannels++;
                            }
                            mAppliances.Add(appliance.Trim());
                        }
                    }

                    //Update the Appliance count Generic
                    ApplianceCount_GENERIC = mAppliances.Count - fireGroundChannels;

                }
            }
        }

        public string[] Appliances
        {
            get
            {
                return mAppliances.ToArray();
            }
        }
        #endregion


        private static string FirstCaps(string inString)
        {
            string workString;
            int spaceIndex = 0;

            workString = inString.ToLower();
            //adjust first value
            workString = workString.Insert(0, Char.ToUpper(workString[0]).ToString());
            workString = workString.Remove(1, 1);
            spaceIndex = workString.IndexOf(" ");
            while (spaceIndex != -1)
            {
                if (spaceIndex == workString.Length - 1)
                {
                    break;
                }
                workString = workString.Insert(spaceIndex + 1, Char.ToUpper(workString[spaceIndex + 1]).ToString());
                workString = workString.Remove(spaceIndex + 2, 1);
                spaceIndex = workString.IndexOf(" ", spaceIndex + 1);
            }

            //adjust value after - value
            spaceIndex = workString.IndexOf("-");
            while (spaceIndex != -1)
            {
                if (spaceIndex == workString.Length - 1)
                {
                    break;
                }
                workString = workString.Insert(spaceIndex + 1, Char.ToUpper(workString[spaceIndex + 1]).ToString());
                workString = workString.Remove(spaceIndex + 2, 1);
                spaceIndex = workString.IndexOf("-", spaceIndex + 1);
            }

            //adjust value after / value
            spaceIndex = workString.IndexOf("/");
            while (spaceIndex != -1)
            {
                if (spaceIndex == workString.Length - 1)
                {
                    break;
                }
                workString = workString.Insert(spaceIndex + 1, Char.ToUpper(workString[spaceIndex + 1]).ToString());
                workString = workString.Remove(spaceIndex + 2, 1);
                spaceIndex = workString.IndexOf("/", spaceIndex + 1);
            }

            //adjust value after . value
            spaceIndex = workString.IndexOf(".");
            while (spaceIndex != -1)
            {
                if (spaceIndex == workString.Length - 1)
                {
                    break;
                }
                workString = workString.Insert(spaceIndex + 1, Char.ToUpper(workString[spaceIndex + 1]).ToString());
                workString = workString.Remove(spaceIndex + 2, 1);
                spaceIndex = workString.IndexOf(".", spaceIndex + 1);
            }

            return workString;
        }

    }
}

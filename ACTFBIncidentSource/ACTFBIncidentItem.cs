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
using System.Text;
using InciWatch;
using System.Xml;
using System.IO;
using System.Globalization;

namespace ACTFBIncidentSource
{
    class ACTFBIncidentItem : GenericIncidentItem
    {
        #region Class Enums

        public enum ACTFBTypes
        {
            Unknown=-1,
            CarFire,
            RubbishFire,
            MVA,
            StructureFire13,
            StructureFire47,
            StructureFire8plus,
            GasPiplineNoInj,
            PowerlinesDown,
            GrassAndBush,
            HouseFireInj,
            HouseFireNoInj,
            HazmatNoCBR,
            StructureBelowGround,
            TransportFireBusTruck,
            StructuralCollapseMinor,
            StructuralCollapseMajor,
            HospitalsAndInstitutionsFire,
            LPGCylinderNoInj,
            LPGCylinderInj
        }

        public enum ACTFBStatus
        {
            Unknown = -1,
            Stop,
            OnScene,
            ResourcesPending,
            OnRoute,
            Finished,
            UnderControl
        }

        #endregion

        #region Class Variables

        //Other Values
        ACTFBIncidentSource mParentSource;

        //Incident Information
        private string mID;      
        private string mSuburb;
        private string mLocation;        
        private ACTFBTypes mType;        
        private ACTFBStatus mStatus;        
        private string mLatitude;        
        private string mLongitude;        
        private DateTime mLastUpdate;
        private string mAgency;

        #endregion

        #region Class Functions
        public ACTFBIncidentItem(ACTFBIncidentSource ParentSource, XmlNode xmlNode)
        {
            mParentSource = ParentSource;

            Region_GENERIC = "ACTFB";
            Size_GENERIC = "Small";
            //We dont have appliance count unfortunately
            this.ApplianceCount_GENERIC = 0;

            ProcessXmlNode(xmlNode);

        }

        private void ProcessXmlNode(XmlNode xmlNode)
        {
            //Get the values from the xmlNode

            //Get the Id
            ID = xmlNode.SelectSingleNode("guid").InnerText;

            //Process description field
            string descString = xmlNode.SelectSingleNode("description").InnerText;

            //Add < and >'s
            descString = descString.Replace("&lt;", "<").Replace("&gt;", ">").Replace("<br />", "!");
            string[] detailFields = descString.Split('!');

            //Get the Status
            string statusString = detailFields[2].Substring(detailFields[2].IndexOf(':') + 2);
            Status = ACTFBIncidentItem.StringToIncidentStatus(statusString);
            //TODO: REMOVE
            if (Status == ACTFBStatus.Unknown)
                PrintString(statusString,"unkstatuslog.txt");

            //Get the type
            string typeString = detailFields[4].Substring(detailFields[4].IndexOf(':') + 2);
            Type = ACTFBIncidentItem.StringToIncidentType(typeString);
            //TODO: REMOVE
            if( Type == ACTFBTypes.Unknown )
                PrintString(typeString, "unktypelog.txt");

            //Get the suburb
            string suburbString = detailFields[3].Substring(detailFields[3].IndexOf(':') + 2);
            if (String.IsNullOrEmpty(suburbString))
            {
                Suburb = "<Unlocated>";
            }
            else
            {
                Suburb = suburbString.Trim();
            }

            //Get the location
            string locationString = detailFields[1].Substring(detailFields[1].IndexOf(':') + 2);
            if (String.IsNullOrEmpty(locationString))
            {
                Location = "<Unlocated>";
            }
            else
            {
                //Strip suburb
                Location = locationString.Substring(0, locationString.LastIndexOf(',')).Trim();
            }

            //Get the agency
            string agencyString = detailFields[5].Substring(detailFields[5].IndexOf(':') + 2);
            Agency = agencyString.Trim();

            //Get the Last update
            string lastUpdate = detailFields[7].Substring(detailFields[7].IndexOf(':') + 2);
            //Try DateTime.ParseExact, if it fails try parse
            try
            {
                LastUpdate = DateTime.ParseExact(lastUpdate, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                    LastUpdate = DateTime.Parse(lastUpdate);
            }
            //Get the location ( if we can )
            string[] latlong = xmlNode.LastChild.InnerText.Split(' ');
            float lat, lon;

            Latitude = "";
            Longitude = "";

            if (float.TryParse(latlong[0], out lat) && float.TryParse(latlong[1], out lon))
            {
                //Valid float values, check they are in the australia box
                if ((lat <= -10.68f && lat >= -43.64) && (lon >= 113.15 && lon <= 153.63))
                {
                    Latitude = latlong[0];
                    Longitude = latlong[1];
                }
            }
            

        }

        private void PrintString(string logString, string p)
        {
            
            //Open file to read all lines (prevent dupes)
            bool Unique = true;
            try
            {
                string[] currentEntries = File.ReadAllLines(p);

                foreach (string s in currentEntries)
                {
                    if (s == logString)
                    {
                        Unique = false;
                        break;
                    }
                }
            }
            catch
            {

            }

            //Only write unique entries
            if (Unique)
            {
                StreamWriter outfile = File.AppendText(p);

                outfile.WriteLine(logString);

                outfile.Flush();
                outfile.Close();
            }
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

        public static string IncidentTypeToString(ACTFBTypes Type)
        {
            string returnString = "";

            switch (Type)
            {
                case ACTFBTypes.CarFire:
                    returnString = "Car Fire";
                    break;
                case ACTFBTypes.MVA:
                    returnString = "MVA";
                    break;
                case ACTFBTypes.RubbishFire:
                    returnString = "Rubbish Fire";
                    break;
                case ACTFBTypes.StructureFire13:
                    returnString = "Structure Fire (1 to 3 Floors)";
                    break;
                case ACTFBTypes.StructureFire47:
                    returnString = "Structure Fire (4 to 7 Floors)";
                    break;
                case ACTFBTypes.StructureFire8plus:
                    returnString = "Structure Fire (8+ Floors)";
                    break;
                case ACTFBTypes.HospitalsAndInstitutionsFire:
                    returnString = "Hospital/Institutional Fire";
                    break;
                case ACTFBTypes.GasPiplineNoInj:
                    returnString = "Gas Leak (No Reported Injuries)";
                    break;
                case ACTFBTypes.GrassAndBush:
                    returnString = "Grass and Bush Fire";
                    break;
                case ACTFBTypes.HouseFireInj:
                    returnString = "House Fire (Reported Injuries)";
                    break;
                case ACTFBTypes.PowerlinesDown:
                    returnString = "Powerlines Down/Hazard";
                    break;
                case ACTFBTypes.HouseFireNoInj:
                    returnString = "House Fire (No Reported Injuries)";
                    break;
                case ACTFBTypes.HazmatNoCBR:
                    returnString = "Hazmat (Non CBR)";
                    break;
                case ACTFBTypes.StructureBelowGround:
                    returnString = "Structure Fire (Below Ground)";
                    break;
                case ACTFBTypes.TransportFireBusTruck:
                    returnString = "Bus or Truck Fire";
                    break;
                case ACTFBTypes.StructuralCollapseMinor:
                    returnString = "Structural Collapse (Minor)";
                    break;
                case ACTFBTypes.StructuralCollapseMajor:
                    returnString = "Structural Collapse (Major)";
                    break;
                case ACTFBTypes.LPGCylinderNoInj:
                    returnString = "LPG Cylinder Fire (No Injuries)";
                    break;
                case  ACTFBTypes.LPGCylinderInj:
                    returnString = "LPG Cylinder Fire (Reported Injuries)";
                    break;
                default:
                    returnString = "Unknown";
                    break;
            }

            return returnString;
        }

        public static ACTFBTypes StringToIncidentType(string TypeString)
        {
            //This takes a number string, and returns the type
            ACTFBTypes returnType = ACTFBTypes.Unknown;

            switch(TypeString.ToUpper())
            {
                case "CAR FIRE":
                    returnType = ACTFBTypes.CarFire;
                    break;
                case "RUBBISH FIRE":
                    returnType = ACTFBTypes.RubbishFire;
                    break;
                case "MVA":
                case "MOTOR VEHICLE ACCIDENT":
                    returnType = ACTFBTypes.MVA;
                    break;
                case "STRUCTURE FIRE (1 TO 3 FLOORS)":
                case "STRUCTURE FIRE 1 TO 3 FLOORS":
                    returnType = ACTFBTypes.StructureFire13;
                    break;
                case "STRUCTURE FIRE (4 TO 7 FLOORS)":
                case "STRUCTURE FIRE 4 TO 7 FLOORS":
                    returnType = ACTFBTypes.StructureFire47;
                    break;
                case "STRUCTURE FIRE (8+ FLOORS)":
                case "STRUCTURE FIRE 8 OR MORE FLOORS":
                    returnType = ACTFBTypes.StructureFire8plus;
                    break;
                case "GAS LEAK (NO REPORTED INJURIES)":
                case "GAS PIPELINE (NO INJURIES)":
                    returnType = ACTFBTypes.GasPiplineNoInj;
                    break;
                case "POWERLINES DOWN/HAZARD":
                case "ELECTRICAL THREAT OR POWER LINES DOWN":
                    returnType = ACTFBTypes.PowerlinesDown;
                    break;
                case "GRASS AND BUSH FIRE":
                    returnType = ACTFBTypes.GrassAndBush;
                    break;
                case "HOUSE FIRE (REPORTED INJURIES)":
                case "HOUSE FIRE (INJURIES)":
                    returnType = ACTFBTypes.HouseFireInj;
                    break;
                case "HOUSE FIRE (NO REPORTED INJURIES)":
                case "HOUSE FIRE (NO INJURIES)":
                    returnType = ACTFBTypes.HouseFireNoInj;
                    break;
                case "HAZMAT (NON CBR)":
                case "HAZMAT INCIDENT (EXCLUDING CBR)":
                    returnType = ACTFBTypes.HazmatNoCBR;
                    break;
                case "STRUCTURE FIRE (BELOW GROUND)":
                    returnType = ACTFBTypes.StructureBelowGround;
                    break;
                case "BUS OR TRUCK FIRE":
                case "TRANSPORT FIRE (BUS / HEAVY TRUCK)":
                    returnType = ACTFBTypes.TransportFireBusTruck;
                    break;
                case "STRUCTURAL COLLAPSE (MINOR)":
                case "STRUCTURAL COLLAPSE - MINOR":
                    returnType = ACTFBTypes.StructuralCollapseMinor;
                    break;
                case "STRUCTURAL COLLAPSE (MAJOR)":
                case "STRUCTURAL COLLAPSE - MAJOR":
                    returnType = ACTFBTypes.StructuralCollapseMajor;
                    break;
                case "LPG CYLINDER FIRE (NO INJURIES)":
                case "LPG CYLINDER (NO INJURIES)":
                    returnType = ACTFBTypes.LPGCylinderNoInj;
                    break;
                case "LPG CYLINDER FIRE (REPORTED INJURIES)":
                case "LPG CYLINDER (REPORTED INJURIES)":
                    returnType = ACTFBTypes.LPGCylinderInj;
                    break;
                case "HOSPITAL/INSTITUTIONAL FIRE":
                case "HOSPITALS AND INSTITUTIONS FIRE":
                    returnType = ACTFBTypes.HospitalsAndInstitutionsFire;
                    break;
                default:
                    returnType = ACTFBTypes.Unknown;
                    break;
            }

            return returnType;
        }

        public static string IncidentStatusToString(ACTFBStatus Status)
        {
            string returnString = "";

            switch (Status)
            {
                case ACTFBStatus.Stop:
                    returnString = "Safe";
                    break;
                case ACTFBStatus.OnRoute:
                    returnString = "On Route";
                    break;
                case ACTFBStatus.OnScene:
                    returnString = "On Scene";
                    break;
                case ACTFBStatus.ResourcesPending:
                    returnString = "Assigning Resources";
                    break;
                case ACTFBStatus.UnderControl:
                    returnString = "Under Control";
                    break;
                case ACTFBStatus.Finished:
                    returnString = "Finished";
                    break;
                default:
                    returnString = "Unknown";
                    break;

            }

            return returnString;
        }

        public static ACTFBStatus StringToIncidentStatus(string StatusString)
        {
            //This takes a number string, and returns the type
            ACTFBStatus returnType = ACTFBStatus.Unknown;

            try
            {
                switch (StatusString.ToUpper())
                {
                    case "SAFE":
                    case "OUT / COMPLETED":
                        returnType = ACTFBStatus.Stop;
                        break;
                    case "ON SCENE":
                        returnType = ACTFBStatus.OnScene;
                        break;
                    case "ASSIGNING RESOURCES":
                    case "RESOURCE ALLOCATION PENDING":
                        returnType = ACTFBStatus.ResourcesPending;
                        break;
                    case "ON ROUTE":
                    case "UNITS ON ROUTE":
                        returnType = ACTFBStatus.OnRoute;
                        break;
                    case "FINISHED":
                        returnType = ACTFBStatus.Finished;
                        break;
                    case "UNDER CONTROL":
                        returnType = ACTFBStatus.UnderControl;
                        break;
                    default:
                        returnType = ACTFBStatus.Unknown;
                        break;
                }
            }
            catch
            {
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

        internal ACTFBTypes Type
        {
            get { return mType; }
            set 
            { 
                mType = value;
                Type_GENERIC = ACTFBIncidentItem.IncidentTypeToString(mType);
            }
        }

        internal ACTFBStatus Status
        {
            get { return mStatus; }
            set 
            {
                mStatus = value;
                Status_GENERIC = ACTFBIncidentItem.IncidentStatusToString(mStatus);
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

        public string Agency
        {
            get { return mAgency; }
            set { mAgency = value; }
        }

        #endregion


        private static string FirstCaps(string inString)
        {
            string workString;
            int spaceIndex = 0;

            //Check for null input
            if (String.IsNullOrEmpty(inString))
            {
                return "";
            }

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

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
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace MFBIncidentSource
{
    class MFBIncidentSourceOptions
    {
        private global::MFBIncidentSource.Properties.Settings mSourceSettings = new global::MFBIncidentSource.Properties.Settings();

        public string IncidentSourceURL
        {
            get { return mSourceSettings.IncidentSourceURL; }
            set { mSourceSettings.IncidentSourceURL = value; }
        }

        public string StreamURL
        {
            get { return mSourceSettings.StreamURL; }
            set { mSourceSettings.StreamURL = value; }
        }

        public bool CrossStreets
        {
            get { return mSourceSettings.ShowCrossStreets; }
            set { mSourceSettings.ShowCrossStreets = value; }
        }

        public string ActionDiamond
        {
            get { return mSourceSettings.ActionDiamond; }
            set { mSourceSettings.ActionDiamond = value; }
        }

        public string ActionDiamondArgs
        {
            get { return mSourceSettings.ActionDiamondArgs; }
            set { mSourceSettings.ActionDiamondArgs = value; }
        }

        public string ActionCircle
        {
            get { return mSourceSettings.ActionCircle; }
            set { mSourceSettings.ActionCircle = value; }
        }

        public string ActionCircleArgs
        {
            get { return mSourceSettings.ActionCircleArgs; }
            set { mSourceSettings.ActionCircleArgs = value; }
        }

        public string ActionSquare
        {
            get { return mSourceSettings.ActionSquare; }
            set { mSourceSettings.ActionSquare = value; }
        }

        public string ActionSquareArgs
        {
            get { return mSourceSettings.ActionSquareArgs; }
            set { mSourceSettings.ActionSquareArgs = value; }
        }


        #region Auto Watch Options
        public List<string> AutoWatchSuburbs
        {
            get { 
                  string[] returnStrings = new string[0];
                  if (mSourceSettings.AutoWatchSuburbs != null)
                  {
                      if (mSourceSettings.AutoWatchSuburbs.Count > 0)
                      {
                          returnStrings = new string[mSourceSettings.AutoWatchSuburbs.Count];
                          mSourceSettings.AutoWatchSuburbs.CopyTo(returnStrings, 0);
                      }
                  }
                  return new List<string>(returnStrings);
            }
            set { mSourceSettings.AutoWatchSuburbs = new StringCollection();
            mSourceSettings.AutoWatchSuburbs.AddRange(value.ToArray());
            }
        }

        public List<string> AutoWatchLocations
        {
            get
            {
                string[] returnStrings = new string[0];
                if (mSourceSettings.AutoWatchLocations != null)
                {
                    if (mSourceSettings.AutoWatchLocations.Count > 0)
                    {
                        returnStrings = new string[mSourceSettings.AutoWatchLocations.Count];
                        mSourceSettings.AutoWatchLocations.CopyTo(returnStrings, 0);
                    }
                }
                return new List<string>(returnStrings);
            }
            set
            {
                mSourceSettings.AutoWatchLocations = new StringCollection();
                mSourceSettings.AutoWatchLocations.AddRange(value.ToArray());
            }
        }

        public List<string> AutoWatchStatuses
        {
            get
            {
                string[] returnStrings = new string[0];
                if (mSourceSettings.AutoWatchStatuses != null)
                {
                    if (mSourceSettings.AutoWatchStatuses.Count > 0)
                    {
                        returnStrings = new string[mSourceSettings.AutoWatchStatuses.Count];
                        mSourceSettings.AutoWatchStatuses.CopyTo(returnStrings, 0);
                    }
                }
                return new List<string>(returnStrings);
            }
            set
            {
                mSourceSettings.AutoWatchStatuses = new StringCollection();
                mSourceSettings.AutoWatchStatuses.AddRange(value.ToArray());
            }
        }

        public List<string> AutoWatchTypes
        {
            get
            {
                string[] returnStrings = new string[0];
                if (mSourceSettings.AutoWatchTypes != null)
                {
                    if (mSourceSettings.AutoWatchTypes.Count > 0)
                    {
                        returnStrings = new string[mSourceSettings.AutoWatchTypes.Count];
                        mSourceSettings.AutoWatchTypes.CopyTo(returnStrings, 0);
                    }
                }
                return new List<string>(returnStrings);
            }
            set
            {
                mSourceSettings.AutoWatchTypes = new StringCollection();
                mSourceSettings.AutoWatchTypes.AddRange(value.ToArray());
            }
        }

        public List<string> AutoWatchAppliances
        {
            get
            {
                string[] returnStrings = new string[0];
                if (mSourceSettings.AutoWatchAppliances != null)
                {
                    if (mSourceSettings.AutoWatchAppliances.Count > 0)
                    {
                        returnStrings = new string[mSourceSettings.AutoWatchAppliances.Count];
                        mSourceSettings.AutoWatchAppliances.CopyTo(returnStrings, 0);
                    }
                }
                return new List<string>(returnStrings);
            }
            set
            {
                mSourceSettings.AutoWatchAppliances = new StringCollection();
                mSourceSettings.AutoWatchAppliances.AddRange(value.ToArray());
            }
        }

        public uint AutoWatchApplianceCount
        {
            get { return mSourceSettings.AutoWatchApplianceCount; }
            set { mSourceSettings.AutoWatchApplianceCount = value; }
        }

        public bool ShouldWeAutowatch(bool NewIncident, MFBIncidentItem Incident)
        {
            //Check if autowatch is enabled?
            if (mSourceSettings.AutoWatchEnabled == false)
                return false;

            //Suburb
            if (CheckSuburb(Incident) == true)
                return true;
            //Location
            if (CheckLocation(Incident) == true)
                return true;
            //Status
            if (CheckStatus(Incident) == true)
                return true;
            //Incident
            if (CheckType(Incident) == true)
                return true;
            //Appliance Stuff
            if (CheckApplianceAndCount(Incident) == true)
                return true;

            return false;
        }

        public bool ShouldWeAutowatch(bool NewIncident, MFBIncidentItem OldIncident,MFBIncidentItem NewUpdate)
        {
            //Check if autowatch is enabled?
            if (mSourceSettings.AutoWatchEnabled == false)
                return false;

            //Suburb
            //Was there a change?
            if (OldIncident.Suburb != NewUpdate.Suburb)
            {
                if (CheckSuburb(NewUpdate) == true)
                    return true;
            }
            //Location
            if (OldIncident.Location != NewUpdate.Location)
            {
                if (CheckLocation(NewUpdate) == true)
                    return true;
            }
            //Status
            if (OldIncident.Status != NewUpdate.Status)
            {
                if (CheckStatus(NewUpdate) == true)
                    return true;
            }
            //Incident
            if (OldIncident.Type != NewUpdate.Type)
            {
                if (CheckType(NewUpdate) == true)
                    return true;
            }
            //Appliance Stuff
            if (OldIncident.ApplicanceString != NewUpdate.ApplicanceString)
            {
                if (CheckApplianceAndCount(NewUpdate) == true)
                    return true;
            }

            return false;
        }

        private bool CheckApplianceAndCount(MFBIncidentItem Incident)
        {
            //Check the count first
            if (Incident.ApplianceCount_GENERIC >= mSourceSettings.AutoWatchApplianceCount)
                return true;

            //Check all the appliance names
            //Get Values from the list
            foreach (string s in mSourceSettings.AutoWatchAppliances)
            {
                foreach (string app in Incident.Appliances)
                {
                    //Does it match
                    if (s == "*")//Match all
                        return true;
                    if (Regex.IsMatch(app, s, RegexOptions.IgnoreCase))
                        return true;
                }
            }

            //No matches
            return false;
        }

        private bool CheckSuburb(MFBIncidentItem Incident)
        {
            //Get Values from the list
            foreach (string s in mSourceSettings.AutoWatchSuburbs)
            {
                //Does it match
                if (s == "*")//Match all
                    return true;
                if (Regex.IsMatch(Incident.Suburb, s, RegexOptions.IgnoreCase))
                    return true;
            }

            //No matches
            return false;
        }

        private bool CheckLocation(MFBIncidentItem Incident)
        {
            //Get Values from the list
            foreach (string s in mSourceSettings.AutoWatchLocations)
            {
                //Does it match
                if (s == "*")//Match all
                    return true;
                if (Regex.IsMatch(Incident.Location, s, RegexOptions.IgnoreCase))
                    return true;
            }

            //No matches
            return false;
        }

        private bool CheckStatus(MFBIncidentItem Incident)
        {
            //Get Values from the list
            foreach (string s in mSourceSettings.AutoWatchStatuses)
            {
                //Get the type
                MFBIncidentItem.MFBStatus watchStatus = (MFBIncidentItem.MFBStatus)Enum.Parse(typeof(MFBIncidentItem.MFBStatus), s);

                //Does it match
                if (Incident.Status == watchStatus)
                    return true;
            }

            //No matches
            return false;
        }

        private bool CheckType(MFBIncidentItem Incident)
        {
            //Get Values from the list
            foreach (string s in mSourceSettings.AutoWatchTypes)
            {
                //Get the type
                MFBIncidentItem.MFBTypes watchType = (MFBIncidentItem.MFBTypes)Enum.Parse(typeof(MFBIncidentItem.MFBTypes), s);

                //Does it match
                if (Incident.Type == watchType)
                    return true;
            }
            //No Matches
            return false;
        }

        public bool AutoWatchEnabled
        {
            get { return mSourceSettings.AutoWatchEnabled; }
            set { mSourceSettings.AutoWatchEnabled = value; }
        }
        #endregion

        public void Save()
        {
            mSourceSettings.Save();
        }

        public void Reset()
        {
            mSourceSettings.Reset();
        }


        internal string ReplaceInciWatchVarsInString(string oldString, MFBIncidentItem IncidentItem)
        {
            String returnString;

            returnString = oldString;

            //Do Replaces

            //ID
            returnString = returnString.Replace("%ID%", IncidentItem.ID);

            //SUBURB
            returnString = returnString.Replace("%SUBURB%", IncidentItem.Suburb);

            //REGION
            returnString = returnString.Replace("%REGION%", IncidentItem.Region_GENERIC);

            //ADDR
            returnString = returnString.Replace("%ADDR%", IncidentItem.Location);

            //TYPE
            returnString = returnString.Replace("%TYPE%", IncidentItem.Type.ToString());

            //STREAM
            returnString = returnString.Replace("%STREAM%", this.StreamURL);

            //STATUS
            returnString = returnString.Replace("%STATUS%", IncidentItem.Status.ToString());

            //SIZE
            returnString = returnString.Replace("%SIZE%", IncidentItem.Size_GENERIC);

            //LAST Updated
            returnString = returnString.Replace("%LASTUP%", IncidentItem.LastUpdate.ToString("yyyy-MM-dd_HH-mm-ss"));

            //APPLIANCE
            returnString = returnString.Replace("%APPLIANCES%", IncidentItem.ApplianceCount_GENERIC.ToString());

            //CURTIME
            returnString = returnString.Replace("%CURTIME%", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));


            //Return adjusted string
            return returnString;
        } 
    }
}

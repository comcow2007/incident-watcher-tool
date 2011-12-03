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
using System.IO;
using System.Net;
using System.ComponentModel;
using InciWatch;

namespace CFAIncidentSource
{
    class IncidentItemList
    {
        private Dictionary<string, IncidentItem> mIncidentDictionary;
        private Gatherer mInfoGatherer;

        public delegate void NewIncident(IncidentItem newIncident);
        public event NewIncident OnNewIncident;

        public delegate void RemovedIncident(IncidentItem removedIncident);
        public event RemovedIncident OnRemovedIncident;

        public string mToolTipString;

        public CFAIncidentSource mParentSource;

        public CFAIncidentSourceOptions mProgramOptions;

        public bool mFirstUpdate = true;

        public IncidentItemList(Gatherer infoGatherer, CFAIncidentSource ParentSource, CFAIncidentSourceOptions ProgOptions)
        {
            mToolTipString = "";
            mInfoGatherer = infoGatherer;

            mParentSource = ParentSource;

            mProgramOptions = ProgOptions;
            
        }

        public Dictionary<string, IncidentItem> GetIncidentDictionary()
        {
            return mIncidentDictionary;
        }

        public bool UpdateDictionary()
        {
            Dictionary<string, IncidentItem> newDictionary;

            bool mPlayNoise = false;

            try
            {
                //Get the updated dictionary
                newDictionary = mInfoGatherer.GatherIncidents();

                if (newDictionary == null)
                    return false; //An error occurred getting the new dictionary, so return false
            }
            catch (WarningException ex)
            {
                //There was an error loading the Incident RSS File
                return false;
            }

            if (mIncidentDictionary == null)
            {
                mIncidentDictionary = new Dictionary<string, IncidentItem>();
            }
            

            //Check for removed incidents
            List<string> removeKeys = new List<string>();
            foreach (KeyValuePair<String, IncidentItem> existingInci in mIncidentDictionary)
            {
                if (newDictionary.ContainsKey(existingInci.Key) == false)
                {
                    
                    //Remove from existing incident list
                    removeKeys.Add(existingInci.Key);

                    //an incident has been removed from source
                    if (OnRemovedIncident != null)
                        OnRemovedIncident(existingInci.Value);
                }
            }

            //Remove all the marked ids.
            foreach (String removeID in removeKeys)
            {
                if (mIncidentDictionary.ContainsKey(removeID) == true)
                    mIncidentDictionary.Remove(removeID);
            }

            removeKeys = null;


            //Sync Dictionaries
            foreach (KeyValuePair<string, IncidentItem> inci in newDictionary)
            {
                //Are we already in the dictionary
                if (mIncidentDictionary.ContainsKey(inci.Key) == true)
                {
                    //Get current list incident
                    IncidentItem existingIncident = mIncidentDictionary[inci.Key];

                    //Region
                    if (inci.Value.Region != existingIncident.Region)
                        existingIncident.Region = inci.Value.Region; //Update Region

                    //Suburb
                    if (inci.Value.Suburb != existingIncident.Suburb)
                        existingIncident.Suburb = inci.Value.Suburb; //update Suburb

                    //Location
                    if (inci.Value.Location != existingIncident.Location)
                        existingIncident.Location = inci.Value.Location; //Update Location

                    //Last Update
                    if (inci.Value.LastUpdate != existingIncident.LastUpdate)
                        existingIncident.LastUpdate = inci.Value.LastUpdate; //Update last wordbackc

                    //Type
                    if (inci.Value.Type != existingIncident.Type)
                        existingIncident.Type = inci.Value.Type; //Update type

                    //Status
                    if (inci.Value.Status != existingIncident.Status)
                        existingIncident.Status = inci.Value.Status; //Update Status

                    //Appliance Count
                    if (inci.Value.ApplianceCount != existingIncident.ApplianceCount)
                        existingIncident.ApplianceCount = inci.Value.ApplianceCount; //Update Status

                    //Size
                    if (inci.Value.Size != existingIncident.Size)
                        existingIncident.Size = inci.Value.Size; //Update Size

                    //On ID Changing (shouldn't happen)
                    if (inci.Value.ID != existingIncident.ID)
                        existingIncident.ID = inci.Value.ID; //Update ID          


                }
                else
                {
                    //This is a new incident so add it to the dictionary
                    mIncidentDictionary.Add(inci.Key, inci.Value);
                    //Add new incident to tooltip
                    if (inci.Value.Responsible.ToLower() == "cfa")
                        mToolTipString += "CFA";
                    else
                        mToolTipString += "DSE";
                    mToolTipString += ": " + IncidentItem.IncidentTypeToString(inci.Value.Type) + "." + inci.Value.Location + " " + inci.Value.Suburb+"\n";

                    //Call the event for a new IncidentItem
                    if( OnNewIncident != null)
                        OnNewIncident(inci.Value);

                    mPlayNoise = true;

                    //Check if we should autowatch
                    if (AutoWatch.ShouldWeAutoWatch(inci.Value, mParentSource, mProgramOptions) == true)
                    {
                        if (mParentSource.GetWatchList().IsKeyBeingWatched(inci.Value.ID_GENERIC) == false)
                        {
                            //Make a noise
                            mParentSource.GetIncidentWatcher().PlayNoise(NoiseType.NewAutowatch);
                            //Create an autowatch
                            mParentSource.GetWatchList().Add(new WatchNotification(inci.Value, mParentSource.GetWatchList(), mProgramOptions, mParentSource), inci.Value);
                        }
                    }
                }

            }    

            if( mPlayNoise == true && mFirstUpdate == false)
            {
                //Play a new incident noise
                mParentSource.GetIncidentWatcher().PlayNoise(InciWatch.NoiseType.NewIncident);                
            }

            mFirstUpdate = false;
            //No errors so return true
            return true;
        }



        internal string GetToolTipText()
        {
            string returnString = mToolTipString;
            mToolTipString = "";
            return returnString;
        }
    }
}

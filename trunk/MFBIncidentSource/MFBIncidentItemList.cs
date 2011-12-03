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
using System.Net;
using System.IO;

namespace MFBIncidentSource
{
    class MFBIncidentItemList
    {
        private Dictionary<string, MFBIncidentItem> mIncidents;
        private string mToolTipText;

        private MFBIncidentSource mParentSource;

        private bool mFirstUpdate = true;

        public MFBIncidentItemList(MFBIncidentSource ParentSource)
        {
            mIncidents = new Dictionary<string, MFBIncidentItem>();
            mParentSource = ParentSource;
            mToolTipText = "";
        }

        public List<GenericIncidentItem> GetIncidents()
        {
            List<GenericIncidentItem> returnList = new List<GenericIncidentItem>();

            //Output the incidents.
            foreach (KeyValuePair<string, MFBIncidentItem> inci in mIncidents)
            {
                returnList.Add(inci.Value);
            }

            return returnList;
        }

        public Dictionary<string, MFBIncidentItem> GetIncidentDictionary()
        {
            return mIncidents;
        }

        public bool UpdateList()
        {
            return UpdateIncidentList();
        }

        private bool UpdateIncidentList()
        {
            bool fNewIncident = false;
            try
            {
            
                //Create a request for the xml file
                HttpWebRequest webRequest = (HttpWebRequest)HttpWebRequest.Create(mParentSource.GetOptions().IncidentSourceURL);

                //Set the proxy if there is one
                if (mParentSource.GetIncidentWatcher().UsesProxy() == true)
                {
                    webRequest.Proxy = mParentSource.GetIncidentWatcher().GetProxy();
                }
                //Get the response as an xml file
                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                //Get the xml document
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(webResponse.GetResponseStream());

                //Get the first node "<markers>"
                XmlNode markerNode = xmlDoc.FirstChild;

                Dictionary<string, MFBIncidentItem> latestIncidentsList = new Dictionary<string,MFBIncidentItem>(); 

                //Loop through the chillen
                foreach (XmlNode incidentEntry in markerNode.ChildNodes)
                {
                    //Process the node into an incident item
                    MFBIncidentItem newIncident = new MFBIncidentItem(mParentSource, incidentEntry);

                    //Add the new incident to the existing incident list for checking
                    latestIncidentsList.Add(newIncident.ID, newIncident);

                    //Add the incident or update it
                    if (mIncidents.ContainsKey(newIncident.ID) == true)
                    {
                        //This incident already exists, update the entry values
                        MFBIncidentItem oldIncident = mIncidents[newIncident.ID];

                        //Is it already being watched?
                        if (mParentSource.GetWatchList().IsKeyBeingWatched(oldIncident.ID_GENERIC) == false)
                        {
                            //Should we auto watch
                            if (mParentSource.GetOptions().ShouldWeAutowatch(false, oldIncident, newIncident) == true)
                            {
                                //Make autowatch noise
                                mParentSource.GetIncidentWatcher().PlayNoise(NoiseType.NewAutowatch);
                                mParentSource.GetWatchList().Add(new MFBWatchNotification(oldIncident, mParentSource.GetWatchList(), mParentSource.GetOptions(), mParentSource), oldIncident);
                            }
                        }

                        oldIncident.ApplicanceString = newIncident.ApplicanceString;
                        oldIncident.Location = newIncident.Location;
                        oldIncident.Latitude = newIncident.Latitude;
                        oldIncident.Longitude = newIncident.Longitude;
                        oldIncident.Status = newIncident.Status;
                        oldIncident.Suburb = newIncident.Suburb;
                        oldIncident.Type = newIncident.Type;

                        //Reseat the old incident
                        mIncidents[newIncident.ID] = oldIncident;
                    }
                    else
                    {
                        //Set flag to Make a noise
                        fNewIncident = true;

                        //Check for autowatch
                        if( mParentSource.GetOptions().ShouldWeAutowatch( true, newIncident) == true)
                        {
                            //Make a noise
                            mParentSource.GetIncidentWatcher().PlayNoise(NoiseType.NewAutowatch);
                            //Add watch
                            mParentSource.GetWatchList().Add(new MFBWatchNotification(newIncident, mParentSource.GetWatchList(), mParentSource.GetOptions(), mParentSource), newIncident);
                        }
                        //Its a new Incident, add it to list and tooltip
                        mIncidents.Add(newIncident.ID, newIncident);

                        mToolTipText += "MFB: "+MFBIncidentItem.IncidentTypeToString(newIncident.Type) +
                            "." + newIncident.Location + "," + newIncident.Suburb + "\n";
                        //Add appliances
                        foreach (string str in newIncident.Appliances)
                        {
                            mToolTipText += "\t" + MFBWatchNotification.DecodeApplianceCode(str).Trim() + "\n";
                        }
                            
                    }  
                }

                //Check for Stops
                foreach (KeyValuePair<string,MFBIncidentItem> existingInci in mIncidents)
                {
                    if (existingInci.Value.Status != MFBIncidentItem.MFBStatus.Stop)
                    {
                        //We arn't stopped so may be set to this
                        if (latestIncidentsList.ContainsKey(existingInci.Key) == false)
                        {
                            //This incident is no longer in the list, so set its status to stop, and set the number of appliances to 0
                            existingInci.Value.Status = MFBIncidentItem.MFBStatus.Stop;
                            existingInci.Value.ApplicanceString = "[]";
                        }
                    }

                }

                //No Problems encountered
                if( fNewIncident == true && mFirstUpdate == false )
                    mParentSource.GetIncidentWatcher().PlayNoise(NoiseType.NewIncident);

                mFirstUpdate = false;
                return true;
            }
            catch
            {
                return false;
            }

        }

        internal string GetToolTipText()
        {
            string returnString = mToolTipText;
            
            //Clear tooltip
            mToolTipText = "";
            return returnString;
        }
    }
}

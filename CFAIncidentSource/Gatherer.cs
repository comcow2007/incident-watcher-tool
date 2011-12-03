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
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;
using System.ComponentModel;
using System.IO.Compression;

namespace CFAIncidentSource
{
    
    class Gatherer
    {
        private CFAIncidentSourceOptions mProgramOptions;
        private CFAIncidentSource mParent;

        public Gatherer( CFAIncidentSourceOptions progOpts, CFAIncidentSource parent)
        {
            mProgramOptions = progOpts;
            mParent = parent;
        }
        
        public Dictionary<string, IncidentItem> GatherIncidents()
        {
            
            //Get incident array
            XmlNodeList tempInciStrings = GetOSOMIncidentStrings(mProgramOptions.GathererSourceURL);

            if (tempInciStrings == null)
            {
                //Throw an exception
                throw new WarningException();
            }
            //Convert the Strings list to a dictionary
            return ConvertXMLListToDictionary(tempInciStrings);

        }

        private Dictionary<string, IncidentItem> ConvertXMLListToDictionary(XmlNodeList tempInciNodesArray)
        {
            //Create a new dictionary
            Dictionary<string, IncidentItem> returnDictionary = new Dictionary<string, IncidentItem>();
            //Loop through all entries in the Xml List
            foreach (XmlNode inci in tempInciNodesArray)
            {
                //Extract the ID
                String idString = inci.SelectSingleNode("guid").InnerText;


                //---------------Extract other details------------------
                string processString = "";
                int workInt = 0;
                string[] stringArray;
                List<string> tempArray = new List<string>();

                processString = inci.SelectSingleNode("description").InnerText.Replace("&lt;","<").Replace("&rt;",">");

                //Split and process segments
                stringArray = processString.Split('>');

                foreach (string workString in stringArray)
                {
                    workInt = workString.IndexOf("<br");

                    if (workInt != -1)
                    {
                        processString = workString.Remove((workString.Length - (workString.Length - workInt)));
                        tempArray.Add(processString.Trim());
                    }
                }

                tempArray.Add(stringArray[stringArray.Length - 1]);

                //Read the details in
                //Strip the "DISTRICT" String
                //tempArray[0] = Region
                
                //---------- Determine Controlling Agency ----------
                string newControllingAgency = "CFA";
                if (tempArray[0].Contains("DISTRICT "))
                {
                    //CFA Job
                    newControllingAgency = "CFA";
                }
                else
                {
                    //DSE Job
                    newControllingAgency = "DSE";
                }

                tempArray[0] = tempArray[0].Replace("DISTRICT ", "");

                string newRegion = tempArray[0];

                //remove the 0 from the region
                if (newControllingAgency == "CFA")
                {
                    try
                    {
                        int tempRegion = int.Parse(tempArray[0]);
                        newRegion = tempRegion.ToString();
                    }
                    catch
                    {
                    }
                }

               

                //tempArray[1] = Suburb
                string newSuburb = FirstCaps(tempArray[1]);

                //tempArray[2] = Street
                string newStreet = FirstCaps(tempArray[2]);

                //tempArray[3] = Last Update
                DateTime newLastUpdate = GetDateTime(tempArray[3]);

                //tempArray[4] = Type
                IncidentItem.IncidentType newIncidentType = IncidentItem.ParseIncidentType(tempArray[4]);

                //tempArray[5] = Status
                IncidentItem.IncidentStatus newIncidentStatus = IncidentItem.ParseIncidentStatus(tempArray[5]);

                //tempArray[6] = Size
                string newIncidentSize = FirstCaps(tempArray[6]);

                //tempArray[7] = Appliances
                int newApplianceCount = int.Parse(tempArray[7]);

                //tempArray[8] = Start Date

                //--------------Get Latitude and Longitude----------
                string[] tempLatLong = inci.LastChild.ChildNodes[0].InnerText.Split(' ');
                string newLatitude = tempLatLong[0];
                string newLongitude = tempLatLong[1];

                 

                //Add the new incident to the dictionary
                returnDictionary.Add(idString, new IncidentItem( newRegion, newSuburb, newStreet, newLastUpdate, newIncidentType,
                                                                 newIncidentStatus, newApplianceCount, newIncidentSize, idString,
                                                                 newLatitude,newLongitude, newControllingAgency, mParent, mProgramOptions));                                     
                
            }
            return returnDictionary;
        }

        private string GetVarValue(string varString)
        {
            int FirstQuoteIndex = varString.IndexOf('\'');
            int SecondQuoteIndex = varString.IndexOf('\'', FirstQuoteIndex + 1);

            return varString.Substring(FirstQuoteIndex+1, (SecondQuoteIndex - FirstQuoteIndex)-1);
        }

        private DateTime GetDateTime(string parseString)
        {
            //The format is 'dd/mm/yy HH:MM:SS AM/PM' (in 12 hour time)
            //split the string at the ' '

            String[] splitString = parseString.Split(' ');
            

            //parse the date
            String[] dateSplit = splitString[0].Split('/');

            int day = int.Parse(dateSplit[0]);
            int month = int.Parse(dateSplit[1]);
            int year = int.Parse(dateSplit[2]) + 2000;

            DateTime time = DateTime.Parse(splitString[1]+" "+splitString[2]);
            
            //Merge 2 together
            return new DateTime(year, month, day, time.Hour, time.Minute, time.Second);

        }

        private XmlNodeList GetOSOMIncidentStrings(String WebAddress )
        {
            XmlNodeList nodeChannel = null;
            try
            {  
                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(WebAddress);
                
                //Set the proxy if there is one
                if (mParent.GetIncidentWatcher().UsesProxy() == true)
                {
                    webRequest.Proxy = mParent.GetIncidentWatcher().GetProxy();
                }


                //Add a header to say we allow gzip (to save download size)
                webRequest.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");

                HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                Stream webStream = webResponse.GetResponseStream();

                try
                {
                    StreamReader dataStream = null;

                    //Should we Decompress GZIP encoding
                    if (webResponse.ContentEncoding.ToLower().Contains("gzip"))
                    {
                        //Decode gzip
                        dataStream = new StreamReader(new GZipStream(webStream, CompressionMode.Decompress));
                    }
                    else
                    {
                        //Not compressed, dont worry about ungzipping
                        dataStream = new StreamReader(webStream);
                    }

                    //Get the rss channel node
                    XmlDocument rssDoc = new XmlDocument();
                    rssDoc.Load(dataStream);
                    nodeChannel = rssDoc.ChildNodes[0].ChildNodes[0].SelectNodes("item");

                }
                catch
                {
                    try
                    {
                        if (mParent.GetIncidentWatcher().GetShowCantUpdateMessage() == true)
                        {
                            MessageBox.Show(Application.OpenForms[0],"Error parsing incident feed from OSOM Public Website.", "OSOM Incident Watch");
                        }
                    }
                    catch
                    {
                    }
                    return null;
                }

            }
            catch
            {
                try
                {
                    if (mParent.GetIncidentWatcher().GetShowCantUpdateMessage() == true)
                    {
                        MessageBox.Show(Application.OpenForms[0], "Error retrieving incident feed from CFA Public Website.", "OSOM Incident Watch");
                    }
                }
                catch
                {
                }

                return null;
            }


            return nodeChannel;
        }

        private string FirstCaps(string inString)
        {
            string workString;
            int spaceIndex = 0;

            if (inString.Length == 0)
                return "";

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

            return workString;
        }
    }
}

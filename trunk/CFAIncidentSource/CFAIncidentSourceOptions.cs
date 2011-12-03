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
using System.Collections.Specialized;

namespace CFAIncidentSource
{
    public class CFAIncidentSourceOptions
    {

        Properties.Settings m_programSettings = new Properties.Settings();

        #region AutoWatch Settings
        //Autowatch Settings
        public StringCollection AutoWatchSuburbs
        {
            set { m_programSettings.AutoWatchSuburb = value; }
            get { if(m_programSettings.AutoWatchSuburb != null) return m_programSettings.AutoWatchSuburb; else return new StringCollection(); }
        }

        public StringCollection AutoWatchAddresses
        {
            get { if (m_programSettings.AutoWatchAddress != null) return m_programSettings.AutoWatchAddress; else return new StringCollection(); }
            set { m_programSettings.AutoWatchAddress = value; }
        }

        public StringCollection AutoWatchTypes
        {
            get { if (m_programSettings.AutoWatchTypes != null) return m_programSettings.AutoWatchTypes; else return new StringCollection(); }
            set { m_programSettings.AutoWatchTypes = value; }
        }

        public StringCollection AutoWatchStatuses
        {
            get { if (m_programSettings.AutoWatchStatus != null) return m_programSettings.AutoWatchStatus; else return new StringCollection(); }
            set { m_programSettings.AutoWatchStatus = value; }
        }

        public StringCollection AutoWatchRegions
        {
            get { if (m_programSettings.AutoWatchRegion != null) return m_programSettings.AutoWatchRegion; else return new StringCollection(); }
            set { m_programSettings.AutoWatchRegion = value; }
        }

        public int AutoWatchApplianceCount
        {
            get { return m_programSettings.AutoWatchAppliances; }
            set { m_programSettings.AutoWatchAppliances = value; }
        }

        public string AutoWatchIncidentSize
        {
            get { return m_programSettings.AutoWatchSize; }
            set { m_programSettings.AutoWatchSize = value; }
        }
        #endregion

        #region Gatherer Settings
        public string GathererSourceURL
        {
            get { return m_programSettings.GathererSourceURL; }
            set { m_programSettings.GathererSourceURL = value; }
        }
        #endregion

        #region Action Settings
        public string ActionDiamond
        {
            get { return m_programSettings.ActionDiamond; }
            set { m_programSettings.ActionDiamond = value; }
        }

        public string ActionSquare
        {
            get { return m_programSettings.ActionSquare; }
            set { m_programSettings.ActionSquare = value; }
        }

        public string ActionCircle
        {
            get { return m_programSettings.ActionCircle; }
            set { m_programSettings.ActionCircle = value; }
        }

        public string ActionDiamondArgs
        {
            get { return m_programSettings.ActionDiamondArgs; }
            set { m_programSettings.ActionDiamondArgs = value; }
        }

        public string ActionSquareArgs
        {
            get { return m_programSettings.ActionSquareArgs; }
            set { m_programSettings.ActionSquareArgs = value; }
        }

        public string ActionCircleArgs
        {
            get { return m_programSettings.ActionCircleArgs; }
            set { m_programSettings.ActionCircleArgs = value; }
        }
        #endregion

        #region Stream Settings

        public string StreamListenerArgs
        {
            get { return m_programSettings.StreamListenerArgs; }
            set { m_programSettings.StreamListenerArgs = value; }
        }

        #region Regions 2-10
        public string Region2Stream
        {
            get { return m_programSettings.StreamURL2; }
            set { m_programSettings.StreamURL2 = value; }
        }

        public string Region4Stream
        {
            get { return m_programSettings.StreamURL4; }
            set { m_programSettings.StreamURL4 = value; }
        }
        public string Region5Stream
        {
            get { return m_programSettings.StreamURL5; }
            set { m_programSettings.StreamURL5 = value; }
        }
        public string Region6Stream
        {
            get { return m_programSettings.StreamURL6; }
            set { m_programSettings.StreamURL6 = value; }
        }
        public string Region7Stream
        {
            get { return m_programSettings.StreamURL7; }
            set { m_programSettings.StreamURL7 = value; }
        }
        public string Region8Stream
        {
            get { return m_programSettings.StreamURL8; }
            set { m_programSettings.StreamURL8 = value; }
        }
        public string Region9Stream
        {
            get { return m_programSettings.StreamURL9; }
            set { m_programSettings.StreamURL9 = value; }
        }
        public string Region10Stream
        {
            get { return m_programSettings.StreamURL10; }
            set { m_programSettings.StreamURL10 = value; }
        }
        #endregion
        #region Regions 11-16
        public string Region11Stream
        {
            get { return m_programSettings.StreamURL11; }
            set { m_programSettings.StreamURL11 = value; }
        }
        public string Region12Stream
        {
            get { return m_programSettings.StreamURL12; }
            set { m_programSettings.StreamURL12 = value; }
        }
        public string Region13Stream
        {
            get { return m_programSettings.StreamURL13; }
            set { m_programSettings.StreamURL13 = value; }
        }
        public string Region14Stream
        {
            get { return m_programSettings.StreamURL14; }
            set { m_programSettings.StreamURL14 = value; }
        }
        public string Region15Stream
        {
            get { return m_programSettings.StreamURL15; }
            set { m_programSettings.StreamURL15 = value; }
        }
        public string Region16Stream
        {
            get { return m_programSettings.StreamURL16; }
            set { m_programSettings.StreamURL16 = value; }
        }
        #endregion
        #region Regions 17-24
        public string Region17Stream
        {
            get { return m_programSettings.StreamURL17; }
            set { m_programSettings.StreamURL17 = value; }
        }
        public string Region18Stream
        {
            get { return m_programSettings.StreamURL18; }
            set { m_programSettings.StreamURL18 = value; }
        }
        public string Region20Stream
        {
            get { return m_programSettings.StreamURL20; }
            set { m_programSettings.StreamURL20 = value; }
        }
        public string Region22Stream
        {
            get { return m_programSettings.StreamURL22; }
            set { m_programSettings.StreamURL22 = value; }
        }
        public string Region23Stream
        {
            get { return m_programSettings.StreamURL23; }
            set { m_programSettings.StreamURL23 = value; }
        }
        public string Region24Stream
        {
            get { return m_programSettings.StreamURL24; }
            set { m_programSettings.StreamURL24 = value; }
        }

        #endregion
        #endregion

        public string GetRegionStream(string Region)
        {
            try
            {
                switch (int.Parse(Region))
                {
                    case 2:
                        return this.Region2Stream;
                    case 4:
                        return this.Region4Stream;
                    case 5:
                        return this.Region5Stream;
                    case 6:
                        return this.Region6Stream;
                    case 7:
                        return this.Region7Stream;
                    case 8:
                        return this.Region8Stream;
                    case 9:
                        return this.Region9Stream;
                    case 10:
                        return this.Region10Stream;
                    case 11:
                        return this.Region11Stream;
                    case 12:
                        return this.Region12Stream;
                    case 13:
                        return this.Region13Stream;
                    case 14:
                        return this.Region14Stream;
                    case 15:
                        return this.Region15Stream;
                    case 16:
                        return this.Region16Stream;
                    case 17:
                        return this.Region17Stream;
                    case 18:
                        return this.Region18Stream;
                    case 20:
                        return this.Region20Stream;
                    case 22:
                        return this.Region22Stream;
                    case 23:
                        return this.Region23Stream;
                    case 24:
                        return this.Region24Stream;
                    default:
                        return String.Empty;
                }
            }
            catch
            {
                return null;
            }
        }

        public void Save()
        {
            m_programSettings.Save();
        }

        public void Reset()
        {
            m_programSettings.Reset();
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

        public String ReplaceInciWatchVarsInString(String oldString, IncidentItem incidentItem)
        {
            String returnString;

            returnString = oldString;

            //Do Replaces

            //ID
            returnString = returnString.Replace("%ID%", incidentItem.ID);

            //SUBURB
            returnString = returnString.Replace("%SUBURB%", incidentItem.Suburb);

            //REGION
            returnString = returnString.Replace("%REGION%", incidentItem.Region.ToString());

            //ADDR
            returnString = returnString.Replace("%ADDR%", incidentItem.Location);

            //TYPE
            returnString = returnString.Replace("%TYPE%", incidentItem.Type.ToString());

            //STREAM
            returnString = returnString.Replace("%STREAM%", this.GetRegionStream(incidentItem.Region));

            //STATUS
            returnString = returnString.Replace("%STATUS%", incidentItem.Status.ToString());

            //SIZE
            returnString = returnString.Replace("%SIZE%", incidentItem.Size.ToString());

            //LAST Updated
            returnString = returnString.Replace("%LASTUP%", incidentItem.LastUpdate.ToString("yyyy-MM-dd_HH-mm-ss"));

            //APPLIANCE
            returnString = returnString.Replace("%APPLIANCES%", incidentItem.ApplianceCount.ToString());

            //CURTIME
            returnString = returnString.Replace("%CURTIME%", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));


            //Return adjusted string
            return returnString;
        }


    }
}

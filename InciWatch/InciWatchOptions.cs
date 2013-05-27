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
using System.Collections.Specialized;

namespace InciWatch
{
    internal class InciWatchOptions
    {

        InciWatch.Properties.Settings m_programSettings = new InciWatch.Properties.Settings();

        #region Gatherer Settings

        public int GathererRefreshInterval
        {
            get { return m_programSettings.RefreshInterval; }
            set { m_programSettings.RefreshInterval = value; }
        }

        public bool ShowCantUpdateMessage
        {
            get { return m_programSettings.ShowCantUpdateMessage; }
            set { m_programSettings.ShowCantUpdateMessage = value; }
        }
        #endregion

        #region Stream Settings
        public string StreamListenerPath
        {
            get { return m_programSettings.StreamListenerPath; }
            set { m_programSettings.StreamListenerPath = value; }
        }

        public bool OpenStreamOnWatch
        {
            get { return m_programSettings.StartStreamOnWatch; }
            set { m_programSettings.StartStreamOnWatch = value; }
        }

        #endregion

        #region Watch Settings
        public bool AutoCloseWatchOnSafe
        {
            get { return m_programSettings.CloseWatchOnIncidentSafe; }
            set { m_programSettings.CloseWatchOnIncidentSafe = value; }
        }

        public int AutoCloseWatchOnSafeDelay
        {
            get { return m_programSettings.CloseWatchOnIncidentSafeDelay; }
            set { m_programSettings.CloseWatchOnIncidentSafeDelay = value; }
        }
        #endregion

        #region Update Settings
        public bool CheckForApplicationUpdatesOnStart
        {
            get { return m_programSettings.CheckUpdatesOnOpen; }
            set { m_programSettings.CheckUpdatesOnOpen = value; }
        }
        public bool CheckForApplicationUpdatesOnAbout
        {
            get { return m_programSettings.CheckUpdatesOnAbout ; }
            set { m_programSettings.CheckUpdatesOnAbout = value; }
        }

        public int HideIncidentsAfterHours
        {
            get { return m_programSettings.OldJobCutoffHours; }
            set { m_programSettings.OldJobCutoffHours = value; }
        }
        #endregion

        #region Proxy Settings
        public bool UseProxy
        {
            get { return m_programSettings.UseProxy; }
            set { m_programSettings.UseProxy = value; }
        }

        public string ProxyAddress
        {
            get { return m_programSettings.ProxyAddress; }
            set { m_programSettings.ProxyAddress = value; }
        }

        public int ProxyPort
        {
            get { return m_programSettings.ProxyPort; }
            set { m_programSettings.ProxyPort = value; }
        }

        public string ProxyUsername
        {
            get { return m_programSettings.ProxyUsername; }
            set { m_programSettings.ProxyUsername = value; }
        }

        public string ProxyPassword
        {
            get { return m_programSettings.ProxyPassword; }
            set { m_programSettings.ProxyPassword = value; }
        }
        #endregion
        #region Display Settings
        public bool DisplayUppercase
        {
            get { return m_programSettings.UseUppercase; }
            set { m_programSettings.UseUppercase = value; }
        }

        public bool AutoSizeColumns
        {
            get { return m_programSettings.AutoSizeColumns; }
            set { m_programSettings.AutoSizeColumns = value; }
        }

        #endregion
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

        
    }
}

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
using InciWatch;

namespace CFAIncidentSource
{
    static class AutoWatch
    {

        public static bool ShouldWeAutoWatch(IncidentItem checkIncident, CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            //If any of the conditions hold true add the watch
            bool fAddWatch = false;

            //Suburb
            if (fAddWatch != true)
            {
                fAddWatch = CheckSuburb(checkIncident,ParentSource,progOptions);
            }

            //Address
            if (fAddWatch != true)
            {
                fAddWatch = CheckAddress(checkIncident, ParentSource, progOptions);
            }

            //Types
            if (fAddWatch != true)
            {
                fAddWatch = CheckTypes(checkIncident, ParentSource, progOptions);
            }

            //Status
            if (fAddWatch != true)
            {
                fAddWatch = CheckStatus(checkIncident, ParentSource, progOptions);
            }

            //Region
            if (fAddWatch != true)
            {
                fAddWatch = CheckRegion(checkIncident, ParentSource, progOptions);
            }
            //Appliances
            if (fAddWatch != true)
            {
                fAddWatch = CheckAppliances(checkIncident, ParentSource, progOptions);
            }

            //Size
            if (fAddWatch != true)
            {
                fAddWatch = CheckSize(checkIncident, ParentSource, progOptions);
            }

            if (checkIncident.Status == IncidentItem.IncidentStatus.Safe)
            {
                //Force Dont Watch
                fAddWatch = false;
            }
            //Return the detail
            return fAddWatch;
        }

        public static bool CheckAppliances(IncidentItem newIncident,CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            if (progOptions.AutoWatchApplianceCount == 0)
                return false;
            //Get the integer of the Appliance Setting
            if (newIncident.ApplianceCount >= progOptions.AutoWatchApplianceCount)
                return true;

            return false;
            
        }

        public static bool CheckRegion(IncidentItem newIncident,CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            if (progOptions.AutoWatchRegions == null)
                return false;
            if (progOptions.AutoWatchRegions.Count == 0)
                return false;

            //Get the list of regions
            foreach (string region in progOptions.AutoWatchRegions)
            {
                if (region == newIncident.Region)
                {
                    //Its a match return true
                    return true;
                }
            }

            return false;
        }

        public static bool CheckSize(IncidentItem newIncident, CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            //Get the Size
            if (String.IsNullOrEmpty(progOptions.AutoWatchIncidentSize) == true)
                return false;

            if (progOptions.AutoWatchIncidentSize == "Ignore")
                return false;

            //Get the incident size
            IncidentItem.IncidentSize inciSize = IncidentItem.ParseIncidentSize(progOptions.AutoWatchIncidentSize);

            //Compare
            if (IncidentItem.ParseIncidentSize(newIncident.Size) == inciSize)
                return true;
            
            return false;
        }

        public static bool CheckStatus(IncidentItem newIncident, CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            //Check for null list or empty list
            if (progOptions.AutoWatchStatuses == null)
                return false;
            if (progOptions.AutoWatchStatuses.Count == 0)
                return false;


            //Compare all the strings
            foreach (string status in progOptions.AutoWatchStatuses)
            {
                if (IncidentItem.ParseIncidentStatus(status) == newIncident.Status)
                    return true;
            }
            
            return false;
        }

        public static bool CheckTypes(IncidentItem newIncident, CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            //Check for null and empty list
            if (progOptions.AutoWatchTypes == null)
                return false;
            if (progOptions.AutoWatchTypes.Count == 0)
                return false;

            //Compare each item
            foreach (string inciType in progOptions.AutoWatchTypes)
            {
                if (IncidentItem.ParseIncidentType(inciType) == newIncident.Type)
                    return true;
            }

            return false;
        }

        public static bool CheckSuburb(IncidentItem newIncident, CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            //Check for empty or null list of string
            if (progOptions.AutoWatchSuburbs == null)
                return false;
            if (progOptions.AutoWatchSuburbs.Count == 0)
                return false;

            //Compare each string, taking into account wildcards
            foreach (string suburb in progOptions.AutoWatchSuburbs)
            {
                bool fStartWild=false, fEndWild = false;
                string compString = suburb;

                if (suburb.StartsWith("*") == true)
                {
                    compString = suburb.Remove(0, 1);
                    fStartWild = true;
                }
                if (suburb.EndsWith("*") == true)
                {
                    compString = compString.TrimEnd('*');
                    fEndWild = true;
                }

                if (fStartWild == false && fEndWild == false)
                {
                    //Complete compare
                    if (compString.ToLower() == newIncident.Suburb.ToLower())
                        return true;
                }
                else if (fStartWild == true && fEndWild == false)
                {
                    //Ends with suburb
                    if (newIncident.Suburb.ToLower().EndsWith(compString.ToLower()) == true)
                        return true;
                }
                else if (fStartWild == true && fEndWild == true)
                {
                    //Has suburb in it
                    if (newIncident.Suburb.ToLower().Contains(compString.ToLower()) == true)
                        return true;
                }
                else if (fStartWild == false && fEndWild == true)
                {
                    //Starts with suburb
                    if (newIncident.Suburb.ToLower().StartsWith(compString.ToLower()) == true)
                        return true;
                }
            }

            return false;
        }

        public static bool CheckAddress(IncidentItem newIncident, CFAIncidentSource ParentSource, CFAIncidentSourceOptions progOptions)
        {
            //Check for empty or null list of string
            if (progOptions.AutoWatchAddresses == null)
                return false;
            if (progOptions.AutoWatchAddresses.Count == 0)
                return false;

            //Compare each string, taking into account wildcards
            foreach (string address in progOptions.AutoWatchAddresses)
            {
                bool fStartWild = false, fEndWild = false;
                string compString = address;

                if (address.StartsWith("*") == true)
                {
                    compString = address.Remove(0, 1);
                    fStartWild = true;
                }
                if (address.EndsWith("*") == true)
                {
                    compString = compString.TrimEnd('*');
                    fEndWild = true;
                }

                if (fStartWild == false && fEndWild == false)
                {
                    //Complete compare
                    if (compString.ToLower() == newIncident.Location.ToLower())
                        return true;
                }
                else if (fStartWild == true && fEndWild == false)
                {
                    //Ends with suburb
                    if (newIncident.Location.ToLower().EndsWith(compString.ToLower()) == true)
                        return true;
                }
                else if (fStartWild == true && fEndWild == true)
                {
                    //Has suburb in it
                    if (newIncident.Location.ToLower().Contains(compString.ToLower()) == true)
                        return true;
                }
                else if (fStartWild == false && fEndWild == true)
                {
                    //Starts with suburb
                    if (newIncident.Location.ToLower().StartsWith(compString.ToLower()) == true)
                        return true;
                }
            }

            return false;
        }

    }
}

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
using System.Collections;
using System.Windows.Forms;
using System;
using System.Globalization;
namespace InciWatch
{
    class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        
        public int Compare(object x, object y) 
        {
            int returnVal = -1;

            if (col == 4)
            {
                //Column is 4(region), Do a special sort, if it is an integer, pad it out to 8 Chars with 0's for good measure
                int xInteger = 0;
                int yInteger = 0;

                string xString = "";
                string yString = "";

                //Check the x item
                if (int.TryParse(((ListViewItem)x).SubItems[col].Text, out xInteger) == true)
                {
                    //Its actually an integer, pad out the string
                    int padLength = 8;
                    padLength -= xInteger.ToString().Length;

                    //Pad that string
                    for (int i = 0; i < padLength; i++)
                    {
                        xString += "0";
                    }

                    //Add the integer
                    xString += xInteger.ToString();
                }
                else
                {
                    //Its just a regular string
                    xString = ((ListViewItem)x).SubItems[col].Text;
                }

                //Check the y item
                if (int.TryParse(((ListViewItem)y).SubItems[col].Text, out yInteger) == true)
                {
                    //Its actually an integer, pad out the string
                    int padLength = 8;
                    padLength -= yInteger.ToString().Length;

                    //Pad that string
                    for (int i = 0; i < padLength; i++)
                    {
                        yString += "0";
                    }

                    //Add the integer
                    yString += yInteger.ToString();
                }
                else
                {
                    //Its just a regular string
                    yString = ((ListViewItem)y).SubItems[col].Text;
                }

                //Compare the strings
                returnVal = String.Compare(xString, yString);

            }
            else if( col == 5 )
            {
                //Column 5 (Last update) - DateTimes
                DateTime dateX = InciWatchOptions.DateStringToDate(((ListViewItem)x).SubItems[col].Text);
                DateTime dateY = InciWatchOptions.DateStringToDate(((ListViewItem)y).SubItems[col].Text);

                if (dateX > dateY)
                    returnVal = 1;
                else if (dateX < dateY)
                    returnVal = -1;
                else
                    returnVal = 0;
            }
            else if (col == 6)
            {
                //column is 6(Appliances) - integer sort
                int valX = int.Parse(((ListViewItem)x).SubItems[col].Text);
                int valY = int.Parse(((ListViewItem)y).SubItems[col].Text);

                if (valX > valY)
                    returnVal = 1;
                else if (valX < valY)
                    returnVal = -1;
                else
                    returnVal = 0;
            }
            else
            {

                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                        ((ListViewItem)y).SubItems[col].Text);

            }


            // Determine whether the sort order is descending.
            if (order == SortOrder.Descending)
                // Invert the value returned by String.Compare.
                returnVal *= -1;
            return returnVal;
         }
    }
}
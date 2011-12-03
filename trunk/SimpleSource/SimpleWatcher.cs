//SimpleSource - This incident source is an example of how to create a source plugin using the interfaces provided by Incident Watcher
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InciWatch;

namespace SimpleSource
{
    public partial class SimpleWatcher : Form, IWatchNotification
    {
        IWatchList mParent;
        SimpleIncident mIncident;

        internal SimpleWatcher(SimpleIncident incident, IWatchList parent)
        {
            InitializeComponent();

            mParent = parent;
            mIncident = incident;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Remove this
            mParent.Remove(mIncident.ID_GENERIC);
        }

        #region Interface Functions
        public Point GetPosition()
        {
            return this.Location;
        }

        public void SetPosition(Point newPosition)
        {
            this.Location = newPosition;
        }

        public int GetWidth()
        {
            return this.Width;
        }

        public int GetHeight()
        {
            return this.Height;
        }

        public void SetDimensions(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void ShowNotification()
        {
            //Set the values
            label1.Text = mIncident.Suburb_GENERIC + "," + mIncident.Location_GENERIC + "," + mIncident.Status_GENERIC +
                "," + mIncident.Type_GENERIC + "," + mIncident.Size_GENERIC + "," + mIncident.LastUpdate_GENERIC + "," + mIncident.Region_GENERIC;
            
            //Show the notification
            this.Show();
        }

        public void CloseNotification()
        {
            this.Close();
        }

        public bool RefreshNotification()
        {
            label1.Text = mIncident.Suburb_GENERIC + "," + mIncident.Location_GENERIC + "," + mIncident.Status_GENERIC +
                "," + mIncident.Type_GENERIC + "," + mIncident.Size_GENERIC + "," + mIncident.LastUpdate_GENERIC + "," + mIncident.Region_GENERIC;

            return false;
        }





        #endregion


    }
}

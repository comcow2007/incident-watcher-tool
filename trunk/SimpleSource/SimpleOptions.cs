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
    public partial class SimpleOptions : Form
    {
        public SimpleOptions()
        {
            InitializeComponent();
        }

        internal SimpleIncident GenerateSimpleIncident(SimpleSource Parent)
        {
            SimpleIncident returnIncident = new SimpleIncident(Parent);

            returnIncident.ApplianceCount_GENERIC = int.Parse(txtAppliances.Text);

            returnIncident.ID_GENERIC = SimpleConstants.ID_PREFIX+ txtID.Text;
            returnIncident.LastUpdate_GENERIC = DateTime.Now;
            returnIncident.Location_GENERIC = txtAddress.Text;
            returnIncident.Region_GENERIC = txtRegion.Text;
            returnIncident.Size_GENERIC = txtSize.Text;
            returnIncident.Status_GENERIC = txtStatus.Text;
            returnIncident.Suburb_GENERIC = txtSuburb.Text;
            returnIncident.Type_GENERIC = txtType.Text;


            return returnIncident;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

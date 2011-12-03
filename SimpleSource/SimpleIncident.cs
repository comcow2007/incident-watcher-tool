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
using System.Text;
using InciWatch;

namespace SimpleSource
{
    internal class SimpleIncident : GenericIncidentItem
    {
        private SimpleSource mParent; 
        public SimpleIncident(SimpleSource parent)
        {
            mParent = parent;
        }

        public override IIncidentSource GetSource()
        {
            return mParent;
        }

        public override string GetMapURL()
        {
            return "";
        }

        public override string GetStreamURL()
        {
            return "";
        }

        public override bool IsMapAvailable()
        {
            //No Map
            return false;
        }

        public override bool IsStreamAvailable()
        {
            //No Stream
            return false;
        }

    }
}

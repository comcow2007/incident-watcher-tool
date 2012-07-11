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
using System.Windows.Forms;
using System.IO;

namespace InciWatch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if !DEBUG
            try
            {
#endif
                Application.Run(new CurrentIncidentsForm());
#if !DEBUG
            }
            catch (ArgumentException e)
            {
                if (e.Message.Contains("Incident Sources") == false)
                {
                    if (MessageBox.Show("Something bad happened where it shouldn't have! Would you like to generate fail.txt with some error details? If so please create an issue at https://code.google.com/p/incident-watcher-tool/ and attach the file to help fix the problem.", AppConstants.ApplicationFriendlyName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        WriteFailFile(e);
                    }
                }
            }
            catch (Exception e)
            {
                if (MessageBox.Show("Something bad happened where it shouldn't have! Would you like to generate fail.txt with some error details? If so please create an issue at https://code.google.com/p/incident-watcher-tool/ and attach the file to help fix the problem.", AppConstants.ApplicationFriendlyName, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    WriteFailFile(e);
                }
            }
#endif
        }

        static void WriteFailFile(Exception e)
        {
            try
            {
                FileStream fs = new FileStream("fail.txt", FileMode.Create);
                StreamWriter fsw = new StreamWriter(fs);

                fsw.WriteLine("Program: " + Application.ProductName);
                fsw.WriteLine("Version: " + Application.ProductVersion);
                fsw.WriteLine(e.ToString());

                fsw.Flush();

                //Close the files
                fsw.Close();
                fs.Close();
            }
            catch
            {

            }
        }
    }
}

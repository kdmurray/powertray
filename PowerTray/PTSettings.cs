using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;

namespace PowerTray
{
    class PTSettings
    {
        public static DataSet LoadSettings()
        {
            DataSet ds;
            if (File.Exists(Globals.APP_SETTINGS_FILE))
            {
                try
                {
                    ds = new DataSet();
                    ds.ReadXml(Globals.APP_SETTINGS_FILE);

                    // Verify that the config file contains the "AppSetings" Section
                    if (ds.Tables.Contains("AppSettings") && ds.Tables.Contains("Plugins"))
                    {
                        // Check to see that there is a version number in the settings file
                        // Version numbers were added in 
                        if (ds.Tables["AppSettings"].Columns.Contains("Version"))
                        {
                            //TODO: Handle out of date versions
                        }
                        return ds;
                    }

                }
                catch (Exception ex)
                {
                    //TODO: Log Exception
                    File.Delete(Globals.APP_SETTINGS_FILE);
                }
            }

            //TODO: Try/Catch
            //TODO: Refactor this section into another method or class

            ds = new DataSet();
            
            // Tables = Config sections in the settings file
            ds.Tables.Add("AppSettings");

            // Columns = Key-Value pair key names n the settings file
            ds.Tables["AppSettings"].Columns.Add("LoadAtStartup");
            ds.Tables["AppSettings"].Columns.Add("Version");

            return ds;
        }
    }
}
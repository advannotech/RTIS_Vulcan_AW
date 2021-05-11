using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIS_Vulcan_AW.Classes
{
    class SQLite
    {
        public static string InitSettingsDB()
        {
            try
            {
                bool dbFound = false;
                if (Directory.Exists(GlobalVars.RSCFolder) == false || File.Exists(GlobalVars.SettingsDB) == false)
                {
                    dbFound = false;
                    try
                    {
                        Directory.CreateDirectory(GlobalVars.RSCFolder);
                    }
                    catch (Exception)
                    { }
                    string created = CreateSettingsTable(GlobalVars.SettingsDB);
                    switch (created.Split('*')[0])
                    {
                        case "1":

                            string insertString = "ServerIP|192.168.1.6~";
                            insertString += "ServerPort|32017~";
                            insertString += "AWWhse|ZECT~";
                            insertString += "AWIT|ZECT IT~";
                            insertString += "ConfigPath|Select Path~";
                            insertString += "AWPath|Select Path~";
                            insertString += "Printer|Select Printer~";
                            insertString += "LotLookup|30~";

                            string inserted = InsertSettings(insertString, GlobalVars.SettingsDB);
                            switch (inserted.Split('*')[0])
                            {
                                case "1":
                                    string settings = GetSettings(GlobalVars.SettingsDB);
                                    switch (settings.Split('*')[0])
                                    {
                                        case "1":
                                            settings = settings.Remove(0, 2);
                                            string settingsSet = SetSettings(settings, GlobalVars.SettingsDB);
                                            switch (settingsSet.Split('*')[0])
                                            {
                                                case "1":
                                                    return "0*Initial Startup Detected" + Environment.NewLine + Environment.NewLine + "Please set up the application";
                                                case "-1":
                                                    return settingsSet;
                                                default:
                                                    StackTrace st4 = new StackTrace(0, true);
                                                    string msgStr4 = "Unexpected error storing settings";
                                                    string infoStr4 = "Unexpected error storing settings";
                                                    return returnErrorST(st4, msgStr4, infoStr4);
                                            }
                                        case "-1":
                                            return settings;
                                        default:
                                            StackTrace st3 = new StackTrace(0, true);
                                            string msgStr3 = "Unexpected error getting settings";
                                            string infoStr3 = "Unexpected error getting settings";
                                            return returnErrorST(st3, msgStr3, infoStr3);
                                    }
                                case "-1":
                                    return inserted;
                                default:
                                    StackTrace st2 = new StackTrace(0, true);
                                    string msgStr2 = "Unexpected error setting up the settings file";
                                    string infoStr2 = "Unexpected error setting up the settings file";
                                    return returnErrorST(st2, msgStr2, infoStr2);
                            }
                        case "-1":
                            return created;
                        default:
                            StackTrace st = new StackTrace(0, true);
                            string msgStr = "Unexpected error creating the settings file";
                            string infoStr = "Unexpected error creating the settings file";
                            return returnErrorST(st, msgStr, infoStr);
                    }
                }
                else
                {
                    string settings = GetSettings(GlobalVars.SettingsDB);
                    switch (settings.Split('*')[0])
                    {
                        case "1":
                            settings = settings.Remove(0, 2);
                            string settingsSet = SetSettings(settings, GlobalVars.SettingsDB);
                            switch (settingsSet.Split('*')[0])
                            {
                                case "1":
                                    return "1*Success";
                                case "-1":
                                    return settingsSet;
                                default:
                                    StackTrace st = new StackTrace(0, true);
                                    string msgStr = "Unexpected error storing settings";
                                    string infoStr = "Unexpected error storing settings";
                                    return returnErrorST(st, msgStr, infoStr);
                            }
                        case "-1":
                            return settings;
                        default:
                            StackTrace st2 = new StackTrace(0, true);
                            string msgStr2 = "Unexpected error getting settings";
                            string infoStr2 = "Unexpected error getting settings";
                            return returnErrorST(st2, msgStr2, infoStr2);

                    }
                }

            }
            catch (Exception ex)
            {
                return ExHandler.returnErrorEX(ex);
            }
        }
        public static string CreateSettingsTable(string db)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn.ConnectionString = "Data Source = " + db;
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = "CREATE TABLE [Settings]" +
                                   "(" +
                                   "[SettingName] NVARCHAR(128) NOT NULL," +
                                   "[Value] NVARCHAR(128)" +
                                    ")";
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                conn.Dispose();
                return "1*Success";
            }
            catch (Exception ex)
            {
                return ExHandler.returnErrorEX(ex);
            }
        }
        public static string InsertSettings(string settings, string db)
        {
            try
            {
                string[] allSetting = settings.Split('~');
                string insertCommand = string.Empty;
                foreach (var item in allSetting)
                {
                    if (item != string.Empty)
                    {
                        insertCommand += "INSERT INTO [Settings] ([SettingName], [Value]) VALUES ('" + item.Split('|')[0] + "', '" + item.Split('|')[1] + "');";
                    }
                }
                SQLiteConnection conn = new SQLiteConnection();
                conn.ConnectionString = @"Data Source = " + db;
                conn.Open();
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = insertCommand;
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                conn.Dispose();
                return "1*Success";
            }
            catch (Exception ex)
            {
                return ExHandler.returnErrorEX(ex);
            }
        }
        public static string GetSettings(string db)
        {
            try
            {
                string returnString = string.Empty;
                SQLiteConnection conn = new SQLiteConnection();
                conn.ConnectionString = "Data Source = " + db;
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT [SettingName], [Value] FROM [Settings]";
                conn.Open();
                SQLiteDataReader rdr = comm.ExecuteReader();
                while (rdr.Read())
                {
                    returnString += Convert.ToString(rdr[0]) + "|" + Convert.ToString(rdr[1]) + "~";
                }
                comm.Dispose();
                conn.Close();
                conn.Dispose();
                if (returnString != string.Empty)
                {
                    return "1*" + returnString;
                }
                else
                {
                    StackTrace st = new StackTrace(0, true);
                    string msgStr = "No settings were found";
                    string infoStr = "No settings were found";
                    return returnErrorST(st, msgStr, infoStr);
                }

            }
            catch (Exception ex)
            {
                return ExHandler.returnErrorEX(ex);
            }
        }
        public static string SetSettings(string settings, string db)
        {
            try
            {
                string[] allSettings = settings.Split('~');
                foreach (string setting in allSettings)
                {
                    if (setting != string.Empty)
                    {
                        string settingName = setting.Split('|')[0];
                        string settingValue = setting.Split('|')[1];
                        switch (settingName)
                        {
                            case "ServerIP":
                                GlobalVars.ServerIP = settingValue;
                                break;
                            case "ServerPort":
                                GlobalVars.ServerPort = settingValue;
                                break;
                            case "AWWhse":
                                GlobalVars.awWhse = settingValue;
                                break;
                            case "AWIT":
                                GlobalVars.awIT = settingValue;
                                break;
                            case "ConfigPath":
                                GlobalVars.configLoc = settingValue;
                                break;
                            case "AWPath":
                                GlobalVars.awLoc = settingValue;
                                break;
                            case "Printer":
                                GlobalVars.Printer = settingValue;
                                break;
                            case "LotLookup":
                                GlobalVars.lotLookupPeriod = settingValue;
                                break;

                        }
                    }
                }
                return "1*Success";
            }
            catch (Exception ex)
            {
                return ExHandler.returnErrorEX(ex);
            }
        }
        public static string UpdateSettings(string query, string db)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                conn.ConnectionString = "Data Source = " + db;
                SQLiteCommand comm = new SQLiteCommand();
                comm.Connection = conn;
                comm.CommandText = query;
                conn.Open();
                comm.ExecuteNonQuery();
                comm.Dispose();
                conn.Close();
                conn.Dispose();
                return "1*Success";
            }
            catch (Exception ex)
            {
                return ExHandler.returnErrorEX(ex);
            }
        }
        public static string returnErrorST(StackTrace st, string msgStr, string infoStr)
        {
            StackFrame sf = new StackFrame();
            sf = st.GetFrame(0);
            string file = sf.GetFileName();
            string line = sf.GetFileLineNumber().ToString();
            string name = sf.GetFileName().ToString();
            string meth = sf.GetMethod().ToString();
            infoStr += Environment.NewLine + Environment.NewLine + "Method:" + Environment.NewLine + meth + Environment.NewLine + Environment.NewLine + "File: " + Environment.NewLine + name + Environment.NewLine + Environment.NewLine + "Line Number: " + Environment.NewLine + line;
            return "-1*" + msgStr + "|" + infoStr;
        }
    }
}

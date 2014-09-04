using System;
using System.Configuration;

using Common.Helpers;

namespace DataTier
{
    /// <summary>
    /// Base class for all database interaction classes
    /// </summary>
    public class DataTierBase
    {
        public string ConnectionString
        {
            get { return GetConnectionStringsValue("CCS1"); }
        }

        public string GetConnectionStringsValue(string key)
        {
            ManagerHelper.LoggingManager().LogMessage(string.Format("{0}.{1}", GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name));
            ManagerHelper.LoggingManager().LogMessage(string.Format("Config key={0}", key));
            string configFile = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            ManagerHelper.LoggingManager().LogMessage(string.Format("Config file={0}", configFile));

            string result = string.Empty;
            if (!string.IsNullOrEmpty(key))
            {
                ConnectionStringSettings connSettings = ConfigurationManager.ConnectionStrings[key];
                if (connSettings != null)
                {
                    result = connSettings.ConnectionString;
                }
            }
            ManagerHelper.LoggingManager().LogMessage(string.Format("ConnectionString={0}", result));
            return result;
        }
    }
}
    
using System;
using System.Configuration;

namespace Common.Helpers
{
    /// <summary>
    /// Class for reading values from the app.config configuration file
    /// </summary>
    public class AppSettingsManager : ManagerBase
    {
        public string GetAppSettingsValue(string key)
        {
            string result = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(key))
                {
                    return ConfigurationManager.AppSettings[key];
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                throw;
            }
            return result;
        }
    }
}

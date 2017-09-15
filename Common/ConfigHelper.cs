using System;

namespace Common
{
    public class ConfigHelper
    {
        public static string ConnectionString(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            return System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppSetting(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException();
            return System.Configuration.ConfigurationManager.AppSettings[name].ToString();
        }
    }
}

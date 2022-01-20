using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTools.Configuration
{
    public static class ConfigManager
    {
        public static class AppConfigManager
        {
            public static string GerDefaultLocalizationPath()
            {
                string ret = "";
                ret = ConfigurationManager.AppSettings["localizationPath"];
                return ret;
            }
        }


        public static class UserConfigManager
        {
            public static UserConfigSettings GetConfig(string sectionName)
            {
                UserConfigSettings ret = ConfigurationManager.GetSection(sectionName) as UserConfigSettings;
                return ret;
            }
        }
    }
}

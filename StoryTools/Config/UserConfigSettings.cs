using System.Configuration;

namespace StoryTools.Configuration
{
    public class UserConfigSettings : ConfigurationSection
    {
        public static UserConfigSettings GetConfig()
        {
            UserConfigSettings userConfigSettings = GetConfig(UserConfigConstants.ConfigKey);
            return userConfigSettings;
        }

        public static UserConfigSettings GetConfig(string sectionName)
        {
            UserConfigSettings userConfigSettings = ConfigurationManager.GetSection(sectionName) as UserConfigSettings;
            return userConfigSettings;
        }

        public static string SavePath(string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            UserConfigSettings userConfig = config.GetSection("UserConfigSettings") as UserConfigSettings;
            userConfig.UserLocalizationPath = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("UserConfigSettings");
            return value;
        }

        [ConfigurationProperty(UserConfigConstants.UserLocalizationPathKey, IsKey = true, IsRequired = true)]
        public string UserLocalizationPath
        {
            get
            {
                return this[UserConfigConstants.UserLocalizationPathKey].ToString();
            }
            set
            {
                this[UserConfigConstants.UserLocalizationPathKey] = value;
            }
        }
    }

    public static class UserConfigConstants
    {
        public const string ConfigKey = "UserConfigSettings";
        public const string UserLocalizationPathKey = "UserLocalizationPath";
    }
}

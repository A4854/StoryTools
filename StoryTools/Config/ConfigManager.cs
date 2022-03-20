using System.Configuration;
using WindowsForm = System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace StoryTools.Config
{
    public class ConfigManager: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static ConfigManager instance;
        private static Configuration config;

        public ConfigManager()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public static ConfigManager Get()
        {
            if (instance == null)
            {
                instance = new ConfigManager();
            }
            return instance;
        }

        public class AppConfigManager
        {
            public static string GerDefaultLocalizationPath()
            {
                string ret = "";
                ret = ConfigurationManager.AppSettings["localizationPath"];
                return ret;
            }
        }

        public string GetConfig(string key)
        {
            return config.AppSettings.Settings[key].Value;
        }

        public void SetConfig(string key, string value)
        {
            config.AppSettings.Settings[key].Value = value ;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSetting");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(key));
        }

        public string GetCsvPath()
        {
            string path = GetConfig("CsvPath");
            if (path == "LoacalPath" || path == "")
            {
                path = Path.GetDirectoryName(Globals.ThisAddIn.Application.ActiveWorkbook.FullName);
            }
            return path;
        }


        public void SetCsvPath(string path)
        {
            SetConfig("CsvPath", path);
        }

    }
}

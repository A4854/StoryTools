using System.Configuration;
using StoryTools.Scripts.Global;
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

        public string GetConfig(string key)
        {
            string path = config.AppSettings.Settings[key].Value;
            if (path == "")
            {
                path = Path.GetDirectoryName(Globals.ThisAddIn.Application.ActiveWorkbook.FullName);
            }
            return path;
        }

        public void SetConfig(string key, string value)
        {
            config.AppSettings.Settings[key].Value = value ;
            OnChangeData(key);
        }

        public void OnChangeData(string key)
        {
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSetting");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(key));
        }
    }
}

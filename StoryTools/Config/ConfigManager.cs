using System.Configuration;
using WindowsForm = System.Windows.Forms;

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

        public static string GetUserLocalizationPath()
        {
            string path = UserConfigSettings.GetConfig().UserLocalizationPath;

            if (path == "")
            {
                WindowsForm.FolderBrowserDialog dialog = new WindowsForm.FolderBrowserDialog();
                dialog.Description = "请选择CSV导出路径";
                if (dialog.ShowDialog() == WindowsForm.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        WindowsForm.MessageBox.Show("文件夹路径不能为空", "Error");
                    }
                }
                path = UserConfigSettings.SavePath(dialog.SelectedPath);
            }
            return path;
        }

    }
}

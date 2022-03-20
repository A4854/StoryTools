using StoryTools.Config;
using StoryTools.Scripts.Global;
using System;
using System.Windows.Forms;

namespace StoryTools.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConfigManager.Get().PropertyChanged += MainForm_PropertyChanged;
        }

        private void MainForm_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Refresh();
        }

        private void ButtonResetCSVPath_Click(object sender, EventArgs e)
        {
            ConfigManager.Get().SetConfig(Defination.CsvPathKey, "");
        }

        private void ButtonChooseCSVPath_Click(object sender, EventArgs e)
        {
            string csvPath = ConfigManager.Get().GetConfig(Defination.CsvPathKey);
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = @"请选择CSV导出路径:";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(@"文件夹路径不能为空!", @"Error");
                }
                else
                {
                    csvPath = dialog.SelectedPath;
                }
            }
            ConfigManager.Get().SetConfig(Defination.CsvPathKey, csvPath);
        }

        private void ButtonChooseLocalizationPath_Click(object sender, EventArgs e)
        {
            string localizationPath = ConfigManager.Get().GetConfig(Defination.LocalizationPathKey);
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = @"请选择本地化配置导出路径:"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.FileName))
                {
                    MessageBox.Show(@"文件夹路径不能为空!", @"Error");
                }
                else
                {
                    localizationPath = dialog.FileName;
                }
            }
            ConfigManager.Get().SetConfig(Defination.LocalizationPathKey, localizationPath);
        }

        private void ButtonResetLocalizationPath_Click(object sender, EventArgs e)
        {
            ConfigManager.Get().SetConfig(Defination.LocalizationPathKey, "");
        }

        private void LabelCurrentCSVPath_Paint(object sender, PaintEventArgs e)
        {
            LabelCurrentCSVPath.Text = ConfigManager.Get().GetConfig(Defination.CsvPathKey);
        }

        private void LabelCurrentLocalizationPath_Paint(object sender, PaintEventArgs e)
        {
            LabelCurrentLocalizationPath.Text = ConfigManager.Get().GetConfig(Defination.LocalizationPathKey);
        }
    }
}


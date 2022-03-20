using System;
using System.Windows.Forms;
using StoryTools.Config;

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
            ConfigManager.Get().SetCsvPath("LoacalPath");
        }

        private void ButtonChooseCSVPath_Click(object sender, EventArgs e)
        {
            string csvPath = ConfigManager.Get().GetCsvPath();
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
            ConfigManager.Get().SetCsvPath(csvPath);
        }

        private void LabelCurrentCSVPath_Paint(object sender, PaintEventArgs e)
        {
            LabelCurrentCSVPath.Text = ConfigManager.Get().GetCsvPath();
        }
    }
}  


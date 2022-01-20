using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using WindowsForm = System.Windows.Forms;
using System.Configuration;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryTools
{
    public partial class StoryToolsFunctions
    {
        Excel.Application app;
        private void StoryToolsFunctions_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void ButtonExportToCSV_Click(object sender, RibbonControlEventArgs e)
        {
            string CSVDirectory = Configuration.UserConfigSettings.GetConfig().UserLocalizationPath;
            if (CSVDirectory == "")
            {
                WindowsForm.FolderBrowserDialog dialog = new WindowsForm.FolderBrowserDialog();
                dialog.Description = "请选择CSV导出路径";
                if (dialog.ShowDialog() == WindowsForm.DialogResult.OK)
                {
                    if (string.IsNullOrEmpty(dialog.SelectedPath))
                    {
                        WindowsForm.MessageBox.Show("文件夹路径不能为空", "Error");
                        return;
                    }
                }
                Configuration.UserConfigSettings.SavePath(dialog.SelectedPath);
            }
            string csvName = Path.GetFileNameWithoutExtension(app.ActiveWorkbook.Name);
            string fileType = ".csv";
            string fullPath = Path.Combine(CSVDirectory, csvName + fileType);
            Excel.Worksheet sheet = app.ActiveWorkbook.Worksheets[1];
            ExcelToCsv.ExportToCsv(sheet.UsedRange, fullPath, sheet.UsedRange.Rows.Count, "dialog", "dialogtext");
            
        }

        private void ButtonConfigManager_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void ConfigManagerWindow_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}

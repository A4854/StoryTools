using Microsoft.Office.Tools.Ribbon;
using StoryTools.Scripts.ExcelHelper;
using StoryTools.Scripts.StyleHelper;
using System;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using WindowsForm = System.Windows.Forms;
using StoryTools.Configuration;
using StoryTools.Scripts.DocumentLog;

namespace StoryTools
{
    public partial class StoryToolsFunctions
    {
        Excel.Application app;
        private void OnStoryToolsLoad(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
            app.WorkbookActivate += OnWorkBookActive;
        }

        private void OnWorkBookActive(Excel.Workbook Wb)
        {
            StyleHelper.AddStyle(app, "LogContent", "宋体", 14, false, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
            StyleHelper.AddStyle(app, "LogTitle", "宋体", 16, true, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
        }

        private void ButtonExportToCSV_Click(object sender, RibbonControlEventArgs e)
        {
            string csvPath = ConfigManager.GetUserLocalizationPath();
            string csvName = Path.GetFileNameWithoutExtension(app.ActiveWorkbook.Name);
            string fileType = ".csv";
            string fullPath = Path.Combine(csvPath, csvName + fileType);
            Excel.Range rng = app.ActiveWorkbook.ActiveSheet.UsedRange;
            ExcelManager.ExportToCsv(rng, fullPath, rng.Rows.Count,
                "id", "speaker", "speakertext", "dialog", "dialogtext", "speed", "protecttime", "anime", "start");
        }

        private void ButtonConfigManager_Click(object sender, RibbonControlEventArgs e)
        {
            WindowsForm.MessageBox.Show(ConfigManager.GetUserLocalizationPath(), "配置路径为");
        }

        private void ConfigManagerWindow_HelpRequest(object sender, EventArgs e)
        {

        }

        private void MakeLog_Click(object sender, RibbonControlEventArgs e)
        {
            if (app.ActiveWorkbook.Worksheets.OfType<Excel.Worksheet>().FirstOrDefault(ws => ws.Name == "log") == null)
            {
                 DocumentLogManager.MakeLog(app.ActiveWorkbook);
            }
        }

        private void CheckRoleName_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }
}

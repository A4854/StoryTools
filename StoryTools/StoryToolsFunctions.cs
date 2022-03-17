using Microsoft.Office.Tools.Ribbon;
using StoryTools.Scripts.ExcelHelper;
using StoryTools.Scripts.StyleHelper;
using System;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using WindowsForm = System.Windows.Forms;
using StoryTools.Configuration;

namespace StoryTools
{
    public partial class StoryToolsFunctions
    {
        Excel.Application app;
        private void StoryToolsFunctions_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
            app.WorkbookActivate += App_WorkbookActivate;
        }

        private void App_WorkbookActivate(Excel.Workbook Wb)
        {
            StyleHelper.AddStyle(app, "LogContent", "宋体", 14, false, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
            StyleHelper.AddStyle(app, "LogTitle", "宋体", 16, true, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void ButtonExportToCSV_Click(object sender, RibbonControlEventArgs e)
        {
            string csvPath = ConfigManager.GetUserLocalizationPath();
            string csvName = Path.GetFileNameWithoutExtension(app.ActiveWorkbook.Name);
            string fileType = ".csv";
            string fullPath = Path.Combine(csvPath, csvName + fileType);
            Excel.Worksheet sheet = app.ActiveWorkbook.Worksheets[1];
            ExcelManager.ExportToCsv(sheet.UsedRange, fullPath, sheet.UsedRange.Rows.Count,
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
                var logSheet = app.ActiveWorkbook.Worksheets.Add() as Excel._Worksheet;
                logSheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;
                logSheet.Name = "log";
                logSheet.Columns.ColumnWidth = 30;
                logSheet.Rows.RowHeight = 18.75;

                RangeManager.InitRange(app, logSheet.Range["A1", "C1"], "LogTitle", "日期", "修改人", "修改内容");
                RangeManager.InitRange(app, logSheet.Range["A2", "C2"], "LogContent", DateTime.Today.ToShortDateString(), "黎　奇", "");
                RangeManager.InitRange(app, logSheet.Range["A3", "C10"], "LogContent", null);
            }
        }

    }
}

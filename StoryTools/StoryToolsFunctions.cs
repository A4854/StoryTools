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
            app.WorkbookActivate += App_WorkbookActivate;         
        }

        private void App_WorkbookActivate(Excel.Workbook Wb)
        {
            StyleManager.AddStyle(app, "LogContent", "宋体", 14, false, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
            StyleManager.AddStyle(app, "LogTitle", "宋体", 16, true, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
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

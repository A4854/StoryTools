using Microsoft.Office.Tools.Ribbon;
using StoryTools.Config;
using StoryTools.Scripts.DataHelper;
using StoryTools.Scripts.DocumentLog;
using StoryTools.Scripts.Global;
using StoryTools.Scripts.StyleHelper;
using System;
using System.Data;
using System.IO;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using MyForm = StoryTools.Forms;


namespace StoryTools
{
    public partial class StoryToolsFunctions
    {
        private Excel.Application app;

        private void OnStoryToolsLoad(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
            app.WorkbookOpen += OnWorkBookActive;
        }

        private void OnWorkBookActive(Excel.Workbook Wb)
        {
            StyleHelper.AddStyle(app, "LogContent", "宋体", 14, false, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
            StyleHelper.AddStyle(app, "LogTitle", "宋体", 16, true, Excel.Constants.xlCenter, Excel.Constants.xlCenter);
        }

        private void ButtonExportCSV_Click(object sender, RibbonControlEventArgs e)
        {
            string csvPath = ConfigManager.Get().GetConfig(Defination.CsvPathKey);

            Excel.Range rng = app.ActiveWorkbook.ActiveSheet.UsedRange;

            DataTable originData = DoExcel.MakeRangeToDataTabel(rng);

            string[] textLiensTitle = new string[] { "name", "fileType", "id", "speaker", "speakertext", "dialog", "dialogtext", "speed", "protecttime", "anime", "start" };
            string[] slectionTitle = new string[] { "name", "fileType", "id", "dialog", "dialogtext", "count" };
            string[] speakerLocalizaiton = new string[] { "speaker", "speakertext" };
            string[] dialogLocalizaiton = new string[] { "dialog", "dialogtext" };

            DoExcel.SaveStoryCsv(originData, slectionTitle, csvPath, Defination.FileTypeSelection);
            DoExcel.SaveStoryCsv(originData, textLiensTitle, csvPath, Defination.FileTypeTextLine);
        }

        private void ButtonConfigManager_Click(object sender, RibbonControlEventArgs e)
        {
            MyForm.MainForm mainForm = new MyForm.MainForm();
            mainForm.Show();
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

        private void ButtonApplendLang_Click(object sender, RibbonControlEventArgs e)
        {
            string localizationCfgPath = ConfigManager.Get().GetConfig(Defination.LocalizationPathKey);

            string fileName = Path.GetFileNameWithoutExtension(app.ActiveWorkbook.Name);

            DataTable originData = DoExcel.MakeRangeToDataTabel(app.ActiveWorkbook.ActiveSheet.UsedRange);
            DataTable localizationData = DoCsv.LoadCsv(localizationCfgPath);
            localizationData.Columns[0].ColumnName = "key";
            localizationData.Columns[1].ColumnName = "zh_cn";
            string[] localizationLines = new string[] { "dialog", "dialogtext" };

            DoExcel.AppendLocalizationCsv(originData, localizationData, localizationLines, localizationCfgPath, fileName);
        }
    }
}

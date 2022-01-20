using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoryTools
{
    public partial class StoryToolsFunctions
    {
        Application app;
        private void StoryToolsFunctions_Load(object sender, RibbonUIEventArgs e)
        {
            app = Globals.ThisAddIn.Application;
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void ButtonExportToCSV_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet sheet = app.ActiveWorkbook.Worksheets[1];
            ExcelToCsv.ExportToCsv(sheet.UsedRange,"", sheet.UsedRange.Rows.Count, "dialog", "dialogtext");
            
        }
    }
}

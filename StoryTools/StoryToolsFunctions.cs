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
        private Application excelApp = null;
        private void StoryToolsFunctions_Load(object sender, RibbonUIEventArgs e)
        {
            excelApp = Globals.ThisAddIn.Application;
        }

        private void ButtonGo_Click(object sender, RibbonControlEventArgs e)
        {
            Range selction = excelApp.ActiveCell;
            selction.Value = "Go";
        }
    }
}

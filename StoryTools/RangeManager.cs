using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace StoryTools
{
    internal static class RangeManager
    {
        public static void InitRange(Excel.Application app, Excel.Range rng, string styleName, params string[] args)
        {
            Excel.Range tableContentRange = rng;
            tableContentRange.Style = app.ActiveWorkbook.Styles[styleName];
            tableContentRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
            tableContentRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            if (args != null)
            {
                tableContentRange.Value = new string[3] { args[0], args[1], args[2] };
            }
        }
    }
}

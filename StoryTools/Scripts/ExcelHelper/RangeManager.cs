using Excel = Microsoft.Office.Interop.Excel;

namespace StoryTools.Scripts.ExcelHelper
{
    internal static class RangeManager
    {
        public static void InitRange(Excel.Workbook workbook, Excel.Range rng, string styleName, params string[] args)
        {
            Excel.Range tableContentRange = rng;
            tableContentRange.Style = workbook.Styles[styleName];
            tableContentRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
            tableContentRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            if (args != null)
            {
                tableContentRange.Value = new string[3] { args[0], args[1], args[2] };
            }
        }
    }
}

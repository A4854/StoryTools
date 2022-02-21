using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace StoryTools
{
    internal static class StyleManager
    {
        public static void AddStyle(Excel.Application app,string styleName, string fontName, int fontSize, bool isBold, params object[] args)
        {
            Excel.Style style = app.ActiveWorkbook.Styles.Add(styleName);
            style.Font.Name = fontName;
            style.Font.Size = fontSize;
            style.Font.Bold = isBold;

            style.HorizontalAlignment = (Excel.XlHAlign)args[0];
            style.VerticalAlignment = (Excel.XlVAlign)args[1];
        }
    }
}

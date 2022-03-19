﻿using StoryTools.Scripts.Global;
using System.Collections.Generic;
using System.Linq;
using Data = System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace StoryTools.Scripts.DataHelper
{
    internal static class DoExcel
    {
        public static int GetColumnID(IEnumerable<string> stringList, string targetName)
        {
            int ret = 0;
            if (stringList.Contains(targetName))
            {
                ret = stringList.TakeWhile(i => i != targetName).Count() + 1;
            }
            return ret;
        }

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

        public static Data.DataTable MakeRangeToDataTabel(Excel.Range rng)
        {
            string[] columnName = Utils.ConvertRowToStringArray(rng.Rows[Defination.AttributeLine].Value2);

            //init datatable
            Data.DataTable dataTable = new Data.DataTable();
            for (int i = 0; i < columnName.Length; i++)
            {
                Data.DataColumn dataColumn = new Data.DataColumn
                {
                    ColumnName = columnName[i]
                };
                dataTable.Columns.Add(dataColumn);
            }

            //fill data to datatable
            for (int i = 0; i < rng.Rows.Count; i++)
            {
                Data.DataRow dataRow = dataTable.NewRow();
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    dataRow[columnName[j]] = rng.Cells[i + 1, j + 1].Value2;
                }
                dataTable.Rows.Add(dataRow);
            }
            // dataTable.Rows.RemoveAt(0);
            return dataTable;
        }

        public static void SaveStoryCsv(Data.DataTable originData, string[] titles, string csvPath, string slectType)
        {
            Data.DataTable dataTable = new Data.DataTable();

            DoDataTable.CopyColumnsToEmpty(originData, ref dataTable, titles);

            Data.DataRow[] title1 = DoDataTable.GetTitleRows(dataTable, Defination.TitleLine);

            try
            {
                Data.DataRow[] dt1 = dataTable.Select($"{Defination.FileTypeTag}=\'{slectType}\'");

                if (title1.Count() == 0 || dt1.Count() == 0)
                {
                    return;
                }
                DoDataTable.SaveStoryCsvByRows(title1, dt1, csvPath);
            }
            catch (Data.SyntaxErrorException)
            {
            }
        }


    }
}
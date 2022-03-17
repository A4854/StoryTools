using Microsoft.Office.Interop.Excel;
using StoryTools.Scripts.CsvHelper;
using StoryTools.Scripts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using Data = System.Data;

namespace StoryTools.Scripts.ExcelHelper
{
    internal static class ExcelManager
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

        public static string[] ConvertRowToStringArray(Array values)
        {
            // create a new string array
            string[] arr = new string[values.Length];
            // loop through the 2-D System.Array and populate the 1-D String Array
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    arr[i - 1] = "";
                else
                    arr[i - 1] = values.GetValue(1, i).ToString();
            }
            return arr;
        }

        public static void ExportToCsv(Range rng, string path, int rowCount, params string[] content)
        {
            string[] attrs = ExcelManager.ConvertRowToStringArray(rng.Rows[Defination.AttributeLine].Value2);
            if (attrs.Intersect(content).Count() == 0)
            {
                return;
            }

            //get colomn indexes
            int[] colomnArray = new int[content.Length];
            for (int i = 0; i < content.Length; i++)
            {
                colomnArray[i] = ExcelManager.GetColumnID(attrs, content[i]);
            }

            //init datatable
            Data.DataTable dataTable = new Data.DataTable();
            for (int i = 0; i < colomnArray.Length; i++)
            {
                dataTable.Columns.Add("");
            }

            //fill data to datatable
            for (int i = 0; i < rowCount; i++)
            {
                Data.DataRow dataRow = dataTable.NewRow();
                for (int j = 0; j < colomnArray.Length; j++)
                {
                    dataRow[j] = rng[i + 1, colomnArray[j]].Value;
                }
                dataTable.Rows.Add(dataRow);
            }
            dataTable.Rows.RemoveAt(0);
            CsvManger.SaveCSV(dataTable, path);

        }
    }
}

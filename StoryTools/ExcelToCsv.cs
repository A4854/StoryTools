using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Data = System.Data;

namespace StoryTools
{
    internal static class ExcelToCsv
    {
        public static void ExportToCsv(Range rng, string path, int rowCount, params string[] content)
        {
            string[] attrs = Utils.ConvertToStringArray(rng.Rows[Defination.AttributeLine].Value2);
            if (attrs.Intersect(content).Count() == 0)
            {
                return;
            }
            
            //get colomn indexes
            int[] colomnArray = new int[content.Length];
            for (int i = 0; i < content.Length; i++)
            {
                colomnArray[i] = Utils.GetColumnID(attrs, content[i]);
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
                    dataRow[j] = rng[i+1,colomnArray[j]+1].Value;
                }
                dataTable.Rows.Add(dataRow);
            }
            Utils.SaveCSV(dataTable, @"D:\doc\策划文档\系统文档\#功能文档\E_ELF\3.0\go.csv");

        }
    }
}

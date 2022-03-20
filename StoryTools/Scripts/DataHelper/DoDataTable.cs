using StoryTools.Scripts.Global;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Data = System.Data;

namespace StoryTools.Scripts.DataHelper
{
    internal class DoDataTable
    {
        public static void PickUpColumnsOnOrigin(Data.DataTable dataTable, params string[] pickUpContent)
        {
            int offset = 0;
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                if (!pickUpContent.Contains(dataTable.Columns[i].ColumnName))
                {
                    dataTable.Columns.RemoveAt(i-offset);
                    offset++;
                }
            }
        }

        public static void SeperateDataByColumnsTittle(Data.DataTable dataTable, ref Data.DataTable result, params string[] pickUpContent)
        {
            result.Clear();
            result = dataTable.Copy();
            int count = result.Columns.Count;
            for (int i = 0; i < count; i++)
            {
                if (!pickUpContent.Contains(result.Columns[i].ColumnName))
                {
                    result.Columns.RemoveAt(i);
                    i--;
                    count--;
                }
            }
        }

        public static void PickUpRowsOnOrigin(Data.DataTable from, string selection)
        {
            Data.DataRow[] ds = from.Select(selection);
            from.Clear();
            AddRows(ref from, ds);
        }

        public static void AddRows(ref Data.DataTable dt, IEnumerable<Data.DataRow> drs)
        {
            int count = dt.Columns.Count;
            if (count <= drs.First().ItemArray.Length)
            {
                for (int i = 0; i < drs.First().ItemArray.Length - count; i++)
                {
                    dt.Columns.Add("");
                }
            }
            IEnumerator<Data.DataRow> enumerator = drs.GetEnumerator();
            while (enumerator.MoveNext())
            {
                dt.ImportRow(enumerator.Current);
            }
        }

        public static Data.DataTable CreateDateTableWithRows(IEnumerable<Data.DataRow> rows)
        {
            Data.DataTable dt = new Data.DataTable();
            AddRows(ref dt, rows);
            return dt;
        }

        public static Data.DataRow[] GetTitleRows(Data.DataTable dt, int titleCount)
        {
            return dt.Rows.Cast<Data.DataRow>().TakeWhile(x => dt.Rows.IndexOf(x) < Defination.TitleLine).ToArray();
        }

        public static void SaveStoryCsvByRows(IEnumerable<Data.DataRow> title, IEnumerable<Data.DataRow> content, string csvPath)
        {
            int fileNameColumn = title.ElementAt(Defination.AttributeLine - 1).ItemArray.TakeWhile(x => x.ToString() != Defination.FileNameTag).Count();
            int fileTypeColumn = title.ElementAt(Defination.AttributeLine - 1).ItemArray.TakeWhile(x => x.ToString() != Defination.FileTypeTag).Count();

            Data.DataTable table = new Data.DataTable();
            table = title.First().Table.Clone();
            IEnumerator<Data.DataRow> enumerator = content.GetEnumerator();
            
            AddRows(ref table, title);
            string fileName = content.ElementAt(0).ItemArray[fileNameColumn].ToString();
            
            while (enumerator.MoveNext())
            {
                if (fileName != enumerator.Current.ItemArray[fileNameColumn].ToString())
                {
                    table.Columns.RemoveAt(fileNameColumn);
                    table.Columns.RemoveAt(fileTypeColumn - 1);
                    DoCsv.SaveCSV(table, Path.Combine(csvPath, fileName + ".csv"));
                    fileName = enumerator.Current.ItemArray[fileNameColumn].ToString();
                    table.Clear();
                    AddRows(ref table, title);
                }
                table.ImportRow(enumerator.Current);
            }
            table.AcceptChanges();
            table.Columns.RemoveAt(fileNameColumn);
            table.Columns.RemoveAt(fileTypeColumn - 1);
            
            DoCsv.SaveCSV(table, Path.Combine(csvPath, fileName + ".csv"));
        }

    }
}

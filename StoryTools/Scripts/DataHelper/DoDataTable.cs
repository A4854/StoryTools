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
                    dataTable.Columns.RemoveAt(i - offset);
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

            IEnumerator<Data.DataRow> enumerator = content.GetEnumerator();
            string fileName = content.ElementAt(0).ItemArray[fileNameColumn].ToString();
            Data.DataTable table = new Data.DataTable();
            table = title.First().Table.Clone();
            AddRows(ref table, title);

            while (enumerator.MoveNext())
            {
                if (fileName != enumerator.Current.ItemArray[fileNameColumn].ToString())
                {
                    table.Columns.RemoveAt(fileNameColumn);
                    table.Columns.RemoveAt(fileTypeColumn - 1);
                    DoCsv.SaveCSV(table, Path.Combine(csvPath, fileName + ".csv"));
                    table = new Data.DataTable();
                    table = title.First().Table.Clone();
                    fileName = enumerator.Current.ItemArray[fileNameColumn].ToString();
                    AddRows(ref table, title);
                }
                table.ImportRow(enumerator.Current);
            }
            table.AcceptChanges();
            table.Columns.RemoveAt(fileNameColumn);
            table.Columns.RemoveAt(fileTypeColumn - 1);
            DoCsv.SaveCSV(table, Path.Combine(csvPath, fileName + ".csv"));
        }

        public static void SaveLocalizationByRows(Data.DataTable localizationTable, IEnumerable<Data.DataRow> content, string savePath)
        {
            IEnumerator<Data.DataRow> enumerator = content.GetEnumerator();

            AddRows(ref localizationTable, content);

            DoCsv.SaveCSV(localizationTable, savePath);
        }

        public static bool CheckTitleValidation(Data.DataTable originData, Data.DataTable targetData)
        {
            bool validation = false;
            return validation;
;
        }

        //public static Data.DataTable AppendDataTable(Data.DataTable originData, Data.DataTable targetData)
        //{
        //    Data.DataTable dataTable = new Data.DataTable();

        //    DoDataTable.SeperateDataByColumnsTittle(originData, ref dataTable, titles);
        //    //dataTable = localizationData.Clone();
        //    dataTable.Columns[0].ColumnName = targetData.Columns[0].ColumnName;
        //    dataTable.Columns[1].ColumnName = targetData.Columns[1].ColumnName;
        //    for (int i = 0; i < Defination.TitleLine; i++)
        //    {
        //        dataTable.Rows.RemoveAt(0);
        //    }

        //    try
        //    {
        //        Data.DataRow[] drs1 = targetData.Select($"key LIKE '{selection}%'");

        //        for (int i = 0; i < drs1.Length; i++)
        //        {
        //            if (drs1[i][0].ToString().Substring(selection.Length, 1) == "_")
        //            {
        //                targetData.Rows.Remove(drs1[i]);
        //            }
        //        }

        //        DoDataTable.SaveLocalizationByRows(targetData, dataTable.Rows.Cast<Data.DataRow>(), savePath);
        //    }
        //    catch (Data.SyntaxErrorException)
        //    {
        //    }

        //}

    }
}

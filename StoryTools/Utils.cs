using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace StoryTools
{
    public static class Utils
    {
        public static int GetColumnID(IEnumerable<string>stringList, string targetName)
        {
            int ret = 0;
            if (stringList.Contains(targetName))
            {
                ret = stringList.TakeWhile(i => i != targetName).Count();
            }
            return ret;
        }
        public static string[] ConvertToStringArray(Array values)
        {
            // create a new string array
            string[] arr = new string[values.Length];
            // loop through the 2-D System.Array and populate the 1-D String Array
            for (int i = 1; i < values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    arr[i - 1] = "";
                else
                    arr[i - 1] = values.GetValue(1, i).ToString();
            }
            return arr;
        }
        public static void SaveCSV(DataTable dt, string fullPath)
        {
            FileInfo fi = new FileInfo(fullPath);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }
            FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            string data = "";
            //写出列名称
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data += dt.Columns[i].ColumnName.ToString();
                if (i < dt.Columns.Count - 1)
                {
                    data += ",";
                }
            }
            sw.WriteLine(data);
            //写出各行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string str = dt.Rows[i][j].ToString();
                    str = str.Replace("\"", "\"\"");
                    if (str.Contains(',') || str.Contains('"') || str.Contains('\r') || str.Contains('\n'))
                    {
                        str = string.Format("\"{0}\"", str);
                    }

                    data += str;
                    if (j < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
            }
            sw.Close();
            fs.Close();
        }
    }
}

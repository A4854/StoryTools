using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace StoryTools.Scripts.DataHelper
{
    internal class DoCsv
    {
        public static void SaveCSV(DataTable dt, string fullPath)
        {

            StreamWriter writer;
            int columns = dt.Columns.Count;

            using (writer = new StreamWriter(fullPath, false, Encoding.UTF8))
            {
                foreach (DataRow row in dt.Rows)
                {
                    bool comma = false;
                    for (int c = 0; c < columns; c++)
                    {
                        if (!comma) comma = true;
                        else writer.Write(',');

                        string go = row[c].ToString();
                        char HEAD;
                        string _HEAD = "";
                        for (int i = 0; i < go.Length; i++)
                        {
                            HEAD = go[i];
                            if (HEAD == '\"')
                            {
                                _HEAD += "\"";
                            }
                            _HEAD += HEAD;
                        }
                        if (_HEAD.ToCharArray().Contains(','))
                        {
                            _HEAD = "\"" + _HEAD + "\"";
                        }
                        writer.Write(_HEAD.ToString());
                    }
                    writer.WriteLine();
                }
            }
        }
        /***
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行        
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行
        临兵斗者，皆阵列前行
        ***/
        public static DataTable LoadCsv(string filePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isFirstLine = true;
                int columnCount = 0;
                while (reader.Peek() != -1)
                {
                    int quote = 0;
                    string line = reader.ReadLine();
                    List<string> ls = new List<string>();
                    bool isFirstChar = true;
                    bool lastIsQuote = false;
                    char HEAD;
                    string _HEAD = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        HEAD = line[i];

                        if (HEAD == ',' | i == line.Length)
                        {
                            lastIsQuote = false;
                            if (quote % 2 == 0 || i == line.Length)
                            {
                                if (i == line.Length)
                                {
                                    _HEAD += HEAD.ToString();
                                }
                                if (isFirstLine && _HEAD == "")
                                {
                                    continue;
                                }
                                ls.Add(_HEAD);

                                _HEAD = "";
                                quote = 0;
                                isFirstChar = true;
                            }
                            else
                            {
                                _HEAD += HEAD.ToString();
                                isFirstChar = false;
                            }
                        }
                        else if (HEAD == '\"')
                        {
                            quote++;
                            if (!isFirstChar)
                            {
                                if (lastIsQuote)
                                {
                                    _HEAD += HEAD.ToString();
                                    lastIsQuote = false;
                                }
                                else
                                {
                                    lastIsQuote = true;
                                }
                            }
                            if (isFirstChar)
                            {
                                isFirstChar = false;
                            }
                        }
                        else if (!char.IsWhiteSpace(HEAD))
                        {
                            lastIsQuote = false;
                            _HEAD += HEAD.ToString();
                            isFirstChar = false;
                        }
                    }
                    if (_HEAD != "")
                    {
                        ls.Add(_HEAD);
                    }
                    if (isFirstLine)
                    {
                        columnCount = ls.Count;
                        for (int i = 0; i < ls.Count; i++)
                        {
                            dt.Columns.Add();
                        }
                        isFirstLine = false;
                    }
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < columnCount; i++)
                    {
                        string m = ls.Count == i ? "" : ls[i].ToString();
                        dr[i] = m;
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}

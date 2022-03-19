using System.Data;
using System.IO;
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

                        writer.Write(row[c].ToString());
                    }
                    writer.WriteLine();
                }
            }

        }
    }
}

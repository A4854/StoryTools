using System;

namespace StoryTools.Scripts.Global
{
    internal class Utils
    {
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
    }
}

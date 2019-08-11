using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Human_Readable_Duration_Format
    {
        
        public static string formatDuration(int seconds)
        {
            
            long time = seconds;
            string result = "";
            Dictionary<long, string> list = new Dictionary<long, string>();
            list.Add(1, "second");
            list.Add(60, "minute");
            list.Add(60 * 60, "hour");
            list.Add(24 * 60 * 60, "day");
            list.Add(7 * 24 * 60 * 60, "week");
            list.Add(30 * 7 * 24 * 60 * 60, "month");
            list.Add(12 * 30 * 7 * 24 * 60 * 60, "year");
            string[] temp = new string[8];
            int i = 0;
            foreach (var item in list.OrderByDescending(p => p.Key))
            {
                if (time >= item.Key)
                {
                    long count = time / item.Key;
                    temp[i] += count;
                    temp[i] += " ";
                    if (count < 2)
                    {
                        temp[i] += item.Value;

                    }
                    else
                    {
                        temp[i] += item.Value;
                        temp[i] += "s";
                    }
                    time -= (time / item.Key) * item.Key;
                }
                i++;
            }
            bool added = false;
            for (int j = 0; j < 8; j++)
            {
                if (!String.IsNullOrEmpty(temp[j]))
                {
                    bool check = true;
                    for (int l1 = j + 1; l1 < 8; l1++)
                        if (!String.IsNullOrEmpty(temp[l1]))
                            check = false;

                    if (added && check)
                    {
                        result += " and ";
                        result += temp[j];

                    }
                    else if (added)
                    {
                        result += ", ";
                        result += temp[j];

                    }
                    else
                    {
                        result += " ";
                        result += temp[j];

                    }
                    added = true;
                }

            }
            if (String.IsNullOrEmpty(result))
                result = "now";
            if (result[result.Length - 1] == ' ')
                result = result.Remove(result.Length - 1);
            return result.TrimStart();
        }
    }
}

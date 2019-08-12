using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Merged_String_Checker
    {

        public static bool isMerge(string s, string part1, string part2)
        {
            Console.WriteLine(s + "  " + part1 + "   " + part2);
            if (s.Length != part2.Length + part1.Length)
                return false;

            int j1 = 0, j2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((!String.IsNullOrEmpty(part2) && !String.IsNullOrEmpty(part1)) && (s[i] != part1[j1] && s[i] != part2[j2]))
                {

                    return false;
                }

                else if ((!String.IsNullOrEmpty(part2) && !String.IsNullOrEmpty(part1)) && (s[i] == part1[j1] && s[i] == part2[j2]))
                {
                    if (i + 1 < s.Length && (!String.IsNullOrEmpty(part2) && !String.IsNullOrEmpty(part1)))
                    {
                        if (part1[j1 + 1] == s[i + 1])
                            j1++;
                        else
                            j2++;
                    }
                }
                else if (!String.IsNullOrEmpty(part2) && s[i] == part2[j2])
                {
                    if (j2 < part2.Length - 1)
                        j2++;
                }
                else
                {
                    if (!String.IsNullOrEmpty(part1) && j1 < part1.Length - 1)
                        j1++;
                }
            }
            return true;
        }
    }
}

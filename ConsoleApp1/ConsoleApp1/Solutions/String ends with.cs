using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class String_ends_with
    {
        public static bool Solution(string str, string ending)
        {

            int i = ending.Length > 0 ? ending.Length - 1 : 0;

            for (int j = str.Length - 1; j >= 0 &&  i >= 0; j--)
            {
                if (String.IsNullOrEmpty(ending) ||str[j] == ending[i])
                {
                    if (i == 0)
                        return true;
                }
                else
                    break;
                i--;
            }

            return false;
        }
    }
}

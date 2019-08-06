using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Reversed_Strings
    {
        public static string Solution(string str)
        {
            string result = "";
            for(int i = str.Length-1;i>=0;i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}

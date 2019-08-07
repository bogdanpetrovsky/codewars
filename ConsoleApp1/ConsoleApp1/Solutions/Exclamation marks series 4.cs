using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Exclamation
    {
        public static string Remove(string s)
        {
            s = s.Replace("!","" );
            s = s.Trim();
            s += "!";
            return s;
        }
    }
}

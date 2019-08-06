using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class TwoToOne
    {

        public static string Longest(string s1, string s2)
        {
            string sum = s1 + s2;
            char[] array = sum.ToCharArray();
            Array.Sort(array);
            var result = (from a in array 
                         select a).ToList().Distinct();
            string resulting = "";
            foreach(char a in result)
            {
                resulting += a;
            }
            return resulting;
        }
    }
}

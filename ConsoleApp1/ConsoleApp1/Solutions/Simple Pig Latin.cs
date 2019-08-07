using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Simple_Pig_Latin
    {
        public static string PigIt(string str)
        {
            string result = "";
            var array = str.Split(" ");
            foreach(string a in array)
            {
                string temp = a;
                if(a.Length > 1)
                {
                    temp += a[0];
                    temp += "ay";
                    temp = temp.Remove(0,1);
                }
                else
                {
                    temp += "ay";
                }
                result += temp;
                result += " ";
            }
            result = result.Remove(result.Length -1);
            return result;
        }
    }
}

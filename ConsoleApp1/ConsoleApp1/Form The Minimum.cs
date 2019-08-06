using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Form_The_Minimum
    {
        public static long MinValue(int[] a)
        {
            bool[] array = new bool[10];
            for(int i =0;i<a.Length;i++)
            {
                array[a[i]] = true;
            }
            string result = "";
            for(int i = 0;i<10;i++)
            {
                if (array[i])
                    result += i.ToString();
            }
            return Convert.ToInt64(result);
        }
    }
}

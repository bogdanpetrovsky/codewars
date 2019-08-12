using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Range_Extraction
    {
        public static string Extract(int[] args)
        {
            string result = "";
            for(int i =0;i<args.Length;i++)
            {
                if (i != 0)
                    result += ",";
                int j = i + 1;
                while (j < args.Length && args[i] + j - i == args[j])
                    j++;
                if (j - i - 1 >= 2)
                {
                    result += args[i];
                    result += "-";
                    result += args[j - 1];
                    i = j - 1;
                }
                else
                    result += args[i];

            }
            //Console.WriteLine(result);
            return result;  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Stop_gninnipS_My_sdroW
    {
        public static string SpinWords(string sentence)
        {
            string[] input = sentence.Split(" ");
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i != 0)
                    result += " ";
                if (input[i].Length >= 5)
                {
                    for (int j = input[i].Length - 1; j >= 0; j--)
                        result += input[i][j];
                }
                else
                    result += input[i];
            }
            return result;
        }
    }
}

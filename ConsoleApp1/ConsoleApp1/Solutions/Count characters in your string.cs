using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Count_characters_in_your_string
    {
        public static Dictionary<char, int> Count(string str)
        {
            char[] array = str.ToCharArray();
            Array.Sort(array);
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i =0;i<array.Length; i++)
            {
                int j = 1;
                while (i + j < array.Length && array[i] == array[i + j])
                    j++;
                dict.Add(array[i], j);
                i += j-1;
            }
            return dict;
        }
    }
}

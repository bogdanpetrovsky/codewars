using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vowel_Count
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            foreach(char a in str)
            {
                if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                    vowelCount++;
            }

            return vowelCount;
        }
    }
}

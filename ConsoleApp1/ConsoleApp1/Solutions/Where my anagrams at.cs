using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Where_my_anagrams_at
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            char[] first = word.ToCharArray();
            Array.Sort(first);

            List<string> result = new List<string>();
            foreach(string wor in words)
            {
                char[] second = wor.ToCharArray();
                Array.Sort(second);
                for(int i = 0;i<second.Length && i < first.Length;i++)
                {
                    if (second[i] != first[i])
                        break;
                    else
                    {
                        if (i == second.Length - 1 && i == first.Length - 1)
                            result.Add(wor);
                    }
                }
            }
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }
            return result;
        }
    }
}

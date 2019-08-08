using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Alphabetic_Anagrams
    {
        public static BigInteger Factorial(int n)
        {
            BigInteger sum = 1;
            for(int i =1;i<=n;i++)
            {
                sum *= i;
            }
            return sum;
        }
        public static long ListPosition(string value)
        {
            List<char> actual = new List<char>();
            List<char> native = new List<char>();
            BigInteger result = 0;
            for (int i =0;i<value.Length;i++)
            {
                native.Add(value[i]);
                actual.Add(value[i]);
            }
            BigInteger sum = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            native.Sort();

            for(int i =0;i<native.Count;i++)
            {

                int temp = 1;
                int j = i;
                while(i < native.Count - 1 && native[i] == native[i+1])
                {
                    temp++;
                    i++;
                }
                i = j;
                dict.Add(native[i], temp);
                while (i < native.Count -1  && native[i] == native[i + 1])
                    i++;
            }
            int count = native.Count;
            //foreach (var item in dict)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            for (int i =0;i<actual.Count;i++)
            {
                BigInteger temp = 0;
                int j = 0;
                while (j < native.Count - 1 && actual[i] != native[j])
                {
                    temp = Factorial(count - 1);
                    dict[native[j]]--;
                    foreach (var item in dict)
                    {
                        temp /= Factorial(item.Value);
                    }
                    if(dict[native[j]] < 1)
                    {
                        native.RemoveAt(j);

                    }
                    count--;
                    while(j<native.Count -1  && native[j] == native[j+1])
                        j++;
                    result += temp;
                    Console.WriteLine(temp);
                }
                count--;
                dict[native[j]]--;
                if (dict[native[j]] < 1)
                {
                    native.RemoveAt(j);

                }

                // Console.WriteLine(temp);
            }

            //for(int i =0;i<native.Count;i++)
            //{
            //    Console.WriteLine(native[i]);
            //}
            //Console.WriteLine();

            Console.WriteLine();
            return Convert.ToInt64(result.ToString());
        }
    }
}

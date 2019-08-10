using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Strings_Mix
    {
        public static string Mix(string s1, string s2)
        {
            List<char> array1 = new List<char>();
            List<char> unsorted1 = new List<char>();
            for (int i =0;i<s1.Length;i++)
            {
                if(s1[i] >= 'a' && s1[i] <= 'z')
                {
                    array1.Add(s1[i]);
                    unsorted1.Add(s1[i]);
                }  
            }

            List<char> array12 = new List<char>();
            List<char> unsorted12 = new List<char>();
            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] >= 'a' && s2[i] <= 'z')
                {
                    array12.Add(s2[i]);
                    unsorted12.Add(s2[i]);
                }
            }

            array1.Sort();
            Dictionary<char, int> d1 = new Dictionary<char, int>();
            for(int i =0;i<array1.Count;i++)
            {
                int j = i;
                while (j < array1.Count && array1[i] == array1[j])
                    j++;
                d1.Add(array1[i], j-i);
                i = j-1;
            }

            array12.Sort();
            Dictionary<char, int> d12 = new Dictionary<char, int>();
            for (int i = 0; i < array12.Count; i++)
            {
                int j = i;
                while (j < array12.Count && array12[i] == array12[j])
                    j++;
                d12.Add(array12[i], j-i);
                i = j-1;
            }


            foreach (var item1 in d1.OrderByDescending(key => key.Value ))
            {

                if (item1.Value < 2)
                    d1.Remove(item1.Key);

            }
            foreach (var item2 in d12.OrderByDescending(key => key.Value))
            {

                if (item2.Value < 2)
                    d12.Remove(item2.Key);
            }


            foreach (var item1 in d1.OrderByDescending(key => key.Value))
            {
                Console.WriteLine(item1.Key + " " + item1.Value);


            }
            Console.WriteLine();
            foreach (var item2 in d12.OrderByDescending(key => key.Value))
            {
                Console.WriteLine(item2.Key + " " + item2.Value);

            }


            string result = "";
            string resulttemp = "";
            int countska = 0;
            foreach (var item1 in d1.OrderByDescending(key => key.Value))
            {
                foreach (var item2 in d12.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine(item1.Key + " " + item1.Value + "---" + item2.Key + " " + item2.Value);
                    bool done = false;
                    if(item1.Value > item2.Value)
                    {
                        if (countska > item1.Value)
                        {
                            result += resulttemp;
                            resulttemp = "";
                            countska = 0;
                        }
                        result += "1:";
                        for (int i = 0; i < item1.Value;i++)
                            result += item1.Key;
                        result += "/";
                        d12.Remove(item1.Key);
                        d1.Remove(item1.Key);
                        done = true;


                    }
                    else if(item1.Value == item2.Value)
                    {
                        if(item1.Key < item2.Key)
                        {   
                            if(countska > item1.Value)
                            {
                                result += resulttemp;
                                resulttemp = "";
                                countska = 0;
                            }

                            result += "1:";
                            for (int i = 0; i < item1.Value; i++)
                                result += item1.Key;
                            result += "/";
                            d12.Remove(item1.Key);
                            d1.Remove(item1.Key);
                            done = true;
                        }
                        else if(item1.Key == item2.Key)
                        {
                            countska = item1.Value;
                            resulttemp += "=:";
                            for (int i = 0; i < item2.Value; i++)
                                resulttemp += item2.Key;
                            resulttemp += "/";
                            d12.Remove(item2.Key);
                            d1.Remove(item1.Key);
                            done = true;
                        }
                        else
                        {
                            if (countska > item2.Value)
                            {
                                result += resulttemp;
                                resulttemp = "";
                                countska = 0;
                            }
                            result += "2:";
                            for (int i = 0; i < item2.Value; i++)
                                result += item2.Key;
                            result += "/";
                            d1.Remove(item2.Key);
                            d12.Remove(item2.Key);

                        }



                    }
                    else
                    {
                        if (countska > item2.Value)
                        {
                            result += resulttemp;
                            resulttemp = "";
                            countska = 0;
                        }
                        if (item2.Key == item1.Key)
                            done = true;
                        result += "2:";
                        for (int i = 0; i < item2.Value;i++)
                            result += item2.Key;
                        result += "/";
                        d1.Remove(item2.Key);
                        d12.Remove(item2.Key);

                    }
                    if (done)
                    {
                        if(d1.Count == 0 && d12.Count > 0)
                        {

                            for(int i =0;i<d12.Count;i++)
                            {
                                if (countska > item2.Value)
                                {
                                    result += resulttemp;
                                    resulttemp = "";
                                    countska = 0;
                                }
                                result += "2:";
                                for (int j = 0; j < d12.First().Value; j++)
                                    result += d12.First().Key;
                                result += "/";
                                d1.Remove(item2.Key);
                                d12.Remove(item2.Key);

                            }
                        }
                        break;
                    }

                }

            }
            result += resulttemp;

            result = result.Remove(result.Length - 1);

            return result;
        }
    }
}

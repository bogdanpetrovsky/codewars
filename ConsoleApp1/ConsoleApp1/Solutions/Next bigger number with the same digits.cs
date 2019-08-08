using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Next_bigger_number_with_the_same_digits
    {
        public static long NextBiggerNumber(long n)
        {

            List<long> array = new List<long>();
            int counter = 0;
            long temp = n;
            while (temp > 0)
            {
                array.Add(temp % 10);
                counter++;
                temp /= 10;
            }
            array.Reverse();

            List<long> resulting = new List<long>();
            List<long> templ = new List<long>();
            for (int i = array.Count - 1; i >= 1; i--)
            {
                if (array[i] > array[i - 1])
                {

                    for (int j = 0; j < i - 1; j++)
                        resulting.Add(array[j]);
                    for (int l = i - 1; l < array.Count; l++)
                        templ.Add(array[l]);
                    templ.Sort();
                    //templ.Reverse();

                    for (int j = 0; j < templ.Count; j++)
                    {

                        if (templ[j] > array[i - 1])
                        {
                            resulting.Add(templ[j]);
                            templ.RemoveAt(j);
                            break;
                        }
                    }
                    for (int j = 0; j < templ.Count; j++)
                        resulting.Add(templ[j]);
                    break;
                }
            }
            if (resulting.Count != 0)
            {
                string result = "";
                for (int i = 0; i < resulting.Count; i++)
                    result += resulting[i].ToString();
                if (result[0] == '0')
                    return -1;
                return Convert.ToInt64(result);
            }
            else
                return -1;
        }
    }
}

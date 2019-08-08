using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class The_observed_PIN
    {
        public static List<List<int>> Checker()
        {
            #region
            List<List<int>> result = new List<List<int>>();
            // 0   
            result.Add(new List<int>() { 0, 8 });

            //1
            result.Add(new List<int>() { 1, 2, 4 });

            //2
            result.Add(new List<int>() { 2, 1, 3, 5 });

            //3
            result.Add(new List<int>() { 3, 2, 6 });

            //4
            result.Add(new List<int>() { 4, 1, 5, 7 });

            //5
            result.Add(new List<int>() { 5, 2, 6, 4, 8 });

            //6
            result.Add(new List<int>() { 6, 3, 5, 9 });

            //7
            result.Add(new List<int>() { 7, 4, 8 });

            //8
            result.Add(new List<int>() { 5, 7, 8, 9, 0 });

            //9
            result.Add(new List<int>() { 6,8, 9});
            #endregion
            return result;
        }
        public static List<string> GetPINs(string observed)
        {
            List<List<int>> combination = Checker();
            List<int> numbers = new List<int>();

            int zerocount = 0;
            while(zerocount < observed.Length && observed[zerocount] == '0')
            {
                zerocount++;
            }

            int number = Convert.ToInt32(observed);

            while (number > 0)
            {
                numbers.Add(number % 10);
                number /= 10;
            }
            while(zerocount > 0)
            {
                numbers.Add(0);
                zerocount--;
            }

            numbers.Reverse();
            List<string> result = new List<string>();
            int[] iterators = new int[numbers.Count];

            bool stop = true;
            while(stop)
            {
                string temp = "";
                for(int i =iterators.Length-1;i>=0;i--)
                {
                    if(iterators[i] > combination[numbers[i]].Count - 1)
                    {
                        iterators[i] = 0;
                        if (i - 1 < 0)
                        {
                            stop = false;
                            break;
                        }

                        iterators[i - 1]++;
                        
                    }
                }
                if (!stop)
                    break;
                for(int i =0;i<numbers.Count;i++)
                {
                    temp += combination[numbers[i]][iterators[i]].ToString();
                }
                result.Add(temp);

                iterators[iterators.Length - 1]++;
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Square_n__Sum
    {
        public static int SquareSum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i] * n[i];
            }
            return sum;
        }
    }
}

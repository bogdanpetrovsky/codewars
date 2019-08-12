using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
   
    class Total_increasing_or_decreasing_numbers_up_to_a_power_of_10
    {
        public static BigInteger TotalIncDec(int n)
        {
            return Choose(n + 10, 10) + Choose(n + 9, 9) - 10 * n - 1;
        }

        private static BigInteger Choose(int n, int k)
        {
            k = Math.Min(k, n - k);
            BigInteger res = 1;
            for (int i = 1; i <= k; i++)
            {
                res *= n - k + i;
                res /= i;
            }
            return res;
        }
        
    }
}

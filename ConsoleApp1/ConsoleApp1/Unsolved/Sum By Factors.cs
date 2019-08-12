using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sum_By_Factors
    {
        public static bool isPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        public static string sumOfDivided(int[] lst)
        {
            return "";
        }
    }
}

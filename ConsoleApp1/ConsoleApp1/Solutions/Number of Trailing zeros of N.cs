using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Number_of_Trailing_zeros_of_N
    {
        public static int TrailingZeros(int n)
        {
            int result = 0;
            result += n / 5;
            int mult = 25;
            while (n >= mult)
            {
                result += n / mult;
                mult *= 5;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1
{
    class Perimeter_of_squares_in_a_rectangle
    {
        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger sum = 0;
            BigInteger first = 1;
            BigInteger last = 0;
            sum = 1;
            for(BigInteger i = 1;i<=n;i++)
            {
                sum += first + last;
                BigInteger temp = last;
                last = first;
                first = temp + first;

            }
            sum *= 4;
            return sum;
        }
    }
}

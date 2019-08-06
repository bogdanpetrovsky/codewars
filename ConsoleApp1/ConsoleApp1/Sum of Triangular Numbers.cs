using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sum_of_Triangular_Numbers
    {
        public static int SumTriangularNumbers(int n)
        {
            int sum = 0;
           
            for(int i =0;i<=n;i++)
            {
                sum += i*(n-i + 1);
            }
            return sum;
        }
    }
}

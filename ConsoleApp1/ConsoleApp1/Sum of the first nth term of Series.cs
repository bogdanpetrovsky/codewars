using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sum_of_the_first_nth_term_of_Series
    {
        public static string seriesSum(int n)
        {
            double sum = 0;
            for(double i = 1;i<3*n + 1;i+=3)
            {
                sum += 1.0 / i;
            }
            string result = String.Format("{0:F2}", sum);

            return result;
        }

    }
}

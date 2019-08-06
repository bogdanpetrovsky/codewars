using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Number
    {
        public static long DigitalRoot(long n)
        {
            bool check = true;
            long sum = 0;
            while(check || sum >= 10)
            {
                if (!check)
                {
                    n = sum;
                    sum = 0;
                }
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;

                }
                check = false;
            }
            
            return sum;
        }
    }
}

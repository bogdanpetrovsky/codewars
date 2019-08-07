using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Is_this_a_triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            int[] array = new int[] { a, b, c };
            Array.Sort(array);
            Array.Reverse(array);
            if (array[0] < array[1] + array[2] && array[2] > 0)
            {
                return true;
            }
            return false;
        }
    }
}

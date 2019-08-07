using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class ArrayDif
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray(); 
        }
    }
}

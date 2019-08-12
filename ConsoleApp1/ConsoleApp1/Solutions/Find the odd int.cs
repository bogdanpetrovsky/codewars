using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Find_the_odd_int
    {
        public static int find_it(int[] seq)
        {
            Array.Sort(seq);
            for(int i =0;i<seq.Length;i++)
            {
                int j = 1;
                while (i + j < seq.Length && seq[i + j] == seq[i])
                    j++;
                if (j % 2 != 0)
                    return seq[i];
                i += j - 1;
            }
            return seq[0];
        }
    }
}

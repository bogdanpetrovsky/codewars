using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Maximum_subarray_sum
    {
        public static int MaxSequence(int[] arr)
        {
            int max_sum = 0;
            int cur_sum = 0;
            for(int i =0;i<arr.Length;i++)
            {
                cur_sum += arr[i];
                if (cur_sum > max_sum)
                    max_sum = cur_sum;
                if (cur_sum < 0)
                    cur_sum = 0;
            }
            return max_sum;
        }
    }
}

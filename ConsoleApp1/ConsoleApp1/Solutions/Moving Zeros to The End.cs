using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Moving_Zeros_to_The_End
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int[] result = new int[arr.Length];
            int j = 0;
            int counter = 0;
            for(int i =0;i<arr.Length;i++)
            {
                if (arr[i] != 0)
                {
                    result[j] = arr[i];
                    j++;
                }
                else
                    counter++;
            }
            for (int i = 0; i < counter; i++)
            {
                result[j] = 0;
                j++;
            }
            return result;
        }
    }
}

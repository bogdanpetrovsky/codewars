using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Ones_and_Zeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int sum = 0;
            int level = 1;
            for(int i = BinaryArray.Length-1;i>=0;i--)
            {
                if(BinaryArray[i] == 1)
                {
                    sum += level;
                }
                level *= 2;
            }
            return sum;
        }
    }
}

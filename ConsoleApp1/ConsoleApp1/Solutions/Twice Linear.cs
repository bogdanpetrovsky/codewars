using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Twice_Linear
    {
        public static int counter = 0;
        public static List<int> array = new List<int>() { 1 };
        public static bool checker = false;
        public static void Fill()
        {
            while (array.Count < 1000000)
            {
                array.Add(array[counter] * 2 + 1);
                array.Add(array[counter] * 3 + 1);
                counter++;
            }
            array = array.Distinct().ToList();
            array.Sort();
        }
        public static int DblLinear(int n)
        {
            if(!checker)
            {
                Fill();
                checker = true;
            }
            for (int i = 0; i < n * 2; i++)
                Console.WriteLine(array[i]);
            return array[n];
        }
    }
}

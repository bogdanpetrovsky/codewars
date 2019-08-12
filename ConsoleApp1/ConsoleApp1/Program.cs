using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{


    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(Range_Extraction.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }));
        }
    }
}

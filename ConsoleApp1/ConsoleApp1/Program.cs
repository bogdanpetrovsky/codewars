using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{


    internal class Program
    {

        static void Main(string[] args)
        {
            Solving_Linear_Equations_N_x_N__Gauss__Part_1_ ls = new Solving_Linear_Equations_N_x_N__Gauss__Part_1_();
            Console.WriteLine(ls.Solve("1 2 0 7\r\n0 0 3 8\r\n0 5 6 9"));

        }
    }
}

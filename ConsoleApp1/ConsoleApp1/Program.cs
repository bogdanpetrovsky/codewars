using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{


    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("abba");
            list.Add("baba");
            list.Add("aabb");

            Console.WriteLine(Next_smaller_number_with_the_same_digits.NextSmaller(907));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Valid_Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ')')
                    count--;
                else
                    count++;
                if (count < 0)
                    return false;
            }
            if (count == 0)
                return true;
            else
                return false;
        }
    }
}

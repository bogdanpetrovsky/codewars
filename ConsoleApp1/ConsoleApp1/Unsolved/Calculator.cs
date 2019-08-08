using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calculator
    {
        public static string evaluate(string input)
        {
            string temp = input;
            temp = temp.Replace(" ", "");
            for(int i =0;i<temp.Length;i++)
            {
                string temporary = "";
                if(temp[i] == '/' || temp[i] == '*')
                {
                    string old = "";
                    old += temp[i - 1];
                    old += temp[i];
                    old += temp[i + 1]; 
                    double a = Convert.ToInt32(temp[i - 1]);
                    double b = Convert.ToInt32(temp[i + 1]);
                    double c = a / b;
                    if (temp[i] == '/')
                        temporary = c.ToString();
                    else
                        temporary = c.ToString();
                    temp = temp.Replace(old, temporary);
                }
            }
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Adding_Big_Numbers
    {
        public static string Add(string s1, string s2)
        {

            string result = "";
            char[] number1 = s1.ToCharArray();
            char[] number2 = s2.ToCharArray();
            
            Array.Reverse(number1);
            Array.Reverse(number2);
           
            int j = 0, i = 0;
            bool jump = false;
            while (i < number1.Length && j < number2.Length)
            {
                int a = Convert.ToInt32(number1[i].ToString());
                int b = Convert.ToInt32(number2[j].ToString());
                if (jump)
                {
                    a++;
                    jump = false;
                }

                if (a + b >= 10)
                {
                    result += ((a + b) % 10).ToString();
                    jump = true;
                }
                else
                    result += (a + b).ToString();

                i++;
                j++;
            }
            if (i < number1.Length)
            {
                while (i < number1.Length)
                {
                    int a = Convert.ToInt32(number1[i].ToString());
                    if (jump)
                    {
                        a++;
                        jump = false;
                    }

                    if (a >= 10)
                    {
                        result += ((a) % 10).ToString();
                        jump = true;
                    }
                    else
                        result += (a).ToString();

                    i++;
                }
            }
            else if (j < number2.Length)
            {
                while (j < number2.Length)
                {
                    int a = Convert.ToInt32(number2[j].ToString());
                    if (jump)
                    {
                        a++;
                        jump = false;
                    }

                    if (a >= 10)
                    {
                        result += ((a) % 10).ToString();
                        jump = true;
                    }
                    else
                        result += (a).ToString();

                    j++;
                }
            }
            else
            {
                i++;
            }
            if (jump)
                result += "1";
            string temp = "";
            for (int l = result.Length - 1; l >= 0; l--)
            {
                temp += result[l];
            }
            result = temp;
            while (result[0] == '0')
                result = result.Remove(0, 1);
            return result;

        }
    }
}

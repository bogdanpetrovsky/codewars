using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sum_Strings_as_Numbers
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
                int a = number1[i] == '1' ? 1 : 0;
                int b = number2[i] == '1' ? 1 : 0;
                if (jump)
                {
                    a++;
                    jump = false;
                }

                if (a + b > 1)
                {
                    result += ((a + b) % 2).ToString();
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
                    int a = number1[i] == '1' ? 1 : 0;
                    if (jump)
                    {
                        a++;
                        jump = false;
                    }

                    if (a > 1)
                    {
                        result += ((a) % 2).ToString();
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
                    int a = number2[j] == '1' ? 1 : 0; ;
                    if (jump)
                    {
                        a++;
                        jump = false;
                    }

                    if (a > 1)
                    {
                        result += ((a) % 2).ToString();
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
            while (result.Length > 1 && result[0] == '0')
                result = result.Remove(0, 1);
            return result;
        }
    }
}

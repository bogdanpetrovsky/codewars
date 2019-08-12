using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Longest_Common_Subsequence__Performance_version_
    {

        public static string lcs(char[] X,char[] Y,int m,int n)

        {
            if (m == 0 || n == 0)
                return "";
            if (X[m - 1] == Y[n - 1])
            {

                return (X[m - 1] + lcs(X, Y, m - 1, n - 1)).ToString();
            }
            else
                return lcs(X, Y, m, n - 1).Length > lcs(X, Y, m - 1, n).Length ? lcs(X, Y, m, n - 1) : lcs(X, Y, m - 1, n);
        }
        public static string Lcs(string a, string b)
        {
            char[] X = a.ToCharArray();
            char[] Y = b.ToCharArray();

            
            for (int j = 0; j < b.Length; j++)
            {

            }
            Array.Reverse(X);
            Array.Reverse(Y);
            string result  = lcs(X, Y, a.Length, b.Length);

            return result ; 
        }
    }
}

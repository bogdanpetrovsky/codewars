using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public static class  Square_into_Squares
    {
        public static string decompose(long n)
        {
            List<long> decomposeArray = Decomposer(n, n * n);

            // no valid solution exists
            if (decomposeArray == null) return null;

            // remove the last element
            decomposeArray.Remove(n);
            List<String> result = new List<String>();

            foreach (long ele in decomposeArray)
            {
                result.Add(ele.ToString());
            }
            string resulting = "";
            foreach (var item in result)
            {
                resulting += item;
                if(item != result[result.Count-1])
                resulting += " ";
            }

            return resulting;
        }


        public static List<long> Decomposer(long n, long remain)
        {
            // basic case
            if (remain == 0)
            {
                List<long> r = new List<long>();
                r.Add(n);
                return r;
            }

            // iterate all element less than n
            for (long i = n - 1; i > 0; i--)
            {
                if ((remain - i * i) >= 0)
                {
                    List<long> r = Decomposer(i, (remain - i * i));

                    // only get the answer
                    if (r != null)
                    {
                        r.Add(n);
                        return r;
                    }
                }
            }

            // no answer
            return null;
        }
    }
}

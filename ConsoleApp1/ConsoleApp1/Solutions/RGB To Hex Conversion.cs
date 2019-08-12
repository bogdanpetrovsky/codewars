using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class RGB_To_Hex_Conversion
    {
        public static string Rgb(int r, int g, int b)
        {
            if (r > 255)
                r = 255;
            if (r < 0)
                r = 0;
            if (g > 255)
                g = 255;
            if (g < 0)
                g = 0;
            if (b > 255)
                b = 255;
            if (b < 0)
                b = 0;

            String rtn = String.Empty;
            rtn = r.ToString("X2") + g.ToString("X2") + b.ToString("X2");

            return rtn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Greed_is_Good
    {

        public static int Score(int[] dice)
        {
            int[] tripleValue = { 0, 1000, 200, 300, 400, 500, 600 };
            int[] singleValue = { 0, 100, 0, 0, 0, 50, 0 };

            int value = 0;
            for (int dieSide = 1; dieSide <= 6; dieSide++)
            {
                int countRolls = dice.Where(outcome => outcome == dieSide).Count();
                value += tripleValue[dieSide] * (countRolls / 3) + singleValue[dieSide] * (countRolls % 3);
            }
            return value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;



namespace ConsoleApp1
{
    class Sudoku_Solution_Validator
    {
        public static bool Check(int i,int j, int[][] board)
        {
            int[] array = new int[9];
            int count = 0;
            for(int i1 = i;i1<=i+2;i1++)
            {
                for(int j1 = j;j1<=j+2;j1++)
                {
                    array[count] = board[i1][j1];
                    count++;
                }
            }
            Array.Sort(array);
            
            for(int i1 =0;i1<9;i1++)
            {
                if (array[i1] != i1 + 1)
                    return false;
            }
            return true;
        }
        public static bool ValidateSolution(int[][] board)
        {
            for(int i =0;i<9;i+=3)
            {
                for(int j = 0;j<9;j+=3)
                {
                    if (!Check(i, j, board))
                        return false;
                }
            }
            return true;
        }
    }
}

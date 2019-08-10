using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Battleship_field_validator
    {
        public static int[] check(int i, int j,int[,] field)
        {
            int[] position = new int[3];
            for(int l1 = i-1;l1<=i+1;l1++)
            {
                for(int l2 = j-1;l2<=j+1;l2++)
                {
                    if (l1 >= 0 && l1 < 10 && l2 >= 0 && l2 < 10 && field[l1, l2] == 1)
                    {

                        position[0] = l1;
                        position[1] = l2;
                        position[2]++;
                    }


                }
            }
            return position;
        }
        public static bool ValidateBattlefield(int[,] field)
        {
            bool[,] checker = new bool[10, 10];
            int[] sizes = new int[] { 1, 2, 3, 4 };
            int[,] fieldcopy = new int[10, 10];
            for(int i = 0;i< 10;i++)
            {
                for(int j = 0;j<10;j++)
                {
                    if(field[i,j] == 1)
                    {
                        int count = 1;
                        int l = j + 1;
                        while(l < 10 && field[i,l] == 1)
                        {
                            count++;
                            l++;
                        }
                        if (count > 1)
                        {
                            while(j != l)
                            {
                                fieldcopy[i, j] = count;
                                j++;
                            }

                        }

                    }
                }
            }
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (field[i, j] == 1)
                    {
                        int count = 1;
                        int l = i + 1;
                        while (l < 10 && field[l, j] == 1)
                        {
                            count++;
                            l++;
                        }
                        if (count > 1)
                        {
                            while (i != l)
                            {
                                fieldcopy[i, j] = count;
                                i++;
                            }

                        }

                    }
                }
            }
            for(int i =0;i<10;i++)
            {
                for(int j = 0;j<10;j++)
                {
                    if(fieldcopy[i,j] == 0 && field[i,j] == 1)
                    {
                        int[] temp = check(i, j, field);
                        if (temp[2] == 1)
                            fieldcopy[i, j] = 1;
                    }
                    
                }

            }
            Dictionary<int, int> game = new Dictionary<int, int>();
            game.Add(4, 16);
            game.Add(3, 18);
            game.Add(2, 12);
            game.Add(1, 4);
            for(int i =0;i<10;i++)
            {
                for(int j = 0;j<10;j++)
                {
                    if(fieldcopy[i,j] != 0)
                    {
                        game[fieldcopy[i, j]] -= fieldcopy[i, j];
                    }
                }
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write(fieldcopy[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            foreach (var item in game)
            {
                if (item.Value != 0)
                    return false;
            }

            return true;
        }
    }
}

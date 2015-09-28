using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectTheCoins
{
    class CollectTheCoins
    {
        static void Main(string[] args)
        {
            string[] inputRows = new string[4];
            for (int i = 0; i < 4; i++)
            {
                inputRows[i] = Console.ReadLine();
            }
            string movement = Console.ReadLine();
            int currentRow = 0, currentCol = 0, wallHit = 0, coins=0;
            foreach (char currentDirection in movement)
            {
                if (currentDirection == 'V')
                {
                    currentRow++;
                    if (currentRow >= inputRows.GetLength(0))
                    {
                        currentRow--;
                        wallHit++;
                        continue;
                    }
                    else if (currentCol >= inputRows[currentRow].Length)
                    {
                        currentRow--;
                        wallHit++;
                        continue;
                    }
                }
                else if (currentDirection == '>')
                {
                    currentCol++;
                    if (currentCol >= inputRows[currentRow].Length)
                    {
                        currentCol--;
                        wallHit++;
                        continue;
                    }
                }
                else if (currentDirection == '<')
                {
                    currentCol--;
                    if (currentCol < 0)
                    {
                        currentCol++;
                        wallHit++;
                        continue;
                    }
                }
                else if (currentDirection == '^')
                {
                    currentRow--;
                    if (currentRow < 0)
                    {
                        currentRow++;
                        wallHit++;
                        continue;
                    }
                    else if (currentCol >= inputRows[currentRow].Length)
                    {
                        currentRow++;
                        wallHit++;
                        continue;
                    }
                }

                if (inputRows[currentRow][currentCol].Equals('$'))
                {
                    coins++;
                }

            }
            Console.WriteLine("walls hit:{0} coins collected:{1}",wallHit,coins);
        }

    }
}


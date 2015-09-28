using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' });
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int j;
            int bestSum=int.MinValue, bestRow=0, bestCol=0,sum=0;
            int[,] myMatrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (j = 0; j < m; j++)
                {
                    myMatrix[i, j] = inputNumbers[j];
                }
            }
            for (int i = 0; i < n-2; i++)
            {
                for (j = 0; j < m-2; j++)
                {
                    sum = myMatrix[i, j] + myMatrix[i, j + 1] + myMatrix[i, j + 2] + 
                        myMatrix[i + 1, j] + myMatrix[i + 1, j + 1] + myMatrix[i + 1, j + 2] + 
                        myMatrix[i + 2, j] + myMatrix[i + 2, j + 1] + myMatrix[i + 2, j + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = i;
                        bestCol = j;
                    }
                    sum = 0;
                }

            }
            Console.WriteLine("Sum is {0} ", bestSum);
            for (int i = bestRow; i < bestRow + 3; i++)
            {
                Console.WriteLine();
                for (j = bestCol; j < bestCol + 3; j++)
                {
                    Console.Write("{0} ",myMatrix[i,j]);
                }
               
            }



        }
    }
}

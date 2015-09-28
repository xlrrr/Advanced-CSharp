using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbersArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.Write(numbersArr[0]+ " ");
            for (int i = 0; i < numbersArr.Length-1; i++)
            {
                if (numbersArr[i] < numbersArr[i + 1])
                {
                    Console.Write(numbersArr[i + 1] + " ");
                }
                if (numbersArr[i] >= numbersArr[i + 1])
                {
                    Console.WriteLine();
                    Console.Write(numbersArr[i+1]+ " ");
                   
                }
             }
            }
        }
    }


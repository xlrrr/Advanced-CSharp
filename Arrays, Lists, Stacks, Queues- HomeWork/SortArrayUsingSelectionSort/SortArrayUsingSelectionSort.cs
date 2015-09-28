using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayUsingSelectionSort
{
    class SortArrayUsingSelectionSort
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = intArray.Length - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int highValue = intArray[j];

                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = highValue;
                    }
                }
            }


                for (int i = 0; i < intArray.Length; i++)
                {
                    Console.WriteLine(intArray[i]);
                }
            }

        }
    }

            

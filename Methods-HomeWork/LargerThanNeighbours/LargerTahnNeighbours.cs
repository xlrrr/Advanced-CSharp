using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerTahnNeighbours
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(checkNeighbours(numbers, i));
            }
        }
        static bool checkNeighbours(int[] numArray, int position)
        {
            if ((position > 0 && position < numArray.Length - 1) && (numArray[position] > numArray[position - 1] && numArray[position] > numArray[position + 1])) return true;
            else return false;

        }
    }
}

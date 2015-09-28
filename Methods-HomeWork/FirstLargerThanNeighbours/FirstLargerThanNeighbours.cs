using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1};
            Console.WriteLine(getIndexOfElement(sequenceOne));
            Console.WriteLine(getIndexOfElement(sequenceTwo));
            Console.WriteLine(getIndexOfElement(sequenceThree));
        }
        static int getIndexOfElement (int[] givenArray)
        {
            for (int i = 0; i < givenArray.Length; i++)
            {
                bool temp = checkNeighbours(givenArray, i);
                if (temp)
                {
                    return i ;
                    break;
                }
            }
            return -1;
        }
        static bool checkNeighbours(int[] numArray, int position)
        {
            if ((position > 0 && position < numArray.Length - 1) && (numArray[position] > numArray[position - 1] && numArray[position] > numArray[position + 1])) return true;
            else return false;

        }
    }
}

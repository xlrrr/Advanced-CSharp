using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceOfEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] stringArr = Console.ReadLine().Split();

        for (int i = 0; i < stringArr.Length - 1; i++)
        {
            Console.Write(stringArr[i]+' ');
            if(!stringArr[i].Equals(stringArr[i+1])){
                Console.WriteLine();
            }
        }
        Console.WriteLine(stringArr[stringArr.Length - 1]);
        }

    }
}


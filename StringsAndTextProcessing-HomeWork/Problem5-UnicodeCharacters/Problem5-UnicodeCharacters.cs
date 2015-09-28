using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5_UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write("\\u" + ((int)inputArr[i]).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string substring = Console.ReadLine();
            int numOccurences = 0;
            int startIndex = 0;
            while (input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                numOccurences++;
                startIndex = input.IndexOf(substring, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
            }
            Console.WriteLine(numOccurences);
        }
    }
}

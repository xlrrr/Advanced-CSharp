using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string twenty = input.Length > 20 ? new string(input.Take(20).ToArray()) : input;
            Console.WriteLine(twenty.PadRight(20, '*'));
            
        }
    }
}

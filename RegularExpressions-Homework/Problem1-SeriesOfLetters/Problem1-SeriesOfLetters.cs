using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem1_SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"(.)\1+");
            Console.WriteLine(regex.Replace(text, "$1"));
        }
    }
}

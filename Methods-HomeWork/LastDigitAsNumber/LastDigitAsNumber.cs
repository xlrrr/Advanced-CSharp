using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitAsNumber
{
    class LastDigitAsNumber
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine(getLastDigitAsWord(digit));
        }
        static string getLastDigitAsWord(int number)
        {
            if (number % 10 == 0) return "zero";
            if (number % 10 == 1) return "one";
            if (number % 10 == 2) return "two";
            if (number % 10 == 3) return "three";
            if (number % 10 == 4) return "four";
            if (number % 10 == 5) return "five";
            if (number % 10 == 6) return "six";
            if (number % 10 == 7) return "seven";
            if (number % 10 == 8) return "eight";
            if (number % 10 == 9) return "nine";
            return "invalid";
        }
    }
}

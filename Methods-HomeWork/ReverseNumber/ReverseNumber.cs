using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(getReversedNumber(number));
            
        }
        static string getReversedNumber(double number)
        {
            string numberStr = Convert.ToString(number);
            string reversed = new string(numberStr.ToCharArray().Reverse().ToArray());
            return reversed;
        }
    }
}

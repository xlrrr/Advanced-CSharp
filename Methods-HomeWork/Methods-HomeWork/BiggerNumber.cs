using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_HomeWork
{
    class BiggerNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            getMax(firstNumber, secondNumber);
        }
        static void getMax(int firstNum, int secondNumb){
            int max = firstNum;
            if (max < secondNumb) max = secondNumb;
            Console.WriteLine(max);
    }
    }
}

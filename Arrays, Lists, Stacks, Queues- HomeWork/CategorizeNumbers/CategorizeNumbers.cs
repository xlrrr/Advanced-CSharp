using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(Double.Parse).ToArray();
            List<double> roundArr = new List<double>();
            List<double> nonZeroArr = new List<double>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 == 0)
                {
                    roundArr.Add(numbers[i]);
                }
                if (numbers[i] % 1 != 0)
                {
                    nonZeroArr.Add(numbers[i]);
                }
            }

            Console.WriteLine('[' + string.Join(", ", roundArr) + ']' + "-> min: " + roundArr.Min() + "max: " + roundArr.Max() + "sum: " +roundArr.Sum() +"avg:" +roundArr.Average());
            Console.WriteLine('[' + string.Join(", ", nonZeroArr) + ']' + "-> min: " + roundArr.Min() + "max: " + roundArr.Max() + "sum: " + roundArr.Sum()+"avg:" +roundArr.Average());

        }
    }
}





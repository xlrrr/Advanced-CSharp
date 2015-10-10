using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]), cols=int.Parse(dimensions[1]);
            string snake = Console.ReadLine();
            char[] snakeSymbol = snake.ToCharArray();
            string[] shotInfo = Console.ReadLine().Split(' ');
            char[,] field= new char[rows,cols];
            int impactRow = int.Parse(shotInfo[0]), impactCol = int.Parse(shotInfo[1]), impactRad = int.Parse(shotInfo[2]);
            int substract = 1, currentIndex=0,count=0;
            int j = cols - 1;
            for (int i = rows - 1; i >= 0; i--)
            {
                if (substract == -1)
                {
                    j = 0;
                }
                if (substract == 1)
                {
                    j = cols - 1;
                }
                for (; count<snakeSymbol.Count()-1 ; j=j-substract)
                {
                    field[i, j] = snakeSymbol[currentIndex];
                    currentIndex++;
                    if (currentIndex >= snakeSymbol.Count())
                    {
                        currentIndex = 0;
                    }
                    if (j == 0)
                    {
                        substract = -1;
                        
                    }
                    if (j == cols-1)
                    {
                        substract = 1;
                    }
                    count++;
                }
                count = 0;
            }
            for (int i = 0; i < rows-1; i++)
            {
                for (j = 0; j < cols; j++)
                {
                    Console.Write("{0}", field[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}

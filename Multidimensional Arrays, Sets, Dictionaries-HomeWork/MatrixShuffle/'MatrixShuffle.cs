using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] input = new string[n, m];
            int x1, y1, x2, y2;
            string temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    input[i, j] = Console.ReadLine();
                }
            }
            string endOf;
            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' });
                string comExecute = command[0];
                endOf = comExecute;

                if (comExecute != "swap" && comExecute!= "end") Console.WriteLine("INVALID INPUT");
                if (comExecute == "swap")
                {
                    x1 = int.Parse(command[1]);
                    y1 = int.Parse(command[2]);
                    x2 = int.Parse(command[3]);
                    y2 = int.Parse(command[4]);
                    temp = input[x1, y1];
                    input[x1, y1] = input[x2, y2];
                    input[x2, y2] = temp;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write("{0} ", input[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                if (comExecute == "end") break;
            }
        }
    }

}
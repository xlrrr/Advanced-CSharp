using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrixB
{
    class FillTheMatrixB
    {
        static void Main(string[] args)
        {

            int[,] myMatrix = new int[4, 4];
            int a = 1;
            for (int i = 0; i <4; i++)
            {
                {
                    if (i % 2 != 1) {
                    for (int j=0; j < 4; j++)
                    {
                        myMatrix[j, i] = a;
                        a++;
                    }
                }
                    if (i % 2== 1)
                    {
                        for (int j = 3; j >=0; j--)
                        {
                            myMatrix[j, i] = a;
                            a++;
                        }
                    }

                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", myMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

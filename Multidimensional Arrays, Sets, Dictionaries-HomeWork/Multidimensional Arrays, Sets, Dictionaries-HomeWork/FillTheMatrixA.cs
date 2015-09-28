using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays__Sets__Dictionaries_HomeWork
{
    class FillTheMatrixA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] myMatrix = new int[n, m];
            int a=1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myMatrix[j, i] = a;
                    a++;
                }
            }
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<m;j++){
                    Console.Write("{0} ", myMatrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];

            List<string> final = new List<string>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }
            //horizontal
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                List<string> tempList = new List<string>();
                tempList.Add(matrix[i, 0]);
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == matrix[i, j - 1])
                    {
                        tempList.Add(matrix[i, j]);
                        if (j == matrix.GetLength(1) - 1)
                        {
                            if (tempList.Count > final.Count)
                            {
                                final.Clear();
                                foreach (var item in tempList)
                                {
                                    final.Add(item);
                                }
                                tempList.Clear();
                                tempList.Add(matrix[i, j]);
                            }
                            else
                            {
                                tempList.Clear();
                                tempList.Add(matrix[i, j]);
                            }
                        }
                    }
                    else
                    {
                        if (tempList.Count > final.Count)
                        {
                            final.Clear();
                            foreach (var item in tempList)
                            {
                                final.Add(item);
                            }
                            tempList.Clear();
                            tempList.Add(matrix[i, j]);
                        }
                        else
                        {
                            tempList.Clear();
                            tempList.Add(matrix[i, j]);
                        }
                    }
                }
            }
            //vertical
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                List<string> tempList = new List<string>();
                tempList.Add(matrix[0, i]);
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] == matrix[j - 1, i])
                    {
                        tempList.Add(matrix[j, i]);
                        if (j == matrix.GetLength(0) - 1)
                        {
                            if (tempList.Count > final.Count)
                            {
                                final.Clear();
                                foreach (var item in tempList)
                                {
                                    final.Add(item);
                                }
                                tempList.Clear();
                                tempList.Add(matrix[j, i]);
                            }
                            else
                            {
                                tempList.Clear();
                                tempList.Add(matrix[j, i]);
                            }
                        }
                    }
                    else
                    {
                        if (tempList.Count > final.Count)
                        {
                            final.Clear();
                            foreach (var item in tempList)
                            {
                                final.Add(item);
                            }
                            tempList.Clear();
                            tempList.Add(matrix[j, i]);
                        }
                        else
                        {
                            tempList.Clear();
                            tempList.Add(matrix[j, i]);
                        }
                    }
                }
            }
            //diagonal
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                List<string> tempList = new List<string>();
                tempList.Add(matrix[0, i]);
                for (int j1 = 1, j2 = 1; j1 < matrix.GetLength(0); j1++, j2++)
                {
                    if (matrix[j1, j2] == matrix[j1 - 1, j2 - 1])
                    {
                        tempList.Add(matrix[j1, j2]);
                        if (j1 == matrix.GetLength(0) - 1)
                        {
                            if (tempList.Count > final.Count)
                            {
                                final.Clear();
                                foreach (var item in tempList)
                                {
                                    final.Add(item);
                                }
                                tempList.Clear();
                                tempList.Add(matrix[j1, j2]);
                            }
                            else
                            {
                                tempList.Clear();
                                tempList.Add(matrix[j1, j2]);
                            }
                        }
                    }
                    else
                    {
                        if (tempList.Count > final.Count)
                        {
                            final.Clear();
                            foreach (var item in tempList)
                            {
                                final.Add(item);
                            }
                            tempList.Clear();
                            tempList.Add(matrix[j1, j2]);
                        }
                        else
                        {
                            tempList.Clear();
                            tempList.Add(matrix[j1, j2]);
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(", ", final));
        }
    }
}
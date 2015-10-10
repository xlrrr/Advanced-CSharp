using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class BombBuster
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int[,] field = new int[int.Parse(dimensions[0]), int.Parse(dimensions[1])];
            for (int i = 0; i < int.Parse(dimensions[0]); i++)
            {
                string[] fieldValue = Console.ReadLine().Split(' ');
                for (int j = 0; j < int.Parse(dimensions[1]); j++)
                {
                    field[i, j] = int.Parse(fieldValue[j]);
                }
            }
            string bombCheck = Console.ReadLine();
            while (bombCheck != "cease fire!")
            {
                string[] BombInfo = bombCheck.Split(' ');
                int bombMainStrength = (int)Convert.ToChar(BombInfo[2]);
                int bombSecondStrength = Convert.ToInt32((Math.Round((double)bombMainStrength / 2.0, MidpointRounding.AwayFromZero)));
                int bombX = int.Parse(BombInfo[0]), bombY = int.Parse(BombInfo[1]);
                field[bombX, bombY] -= bombMainStrength;
                if (bombX + 1 <int.Parse(dimensions[0]))
                {
                    field[bombX + 1, bombY] -= bombSecondStrength;
                }
                if (bombX - 1 >= 0)
                {
                    field[bombX - 1, bombY] -= bombSecondStrength;
                }
                if (bombX - 1 >= 0 && bombY -1>= 0)
                {
                    field[bombX - 1, bombY - 1] -= bombSecondStrength;
                }
                if (bombX > 0 && bombY + 1 < int.Parse(dimensions[1]))
                {
                    field[bombX - 1, bombY + 1] -= bombSecondStrength;
                }
                if (bombX+1 < int.Parse(dimensions[0]) && bombY - 1 >= 0)
                {
                    field[bombX + 1, bombY - 1] -= bombSecondStrength;
                }
                if (bombX +1< int.Parse(dimensions[0]) && bombY +1 < int.Parse(dimensions[1]))
                {
                field[bombX + 1, bombY + 1] -= bombSecondStrength;
                }
                if(bombY-1>=0)
                {
                field[bombX, bombY - 1] -= bombSecondStrength;
                }
                if(bombY+1<int.Parse(dimensions[1]))
                {
                field[bombX, bombY +1] -= bombSecondStrength;
                }
                
                bombCheck = Console.ReadLine();
            }
            int destroyed = 0, maxField = int.Parse(dimensions[0]) * int.Parse(dimensions[1]);
            
            for (int i = 0; i < int.Parse(dimensions[0]); i++)
            {
                for (int j = 0; j < int.Parse(dimensions[1]); j++)
                {
                    if (field[i, j] <= 0) destroyed++;
                }
            }
            double dmgDone =Math.Round( (destroyed*100.0)/ maxField,1, MidpointRounding.AwayFromZero);
            Console.WriteLine("Destroyed bunkers: {0}", destroyed);
            Console.WriteLine("Damage done: {0:0.0} %", dmgDone);
            //for (int i = 0; i < int.Parse(dimensions[0]); i++)
            //{
            //    for (int j = 0; j < int.Parse(dimensions[1]); j++)
            //    {
            //        Console.Write("{0} ", field[i,j]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}

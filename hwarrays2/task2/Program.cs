using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arry = new int[3, 4];

            for (int i = 0; i < arry.GetLength(0); i++)
            {
                for (int j = 0; j < arry.GetLength(1); j++)
                {
                    arry[i, j] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < arry.GetLength(0); i++)
            {
                for (int j = 0; j < arry.GetLength(1); j++)
                {
                    Console.Write("   " + arry[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tttt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 2 to 9:");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    Console.WriteLine("please enter a number:");

                    arr[j, i] = int.Parse(Console.ReadLine());

                }
            }
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    Console.Write(arr[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
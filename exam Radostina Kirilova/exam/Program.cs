using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number from 2 to 9:");
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int[] arry = new int[n * n];
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   Console.WriteLine("please enter a number:");

                   arr[i, j] = int.Parse(Console.ReadLine());
                   
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.WriteLine("the sum of elements is:{0}",sum);
            
           
        }
    }
}

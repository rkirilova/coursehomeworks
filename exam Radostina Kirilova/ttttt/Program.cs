using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttttt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int n = int.Parse(Console.ReadLine());
            if (n<2 || n>9)
            {
                Console.WriteLine("the number is out of range");
            }
            int[,] arr = new int[n, n];
            int[] arry = new int[n * n];
            int count = 0;
           
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    Console.WriteLine("please enter a number:");

                    arr[j, i] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arry[count] = arr[j, i];
                    count++;
                }
              
            }
            ;
            for (int i = 0; i < arry.Length; i++)
            {
                Console.WriteLine(arry[i]);
            }
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            Console.WriteLine("the sum of elements is:{0}", sum);
        }
    }
}

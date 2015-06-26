using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[]arr= new int [11] {1,2,3,4,5,6,7,8,0,9,10};
            Console.WriteLine("please enter a numer");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                if (i==n)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}

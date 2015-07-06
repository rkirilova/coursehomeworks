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
            Console.WriteLine("please enter a nuber:");
            int a = int.Parse(Console.ReadLine());
            EvenOdd(a);
        }
        public static void EvenOdd(int a)
        {
            if (a%2==0)
            {
                Console.WriteLine("the nuber is even");
            }
            else
            Console.WriteLine("the number is odd");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter tird number:");
            int c = int.Parse(Console.ReadLine());
            Multiplication(a, b, c);
        }
        public static void Multiplication(int a, int b, int c)
        {
            int multi = a * b * c;
            Console.Write("The result of multiplication is: ");
            Console.WriteLine(multi);
        }
    }
}

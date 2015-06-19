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
            Console.WriteLine("please enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            Console.Write("остатък при делене: ");
            Console.WriteLine(a%b); 
        }
    }
}

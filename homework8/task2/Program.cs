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
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Print(name);

        }
        static void Print(string ourString)
        {
            Console.WriteLine("Greatings"+" "+ourString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            while (count <= n)
            {
                Console.WriteLine(count); count++;
            }
        }
    }
}

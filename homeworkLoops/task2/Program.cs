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
            Console.WriteLine("Please enter a nuber:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    continue;
                }
                Console.Write("не се дели на 3 и 7: {0}", i);
                Console.WriteLine();
            }
        }
    }
}
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
            Console.Write("Enter 5 numbers:");

            int biggest = 0;
            int smallest = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("n {0}: ", i);
                int n = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    biggest = n;
                    smallest = n;
                }
                else
                {
                    if (n > biggest)
                    {
                        biggest = n;
                    }
                    else if (n < smallest)
                    {
                        smallest = n;
                    }
                }
            }

            Console.WriteLine("Biggest: {0} Smallest: {1}", biggest, smallest);
        }
    }
}

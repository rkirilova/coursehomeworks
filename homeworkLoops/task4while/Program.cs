using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4while
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            while (c<=100)
            {
                if (c % 7 == 0 || c % 11 == 0)
                    Console.WriteLine(c);
                c++;
            }
        }
    }
}

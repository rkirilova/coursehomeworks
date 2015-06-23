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
            for (int i = 0; i <= 100; i++)
            {

                if (i % 7 == 0 || i % 11 == 0)
                {
                    Console.WriteLine("числото се дели на 7 или 11 : {0}", i);
                }
            }
        }
    }
}

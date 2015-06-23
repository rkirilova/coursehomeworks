using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            do
            {
                if (count % 7 == 0 || count % 11 == 0)
                    Console.WriteLine(count);
                count++;
                {

                }
            } while (count <= 100); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int cnum = 0;
            do
            {
                Console.WriteLine("pls ent a num");
                cnum = int.Parse(Console.ReadLine());
                sum = sum + cnum;
            } while (cnum !=0);
            Console.WriteLine(sum);
        }
    }
}

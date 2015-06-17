using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Моля въведете страна на триъгълника:");
           int a = int.Parse(Console.ReadLine());
           Console.WriteLine("Моля въведете височина на триъгълника:");
           int b = int.Parse(Console.ReadLine());
           int x = ((a * b) / 2);
            Console.Write ("Лицето на триъгълника е: ");
            Console.WriteLine (x);

        }
    }
}

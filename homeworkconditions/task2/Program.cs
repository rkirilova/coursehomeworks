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
            Console.WriteLine("Please enter your points: ");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(a*5);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(a*10);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(a*50);
                    break;


                default:
                    Console.WriteLine("invalid number");
                    break;
            }
        }
    }
}

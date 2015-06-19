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
            Console.WriteLine("please enter a symbol");
            string a = Console.ReadLine();
            switch (a)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "J":
                case "10 ":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine("valid card");
                    break;
                default:
                    Console.WriteLine("invalid card");
                    break;
            }

        }
    }
}
  

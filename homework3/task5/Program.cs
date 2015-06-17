using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plese enter your first name");
            string a = (Console.ReadLine());
            Console.WriteLine("please enter your last name");
            string b = (Console.ReadLine());
            string c = (a+"_"+b);
            Console.Write("Wellcome ");
            Console.WriteLine(c);

        }
    }
}

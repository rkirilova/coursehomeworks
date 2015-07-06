using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Plese enter second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter tird number:");
            int c = int.Parse(Console.ReadLine());
            int result= MaxNumber(MaxNumber(a,b),c);
            Console.Write("max number is:");
            Console.WriteLine(result);
        }  
        public static int MaxNumber( int a, int b)
        { if (a>b)
	{
		 return a;
	}
    return b;
    }
    }
}
   


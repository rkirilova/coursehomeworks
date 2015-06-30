using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwarrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arry = new int[,]{
                {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12}
            };
            for (int i = 0; i < arry.GetLength(0); i++)
            {
                for (int j = 0; j < arry.GetLength(1); j++)
                {
                    if (arry[i, j] % 2 == 0)
                    {
                        Console.WriteLine(arry[i, j]);
                    }
                }
            }
        }
    }
}

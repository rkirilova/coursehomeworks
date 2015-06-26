using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[] {5,3,2,1};
            int sum= 0;
            
            for (int i = 0; i < 4; i++)
            {
                if (i%2==0)
                {
                    sum = arr[i] + sum;
                }
            } Console.WriteLine(sum);

            
        }
    }
}

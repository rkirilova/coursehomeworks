﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkconditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            case 4:
                    Console.WriteLine("four");
                    break;
            case 5:
                    Console.WriteLine("five");
                    break;
                    case 6:
                        Console.WriteLine("six");
                    break;
            case 7:
                    Console.WriteLine("seven");
                    break;
            case 8:
                    Console.WriteLine("eight");
                    break;
            case 9:
                    Console.WriteLine("nine");
                    break;
                
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
        }
    }
}

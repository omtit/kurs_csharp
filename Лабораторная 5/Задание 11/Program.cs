﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if(a<b&&b<c)
            {
                Console.WriteLine("выполняется");
            }
            else
            {
                Console.WriteLine("не выполняется");
            }
        }
    }
}

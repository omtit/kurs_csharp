﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            a = double.Parse(Console.ReadLine());

            if(a<=0)
            {
                a = a * (-1);
           
            }

            Console.WriteLine(a);
        }
    }
}

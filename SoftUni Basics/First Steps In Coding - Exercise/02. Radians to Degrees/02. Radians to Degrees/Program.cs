﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine(degrees);
        }
    }
}

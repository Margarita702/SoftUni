﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English"); break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish"); break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

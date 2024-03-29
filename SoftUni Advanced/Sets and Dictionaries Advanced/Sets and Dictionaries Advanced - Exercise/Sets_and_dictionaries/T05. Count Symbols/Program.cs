﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (!symbols.ContainsKey(symbol))
                {
                    symbols[symbol] = 0;
                }
                symbols[symbol]++;
            }

            foreach (var (symbol, count) in symbols)
            {
                Console.WriteLine($"{symbol}: {count} time/s");
            }
        }
    }
}

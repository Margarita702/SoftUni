using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var endNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endNumber; i++)
            {
                int currentNumber = i;
                int currentNumberSum = 0;

                while (currentNumber != 0)
                {
                    currentNumberSum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                bool isSpecial = currentNumberSum == 5 || currentNumberSum == 7 || currentNumberSum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}

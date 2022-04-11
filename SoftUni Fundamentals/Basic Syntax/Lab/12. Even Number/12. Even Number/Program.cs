using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }

                Console.WriteLine("Please write an even number.");
            }
            while (number % 2 != 0);
        }
    }
}

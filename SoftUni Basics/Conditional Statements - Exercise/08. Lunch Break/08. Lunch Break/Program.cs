using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfSerial = Console.ReadLine();
            int dauertOfEpizod = int.Parse(Console.ReadLine());
            int timeOfBreak = int.Parse(Console.ReadLine());

            double restTime = timeOfBreak - timeOfBreak * 0.125 - timeOfBreak * 0.25;
          
            if (restTime >= dauertOfEpizod)
            {
                Console.WriteLine($"You have enough time to watch {nameOfSerial} and left with {Math.Ceiling(restTime-dauertOfEpizod)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameOfSerial}, you need {Math.Ceiling(dauertOfEpizod-restTime)} more minutes.");
            }
        }
    }
}

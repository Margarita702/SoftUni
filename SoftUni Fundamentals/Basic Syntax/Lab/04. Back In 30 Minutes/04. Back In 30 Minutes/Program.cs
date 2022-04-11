using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes > 60)
            {
                minutes = minutes - 60;
                hours += 1;
            }

            if (hours == 24)
            {
                hours = 0;
            }

            if (minutes == 60)
            {
                minutes = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}

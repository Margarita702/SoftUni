using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Metres_To_Kilometres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometeres = meters / 1000.0;
            Console.WriteLine($"{Math.Round(kilometeres, 2, MidpointRounding.AwayFromZero):F2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double annualPrice = double.Parse(Console.ReadLine());
            double shoes = annualPrice - (annualPrice * 0.4);
            double costume = shoes - (shoes * 0.2);
            double ball = 0.25 * costume;
            double accessories = ball * 0.2;
            double sum = annualPrice + shoes + costume + ball + accessories;
            Console.WriteLine(sum);
        }
    }
}

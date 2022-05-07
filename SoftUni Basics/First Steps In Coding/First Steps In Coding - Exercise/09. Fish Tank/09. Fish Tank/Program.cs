using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double procentage = double.Parse(Console.ReadLine());
            double vOfTheAguar = length * width * heigth;
            double vInLiters = vOfTheAguar / 1000;
            double space = procentage / 100;
            double neededLiters = vInLiters * (1 - space);

            Console.WriteLine(neededLiters);
        }
    }
}

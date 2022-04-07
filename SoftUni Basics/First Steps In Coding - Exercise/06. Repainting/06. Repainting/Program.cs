using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nailon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double razreditel = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double sumForNailon = (nailon + 2) * 1.50;
            double procentForPaint = 0.1 * paint;
            double sumForPaint = (paint + procentForPaint) * 14.50;
            double sumForRazreditel = razreditel * 5.00;
            double sumForBags = 0.40;
            double sumForMaterials = sumForBags + sumForNailon + sumForPaint + sumForRazreditel;
            double sumForMasters = (sumForMaterials * 0.30) * hours;
            double finalSum = sumForMaterials + sumForMasters;
            Console.WriteLine(finalSum);
        }
    }
}

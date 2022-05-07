using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double allPacketsOfPens = double.Parse(Console.ReadLine());
            double allPacketsOfMarkets = double.Parse(Console.ReadLine());
            double ltresToClean = double.Parse(Console.ReadLine());
            double percentageDiscount = double.Parse(Console.ReadLine());
            double sumPacketOfPens = allPacketsOfPens * 5.80;
            double sumPacketsOfMarkers = allPacketsOfMarkets * 7.20;
            double preparation = ltresToClean * 1.20;
            double sum = sumPacketOfPens + sumPacketsOfMarkers + preparation;
            percentageDiscount = percentageDiscount / 100;
            double discountSum = sum - (sum * percentageDiscount);
            Console.WriteLine(discountSum);
        }
    }
}

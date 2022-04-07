using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packetsOfFoodForDogs = double.Parse(Console.ReadLine());
            int packetsOfFoodForCats = int.Parse(Console.ReadLine());
            double sumForDogs = packetsOfFoodForDogs * 2.50;
            int sumForCats = packetsOfFoodForCats * 4;
            Console.WriteLine(sumForCats + sumForDogs + " lv.");
        }
    }
}

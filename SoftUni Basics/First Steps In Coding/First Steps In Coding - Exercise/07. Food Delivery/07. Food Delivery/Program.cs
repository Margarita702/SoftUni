using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenues = double.Parse(Console.ReadLine());
            double fishMenues = double.Parse(Console.ReadLine());
            double vegetarianMenues = double.Parse(Console.ReadLine());
            double sumForChicken = chickenMenues * 10.35;
            double sumForFish = fishMenues * 12.40;
            double sumForVegetarian = vegetarianMenues * 8.15;
            double sumForTheMenues = sumForChicken + sumForFish + sumForVegetarian;
            double dessertPrice = 0.2 * sumForTheMenues;
            double delivery = 2.50;
            double sum = sumForTheMenues + dessertPrice + delivery;
            Console.WriteLine(sum);
        }
    }
}

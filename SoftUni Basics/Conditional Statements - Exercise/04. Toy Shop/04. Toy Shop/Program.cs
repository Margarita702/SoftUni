using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int quantityPuzzle = int.Parse(Console.ReadLine());
            int quantityBarby = int.Parse(Console.ReadLine());
            int quantityBears = int.Parse(Console.ReadLine());
            int quantityMinions = int.Parse(Console.ReadLine());
            int quantityTirs = int.Parse(Console.ReadLine());

            double pricePuzzle = 2.60 * quantityPuzzle;
            double priceBarby = 3 * quantityBarby;
            double priceBears = 4.10 * quantityBears;
            double priceMinions = 8.20 * quantityMinions;
            double priceTirs = 2 * quantityTirs;

            double price = priceBarby + priceBears + priceMinions + priceTirs + pricePuzzle;
            int quantity = quantityBarby + quantityBears + quantityMinions + quantityPuzzle + quantityTirs;
            if (quantity >= 50)
            {
                price = 0.75 * price;
            }
            double naem = 0.10 * price;
            price = price - naem;

            if (price >= priceTrip)
            {
                var ostatak = price - priceTrip;
                Console.WriteLine("Yes! {0:F2} lv left.", ostatak);
            }
            else
            {
                double nedostig = priceTrip - price;
                Console.WriteLine("Not enough money! {0:F2} lv needed.", nedostig);
            }
        }
    }
}

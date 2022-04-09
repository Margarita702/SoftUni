using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50;
                }
                if (product == "water")
                {
                    price = 0.80;
                }
                if (product == "beer")
                {
                    price = 1.20;
                }
                if (product == "sweets")
                {
                    price = 1.45;
                }
                if (product == "peanuts")
                {
                    price = 1.60;
                }
            }
            if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40;
                }
                if (product == "water")
                {
                    price = 0.70;
                }
                if (product == "beer")
                {
                    price = 1.15;
                }
                if (product == "sweets")
                {
                    price = 1.30;
                }
                if (product == "peanuts")
                {
                    price = 1.50;
                }
            }
            if (city == "Varna")
            {
                if (product == "coffee")
                {
                    price = 0.45;
                }
                if (product == "water")
                {
                    price = 0.70;
                }
                if (product == "beer")
                {
                    price = 1.10;
                }
                if (product == "sweets")
                {
                    price = 1.35;
                }
                if (product == "peanuts")
                {
                    price = 1.55;
                }
            }
            double finalPrice = price * quantity;
            Console.WriteLine(finalPrice);
        }
    }
}

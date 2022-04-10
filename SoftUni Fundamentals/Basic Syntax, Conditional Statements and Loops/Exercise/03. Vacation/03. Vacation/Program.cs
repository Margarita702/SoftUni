using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double AmountOfPeople = double.Parse(Console.ReadLine());
            string Group = Console.ReadLine();
            string Day = Console.ReadLine();

            if (Group == "Students")
            {
                double price = 0;
                if (Day == "Friday")
                {
                    price = 8.45;
                }
                else if (Day == "Saturday")
                {
                    price = 9.80;
                }
                else if (Day == "Sunday")
                {
                    price = 10.46;
                }

                if (AmountOfPeople >= 30)
                {
                    double fee = price * AmountOfPeople;
                    double discount = fee * 0.15;
                    double finalPrice = fee - discount;
                    Console.WriteLine($"Total price: {finalPrice:F2}");
                }
                else
                {
                    double PriceWithoutDiscount = price * AmountOfPeople;
                    Console.WriteLine($"Total price: {PriceWithoutDiscount:F2}");
                }
            }
            else if (Group == "Business")
            {
                double price = 0;
                if (Day == "Friday")
                {
                    price = 10.90;
                }
                else if (Day == "Saturday")
                {
                    price = 15.60;
                }
                else if (Day == "Sunday")
                {
                    price = 16;
                }

                if (AmountOfPeople >= 100)
                {
                    double fee = price * (AmountOfPeople - 10);
                    Console.WriteLine($"Total price: {fee:F2}");
                }
                else
                {
                    double PriceWithoutDiscount = price * AmountOfPeople;
                    Console.WriteLine($"Total price: {PriceWithoutDiscount:F2}");
                }
            }
            else if (Group == "Regular")
            {
                double price = 0;
                if (Day == "Friday")
                {
                    price = 15;
                }
                else if (Day == "Saturday")
                {
                    price = 20;
                }
                else if (Day == "Sunday")
                {
                    price = 22.50;
                }

                if (AmountOfPeople >= 10 && AmountOfPeople <= 20)
                {
                    double fee = price * AmountOfPeople;
                    double discount = fee * 0.05;
                    double finalPrice = fee - discount;
                    Console.WriteLine($"Total price: {finalPrice:F2}");
                }
                else
                {
                    double PriceWithoutDiscount = price * AmountOfPeople;
                    Console.WriteLine($"Total price: {PriceWithoutDiscount:F2}");
                }
            }

        }
    }
}

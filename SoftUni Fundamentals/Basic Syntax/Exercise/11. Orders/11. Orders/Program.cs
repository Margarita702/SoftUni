﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int order = 0; order < numberOfOrders; order++)
            {
                double totalPerOrder = 0;

                double pricePerCapsule = double.Parse(Console.ReadLine());
                int numberOfDays = int.Parse(Console.ReadLine());
                int numberOfCapsules = int.Parse(Console.ReadLine());

                totalPerOrder = numberOfCapsules * pricePerCapsule * numberOfDays;

                Console.WriteLine($"The price for the coffee is: ${totalPerOrder:f2}");
                totalPrice += totalPerOrder;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}

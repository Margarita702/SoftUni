using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double saberPrize = double.Parse(Console.ReadLine());
            double robePrize = double.Parse(Console.ReadLine());
            double beltrPrize = double.Parse(Console.ReadLine());
            double costSaber = saberPrize * Math.Ceiling(students * 1.1);
            double costRobe = robePrize * students;
            double costBelts = beltrPrize * (students - Math.Floor(students / 6));
            double sum = costSaber + costRobe + costBelts;
            if (sum <= moneyHave) Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            else Console.WriteLine($"John will need {sum - moneyHave:f2}lv more.");
        }
    }
}

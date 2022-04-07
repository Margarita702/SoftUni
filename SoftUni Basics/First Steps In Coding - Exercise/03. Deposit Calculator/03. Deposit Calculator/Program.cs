using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());
            annualInterestRate = annualInterestRate / 100;
            double sum = depositSum + months * ((depositSum * annualInterestRate) / 12);
            Console.WriteLine(sum);
        }
    }
}

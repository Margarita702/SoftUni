using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double s = a * a;
                Console.WriteLine("{0:F3}", s);
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine("{0:F3}", s);
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double s = Math.PI * r * r;
                Console.WriteLine("{0:F3}", s);

            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double s = a * h / 2;
                Console.WriteLine("{0:F3}", s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWndow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int carpassed = 0;

            Queue<string> cars = new Queue<string>();
            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                int currGreenLight = greenLight;

                while (currGreenLight > 0 && cars.Count > 0)
                {
                    string currCar = cars.Dequeue();
                    if (currGreenLight - currCar.Length >= 0)
                    {
                        currGreenLight -= currCar.Length;
                        carpassed++;
                        continue;
                    }
                    if (currGreenLight + freeWndow - currCar.Length >= 0)
                    {
                        currGreenLight = 0;
                        carpassed++;
                        continue;
                    }

                    int hittedChar = currGreenLight + freeWndow;
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currCar} was hit at {currCar[hittedChar]}.");
                    Environment.Exit(0);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carpassed} total cars passed the crossroads.");
        }
    }
}

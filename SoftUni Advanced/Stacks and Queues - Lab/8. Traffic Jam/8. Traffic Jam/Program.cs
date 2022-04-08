using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int count = 0;
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        var car = cars.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        count++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");

        }
    }
}

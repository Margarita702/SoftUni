using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (clients.Count > 0)
                    {
                        Console.WriteLine(clients.Dequeue());
                    }
                }
                else
                {
                    clients.Enqueue(input);
                }
            }
            Console.WriteLine($"{clients.Count} people remaining.");

        }
    }
}

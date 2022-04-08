using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(people);
            int tossCount = int.Parse(Console.ReadLine());
            int currTosses = 1;
            while (queue.Count > 1)
            {
                var kidWithPotato = queue.Dequeue();
                if (currTosses != tossCount)
                {
                    currTosses++;
                    queue.Enqueue(kidWithPotato);
                }
                else
                {
                    currTosses = 1;
                    Console.WriteLine($"Removed {kidWithPotato}");

                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}

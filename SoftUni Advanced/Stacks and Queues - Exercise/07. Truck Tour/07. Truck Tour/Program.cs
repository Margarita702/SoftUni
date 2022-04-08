using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolCircles = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < petrolCircles; i++)
            {
                int[] information = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(information);
            }
            int startIndex = 0;


            while (true)
            {
                int totalLitres = 0;
                bool isComplete = true;
                foreach (var item in queue)
                {
                    int litres = item[0];
                    int distance = item[1];
                    totalLitres += litres;

                    if (totalLitres - distance < 0)
                    {
                        startIndex++;
                        int[] currPump = queue.Dequeue();
                        queue.Enqueue(currPump);
                        isComplete = false;
                        break;
                    }

                    totalLitres -= distance;

                }
                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}

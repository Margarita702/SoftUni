using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] quantityOfOrder = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(quantityOfOrder);
            int max = queue.Max();
            while (queue.Count>0&&quantityOfFood>=0)
            {
                int currOrders = queue.Peek();
                if (quantityOfFood-currOrders<0)
                {
                    break;
                }
                quantityOfFood-=currOrders;
                queue.Dequeue();
            }
            Console.WriteLine(max);
            if (queue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                //Console.Write("Orders left:");
                //foreach (var item in queue)
                //{
                //    Console.Write($" {item}");
                //}

                Console.Write($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}

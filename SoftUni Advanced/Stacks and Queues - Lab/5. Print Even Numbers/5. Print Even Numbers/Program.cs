using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(array);

            for (int i = 0; i < array.Length; i++)
            {
                int element = queue.Dequeue();
                if (element % 2 == 0)
                {
                    queue.Enqueue(element);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}

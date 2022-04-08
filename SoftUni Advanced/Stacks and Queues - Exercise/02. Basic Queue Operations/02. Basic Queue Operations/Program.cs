using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toPush = operations[0];
            int toPop = operations[1];
            int searchFor = operations[2];
            Queue<int> stack = new Queue<int>();
            for (int i = 0; i < toPush; i++)
            {
                stack.Enqueue(inputElements[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Dequeue();
            }
            if (stack.Contains(searchFor))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

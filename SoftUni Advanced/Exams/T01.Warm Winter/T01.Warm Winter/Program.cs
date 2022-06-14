using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hat = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var scarf = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            //int[] hats = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] scarfs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //  Queue <int> scarf = new Queue<int>(scarfs);
            //  Stack<int> hat = new Stack<int>(hats);
            List<int> sets = new List<int>();

            while (hat.Any() && scarf.Any())
            {
                if (hat.Peek()>scarf.Peek())
                {
                    int value=hat.Peek()+scarf.Peek();
                    sets.Add(value);
                    hat.Pop();
                    scarf.Dequeue();
                }
                else if (hat.Peek() < scarf.Peek())
                {
                    hat.Pop();
                }
                else
                {
                    scarf.Dequeue();
                    hat.Push(hat.Pop() + 1);
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
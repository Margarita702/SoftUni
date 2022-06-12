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
            int[] hats = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] scarfs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> hat = new Stack<int>(scarfs);
            Queue <int> scarf = new Queue<int>(hats);
           
            List<int> sets = new List<int>();

            while (hat.Any() && scarf.Any())
            {         
           
                int hatt=hat.Peek();
                int scarff = scarf.Peek();
                if (hatt>scarff)
                {
                    
                    sets.Add(hatt+scarff);
                    hat.Pop();
                    scarf.Dequeue();
                   
                }
                else if (hatt < scarff)
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
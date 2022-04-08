using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] operations=Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toPush = operations[0];
            int toPop = operations[1];
            int searchFor = operations[2];
          Stack<int> stack =new Stack<int>();
            for (int i = 0; i < toPush; i++)
            {
                stack.Push(inputElements[i]);
            }
            for (int i = 0; i < toPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(searchFor))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count>0)
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

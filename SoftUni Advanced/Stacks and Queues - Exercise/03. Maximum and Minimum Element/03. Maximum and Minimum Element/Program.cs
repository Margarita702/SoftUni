using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuery = int.Parse(Console.ReadLine());
            Stack<int> stack=new Stack<int>();
            for (int i = 0; i < numberOfQuery; i++)
            {
                int[] commnds = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int commandArgs=(commnds[0]);
                if (commandArgs==1)
                {
                    int element = commnds[1];
                    stack.Push(element);
                }
                else if (commandArgs==2)
                {
                   stack.Pop();
                }
                else if (commandArgs==3)
                {
                    if (stack.Count>0)
                    
                    Console.WriteLine(stack.Max());
                }
                else if (commandArgs==4)
                {
                    if (stack.Count > 0)
                    
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}

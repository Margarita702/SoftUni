using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            string commans = Console.ReadLine().ToLower();
            while (commans != "end")
            {
                var splittedcommand = commans.Split();
                if (splittedcommand[0] == "add")
                {
                    int firrst = int.Parse(splittedcommand[1]);
                    int second = int.Parse(splittedcommand[2]);
                    stack.Push(firrst);
                    stack.Push(second);
                }
                else if (splittedcommand[0] == "remove")
                {
                    int count = int.Parse(splittedcommand[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }

                commans = Console.ReadLine().ToLower();
            }
            int sum = 0;
            while (stack.Count != 0)
            {
                sum += stack.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

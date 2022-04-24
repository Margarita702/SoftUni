using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;
            foreach (var item in input)
            {
                if (item=='{'||
                    item=='['||
                    item=='(')
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Count == 0)
                { 
                isBalanced= false;
                    break;
                }
                if (item == '}' && stack.Peek() == '{')
                {
                   stack.Pop();
                }
               else if (item == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
               else if (item == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }
            if (isBalanced==false||stack.Count>0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text=string.Empty;
            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] commands = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "1")
                {
                    stack.Push(text);
                    text += commands[1];
                }
                else if (commands[0] == "2")
                {
                    stack.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(commands[1]));
                }
                else if (commands[0]=="3")
                {
                    Console.WriteLine(text[int.Parse(commands[1]) - 1]);
                }
                else if (commands[0] == "4")
                {
                    text=stack.Pop();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToReverse = Console.ReadLine();
            Stack<char> stach = new Stack<char>();

            foreach (var item in stringToReverse)
            {
                stach.Push(item);
            }
            while (stach.Count > 0)
            {
                Console.Write(stach.Pop());
            }
        }
    }
}

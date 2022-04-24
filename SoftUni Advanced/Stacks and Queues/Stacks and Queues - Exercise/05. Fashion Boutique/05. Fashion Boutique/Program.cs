using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] clothesInTheBox=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothesInTheBox);
            int numberOfRacks = 1;
            int sumOfClothes = 0;
            while (stack.Count>0)
            {
                sumOfClothes += stack.Peek();
                if (sumOfClothes <= capacityOfRack)
                {
                    stack.Pop();
                }
                else
                {
                    numberOfRacks++;
                    sumOfClothes = 0;
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}

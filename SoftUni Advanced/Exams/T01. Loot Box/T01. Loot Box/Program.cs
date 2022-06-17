using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Loot_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int claimedItems = 0;
            while (firstBox.Any()&&secondBox.Any())
            {
                int sum=firstBox.Peek()+secondBox.Peek();
                if (sum%2==0)
                {
                    claimedItems+=sum;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    int lastItemFromSecondBox = secondBox.Pop();
                    secondBox.Pop();
                    firstBox.Enqueue(lastItemFromSecondBox);
                }
                if (firstBox.Count<=0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                if (secondBox.Count<=0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break ;
                }
            }
            if (claimedItems>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}

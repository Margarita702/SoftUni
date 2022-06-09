using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Func<int[], int> minNumber = numbers =>
            {
                int minNum = int.MaxValue;
                foreach (var num in numbers)
                {
                    if (num < minNum)
                    {
                        minNum = num;
                    }
                }
                return minNum;
            };

            int minNum = minNumber(numbers);
            Console.WriteLine(minNum);
        }
    }
}

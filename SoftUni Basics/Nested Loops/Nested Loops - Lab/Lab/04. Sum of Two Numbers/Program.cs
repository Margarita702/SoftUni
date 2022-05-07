using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool flag = false;

            for (int first = start; first <= end; first++)
            {
                for (int second = start; second <= end; second++)
                {
                    combinations++;
                    if (first + second == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({first} + {second} = {magicNum})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        
    }
    }
}

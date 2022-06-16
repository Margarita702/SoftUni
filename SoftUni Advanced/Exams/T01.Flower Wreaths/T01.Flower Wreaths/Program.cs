using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Flower_Wreaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            var roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            int wreaths = 0;
            int flowers = 0;
            while (roses.Any() && lilies.Any())
            {
                var lilie = lilies.Pop();
                var rose = roses.Dequeue();
                int sum = lilie + rose;
                if (sum == 15)
                {
                    wreaths++;
                }
                
                else if (sum < 15)
                {
                    flowers += sum;
                }
                else 
                {
                    while (sum > 15)
                    {
                        sum -= 2;
                        if (sum == 15)
                        {
                            wreaths++;
                            break;
                        }
                        else if (sum < 15)
                        {
                            flowers += sum;
                            break;
                        }
                    }

                }
            }
            wreaths += flowers / 15;
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}

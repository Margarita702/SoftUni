using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т01.Cooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int bread = 0, cake = 0, pastry = 0, fruitPie = 0;

            while (liquids.Any()&&ingredients.Any())
            {
                int sum = liquids.Peek() + ingredients.Peek();
                if (sum==25)
                {
                    bread++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum==50)
                {
                    cake++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 75)
                {
                    pastry++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (sum == 100)
                {
                    fruitPie++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Push(ingredients.Pop()+3);
                }
            }
            if (bread>0&&cake>0&&pastry>0&&fruitPie>0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");

            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: { string.Join(", ", ingredients)}");

            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");

        }
    }
}

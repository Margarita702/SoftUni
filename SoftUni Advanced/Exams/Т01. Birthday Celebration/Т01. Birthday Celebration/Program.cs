using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т01.Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] queue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] stack = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> guests = new Queue<int>(queue);
            Stack<int> plates = new Stack<int>(stack);
            int wastedFood = 0;
            bool allGuestsAreFed = false;
            bool noMorePlates = false;
             
            while (true)
            {
                int guestValue = guests.Peek();
                int plateValue = plates.Peek();

                if (guestValue > plateValue)
                {
                    guests.Dequeue();
                    plates.Pop();
                  //Обръщаме опашката като сме премахнали госта със 
                  //съответната му стойност
                    guests = new Queue<int>(guests.Reverse());
                 //добавяме най-отпред(тъй като сме обърнали опашката) госта
                 //с новата стойност, която се е получила като сме извадили от
                 //стойността му-стойността на чинията
                 //и така добавяме новата му стойност(на същия гост)
                    guests.Enqueue(guestValue - plateValue);
                    //отново обръщаме опашката в първоначалния и ред
                    guests = new Queue<int>(guests.Reverse());
                }
                else if (guestValue < plateValue)
                {

                    plates.Pop();
                    guests.Dequeue();
                    wastedFood += plateValue - guestValue;
                }
                else
                {
                    plates.Pop();
                    guests.Dequeue();
                }

                if (guests.Count == 0)
                {
                    allGuestsAreFed = true;
                    break;
                }

                if (plates.Count == 0)
                {
                    noMorePlates = true;
                    break;
                }
            }

            if (allGuestsAreFed)
            {
                // If you have managed to fill up all of the guests,
                // print the remaining prepared plates of food, from the last entered – to the first,
                string result = string.Join(" ", plates.Reverse().ToList());
                Console.WriteLine($"Plates: {result}");
            }
            else if (noMorePlates)
            {
                // otherwise you must print the remaining guests,
                // by order of entrance – from the first entered – to the last. 
                string result = string.Join(" ", guests.ToList());
                Console.WriteLine($"Guests: {result}");
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");

        }

    }
}


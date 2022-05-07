using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstChar = Console.ReadLine();
            var secondChar = Console.ReadLine();
            var thirdChar = Console.ReadLine();

            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}

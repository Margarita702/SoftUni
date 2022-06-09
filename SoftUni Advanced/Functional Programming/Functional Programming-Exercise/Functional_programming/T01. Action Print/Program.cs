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
            string[] strings = Console.ReadLine()
               .Split();

            Action<string> printStrings = (x) => Console.WriteLine(x);

            strings.ToList().ForEach(x => printStrings(x));


        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Predicate_for_names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ').ToList();

            Func<string, bool> function = name => name.Length <= targetLength;

            names = names.Where(function).ToList();

            Action<List<string>> print = names => Console.WriteLine(string.Join(Environment.NewLine, names));

            print(names);

        }
    }
}

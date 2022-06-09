using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Knights_of_Honor
{
  
       
        internal class Program
        {
            static void Main(string[] args)
            {
                Action<string> printAddSir = _text => _text
                     .Split()
                     .ToList()
                     .ForEach(x => Console.WriteLine($"Sir {x}"));

                string text = Console.ReadLine();

                printAddSir(text);
            }
        }
    }


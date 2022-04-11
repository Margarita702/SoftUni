using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++) // <=

            {
                //Console.WriteLine(row);
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");// + " "

                }
                Console.WriteLine();
            }
        
    }
    }
}

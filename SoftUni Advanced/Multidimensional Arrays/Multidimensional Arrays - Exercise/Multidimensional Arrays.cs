using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Multimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rowsLength = matrixSize[0];
            int colsLength = matrixSize[1];

            int[,] matrix = new int[rowsLength, colsLength];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                // .Split(" ", StringSplitOptions.RemoveEmptyEntries) in order to pass second test
                int[] elements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
        }
    }
}

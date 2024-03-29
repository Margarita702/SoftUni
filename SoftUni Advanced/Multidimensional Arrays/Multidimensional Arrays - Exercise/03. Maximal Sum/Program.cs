﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximal_Sum
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

            int maxSquare3x3Sum = int.MinValue;
            int rowMaxIndex = 0;
            int colMaxIndex = 0;

            // matrix.GetLength(0) - 2
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSquareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSquareSum > maxSquare3x3Sum)
                    {
                        maxSquare3x3Sum = currentSquareSum;
                        rowMaxIndex = row;
                        colMaxIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSquare3x3Sum}");
            Console.WriteLine(matrix[rowMaxIndex, colMaxIndex] + " " + matrix[rowMaxIndex, colMaxIndex + 1] + " " + matrix[rowMaxIndex, colMaxIndex + 2]);
            Console.WriteLine(matrix[rowMaxIndex + 1, colMaxIndex] + " " + matrix[rowMaxIndex + 1, colMaxIndex + 1] + " " + matrix[rowMaxIndex + 1, colMaxIndex + 2]);
            Console.WriteLine(matrix[rowMaxIndex + 2, colMaxIndex] + " " + matrix[rowMaxIndex + 2, colMaxIndex + 1] + " " + matrix[rowMaxIndex + 2, colMaxIndex + 2]);
        }
    }
}

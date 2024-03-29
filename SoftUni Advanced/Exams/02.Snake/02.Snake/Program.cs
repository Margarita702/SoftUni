﻿using System;

namespace _02.Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int snakeRow = 0;
            int snakeCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }

            string input = Console.ReadLine();
            int food = 0;
            bool eaten = false;
            while (true)
            {
                matrix[snakeRow, snakeCol] = '-';
                snakeRow = MoveRow(snakeRow, input);
                snakeCol = MoveCol(snakeCol, input);
              
                if (!IsPositionValid(snakeRow, snakeCol, n, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (food>=10)
                {
                    eaten = true;
                    break;
                }
                if (matrix[snakeRow, snakeCol] == '*')
                {
                    food++;
                }

                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '-';
                    snakeRow = MoveRow(snakeRow, input);
                    snakeCol = MoveCol(snakeCol, input);
                    matrix[snakeRow, snakeCol] = 'S';
                } 

                matrix[snakeRow, snakeCol] = '.';
                input = Console.ReadLine();
            }

            if (eaten)
            {
                Console.WriteLine($"You won! You fed the snake.");
            }

                Console.WriteLine($"Food eaten: {food}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }
            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }
            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }
        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }
            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }

    }
}


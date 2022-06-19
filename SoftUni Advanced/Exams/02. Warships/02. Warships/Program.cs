using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Warships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];
            int firstPlayer = 0;
            int secondPlayer = 0;
            int totalCountShipsDestroyed = 0;
            
            var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];

                    if (matrix[row, col] == '<')
                    {
                        firstPlayer++;
                    }
                    else if (matrix[row, col] == '>')
                    {
                        secondPlayer++;
                    }
                }
            }
            totalCountShipsDestroyed=firstPlayer+secondPlayer;
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                int row = input[i];
                int col = input[i + 1];
                if (!IsInRange(matrix, row, col))
                {
                    continue;
                }

                if (matrix[row,col]=='>')
                {
                    secondPlayer--;
                    matrix[row, col] = 'X';
                }
                else if (matrix[row, col] == '<')
                {
                    firstPlayer--;
                    matrix[row, col] = 'X';
                }
                else if (matrix[row, col] == '#')
                {
                    if (IsInRange(matrix,row-1,col))
                    {
                        if (matrix[row-1,col]=='>')
                        {
                            secondPlayer--;
                           
                        }
                        else if (matrix[row - 1, col] == '<')
                        {
                            firstPlayer--;
                          
                        }
                        matrix[row - 1, col] = 'X';
                    }
                    if (IsInRange(matrix, row + 1, col))
                    {
                        if (matrix[row + 1, col] == '>')
                        {
                            secondPlayer--;

                        }
                        else if (matrix[row + 1, col] == '<')
                        {
                            firstPlayer--;

                        }
                        matrix[row + 1, col] = 'X';
                    }
                    if (IsInRange(matrix, row, col+1))
                    {
                        if (matrix[row, col+1] == '>')
                        {
                            secondPlayer--;

                        }
                        else if (matrix[row, col+1] == '<')
                        {
                            firstPlayer--;

                        }
                        matrix[row, col+1] = 'X';
                    }
                    if (IsInRange(matrix, row, col - 1))
                    {
                        if (matrix[row, col - 1] == '>')
                        {
                            secondPlayer--;

                        }
                        else if (matrix[row, col - 1] == '<')
                        {
                            firstPlayer--;

                        }
                        matrix[row, col - 1] = 'X';
                    }
                    if (IsInRange(matrix, row - 1, col+1))
                    {
                        if (matrix[row-1, col + 1] == '>')
                        {
                            secondPlayer--;

                        }
                        else if (matrix[row-1, col + 1] == '<')
                        {
                            firstPlayer--;

                        }
                        matrix[row-1, col + 1] = 'X';
                    }
                    if (IsInRange(matrix, row + 1, col - 1))
                    {
                        if (matrix[row + 1, col - 1] == '>')
                        {
                            secondPlayer--;

                        }
                        else if (matrix[row + 1, col - 1] == '<')
                        {
                            firstPlayer--;

                        }
                        matrix[row + 1, col - 1] = 'X';
                    }
                    if (IsInRange(matrix, row + 1, col + 1))
                    {
                        if (matrix[row + 1, col + 1] == '>')
                        {
                            secondPlayer--;

                        }
                        else if (matrix[row + 1, col + 1] == '<')
                        {
                            firstPlayer--;

                        }
                        matrix[row + 1, col + 1] = 'X';
                    }
                    if (IsInRange(matrix, row - 1, col - 1))
                    {
                        if (matrix[row - 1, col - 1] == '>')
                        {
                            secondPlayer--;

                        }
                        else if (matrix[row - 1, col - 1] == '<')
                        {
                            firstPlayer--;

                        }
                        matrix[row - 1, col - 1] = 'X';
                    }

                }
                if (firstPlayer==0||secondPlayer==0)
                {
                    break;
                }
            }
            if (firstPlayer>0&&secondPlayer>0)
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayer} ships left. Player Two has {secondPlayer} ships left.");
            }
            else if (firstPlayer>0)
            {
                Console.WriteLine($"Player One has won the game! {totalCountShipsDestroyed-(firstPlayer+secondPlayer)} ships have been sunk in the battle.");
            }
            else if (secondPlayer > 0)
            {
                Console.WriteLine($"Player Two has won the game! {totalCountShipsDestroyed-(firstPlayer+secondPlayer)} ships have been sunk in the battle.");
            }
        }

        private static bool IsInRange(char[,] matrix, int row, int col)       
        => row >= 0 && row < matrix.GetLength(0)
              && col >= 0 && col < matrix.GetLength(1);
        
    }
    
}

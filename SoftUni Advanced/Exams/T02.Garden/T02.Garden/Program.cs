using System;

namespace T02.Garden
{
    public class Program
    {
        static void Main(string[] args)
        {
            int armour = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] field = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                var chars = Console.ReadLine().ToCharArray();
                field[i] = chars;
            }
            var heroRow = 0;
            var heroCol = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'A')
                    {
                        heroRow = i;
                        heroCol = j;
                    }
                }

            }
            while (true)
            {
                var commansLine = Console.ReadLine();
                var commandParts = commansLine.Split(' ');
                var command = commandParts[0];
                var orcRow = int.Parse(commandParts[1]);
                var orcCol = int.Parse(commandParts[2]);
                armour--;
                field[orcRow][orcCol] = 'O';
                field[heroRow][heroCol] = '-';
                if (command == "up" && heroRow - 1 >= 0)
                {
                    heroRow--;
                }
                else if (command == "down" && heroRow + 1 < rows)
                {
                    heroRow++;
                }
                else if (command == "left" && heroCol - 1 >= 0)
                {
                    heroCol--;
                }
                else if (command == "right" && heroCol + 1 < field[heroRow].Length)
                {
                    heroCol++;
                }

                if (field[heroRow][heroCol] == 'O')
                {
                    armour -= 2;
                }
                else if (field[heroRow][heroCol] == 'M')
                {
                    field[heroRow][heroCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armour}");
                    break;
                }

                if (armour <= 0)
                {
                    field[heroRow][heroCol] = 'X';
Console.WriteLine($"The army was defeated at {heroRow};{heroCol}.");
                    break;
                }
                field[heroRow][heroCol] = 'A';
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
        }


    }
}

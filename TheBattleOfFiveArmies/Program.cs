using System;

namespace Тhe_battle_oif_five_armies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int armour = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];
            var armyRow = -1;
            var armyCol = -1;
            var isMissionSuccess = false;

            for (int row = 0; row < rows; row++)
            {
                var matrixRow = Console.ReadLine();
                matrix[row] = new char[matrixRow.Length];

                for (int col = 0; col < matrixRow.Length; col++)
                {
                    matrix[row][col] = matrixRow[col];

                    if (matrix[row][col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split();
                var direction = command[0];
                var orcRow = int.Parse(command[1]);
                var orcCol = int.Parse(command[2]);

                matrix[orcRow][orcCol] = 'O';
                matrix[armyRow][armyCol] = '-';
                armour--;

                switch (direction)
                {
                    case "up":
                        if (armyRow - 1 < 0)
                        {
                            continue;
                        }
                        armyRow--; break;
                    case "down":
                        if (armyRow + 1 == rows)
                        {
                            continue;
                        }
                        armyRow++; break;
                    case "left":
                        if (armyCol - 1 < 0)
                        {
                            continue;
                        }
                        armyCol--; break;
                    case "right":
                        if (armyCol + 1 == matrix[armyRow].Length)
                        {
                            continue;
                        }
                        armyCol++; break;

                    default:
                        break;
                }

                if (armour <= 0)
                {
                    matrix[armyRow][armyCol] = 'X';
                    break;
                }

                if (matrix[armyRow][armyCol] == 'O')
                {
                    armour -= 2;
                    if (armour <= 0)
                    {
                        matrix[armyRow][armyCol] = 'X';
                        break;
                    }
                }
                else if (matrix[armyRow][armyCol] == 'M')
                {
                    isMissionSuccess = true;
                    matrix[armyRow][armyRow] = '-';
                    break;
                }


                Console.WriteLine(isMissionSuccess ? $"The army managed to free the Middle World! Armour left: {armour}" : $"The army was defeated at {armyRow};{armyCol}.");

                foreach (var item in matrix)
                {
                    Console.WriteLine(String.Join("", item));
                }
            }
        }
    }
}

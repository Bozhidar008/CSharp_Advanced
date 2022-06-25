using System;

namespace WallDestroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int vankoRow = 0;
            int vankoCol = 0;

            InitializeTheMatrix(matrix);

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;
                    }
                }
            }

            string directions = Console.ReadLine();
            int holeCreated = 0;
            int timeMoved = 0;
            int rodHit = 0;
            while (directions != "End")
            {
                int newPlayerRow = vankoRow;
                int newPlayerCol = vankoCol;

                switch (directions)
                {
                    case "up":
                        newPlayerRow--;
                        timeMoved++;
                        break;
                    case "down":
                        newPlayerRow++;
                        timeMoved++;
                        break;
                    case "left":
                        newPlayerCol--;
                        timeMoved++;
                        break;
                    case "right":
                        newPlayerCol++;
                        timeMoved++;
                        break;
                }

                if (timeMoved <= 1)
                {
                    holeCreated++;
                }

                if (!InBounds(matrix, newPlayerRow, newPlayerCol))
                {
                    directions = Console.ReadLine();
                    continue;
                }

                if (matrix[newPlayerRow, newPlayerCol] == '-')
                {
                    matrix[newPlayerRow, newPlayerCol] = 'V';
                    matrix[vankoRow, vankoCol] = '*';
                    holeCreated++;
                    vankoRow = newPlayerRow;
                    vankoCol = newPlayerCol;
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'R')
                {
                    rodHit++;
                    Console.WriteLine("Vanko hit a rod!");
                    matrix[newPlayerRow, newPlayerCol] = 'R';
                    matrix[vankoRow, vankoCol] = 'V';
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'C')
                {
                    holeCreated++;
                    matrix[newPlayerRow, newPlayerCol] = 'E';
                    matrix[vankoRow, vankoCol] = '*';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCreated} hole(s).");
                    PrintMatrix(matrix);
                    return;
                }
                else if (matrix[newPlayerRow, newPlayerCol] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{newPlayerRow}, {newPlayerCol}]!");
                    matrix[vankoRow, vankoCol] = '*';
                    vankoRow = newPlayerRow;
                    vankoCol = newPlayerCol;
                }

                directions = Console.ReadLine();
            }

            Console.WriteLine($"Vanko managed to make {holeCreated} hole(s) and he hit only {rodHit} rod(s).");
            PrintMatrix(matrix);
        }

        static void InitializeTheMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static bool InBounds(char[,] matrix, int row, int col) => row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);

    }
}
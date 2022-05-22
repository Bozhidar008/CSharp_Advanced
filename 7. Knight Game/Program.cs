using System;
using System.Linq;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            char[,] matrix = new char[rows, cols];
            FillTheMatrix(rows, cols, matrix);
                       
            int removeCount = 0;
            while (true)
            {
                int maxAttackedKnightsCount = 0;
                int knightRow = -1;
                int knightCol = -1;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char symbol = matrix[row, col];
                        if (symbol != 'K')
                        {
                            continue;
                        }
                        int count = GetCountOfAttackedKnights(matrix, row, col);
                        if (count > maxAttackedKnightsCount)
                        {
                            maxAttackedKnightsCount = count;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }
                if (maxAttackedKnightsCount == 0)
                {
                    break;
                }
                matrix[knightRow, knightCol] = '0';
                removeCount++;
            }
            Console.WriteLine(removeCount);
        }
        private static int GetCountOfAttackedKnights(char[,] matrix, int row, int col)
        {
            int count = 0;
            if (ContainsKnight(matrix, row - 2, col - 1))
            {
                count++;
            }
            if (ContainsKnight(matrix, row - 2, col + 1))
            {
                count++;
            }
            if (ContainsKnight(matrix, row - 1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(matrix, row - 1, col + 2))
            {
                count++;
            }
            if (ContainsKnight(matrix, row + 1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(matrix, row + 1, col + 2))
            {
                count++;
            }
            if (ContainsKnight(matrix, row + 2, col - 1))
            {
                count++;
            }
            if (ContainsKnight(matrix, row + 2, col + 1))
            {
                count++;
            }
            return count;
        }
        private static bool ContainsKnight(char[,] matrix, int row, int col)
        {
            if (!IsValidCell(row, col, matrix.GetLength(0)))
            {
                return false;
            }
            return matrix[row, col] == 'K';
        }
        private static bool IsValidCell(int row, int col, int lenght)
        {
            return row >= 0 && row < lenght && col >= 0 && col < lenght;
        }

        private static void FillTheMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {

                char[] currentRow = Console.ReadLine()
                                       .ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

    }


    
}

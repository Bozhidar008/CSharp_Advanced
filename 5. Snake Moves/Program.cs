using System;
using System.Linq;

namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            char next = ' ';
            int i = 0;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (i == snake.Length)
                    {
                        i = 0;
                    }
                    next = snake[i];
                    i++;
                    if (r % 2 !=0)
                    {
                        matrix[r, cols-1 - c] = next;
                    }
                    if (r%2 == 0)
                    {
                        matrix[r, c] = next;
                    }
                }
            }

            PrintMatrix(rows, cols, matrix);

        }

        private static void PrintMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows =sizes[0];
            int cols =sizes[1];
            string[,] matrix = new string[rows, cols];

            FillTheMatrix(rows, cols, matrix);

            string input;
            while ((input = Console.ReadLine() )!= "END")
            {
                string[] parameters = input.Split();

                string command = parameters[0];
                if (command == "swap" && parameters.Length == 5)
                {
                    int row1 = int.Parse(parameters[1]);
                    int col1 = int.Parse(parameters[2]);
                    int row2 = int.Parse(parameters[3]);
                    int col2 = int.Parse(parameters[4]);
                    if (row1 >= 0 && col1 >= 0 && row2 >= 0 && col2 >= 0 && row1 < rows && row2 < rows && col1 < cols && col2 < cols)
                    {
                        var temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;
                        PrintMatrix(rows, cols, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!"); 
                    }                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                               
            }
        }

        private static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillTheMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {

                string[] currentRow = Console.ReadLine()
                                       .Split()
                                       .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }


    }
}

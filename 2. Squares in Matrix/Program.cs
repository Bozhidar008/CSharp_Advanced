using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] colElements = Console.ReadLine().Split();
                for (int k = 0; k < cols; k++)
                {
                    matrix[i, k] = colElements[k];
                }
            }
            int counter = 0;
            for (int i = 0; i < rows-1; i++)
            {
                for (int c = 0; c < cols-1; c++)
                {
                    if ((matrix[i,c] == matrix[i + 1, c]) && (matrix[i+1,c+1]== matrix[i, c+1]) && (matrix[i + 1, c] == matrix[i + 1, c + 1]))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}

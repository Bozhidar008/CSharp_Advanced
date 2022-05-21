using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] colRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[colRow[0], colRow[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int maxSum = 0;
            int[,] matrixMaxSum = new int[2, 2];
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    var newSquareSum = matrix[row, col] + matrix[row+1, col] + matrix[row+1, col+1] + matrix[row, col+1];
                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        matrixMaxSum[0, 0] = matrix[row, col];
                        matrixMaxSum[0, 1] = matrix[row, col+1];
                        matrixMaxSum[1, 0] = matrix[row+1, col];
                        matrixMaxSum[1, 1] = matrix[row+1, col+1];
                        
                    }
                }
            }
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(matrixMaxSum[r,c]+ " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}

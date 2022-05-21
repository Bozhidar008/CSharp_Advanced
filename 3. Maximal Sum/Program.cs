using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();      

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < sizes[0]; i++)
            {
                int[] colElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int k = 0; k < sizes[1]; k++)
                {
                    matrix[i, k] = colElements[k];
                }
            }
            int sum = 0;
            int maxSum = int.MinValue;
            int currentRow = -1;
            int currentCol = -1;
            
            for (int i = 0; i < sizes[0]-2; i++)
            {
                
                for (int k = 0; k < sizes[1]-2; k++)
                {
                    sum = matrix[i, k]   + matrix[i, k+1]   + matrix[i, k+2] +
                          matrix[i+1, k] + matrix[i+1, k+1] + matrix[i+1, k+2] +
                          matrix[i+2, k] + matrix[i+2, k+1] + matrix[i+2, k+2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        currentRow = i;
                        currentCol = k;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int r = currentRow; r < currentRow+3; r++)
            {
                for (int c =currentCol; c < currentCol+3; c++)
                {
                    Console.Write(matrix[r,c]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}

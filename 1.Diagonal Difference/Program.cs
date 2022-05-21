using System;
using System.Linq;

namespace _1.Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int r = 0; r < n; r++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = colElements[c];
                }
            }
            int sum1 = 0;
            int sum2 = 0;
            
            for (int r = 0; r < n; r+=1)
            {
                for (int c = r; c < n; c+=1)
                {
                    
                    sum1 += matrix[r, c];
                    sum2 += matrix[n-1-r, c];
                    break;
                }                
            }
            int difference = Math.Abs(sum1 - sum2);
            Console.WriteLine(difference);
        }
    }
}

using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n,n];
            for (int row = 0; row < n; row++)
            {
                
                char[] colElements = Console.ReadLine().ToCharArray();
                
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool IsExist = false;
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (matrix[r,c] == symbol)
                    {                        
                        IsExist = true;
                        Console.WriteLine($"({r}, {c})");
                        break;
                    }
                }
                if (IsExist)
                {
                    break;
                }
            }
            
            if (!IsExist)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}

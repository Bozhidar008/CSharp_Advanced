﻿using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i+=1)
            {
                 sum += matrix[i,i];
                
            }
            Console.WriteLine(sum);
        }
    }
}

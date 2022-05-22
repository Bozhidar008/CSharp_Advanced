using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[i] = colElements;
            }
            for (int i = 0; i < rows-1; i++)
            {
                if (jagged[i].Length == jagged[i+1].Length)
                {
                    for (int c = 0; c < jagged[i].Length; c++)
                    {
                        jagged[i][c] *= 2;
                        jagged[i+1][c] *= 2;
                    }
                   
                }
                else
                {
                    for (int c = 0; c < jagged[i].Length; c++)
                    {
                        jagged[i][c] /= 2;
                    }
                    for (int c = 0; c < jagged[i + 1].Length; c++)
                    {
                        jagged[i + 1][c] /= 2;
                    }
                }
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);
                if (row >= 0 && row < rows && col >=0 && col < jagged[row].Length)
                {
                    if (command == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        jagged[row][col] -= value;
                    }
                }
                input = Console.ReadLine();
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < jagged[r].Length; c++)
                {
                    Console.Write(jagged[r][c]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}

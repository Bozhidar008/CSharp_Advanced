using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int r = 0; r < rows; r++)
            {               
                int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jagged[r]=columns;                               
            }
            string input= Console.ReadLine();
            bool IsValid = true;
            while (input != "END")
            {
                string[] parameters = input.Split();
                string command = parameters[0];
                int row = int.Parse(parameters[1]);
                int col = int.Parse(parameters[2]);
                int value = int.Parse(parameters[3]);

                if (row < 0 || row >= rows || col < 0 || col >= jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    IsValid = false;
                }
                if (command == "Add" && IsValid)
                {
                    jagged[row][col] += value;
                }
                if (command == "Subtract" && IsValid)
                {
                    jagged[row][col] -= value;
                }
                IsValid = true;
                input = Console.ReadLine();
            }
            foreach (var item in jagged)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}

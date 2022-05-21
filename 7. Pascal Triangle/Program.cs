using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jagged = new long[n][];
            int currentWidth = 1;
            for (long row = 0; row < n; row++)
            {
                jagged[row] = new long[currentWidth];
                long[] currentRow = jagged[row];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentWidth++;
                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length-1; i++)
                    {
                        long[] previousRow = jagged[row - 1];
                        long previousRowSum = previousRow[i]+ previousRow[i-1];
                        currentRow[i]= previousRowSum;
                    }
                }
            }
            foreach (long[] row in jagged)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}

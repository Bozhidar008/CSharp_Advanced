using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = GetMin;
            Console.WriteLine(func(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()));
                
        }
        private static int GetMin(int[] array)
        {
            int minNum = int.MaxValue;

            foreach (var item in array)
            {
                if (item<minNum)
                {
                    minNum = item;
                }
            }
            return minNum;
        }
    }
}

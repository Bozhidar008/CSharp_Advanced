using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int numberToAdd = int.Parse(n[0]);
            int numberToRemove = int.Parse(n[1]);
            int numberToCheck = int.Parse(n[2]);
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < numberToRemove; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(numberToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    var array = stack.ToArray();
                    Console.WriteLine(array.Min());
                }

            }

        }
    }
}

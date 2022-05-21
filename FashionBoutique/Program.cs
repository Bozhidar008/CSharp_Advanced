using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(array);
            int sum = 0;
            int counter = 1;
            while (stack.Count > 0)
            {
                if ((sum + stack.Peek()) <= capacity)
                {
                    sum += stack.Pop();
                }
                if (stack.Count == 0)
                {
                    break;
                }
                if ((sum + stack.Peek()) > capacity)
                {
                    counter++;
                    sum = stack.Pop();
                }
            }
            Console.WriteLine(counter);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[arr.Length - 1 - i]);
            }

            int sum = int.Parse(stack.Pop());
            int num = 0;
            string sign = "";

            while (stack.Count > 0)
            {
                sign = stack.Pop();
                num = int.Parse(stack.Pop());

                if (sign == "+")
                {
                    sum += num;
                }
                if (sign == "-")
                {
                    sum -= num;
                }

            }
            Console.WriteLine(sum);

        }
    }
}

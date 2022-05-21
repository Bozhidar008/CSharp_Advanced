using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> ints = new Stack<int>(arr);
            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandToDo = command[0].ToLower();
                if (commandToDo == "add")
                {
                    int num1 = int.Parse(command[1]);
                    int num2 = int.Parse(command[2]);
                    ints.Push(num1);
                    ints.Push(num2);
                }
                if (commandToDo == "remove")
                {
                    int nums = int.Parse(command[1]);
                    if (nums <= ints.Count)
                    {
                        for (int i = 0; i < nums; i++)
                        {
                            ints.Pop();
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum: {ints.Sum()}");
        }
    }
}

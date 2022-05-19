using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMinElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];

                switch (command)
                {
                    case "1":
                        int number = int.Parse(input[1]);
                        stack.Push(number); break;
                    case "2": stack.Pop(); break;
                    case "3":
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            var array = stack.ToArray();
                            Console.WriteLine(array.Max()); break;
                        }

                    case "4":
                        if (stack.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            var array1 = stack.ToArray();
                            Console.WriteLine(array1.Min()); break;
                        }
                    default:
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}

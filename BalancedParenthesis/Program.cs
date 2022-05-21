using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string expression = Console.ReadLine();
            foreach (var item in expression)
            {
                if (stack.Any())
                {
                    char exist = stack.Peek();
                    if (exist == '(' && item == ')')
                    {
                        stack.Pop(); continue;
                    }
                    else if (exist == '{' && item == '}')
                    {
                        stack.Pop(); continue;
                    }
                    else if (exist == '[' && item == ']')
                    {
                        stack.Pop(); continue;
                    }
                }

                stack.Push(item);
            }
            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

        }
    }
}

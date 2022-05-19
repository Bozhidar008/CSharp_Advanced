using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];
                if (ch == '(')
                {
                    stack.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i + 1;
                    string subExpr = expression.Substring(startIndex, endIndex - startIndex);
                    Console.WriteLine(subExpr);
                }
            }
        }
    }
}

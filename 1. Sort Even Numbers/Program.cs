using System;
using System.Linq;

namespace _1._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           var result = input.Where(n => n % 2 == 0).OrderBy(n=>n);
            Console.WriteLine(String.Join(", ", result));
        }
    }
}

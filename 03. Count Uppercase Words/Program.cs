using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x[0] == x.ToUpper()[0])
                .ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}

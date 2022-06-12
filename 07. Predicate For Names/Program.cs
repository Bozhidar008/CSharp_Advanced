using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string[], string[]> length = num => num.Where(x => x.Length <= n).ToArray();

            foreach (var item in length(names))
            {
                Console.WriteLine(item);
            }
        }
    }
}

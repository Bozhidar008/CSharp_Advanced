using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToArray();
            int num = int.Parse(Console.ReadLine());
            
            Func<int[], int[]> divisible = n => n.Where(x => x % num !=0).ToArray();
            Console.WriteLine(String.Join(" ", divisible(array)));
        }
    }
}

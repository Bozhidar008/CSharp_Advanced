using System;
using System.Linq;

namespace _1.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}

            Action<string> print = word => Console.WriteLine(word);
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);    
        }
    }
}

using System;
using System.Linq;

namespace _5._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Func<int[], int[]> add = n => n.Select(x =>  x + 1).ToArray();
            Func<int[], int[]> multiply = n => n.Select(x =>  x * 2).ToArray();
            Func<int[], int[]> subtract = n => n.Select(x =>  x - 1).ToArray();
            Action< int[]> print = n => Console.WriteLine(string.Join(" ", n));
            string command;
            while (( command =Console.ReadLine()) != "end")
            {
                
                if (command == "add")
                {
                    input = add(input);
                }
                if (command == "multiply")
                {
                    input = multiply(input);
                }
                if (command == "subtract")
                {
                    input = subtract(input);
                }
                if (command == "print")
                {
                    print(input);
                }
            }
        }
    }
}

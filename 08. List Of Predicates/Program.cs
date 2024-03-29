﻿using System;
using System.Linq;

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int, bool> func = Divisible;
            for (int i = 1; i <= n; i++)
            {
                if (func(array, i) == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
        private static bool Divisible(int[] nums, int num)
        {
            bool output = true;
            foreach (var item in nums)
            {
                if (num % item != 0)
                {
                    output = false;
                }
            }
            return output;
        }
    }
}

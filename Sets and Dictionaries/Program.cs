using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesinArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            
            Dictionary<double,int> counter= new Dictionary<double, int>();

            foreach (var item in list)
            {
                if (!counter.ContainsKey(item))
                {
                    counter.Add(item, 0);
                    counter[item] = 0;
                }
                counter[item]++;
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}

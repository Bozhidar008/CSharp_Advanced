using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> map = new SortedDictionary<char, int>();

            foreach (var item in text)
            {
                if (!map.ContainsKey(item))
                {
                    map.Add(item, 0);
                }
                map[item]++;
            }
            foreach (var item in map)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> map = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] items = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (!map.ContainsKey(color))
                {
                    map[color] = new Dictionary<string, int>();
                }
                for (int k = 0; k < items.Length; k++)
                {
                    string item = items[k];
                    if (!map[color].ContainsKey(item))
                    {
                        map[color][item] = 0;
                    }
                    map[color][item]++;
                }
            }
            string[] searched = Console.ReadLine().Split();
            string searchedColor = searched[0];
            string searchedItem = searched[1];
            foreach (var color in map)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == searchedColor && item.Key == searchedItem)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}

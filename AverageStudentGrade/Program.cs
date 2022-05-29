using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> map = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var key = input[0];
                var value = double.Parse(input[1]);
                if (!map.ContainsKey(key))
                {         
                    map.Add(key, new List<decimal> { });
                    
                }                
                    map[key].Add((decimal)value);                
            }            
            foreach (var(key,value) in map)
            {
                string AllValues = string.Join(" ", value.Select(x => x.ToString("F2")));
                Console.WriteLine($"{key} -> {AllValues} (avg: {value.Average():f2})");
            }
        }
    }
}

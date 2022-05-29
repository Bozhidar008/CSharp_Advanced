using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!dic.ContainsKey(continent))
                {
                    dic.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!dic[continent].ContainsKey(country))
                {
                    dic[continent][country] = new List<string>();
                }
                dic[continent][country].Add(city);
            }
            
            foreach (var (continent, country) in dic)
            {
                Console.WriteLine($"{continent}:");
                foreach (var (countryName, city) in country)
                {
                    
                    Console.WriteLine($" {countryName} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}

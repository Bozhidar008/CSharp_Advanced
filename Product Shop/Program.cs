using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> dic = new SortedDictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();

            while (command != "Revision")
            {
                string[] input = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);
                if (!dic.ContainsKey(shop))
                {
                    dic.Add(shop, new Dictionary<string, double>());
                }
                if (!dic[shop].ContainsKey(product))
                {
                    dic[shop].Add(product, 0);
                }
                dic[shop][product]= price;

                command = Console.ReadLine();
            }

            foreach (var (shop, product) in dic)
            {
                Console.WriteLine($"{shop}->");
                foreach (var (productName, price) in product)
                {
                    Console.WriteLine($"Product: {productName}, Price: {price}");
                }
            }

        }
    }
}

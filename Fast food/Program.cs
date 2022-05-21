using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);
            var foodNeeded = queue.ToArray().Sum();
            Console.WriteLine(queue.ToArray().Max());
            while (quantity > 0)
            {
                if (queue.Count > 0)
                {
                    var orderFood = queue.Peek();
                    if (quantity >= orderFood)
                    {
                        queue.Dequeue();
                        quantity -= orderFood;
                    }
                }
                if (queue.Count > 0 && (quantity <= 0 || quantity < queue.Peek()))
                {
                    Console.Write($"Orders left: ");
                    Console.Write(String.Join(' ', queue)); break;
                }
                if (queue.Count == 0 && quantity >= 0)
                {
                    Console.WriteLine($"Orders complete"); break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotatoQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players = Console.ReadLine().Split(' ');
            var queue = new Queue<string>(players);
            int nums = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i < nums - 1; i++)
                {
                    var player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                var lostPlayer = queue.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }
            var lastPlayer = queue.Dequeue();
            Console.WriteLine($"last is: {lastPlayer}");

        }
    }
}

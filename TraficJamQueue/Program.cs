using System;
using System.Collections.Generic;

namespace TraficJamQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string input = Console.ReadLine();
            int counter = 0;
            while (input != "end")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}

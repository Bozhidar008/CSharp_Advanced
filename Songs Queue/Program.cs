using System;
using System.Collections.Generic;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);
            string input = Console.ReadLine();
            while (queue.Count > 0)
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string com = commands[0];
                if (com == "Play")
                {
                    queue.Dequeue();
                    
                }
                if (com == "Add")
                {
                    var array = new List<string>(commands);
                    array.Remove(commands[0]);
                    string com2 = String.Join(" ", array);
                    if (queue.Contains(com2))
                    {
                        Console.WriteLine($"{com2} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(com2);
                    }

                }
                if (com == "Show")
                {
                    Console.WriteLine(String.Join(", ", queue));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}

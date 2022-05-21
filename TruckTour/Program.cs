using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> q = new Queue<int[]>();
            int start = 0;
            for (int i = 0; i < n; i++)
            {

                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                q.Enqueue(input);

            }
            int index = 0;
            while (true)
            {
                int fuelLeft = 0;
                foreach (var input in q)
                {
                    int litres = input[0];
                    int distance = input[1];
                    fuelLeft += litres - distance;
                    if (fuelLeft < 0)
                    {
                        int[] current = q.Dequeue();
                        q.Enqueue(current);
                        index++;

                        break;
                    }
                }
                if (fuelLeft >= 0)
                {
                    break;
                }
            }


            Console.WriteLine(index);
        }
    }
}

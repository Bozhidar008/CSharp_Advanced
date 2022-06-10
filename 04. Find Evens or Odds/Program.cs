using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int min = input[0];
            int max = input[1];
            string command = Console.ReadLine();
            Predicate< int> compare = x => command == "odd"? x%2 !=0 : x%2 == 0;

            for (int i = min; i <= max; i++)
            {
                if (compare(i))
                {
                    Console.Write(i+ " ");
                }
            }  
            
        }
    }
}

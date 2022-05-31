using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];
            HashSet<int>setN = new HashSet<int>();
            HashSet<int>setM = new HashSet<int>();
            
            for (int i = 0; i < n+m; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    setN.Add(input);
                }
                if (i >= m)
                {
                     setM.Add(input);
                }
            }
             setN.IntersectWith(setM);
            foreach (var item in setN)
            {
                Console.Write(item+ " ");
            }  

            
        }
    }
}

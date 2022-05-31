using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                                
                    set.UnionWith(input);
            }

            foreach (var item in set.OrderBy(s=>s))
            {
                Console.Write(item+" ");
            }
        }
    }
}

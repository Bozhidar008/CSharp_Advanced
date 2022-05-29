using System;
using System.Linq;

namespace Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            nums.OrderByDescending(x=>x).Take(3).ToList().ForEach(x => Console.Write(x+ " "));
        }
    }
}

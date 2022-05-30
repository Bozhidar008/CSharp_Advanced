using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string input;

            while ((input =Console.ReadLine())!= "END")
            {
                string[] split = input.Split(",");
                string command = split[0];
                string plate = split[1];
                if (command == "IN")
                {                    
                    set.Add(plate);
                }
                if (command == "OUT")
                {
                    if (set.Count > 0)
                    {
                        set.Remove(plate);
                    }                    
                }
            }
            if(set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in set)
                {
                    if (set.Count > 0)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
            
            
            
        }
    }
}

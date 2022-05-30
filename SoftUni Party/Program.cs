using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setVIP = new HashSet<string>();
            HashSet<string> setRegular = new HashSet<string>();
            string present = string.Empty;
            string input = Console.ReadLine();
            while (input !="END")
            {
                if (input == "PARTY")
                {
                    while (true)
                    {
                        present = Console.ReadLine();
                        if (present == "END")
                        {
                            break;
                        }
                        if (setVIP.Contains(present))
                        {
                            setVIP.Remove(present);
                        }
                        if (setRegular.Contains(present))
                        {
                            setRegular.Remove(present);
                        }
                    }
                    if (present =="END")
                    {
                        break;
                    }                    
                }
                else
                {
                    if (char.IsDigit(input[0]))
                    {
                        setVIP.Add(input);
                    }
                    else
                    {
                        setRegular.Add(input);
                    }
                }
                input = Console.ReadLine();
            }
            int missingPeople = setVIP.Count + setRegular.Count;
            Console.WriteLine(missingPeople);
            foreach (var item in setVIP)
            {
                Console.WriteLine(item);
            }
            foreach (var item in setRegular)
            {
                Console.WriteLine(item);
            }
        }
    }
}

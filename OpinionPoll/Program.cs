using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Family people = new Family();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = input[0];
            int age = int.Parse(input[1]);
            Person person = new Person(name, age);
            people.AddMember(person);
        }

        var newfamily = people.GetPollMembers();

        foreach (var item in newfamily)
        {
            Console.WriteLine(item.ToString());
        }
    }
}


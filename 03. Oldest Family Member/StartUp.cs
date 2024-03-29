﻿using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family persons = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
               
                persons.AddMember(person);
            }
            var oldest = persons.GetOldestMember().ToString();
            Console.WriteLine(oldest);
        }
    }


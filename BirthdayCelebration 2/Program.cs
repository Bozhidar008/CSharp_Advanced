using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void RemainingGuests(Queue queue)
    {
        string guests = "";

        while (queue.Count != 0)
            guests += queue.Dequeue().ToString() + " ";

        Console.WriteLine($"Guests: {guests}");
    }

    static void RemainingPlates(Stack stack)
    {
        string plates = "";

        while (stack.Count != 0)
            plates += stack.Pop().ToString() + " ";

        Console.WriteLine($"Plates: {plates}");
    }

    static void Main(string[] args)
    {
        List<int> queuer = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> stacker = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        int foodWasted = 0;

        Stack stack = new Stack();
        Queue queue = new Queue();

        foreach (var s in stacker)
        {
            stack.Push(s);
        }
        foreach (var q in queuer)
        {
            queue.Enqueue(q);
        }

        while (true)
        {
            if (stack.Count == 0)
            {
                RemainingGuests(queue);
                break;
            }
            if (queue.Count == 0)
            {
                RemainingPlates(stack);
                break;
            }
            bool checker = false;



            if ((int)stack.Peek() < (int)queue.Peek())
            {
                int remaining = (int)queue.Peek();
                while (remaining > 0)
                {
                    if ((int)stack.Peek() - remaining >= 0)
                    {
                        queue.Dequeue();
                        foodWasted += (int)stack.Pop() - remaining;
                        checker = true;
                        break;
                    }
                    remaining -= (int)stack.Pop();

                    if (stack.Count == 0)
                        break;
                }
            }



            if (checker)
                continue;



            if (stack.Count != 0 && queue.Count != 0)
                foodWasted += (int)stack.Pop() - (int)queue.Dequeue();
        }



        Console.WriteLine($"Wasted grams of food: {foodWasted}");
    }
}





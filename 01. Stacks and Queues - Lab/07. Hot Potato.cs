using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(children);

            int count = int.Parse(Console.ReadLine());

            //second option for adding them to queue
            //for (int i = 0; i < children.Length; i++)
            //{
            //    queue.Enqueue(children[i]);
            //}

            while (queue.Count > 1)
            {
                for (int i = 1; i < count; i++)
                {
                    queue.Enqueue(queue.Dequeue()); //taking the first element and adding it to the end
                }

                Console.WriteLine($"Removed {queue.Dequeue()}"); 
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}

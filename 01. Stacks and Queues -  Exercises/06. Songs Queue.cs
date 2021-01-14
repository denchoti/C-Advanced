using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>(songs);


            string command = Console.ReadLine();
            while (queue.Count > 0)
            {
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }

                else if (command.Contains("Add"))
                {
                    var song = command.Split("Add ",StringSplitOptions.RemoveEmptyEntries)[0];
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }

                else if (command.Contains("Show"))
                {
                    Console.WriteLine(String.Join(", ", queue));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}

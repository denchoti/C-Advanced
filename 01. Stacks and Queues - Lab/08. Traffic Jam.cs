using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenCount = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            string name = Console.ReadLine();
            int count = 0;
            while (name != "end")
            {
                if (name == "green")
                {
                    for (int i = 0; i < greenCount; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        count++;
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }
                else
                {
                    cars.Enqueue(name);
                }

                name = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}

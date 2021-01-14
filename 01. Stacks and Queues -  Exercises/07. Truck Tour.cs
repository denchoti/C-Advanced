using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPumps = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < numPumps; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                queue.Enqueue(input);
            }

            int totalFuel = 0;
            for (int i = 0; i < numPumps; i++)
            {
                string currentInfo = queue.Dequeue();
                var info = currentInfo.Split().Select(int.Parse).ToArray();

                var fuel = info[0];
                var distance = info[1];
                totalFuel += fuel;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }

                queue.Enqueue(currentInfo);
            }
            var firstElement = queue.Dequeue().Split().ToArray();
            Console.WriteLine(firstElement[2]);
        }
    }
}

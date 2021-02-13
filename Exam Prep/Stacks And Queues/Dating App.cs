using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(
                      Console.ReadLine()
                     .Split()
                     .Select(int.Parse));


            Queue<int> females = new Queue<int>(
                                Console.ReadLine()
                               .Split()
                               .Select(int.Parse));

            int matches = 0;

            while (males.Any() && females.Any())
            {
                int currentFemale = females.Peek();
                int currentMale = males.Peek();

                if (currentFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }
                if (currentMale <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (currentFemale % 25 == 0)
                {
                    females.Dequeue();
                    if (females.Any())
                    {
                        females.Dequeue();
                    }
                   
                }
                if (currentMale % 25 == 0)
                {
                    males.Pop();
                    if (males.Any())
                    {
                        males.Pop();
                    }
                   
                }
                if (!males.Any() || !females.Any())
                {
                    break;
                }
                if (currentFemale == currentMale)
                {
                    matches++;
                    females.Dequeue();
                    males.Pop();

                }
                else if (currentFemale != currentMale)
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(currentMale - 2);
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Any())
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Any())
            {
                Console.WriteLine($"Males left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}

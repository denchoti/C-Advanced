using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(
                           Console.ReadLine()
                           .Split()
                           .Select(int.Parse));

            Stack<int> warriors = new Stack<int>();


            for (int i = 1; i <= waves; i++)
            {

                int[] warriorsValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (!plates.Any())
                {
                    break;
                }
                warriors = new Stack<int>(warriorsValues);

                if (i % 3 == 0)
                {
                    int plate = int.Parse(Console.ReadLine());
                    plates.Enqueue(plate);
                }

                int currentWarrior = warriors.Peek(); 
                int currentPlate = plates.Peek();

                while (warriors.Any() && plates.Any())
                {
                    if (currentWarrior == 0)
                    {
                        warriors.Pop();
                        continue;
                    }

                    if (currentWarrior > currentPlate)
                    {
                        currentWarrior -= currentPlate;
                        plates.Dequeue();
                        if (plates.Any())
                        {
                            currentPlate = plates.Peek();
                        }
                        else
                        {
                            warriors.Pop();
                            warriors.Push(currentWarrior);
                        }
                    }

                    else if (currentWarrior < currentPlate)
                    {
                        currentPlate -= currentWarrior;
                        warriors.Pop();
                        if (warriors.Any())
                        {
                            currentWarrior = warriors.Peek();
                        }
                    }

                    else if (currentWarrior == currentPlate)
                    {
                        warriors.Pop();
                        plates.Dequeue();
                    }

                  
                }
            }


            if (warriors.Any())
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }


        }
    }
}

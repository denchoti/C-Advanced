using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(
                                 Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse));

            Stack<int> items = new Stack<int>(
                               Console.ReadLine()
                               .Split() 
                               .Select(int.Parse));

            Dictionary<string, int> collection = new Dictionary<string, int>
            {
                { "Aluminium", 0 },
                { "Carbon fiber", 0 },
                { "Glass", 0 },
                { "Lithium", 0 }
            }
            ;

            while (liquids.Any() && items.Any())
            {
                int currentLiquid = liquids.Dequeue();
                int currentItem = items.Pop();

                int sum = currentLiquid + currentItem;

                if (sum == 25)
                {
                    collection["Glass"]++;
                    
                }
                else if (sum == 50)
                {
                    collection["Aluminium"]++;
                    
                }
                else if (sum == 75)
                {
                    collection["Lithium"]++;
                    
                }
                else if (sum == 100)
                {
                    collection["Carbon fiber"]++;
                  
                }
                else
                {
                    items.Push(currentItem + 3);
                }
            }

            if (!collection.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count > 0) 
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Count > 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}

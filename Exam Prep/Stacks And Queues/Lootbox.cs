using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootbox = new Queue<int>
                                     (Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse));
            Stack<int> secondLootbox = new Stack<int>
                                     (Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse));

            List<int> claimedItems = new List<int>();

            while (firstLootbox.Any() && secondLootbox.Any())
            {
                int itemFirst = firstLootbox.Peek();
                int itemSecond = secondLootbox.Peek();
                int sum = itemFirst + itemSecond;

                if (sum % 2 == 0)
                {
                    claimedItems.Add(sum);
                    firstLootbox.Dequeue();
                    secondLootbox.Pop();
                }

                else 
                {
                    firstLootbox.Enqueue(itemSecond);
                    secondLootbox.Pop();
                }
            }

            if (!firstLootbox.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (!secondLootbox.Any())
            {
                Console.WriteLine("Second lootbox is empty");
            }

            int itemsValue = claimedItems.Sum();
            if (itemsValue >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {itemsValue}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {itemsValue}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string colour = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[colour].ContainsKey(clothes[j]))
                    {
                        wardrobe[colour].Add(clothes[j], 0);
                    }
                    wardrobe[colour][clothes[j]]++;
                }
            }

            var toFind = Console.ReadLine().Split().ToArray();

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var clothing in item.Value)
                {
                    Console.Write($"* {clothing.Key} - {clothing.Value} ");

                    if (clothing.Key == toFind[1] && item.Key == toFind[0])
                    {
                        Console.Write("(found!)");
                    }

                    Console.WriteLine();
                }
            }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(
                             Console.ReadLine()
                            .Split()
                            .Select(int.Parse));

            Stack<int> freshnessLv = new Stack<int>(
                               Console.ReadLine()
                              .Split()
                              .Select(int.Parse));

            Dictionary<string, int> cocktails = new Dictionary<string, int>
            {
                { "Mimosa", 0 },
                { "Daiquiri", 0 },
                { "Sunshine", 0 },
                { "Mojito", 0 }
            };


            while (ingredients.Count > 0 && freshnessLv.Count > 0)
            {
                int totalFreshness = ingredients.Peek() * freshnessLv.Peek();
                if (totalFreshness == 150)
                {
                    cocktails["Mimosa"]++;
                    ingredients.Dequeue();
                    freshnessLv.Pop();
                }
                else if (totalFreshness == 250)
                {
                    cocktails["Daiquiri"]++;
                    ingredients.Dequeue();
                    freshnessLv.Pop();
                }
                else if (totalFreshness == 300)
                {
                    cocktails["Sunshine"]++;
                    ingredients.Dequeue();
                    freshnessLv.Pop();
                }
                else if (totalFreshness == 400)
                {
                    cocktails["Mojito"]++;
                    ingredients.Dequeue();
                    freshnessLv.Pop();
                }
                else if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }
                else 
                {
                    freshnessLv.Pop();
                    ingredients.Enqueue(ingredients.Peek() + 5);
                    ingredients.Dequeue();
                }
            }

           
            if (cocktails["Mimosa"] >0 && cocktails["Daiquiri"] >0 && cocktails["Sunshine"] >0 && cocktails["Mojito"] >0)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            int sum = 0;
            while (ingredients.Any())
            {
                sum += ingredients.Dequeue();
            }
            if (sum >0)
            {
                Console.WriteLine($"Ingredients left: {sum}");
            }

            cocktails = cocktails.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
          
            foreach (var item in cocktails.Where(y => y.Value >0))
            {
                Console.WriteLine($"# {item.Key}--> {item.Value}");
            }

        }
    }
}

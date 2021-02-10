
using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vegetables = new Queue<string>(
                                    Console.ReadLine()
                                    .Split());

            Stack<int> calories = new Stack<int>(
                                  Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse));

            Dictionary<string, int> salads = new Dictionary<string, int>
            {
                {"tomato", 80 },
                { "carrot", 136},
                { "lettuce", 109},
                { "potato", 215}
            };


            while (vegetables.Any() && calories.Any())
            {
                int calorieValue = calories.Peek();
                while (calorieValue > 0 && vegetables.Count > 0)
                {
                    calorieValue -= salads[vegetables.Dequeue()]; 
                }
                Console.Write(calories.Pop() + " ");
            }
            Console.WriteLine();

            if (vegetables.Any())
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }

            if (calories.Count > 0)
            {
                Console.WriteLine(string.Join(" ", calories));
            }
        }

   
    }
}

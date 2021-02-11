using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lillies = new Stack<int>(
                                 Console.ReadLine()
                                .Split(", ")
                                .Select(int.Parse));
            Queue<int> roses = new Queue<int>(
                                Console.ReadLine()
                               .Split(", ")
                               .Select(int.Parse));


            int flowerWreaths = 0;
            int flowersLeft = 0;

            while (lillies.Any() && roses.Any())
            {
                int currentLily = lillies.Peek();
                int currentRose = roses.Peek();
                int sum = currentLily + currentRose;
               
                if (sum == 15)
                {
                    flowerWreaths++;
                    lillies.Pop();
                    roses.Dequeue();
                }
                else if (sum > 15)
                {
                    lillies.Pop();
                    currentLily -= 2;
                    lillies.Push(currentLily);
                }
                else if (sum < 15)
                {
                    flowersLeft += sum;
                    lillies.Pop();
                    roses.Dequeue();
                }
            }
           
            int newWreaths = flowersLeft / 15;
            flowerWreaths += newWreaths;

            if (flowerWreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {flowerWreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - flowerWreaths} wreaths more!");
            }
        }
    }
}

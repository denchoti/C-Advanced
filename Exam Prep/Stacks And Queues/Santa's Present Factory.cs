using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> materialValue = new Stack<int>(
                               Console.ReadLine()
                              .Split()
                              .Select(int.Parse));

            Queue<int> magicValue = new Queue<int>(
                             Console.ReadLine()
                            .Split()
                            .Select(int.Parse));

            Dictionary<string, int> presents = new Dictionary<string, int>
            {
                {"Bicycle",0 },
                {"Doll", 0},
                {"Wooden train", 0},
                {"Teddy bear",0 }
            };

            while (materialValue.Any() && magicValue.Any())
            {
                int currentMaterial = materialValue.Peek();
                int currentValue = magicValue.Peek();

                int magicLevel = currentMaterial * currentValue;
              
                if (magicLevel == 150)
                {
                    presents["Doll"]++;
                    magicValue.Dequeue();
                    materialValue.Pop();

                }
                else if (magicLevel == 250)
                {
                    presents["Wooden train"]++;
                    magicValue.Dequeue();
                    materialValue.Pop();

                }
                else if (magicLevel == 300)
                {
                    presents["Teddy bear"]++;
                    magicValue.Dequeue();
                    materialValue.Pop();

                }
                else if (magicLevel == 400)
                {
                    presents["Bicycle"]++;
                    magicValue.Dequeue();
                    materialValue.Pop();

                }
                else if (magicLevel < 0)
                {
                    int sum = currentMaterial + currentValue;
                    magicValue.Dequeue();
                    materialValue.Pop();

                    materialValue.Push(sum);
                }
                else if (magicLevel > 0)
                {
                    magicValue.Dequeue();
                    materialValue.Pop();
                    materialValue.Push(currentMaterial + 15);
                }
                if (currentMaterial == 0)
                {
                   materialValue.Pop();
                }
                if (currentValue == 0)
                {
                    magicValue.Dequeue();
                }      
              
            }

            if (presents.Count > 0)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            Console.WriteLine($"Materials left: {string.Join(", ", materialValue)}");

            foreach (var item in presents)
            {
                if (item.Value != 0)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }

            }
        }
        
    }
}

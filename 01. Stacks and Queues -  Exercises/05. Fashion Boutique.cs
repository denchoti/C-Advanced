using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(clothes);
            int capacity = int.Parse(Console.ReadLine());

            int sum = 0;
            int racks = 0;
            while (stack.Count > 0)
            {
                int value = stack.Peek();

                if (sum + value > capacity)
                {
                    racks++;
                    sum = 0;
                }
                else if (sum + value == capacity)
                {
                    racks++;
                    sum = 0;
                    stack.Pop();
                }
                else if (sum + value < capacity)
                {
                    sum += stack.Pop();
                }

            }

            if (sum > 0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}

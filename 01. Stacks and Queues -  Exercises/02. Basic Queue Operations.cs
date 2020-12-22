using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> stack = new Queue<int>(numbers);
            int s = input[1];

            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }

            int x = input[2];

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }

            else if (stack.Count > 0)
            {
                Console.WriteLine(stack.Min());
            }

            else
            {
                Console.WriteLine(0);
            }
        }
    }
}

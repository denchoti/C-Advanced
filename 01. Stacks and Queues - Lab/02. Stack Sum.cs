using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            Stack<int> stack = new Stack<int>(numbers);

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (command == "remove")
                {
                    int count = int.Parse(tokens[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }       
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            //int sum = 0;

            //while (stack.Count > 0)
            //{
            //    sum += stack.Pop();
            //}

            var sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

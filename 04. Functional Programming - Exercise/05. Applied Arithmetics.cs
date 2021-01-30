using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> addFunc = x => x + 1;
            //Func<int, int> miltipleFunc = x => x * 2;
            //Func<int, int> subtractFunc = x => x - 1;
            

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case"add":
                        //numbers = numbers.Select(addFunc).ToList();
                        numbers = numbers.Select(x => x + 1).ToList();
                        break;

                    case "multiply":
                        numbers = numbers.Select(x => x * 2).ToList();
                        break;

                    case "subtract":
                        numbers = numbers.Select(x => x - 1).ToList();
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;

                       
                }
                command = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> equalSum = (name, sum) => name.Sum(x => x) >= sum;

            int inputSum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(" ", names.FirstOrDefault(x => equalSum(x, inputSum))));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> table = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                foreach (var element in elements)
                {
                    table.Add(element);
                }
            }
            var sorted = table.OrderBy(x => x);
            Console.WriteLine(string.Join(" ",sorted));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfEelements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int first = n[0];
            int second = n[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < first; i++)
            {
                int toAdd = int.Parse(Console.ReadLine());
                firstSet.Add(toAdd);
            }
            for (int i = 0; i < second; i++)
            {
                int toAdd = int.Parse(Console.ReadLine());
                secondSet.Add(toAdd);
            }

            var third = firstSet.Intersect(secondSet);
            Console.WriteLine(string.Join(" ",third));
        }
    }
}

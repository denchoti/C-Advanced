using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> result = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool isDivisable = true;

                for (int j = 0; j < dividers.Length; j++)
                {
                    if (i % dividers[j] != 0)
                    {
                        isDivisable = false;
                        break;
                    }
                }

                if (isDivisable)
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

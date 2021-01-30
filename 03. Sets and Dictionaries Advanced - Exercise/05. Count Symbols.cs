using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> occurances = new SortedDictionary<char, int>();
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!occurances.ContainsKey(currentChar))
                {
                    occurances.Add(currentChar, 0);
                }
                occurances[currentChar]++;
            }
            foreach (var item in occurances)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}

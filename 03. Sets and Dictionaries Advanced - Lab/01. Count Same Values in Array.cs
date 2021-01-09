using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> occurances = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!occurances.ContainsKey(numbers[i]))
                {
                    occurances.Add(numbers[i], 0);
                }
                occurances[numbers[i]]++;
            }

            foreach (var pair in occurances)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value + " times");
            }
        }
    }
}

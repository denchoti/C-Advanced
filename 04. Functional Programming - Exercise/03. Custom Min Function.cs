using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> func = nums =>
            {
                int min = int.MaxValue;
                foreach (var num in nums)
                {
                    if (num < min)
                    {
                        min = num;
                    }

                }
                return min;
            };
            Console.WriteLine(func(numbers));

        }
    }
}

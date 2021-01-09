using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select((x) =>
            {
                return int.Parse(x);
            })
                .Where(x => x % 2 == 0)
                .OrderBy((int x) =>
                {
                    return x; 
                })
                .ToArray();

            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}

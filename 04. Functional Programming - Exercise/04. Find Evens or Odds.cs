using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];
            string type = Console.ReadLine();

            Func<int, int, List<int>> generateList = (start, end) =>
             {
                 List<int> nums = new List<int>();

                 for (int i = start; i <= end; i++)
                 {
                     nums.Add(i);
                 }
                 return nums;
             };

            List<int> numbers = generateList(start, end);
            Predicate<int> predicate = x => x % 2 == 0;

            if (type == "odd")
            {
                predicate = x => x % 2 != 0;
            }

            numbers = MyWhere(numbers, predicate);
            Console.WriteLine(string.Join(" ", numbers));
        }
        static List<int> MyWhere(List<int> nums, Predicate<int> predicate)
        {
            List<int> list = new List<int>();

            foreach(int item in nums)
            {
                if (predicate(item))
                {
                    list.Add(item);

                }
            }
            return list;
        }
    }
}

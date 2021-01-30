using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> occurunces = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!occurunces.ContainsKey(number))
                {
                    occurunces.Add(number, 0);
                }
                occurunces[number]++;
            }

            //foreach (var item in occurunces)
            //{
            //    if (item.Value % 2== 0)
            //    {
            //        Console.WriteLine(item.Key);
            //        break;
            //    }
            //}

            var num = occurunces.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
            Console.WriteLine(num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box);
            }

            string value = Console.ReadLine();
            Box<string> comparableBox = new Box<string>(value);
            int count = GetGreaterThanCount(boxes,comparableBox);
            Console.WriteLine(count); ;
        }

        private static int GetGreaterThanCount<T>(List<Box<T>> boxes, Box<T> box)
            where T: IComparable
        {
            int count = 0;

            foreach (Box<T> item in boxes)
            {
                int compare = item.Value.CompareTo(box.Value);
                if (compare > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}


using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> check = n => n[0] == n.ToUpper()[0];
            var words = Console.ReadLine().Split(new string[] { " " },
                          StringSplitOptions.RemoveEmptyEntries)
                               .Where(check)
                               .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}

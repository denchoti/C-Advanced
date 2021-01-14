using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string text = "";

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
               

                switch (command)
                {
                    case "1":
                        string chars = input[1];
                        text += chars;
                        stack.Push(text);
                        break;

                    case "2":
                        int count = int.Parse(input[1]);
                        text = text.Substring(0, text.Length - count);
                        stack.Push(text);
                        break;

                    case "3":
                        int index = int.Parse(input[1]);
                        Console.WriteLine(text[index - 1]);
                        break;

                    case "4":
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            text = stack.Peek();
                        }
                        else
                        {
                            text = string.Empty;
                        }
                        break;
                }
            }
        }
    }
}

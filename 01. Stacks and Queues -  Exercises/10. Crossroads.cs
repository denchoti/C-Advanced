using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            Stack<string> passed = new Stack<string>();



            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int green = greenLight;
                    int free = freeWindow;
                    int counter = cars.Count();
                    for (int i = 0; i < counter; i++)
                    {
                        if (cars.Count > 0 && green >= cars.Peek().Length)
                        {
                            green -= cars.Peek().Length;
                            passed.Push(cars.Dequeue());
                        }
                        else if (cars.Count > 0 && green < cars.Peek().Length)
                        {
                            int timeLeft = green + free;
                            if (green <= 0)
                            {
                                continue;
                            }
                            else if (timeLeft > 0 && timeLeft >= cars.Peek().Length)
                            {
                                string car = cars.Peek();
                                timeLeft -= car.Length;
                                passed.Push(cars.Dequeue()); 
                                green = 0;
                                free = 0;
                            }
                            else if (timeLeft > 0 && timeLeft < cars.Peek().Length)
                            {
                                string car = cars.Peek();
                                Console.WriteLine("A crash happened!");
                                int hit = timeLeft;
                                Console.WriteLine($"{car} was hit at {car[hit]}.");
                                return;
                            }

                        }

                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passed.Count} total cars passed the crossroads.");
        }
    }
}

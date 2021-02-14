using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                var engine = new Engine();

                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                engine.Model = model;
                engine.Power = power;

                if (engineData.Length == 3)
                {
                    string thirdParam = engineData[2];
                    if (Char.IsDigit(thirdParam, 0))
                    {
                        string displacement = thirdParam;
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = thirdParam;
                        engine.Efficiency = efficiency;
                    }
                }
                else if (engineData.Length == 4)
                {
                    string displacement = engineData[2];
                    string efficiency = engineData[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                engines.Add(engine);
            }


            int m = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                var currCar = new Car();

                string carModel = carInfo[0];
                var currEngine = engines.Where(x => x.Model == carInfo[1]).FirstOrDefault();
                currCar.Model = carModel;
                currCar.Engine = currEngine;

                if (carInfo.Length == 3)
                {
                    string thirdParam = carInfo[2];
                    if (Char.IsDigit(thirdParam, 0))
                    {
                        string weigth = thirdParam;
                        currCar.Weight = weigth;
                    }
                    else
                    {
                        string color = thirdParam;
                        currCar.Color = color;
                    }
                }
                else if (carInfo.Length == 4)
                {
                    string weigth = carInfo[2];
                    string color = carInfo[3];
                    currCar.Weight = weigth;
                    currCar.Color = color;
                }

                cars.Add(currCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($" {car.Engine.Model}:");
                Console.WriteLine($"  Power: {car.Engine.Power}");
                Console.WriteLine($"  Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($" Weight: {car.Weight}");
                Console.WriteLine($" Color: {car.Color}");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] data = command.Split();

                string model = data[1];
                int amountOfKm = int.Parse(data[2]);

                Car car = cars.FirstOrDefault(x => x.Model == model);
                car.Drive(amountOfKm);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }


    }
}
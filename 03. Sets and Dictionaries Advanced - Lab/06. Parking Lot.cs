using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>();

            while (input!= "END")
            {
                var splitted = input.Split(", ");
                string position = splitted[0];
                string number = splitted[1];
                if (position == "IN")
                {
                    parking.Add(number);
                }
                else
                {
                    parking.Remove(number);
                }
                input = Console.ReadLine();
            }
            if (parking.Count >0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}

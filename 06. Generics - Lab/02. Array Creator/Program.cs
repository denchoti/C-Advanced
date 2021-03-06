using System;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] array = GenericArrayCreator.Create(5, "deni");

            Console.WriteLine(string.Join(" ",array));
        }
    }
}

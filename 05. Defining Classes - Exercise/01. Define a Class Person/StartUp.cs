using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);
            Person gosho = new Person("Gosho", 18);
            Person stamat = new Person("Stamat", 43);

            Console.WriteLine(pesho.Name + " " + pesho.Age);
        }
    }
}

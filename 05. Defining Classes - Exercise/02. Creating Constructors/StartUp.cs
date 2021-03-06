using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
            Person person2 = new Person();

            Console.WriteLine(person2.Age + " " + person2.Name);
        }
    }
}

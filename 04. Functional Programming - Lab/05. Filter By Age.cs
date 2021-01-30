using System;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                people[i] = new Person() { Name = input[0], Age = int.Parse(input[1]) };
            }

            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> conditionDelegate = GetCondition(condition, ageFilter);
            Action<Person> printerDelegate = GetPrinter(format);
            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    printerDelegate(person);
                }
            }

        }
        static Action<Person> GetPrinter(string format)
        {
            switch (format)
            {
                case"name":
                    return x => 
                    {
                        Console.WriteLine($"{x.Name}");
                    };

                case "age":
                    return x =>
                    {
                        Console.WriteLine($"{x.Age}");
                    };

                case "name age":
                    return x =>
                    {
                        Console.WriteLine($"{x.Name} - {x.Age}");
                    };
                default:
                    return null;
            }
        }

        static Func<Person, bool> GetCondition(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x.Age < age;
                   
                case "older": return x => x.Age >= age;
                 
                default: return null;
            }
        }

    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

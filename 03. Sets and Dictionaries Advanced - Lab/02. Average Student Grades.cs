using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string nameGrade = Console.ReadLine();
                string[] input = nameGrade.Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                }
                students[name].Add(grade);
            }

            foreach (var student in students)
            {
                StringBuilder allGrades = new StringBuilder();
                for (int i = 0; i < student.Value.Count; i++)
                {
                    allGrades.Append($"{student.Value[i]:f2} ");
                }
                Console.WriteLine($"{student.Key} -> {allGrades:d2}(avg: {student.Value.Average():f2})");
            }
        }
    }
}

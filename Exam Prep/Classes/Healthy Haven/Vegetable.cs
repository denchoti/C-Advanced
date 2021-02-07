using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHaven
{
    class Vegetable
    {
        public Vegetable(string name, int calories)
        {
            Name = name;
            Calories = calories;
        }

        public string Name { get; set; }
        public int Calories { get; set; }

        public override string ToString()
        {
            return $" - {Name} have {Calories} calories";
        }
    }
}

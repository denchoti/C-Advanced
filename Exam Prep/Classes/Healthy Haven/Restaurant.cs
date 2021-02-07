using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHaven
{
    class Restaurant
    {
        List<Salad> data = new List<Salad>();
        private int count => data.Count;
        public Restaurant(string name)
        {
            Name = name;
            data = new List<Salad>();
        }

        public string Name { get; set; }

        public void Add(Salad salad)
        {
            data.Add(salad);
        }
        public bool Buy(string name)
        {
            foreach (var salad in data)
            {
                if (salad.Name == name)
                {
                    data.Remove(salad);
                    return true;
                }
            }
            return false;
        }

        public Salad GetHealthiestSalad()
        {
            return data.OrderBy(x => x.GetTotalCalories()).First();
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} have {count} salads:");

            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}

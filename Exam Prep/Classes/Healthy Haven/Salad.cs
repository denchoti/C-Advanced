using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHaven
{
    class Salad
    {
        List<Vegetable> products = new List<Vegetable>();

        public Salad(string name)
        {
            Name = name;
            products = new List<Vegetable>();
        }

        public string Name { get; set; }

        public int GetTotalCalories()
        {
            return products.Select(x => x.Calories).Sum();
        }
        public int GetProductCount()
        {
            return products.Count;
        }
        public void Add(Vegetable product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int calories = GetTotalCalories();
            
            sb.AppendLine($"* Salad {Name} is {calories} calories and have {products.Count} products:");
            foreach (var item in products)
            {
                sb.AppendLine(item.ToString().TrimEnd());
            }
            return sb.ToString().TrimEnd();
        }
    }
}

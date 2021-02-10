using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantasBagOfPresents
{
    public class Bag
    {
        private List<Present> bag;

        public Bag(string color, int capacity)
        {        
            Color = color;
            Capacity = capacity;
            bag = new List<Present>();
        }

        public string Color { get; set; }
        public int Capacity { get; set; }

        public void Add(Present present)
        {
            if (bag.Count + 1 <= Capacity)
            {
                bag.Add(present);
            }
        }
        public bool Remove(string name)
        {
            foreach (var present in bag)
            {
                if (present.Name == name)
                {
                    bag.Remove(present);
                    return true;
                }

            }
            return false;
        }

        public Present GetHeaviestPresent()
        {
           return bag.OrderByDescending(x => x.Weight).FirstOrDefault();
        
        }

        public Present GetPresent(string name)
        {
            return bag.Where(x => x.Name == name).FirstOrDefault();
           
        }

        public int Count => bag.Count;

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag contains:");
         
            foreach (var present in bag)
            {
                sb.AppendLine($"Present {present.Name} for a {present.Gender}");
            }

            return sb.ToString().Trim();
        }
    }
}

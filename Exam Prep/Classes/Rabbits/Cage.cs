using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            rabbits = new List<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }


        public void Add(Rabbit rabbit)
        {
            if (rabbits.Count < Capacity)
            {
                rabbits.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            foreach (var bunny in rabbits)
            {
                if (bunny.Name == name)
                {
                    rabbits.Remove(bunny);
                    return true;
                }
            }
            return false;
        }


        public void RemoveSpecies(string species)
        {
            foreach (var bunny in rabbits)
            {
                if (bunny.Species == species)
                {
                    rabbits.Remove(bunny);
                }
            }
        }

        public Rabbit SellRabbit(string name)
        {
            foreach (var bunny in rabbits)
            {
                if (bunny.Name == name)
                {
                    bunny.Available = false;
                    return bunny;
                    
                }
            }
            return rabbits.FirstOrDefault();
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> sold = new List<Rabbit>();
            //Rabbit[] sold = new Rabbit[rabbits.Count];
            foreach (var bunny in rabbits)
            {
                if (bunny.Species == species)
                {
                    bunny.Available = false;
                    sold.Add(bunny);
                }
            }
            return sold.ToArray();
        }

        public int Count => rabbits.Count;

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");

            foreach (var bunny in rabbits)
            {
                if (bunny.Available == true)
                {
                   sb.AppendLine($"{bunny}").ToString();
                }
            }
            return sb.ToString().Trim();
        }
    }
}

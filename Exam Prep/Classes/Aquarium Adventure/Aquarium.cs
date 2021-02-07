using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquariumAdventure
{
    public class Aquarium
    {
        public List<Fish> fishInPool = new List<Fish>();

        public Aquarium(string name, int capacity, int size)
        {
            Name = name;
            Capacity = capacity;
            Size = size;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Size { get; set; }

        public void Add(Fish fish)
        {
            if (!fishInPool.Contains(fish) && fishInPool.Count + 1 < Capacity)
            {
                fishInPool.Add(fish);
            }
        }
        public bool Remove(string name)
        {
            foreach (var fish in fishInPool)
            {
                if (fish.Name == name)
                {
                    fishInPool.Remove(fish);
                    return true;
                }
            }
            return false;
        }

        public Fish FindFish(string name)
        {
            Fish fish = fishInPool.FirstOrDefault(x => x.Name == name);
            return fish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Aquarium: {Name} ^ Size: {Size}");
            foreach (var fish in fishInPool)
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}

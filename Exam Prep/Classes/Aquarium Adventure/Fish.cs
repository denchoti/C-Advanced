using System;
using System.Collections.Generic;
using System.Text;

namespace AquariumAdventure
{
    public class Fish
    {
        public Fish(string name, string color, int fins)
        {
            Name = name;
            Color = color;
            Fins = fins;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Fins { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fish: {Name}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Number of fins: {Fins}");

            return sb.ToString().TrimEnd();

        }
    }
}

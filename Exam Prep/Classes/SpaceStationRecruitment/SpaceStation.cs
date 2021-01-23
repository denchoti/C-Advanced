using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StartUp
{
    public class SpaceStation
    {
        public List<Astronaut> astronauts = new List<Astronaut>();
        public SpaceStation(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            astronauts = new List<Astronaut>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => astronauts.Count;

        public void Add(Astronaut astronaut)
        {
            if (astronauts.Count < Capacity)
            {
                astronauts.Add(astronaut);
            }
            
        }

        public bool Remove(string name)
        {
            foreach (var astronaut in astronauts)
            {
                if (astronaut.Name == name)
                {
                    astronauts.Remove(astronaut);
                    return true;
                }
            }
            return false;
        }
        public Astronaut GetOldestAstronaut()
        {
            //Astronaut result = new Astronaut(string.Empty, int.MinValue, string.Empty);
            //foreach (var astronaut in astronauts)
            //{
            //    if (astronaut.Age > result.Age)
            //    {
            //        result = astronaut;
            //    }
            //}

            return astronauts.OrderByDescending(x => x.Age).FirstOrDefault();
             
        }

        public Astronaut GetAstronaut(string name)
        {
            //Astronaut result = null;
            //foreach (var astronaut in astronauts)
            //{
            //    if (astronaut.Name == name)
            //    {
            //        result = astronaut;
            //        break;
            //    }
            //}
            //return result;
            return astronauts.FirstOrDefault(x => x.Name == name);
        }

       public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Astronauts working at Space Station {Name}:");

            foreach (var astronaut in astronauts)
            {
                sb.AppendLine(astronaut.ToString());
            }
            return sb.ToString().TrimEnd();
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
   public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            Name = name;
            gladiators = new List<Gladiator>();
            
        }

        public string Name { get; set; }

        public int Count => gladiators.Count();

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);

        }
       
        public void Remove(string name)
        {
            //foreach (var item in gladiators)
            //{
            //    if (item.Name == name)
            //    {
            //        gladiators.Remove(item);
            //    }
            //}

            for (int i = 0; i < gladiators.Count; i++)
            {
                if (gladiators[i].Name == name)
                {
                    gladiators.RemoveAt(i);
                   
                }
            }
        }
        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator highestStatPower = gladiators[0];

            foreach (var gladiator in gladiators)
            {
                if (gladiator.GetStatPower() > highestStatPower.GetStatPower())
                {
                    highestStatPower = gladiator;
                }
            }
            return highestStatPower;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator highestWeaponPower = gladiators[0];

            foreach (var gladiator in gladiators)
            {
                if (gladiator.GetWeaponPower() > highestWeaponPower.GetWeaponPower())
                {
                    highestWeaponPower = gladiator;
                }
            }
            return highestWeaponPower;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator highestTotalPower = gladiators[0];

            foreach (var gladiator in gladiators)
            {
                if (gladiator.GetTotalPower() > highestTotalPower.GetTotalPower())
                {
                    highestTotalPower = gladiator;
                }
            }
            return highestTotalPower;
        }

       
        public override string ToString()
        {
            return $"{Name} - {gladiators.Count} gladiators are participating.";
        }
    }
}

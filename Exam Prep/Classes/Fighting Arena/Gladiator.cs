using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            Name = name;
            Stat = stat;
            Weapon = weapon;
        }

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetStatPower()
        {
            int power = Stat.Agility + Stat.Flexibility + Stat.Intelligence 
                       + Stat.Skills + Stat.Strength;
            return power;
        }
        public int GetWeaponPower()
        {
            int power = Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            return power;
        }
        public int GetTotalPower()
        {
            return GetWeaponPower() + GetStatPower();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} - {GetTotalPower()}");
            sb.AppendLine($"  Weapon Power: {GetWeaponPower()}");
            sb.AppendLine($"  Stat Power: {GetStatPower()}");

            return sb.ToString();
        }

    }
}

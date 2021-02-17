using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;
        public HeroRepository()
        {
            heroes = new List<Hero>();
        }

        public void Add(Hero hero)
        {
            heroes.Add(hero);
        }

        public void Remove(string name)
        {
            //foreach (var item in heroes)
            //{
            //    if (item.Name == name)
            //    {
            //        heroes.Remove(item);
            //    }
            //}

            heroes = heroes.Where(x => x.Name != name).Select(x => x).ToList();
        }

        public Hero GetHeroWithHighestStrength()
        {
            return heroes.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
        }

        public Hero GetHeroWithHighestAbility()
        {
            return heroes.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return heroes.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
        }

        public int Count => heroes.Count;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var hero in heroes)
            {
                sb.AppendLine(hero.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

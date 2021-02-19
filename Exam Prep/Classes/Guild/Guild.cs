using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roster = new List<Player>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }


        public void AddPlayer(Player player)
        {
                if (roster.Count < Capacity)
                {
                    roster.Add(player);
                }
        }
        public bool RemovePlayer(string name)
        {
            //roster = roster.Where(x => x.Name != name).Select(x => x).ToList();
            foreach (var player in roster)
            {
                if (player.Name == name)
                {
                    roster.Remove(player);
                    return true;
                }
            }
            return false;
        }
        public void PromotePlayer(string name)
        {
            foreach (var player in roster)
            {
                if (player.Name == name)
                {
                    player.Rank = "Member";
                    break;
                }
            }
        }
        public void DemotePlayer(string name)
        {
            foreach (var player in roster)
            {
                if (player.Name == name)
                {
                    player.Rank = "Trial";
                    break;
                }
            }
        }

        public Player[] KickPlayersByClass(string @class) 
        {
            List<Player> removed = new List<Player>();
            removed = roster.Where(x => x.Class == @class).Select(y => y).ToList();
            roster = roster.Where(x => x.Class != @class).Select(y => y).ToList();

            return removed.ToArray();
        }
        public int Count => roster.Count();

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {Name}");
            foreach (var player in roster)
            {
                sb.AppendLine($"{player}").ToString();
            }
            return sb.ToString().Trim();
        }
    }
}

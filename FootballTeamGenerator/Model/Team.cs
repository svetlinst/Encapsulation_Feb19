using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator.Model
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A name should not be empty.");
                }
                name = value;
            }
        }

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public double Rating
        {
            get
            {
                return this.players.Average(s => s.OverallSkillLevel);
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            this.players.Remove(player);
        }
    }
}

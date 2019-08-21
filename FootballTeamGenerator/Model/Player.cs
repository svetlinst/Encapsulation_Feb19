using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator.Model
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        private const int minSkill = 0;
        private const int maxSkill = 100;

        public Player(string name, int endurance, int spirit, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                if (value<minSkill || value>maxSkill)
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }
                endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (value < minSkill || value > maxSkill)
                {
                    throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
                }
                sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (value < minSkill || value > maxSkill)
                {
                    throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
                }
                dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                if (value < minSkill || value > maxSkill)
                {
                    throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
                }
                passing = value;
            }
        }

        public int Shooting
        {
            get => this.shooting;
            private set
            {
                if (value < minSkill || value > maxSkill)
                {
                    throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100.");
                }
                shooting = value;
            }
        }

        public double OverallSkillLevel
        {
            get
            {
                return Passing * Shooting * Dribble * Sprint * Endurance / 5;
            }
        }
    }
}

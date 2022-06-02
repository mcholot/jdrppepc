using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class CreateRace
    {
        public string name;
        public int life_point;
        public int strength;
        public int agility;
        public int intelligence;
        public int initiative;
        public int social;

        public CreateRace(string Name, int Life_point, int Strength, int Agility, int Intelligence, int Initiative, int Social)
        {
            name = Name;
            life_point = Life_point;
            strength = Strength;
            agility = Agility;
            intelligence = Intelligence;
            initiative = Initiative;
            social = Social;
        }
    }

    public class Races
    {
        private int id;
        private string name;
        private int life_point;
        private int strength;
        private int agility;
        private int intelligence;
        private int initiative;
        private int social;

        public Races(int Id, string Name, int Life_point, int Strength, int Agility, int Intelligence, int Initiative, int Social)
        {
            id = Id;
            name = Name;
            life_point = Life_point;
            strength = Strength;
            agility = Agility;
            intelligence = Intelligence;
            initiative = Initiative;
            social = Social;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Life_point
        {
            get
            {
                return life_point;
            }
            set
            {
                life_point = value;
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
            }
        }

        public int Agility
        {
            get
            {
                return agility;
            }
            set
            {
                agility = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                intelligence = value;
            }
        }

        public int Initiative
        {
            get
            {
                return initiative;
            }
            set
            {
                initiative = value;
            }
        }

        public int Social
        {
            get
            {
                return social;
            }
            set
            {
                social = value;
            }
        }
    }
}

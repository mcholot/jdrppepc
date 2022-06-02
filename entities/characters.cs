using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{

    public class CreateCharacters
    {
        public string name;
        public int level;
        public string biography;
        public int melee_damage;
        public int remote_damage;
        public int defense;
        public int life_point;
        public int strength;
        public int agility;
        public int intelligence;
        public int initiative;
        public int social;
        public bool is_npc;
        public int userId;
        public int classId;
        public int raceId;

        public CreateCharacters(string Name, int Level, string Biography, int M_d, int R_d, int Defense, int Life_point, int Strength, int Agility, int Intelligence, int Initiative, int Social, bool Is_npc, int Ui, int Ci, int Ri)
        {
            name = Name;
            level = Level;
            biography = Biography;
            melee_damage = M_d;
            remote_damage = R_d;
            defense = Defense;
            life_point = Life_point;
            strength = Strength;
            agility = Agility;
            intelligence = Intelligence;
            initiative = Initiative;
            social = Social;
            is_npc = Is_npc;
            userId = Ui;
            classId = Ci;
            raceId = Ri;
        }
    }
    public class Characters
    {
        private int id;
        private string name;
        private int level;
        private string biography;
        private int melee_damage;
        private int remote_damage;
        private int defense;
        private int life_point;
        private int strength;
        private int agility;
        private int intelligence;
        private int initiative;
        private int social;
        private bool is_npc;
        private int userId;
        private int classId;
        private int raceId;

        public Characters() { }

        public Characters(int Id, string Name, int Level, string Biography, int Melee_damage, int Remote_damage, int Defense, int Life_point, int Strength, int Agility, int Intelligence, int Initiative, int Social, bool Is_npc, int UserId, int ClassId, int RaceId)
        {
            id = Id;
            name = Name;
            level = Level;
            biography = Biography;
            melee_damage = Melee_damage;
            remote_damage = Remote_damage;
            defense = Defense;
            life_point = Life_point;
            strength = Strength;
            agility = Agility;
            intelligence = Intelligence;
            initiative = Initiative;
            social = Social;
            is_npc = Is_npc;
            userId = UserId;
            classId = ClassId;
            raceId = RaceId;
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

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public string Biography
        {
            get
            {
                return biography;
            }
            set
            {
                biography = value;
            }
        }

        public int Melee_damage
        {
            get
            {
                return melee_damage;
            }
            set
            {
                melee_damage = value;
            }
        }

        public int Remote_damage
        {
            get
            {
                return remote_damage;
            }
            set
            {
                remote_damage = value;
            }
        }

        public int Defense
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
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

        public bool Is_npc
        {
            get
            {
                return is_npc;
            }
            set
            {
                is_npc = value;
            }
        }

        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        public int ClassId
        {
            get
            {
                return classId;
            }
            set
            {
                classId = value;
            }
        }

        public int RaceId
        {
            get
            {
                return raceId;
            }
            set
            {
                raceId = value;
            }
        }

    }
}

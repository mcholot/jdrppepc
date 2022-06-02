using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class CreateSkills
    {
        
        public string name;
        public string stat;

        public CreateSkills( string Name, string Stat)
        {
            
            name = Name;
            stat = Stat;
        }
    }

    public class Skills
    {
        private int id;
        private string name;
        private string stat;

        public Skills() { }
        public Skills(int Id, string Name, string Stat)
        {
            id = Id;
            name = Name;
            stat = Stat;
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
        public string Stat
        {
            get
            {
                return stat;
            }
            set
            {
                stat = value;
            }
        }
    }
}

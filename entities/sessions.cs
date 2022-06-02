using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class CreateSessions
    {
        public int id;
        public string name;

        public CreateSessions(int Id, string Name)
        {
            id = Id;
            name = Name;
        }
    }

    public class Sessions
    {
        private int id;
        private string name;


        public Sessions(int Id, string Name)
        {
            id = Id;
            name = Name;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class CreateRooms
    {
        public int id;
        public string name;

        public CreateRooms(int Id, string Name)
        {
            id = Id;
            name = Name;
        }
    }

    public class Rooms
    {
        private int id;
        private string name;


        public Rooms(int Id, string Name)
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

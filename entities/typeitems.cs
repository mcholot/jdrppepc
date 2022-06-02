using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class CreateTypeitems
    {
        public int id;
        public string name;
        public string description;

        public CreateTypeitems(int Id, string Name, string Description)
        {
            id = Id;
            name = Name;
            description = Description;
        }
    }

    public class Typeitems
    {
        private int id;
        private string name;
        private string description;


        public Typeitems(int Id, string Name, string Description)
        {
            id = Id;
            name = Name;
            description = Description;
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
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
    }
}

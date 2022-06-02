using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class CreateRarityItems
    {
        public int id;
        public string name;

        public CreateRarityItems(int Id, string Name)
        {
            id = Id;
            name = Name;
        }
    }

    public class Rarityitems
    {
        private int id;
        private string name;

        public Rarityitems(int Id, string Name)
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

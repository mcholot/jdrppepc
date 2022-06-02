using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe
{
    public class CreateItems
    {
        public string name;
        public string description;
        public int rarityItemId;

        public CreateItems(string Name, string Description, int RarityItemId)
        {
            name = Name;
            description = Description;
            rarityItemId = RarityItemId;
        }
    }
    public class Items
    {
        private int id;
        private string name;
        private string description;
        private int rarityItemId;

        public Items() { }

        public Items(int Id, string Name, string Description, int RarityItemId)
        {
            id = Id;
            name = Name;
            description = Description;
            rarityItemId = RarityItemId;
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
                if (value == null)
                {
                    name = "ERREUR NULL";
                }
                else
                {
                    name = value;
                }
                
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
                if (value == null)
                {
                    description = "ERREUR NULL";
                }
                else
                {
                    description = value;
                }

                
            }
        }
        public int RarityItemId
        {
            get
            {
                return rarityItemId;
            }
            set
            {
                if (value == null)
                {
                    rarityItemId = -1;
                }
                else
                {
                    rarityItemId = value;
                }
            }
        }
    }
}

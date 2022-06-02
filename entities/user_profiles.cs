using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class CreateUser_profiles
    {
        public int characterId;
        public int itemId;

        public CreateUser_profiles(int CharacterId, int ItemId)
        {
            characterId = CharacterId;
            itemId = ItemId;
        }
    }

    public class User_profiles
    {
        private int characterId;
        private int itemId;

        public User_profiles(int CharacterId, int ItemId)
        {
            characterId = CharacterId;
            itemId = ItemId;
        }

        public int CharacterId
        {
            get
            {
                return characterId;
            }
            set
            {
                characterId = value;
            }
        }
        public int ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
            }
        }
    }
}

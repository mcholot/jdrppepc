using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class CreateRoom_characters
    {
        public int roomId;
        public int characterId;

        public CreateRoom_characters(int RoomId, int CharacterId)
        {
            roomId = RoomId;
            characterId = CharacterId;
        }
    }

    public class Room_characters
    {
        private int roomId;
        private int characterId;
        
        public Room_characters(int RoomId, int CharacterId)
        {
            roomId = RoomId;
            characterId = CharacterId;
        }

        public int RoomId
        {
            get
            {
                return roomId;
            }
            set
            {
                roomId = value;
            }
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
    }
}

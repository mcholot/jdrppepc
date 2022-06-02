using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class CreateMessages
    {
        public int id;
        public string message;
        public int characterId;
        public int roomId;

        public CreateMessages(int Id, string Message, int CharacterId, int RoomId)
        {
            id = Id;
            message = Message;
            characterId = CharacterId;
            roomId = RoomId;
        }
    }

    public class Messages
    {
        private int id;
        private string message;
        private int characterId;
        private int roomId;


        public Messages(int Id, string Message, int CharacterId, int RoomId)
        {
            id = Id;
            message = Message;
            characterId = CharacterId;
            roomId = RoomId;
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
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
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
    }
}

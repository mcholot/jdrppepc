using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class CreateTypeitem_items
    {
        public int itemId;
        public int typeItemId;

        public CreateTypeitem_items(int ItemId, int TypeItemId)
        {
            itemId = ItemId;
            typeItemId = TypeItemId;
        }
    }

    public class Typeitem_items
    {
        private int itemId;
        private int typeItemId;


        public Typeitem_items(int ItemId, int TypeItemId)
        {
            itemId = ItemId;
            typeItemId = TypeItemId;
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
        public int TypeItemId
        {
            get
            {
                return typeItemId;
            }
            set
            {
                typeItemId = value;
            }
        }
    }
}

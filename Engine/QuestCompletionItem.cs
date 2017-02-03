using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public  class QuestCompletionItem
    {

        public List<InventoryItem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }


        public Item Details { get; set; }
        public int Quantity { get; set; }
        public QuestCompletionItem(Item details,int quantity)
        {
            Details = details;
            Quantity = quantity;

            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();/* empty lists to prevent the values to default to null*/
                            /* so we can add items to them later ,you cant add items to nothing(null)*/
        }
    }
}

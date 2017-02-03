using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Quests have items that need to be turned in,to complete them
 * We need to store the quantity of each item that is needed to complete the Quest
 */
namespace Engine
{
    public class Quest
    {
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints{get;set;}
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }//stores what item the Player gets when he wins quest

        public Quest(int id,string name,string description,int rewardExperiencePoints,int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;

            QuestCompletionItems = new List<QuestCompletionItem>();
            /* make it empty so we can add items later*/
        }
    }
}

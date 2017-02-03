using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Monsters have items that can be looted from them
 * Monster needs to have more than one Item :) use Lists or Collections
 * The list of items that can be looted from the Monster -> loot table
 * store the item,the percentage of times its dropped
 * check if the item is a default loot item -> incase the random # generator says none of the items dropped
 */
namespace Engine
{
   public  class Monster : LivingCreature
    {
        public List<LootItem> LootTable { get; set; } //list of items that can looted from the monster

        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public Monster(int id,string name,int maximumDamage,int rewardExperiencePoint,int rewardGold,
             int currentHitPoints,int maximumHitPoints)
            :base(currentHitPoints,maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoint;
            RewardGold = rewardGold;

            LootTable = new List<LootItem>();/* make it empty we dont want it to default to null*/
        }

    }
}

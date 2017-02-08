using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Player will be able to have Items in their inventory
 * Player will have Quests
 * Player needs more than one Quest and more than one Item :) use Lists or Collections
 * We need to store the quantity of each items the Player has in the inventory
 * For the Player Quest we also need a place to record whether or not the Player has completed the Quest
 */
namespace Engine
{
    /*public class Player because it has to be visible in the whole solution
     * this is because we want the UI project to be able to create a Player object
     * and read the values of its properties
     */
    public class Player : LivingCreature
    {
        public List<InventoryItem> Inventory;// TODO: Francis just trying
        //the players current location
        public Location currentLocation { get; set; }
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public Player(int gold,int experiencePoints,int level,int currentHitPoints,int maximumHitPoints)
            :base(currentHitPoints,maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;

            //TODO Francis: clear this shit up

            //this code might not supposed to be here
            Inventory = new List<InventoryItem>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /* At a certain Location we can store an item,a quest, and maybe check if there is a monster*/
        /* these properties hold the above values for each location*/
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToWest { get; set; }
        public Location LocationToSouth { get; set; }

        //public ctor so we can create a location from anywhere in the solution
        public Location(int id,string name,string description,
            Item itemRequiredToEnter=null,
            Quest questAvailableHere=null,
            Monster monsterLivingHere=null //incase Player didnt pass in the location it defaults to null
            )
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class PlayerQuest
    {
        public Quest Details { get; set; } //the Quest the Player undertakes
        public bool IsCompleted { get; set; }
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false; //will only be true after the player completes the Quest
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        //we dont need anything outside of this screen to use it
        private Player _player;
        private Monster _currentMonster;

        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1,"Home","Description");
         

            _player = new Player(10,10,20,0,1);


            IbIHitPoints.Text = _player.CurrentHitPoints.ToString();
            IbIGold.Text = _player.Gold.ToString();
            IbIExperience.Text = _player.ExperiencePoints.ToString();
            IbILevel.Text = _player.Level.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNorth1_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }
        private void moveTo(Location newLocation)
        {
            //moves the player to a new location
            if (newLocation.ItemRequiredToEnter != null)
            {
                //an item is required to enter this location
                //check if the player has the required item in their inventory

                bool playerHasRequiredItem = false;

                foreach(InventoryItem ii in _player.Inventory)
                {
                    if(ii.Details.ID==newLocation.ItemRequiredToEnter.ID)
                    {
                        //found the required item
                        playerHasRequiredItem = true;

                        break;//exit out of the foreach loop

                    }
                }
                if(!playerHasRequiredItem)
                {
                    //we didnt find the required item in their inventory,
                    //display message and stop trying to move
                    rtMessages.Text = @"You must have a " + newLocation.ItemRequiredToEnter.Name +
                            " to enter this location. " + Environment.NewLine;

                    return;

                }
            }

            //update the players current location
            _player.currentLocation = newLocation;

            //show/Hide  the available movement buttons
            btnNorth1.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);
            btnWest.Visible = (newLocation.LocationToWest != null);

            //display the current name and location
            rtLocation.Text = newLocation.Name + Environment.NewLine;
            rtLocation.Text += newLocation.Description + Environment.NewLine;

            //completely heal the player
            _player.CurrentHitPoints = _player.MaximumHitPoints;

            //update the hitPoints in UI
            IbIHitPoints.Text = _player.CurrentHitPoints.ToString(); 
        }
    }
}

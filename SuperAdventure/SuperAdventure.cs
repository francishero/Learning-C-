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
    }
}

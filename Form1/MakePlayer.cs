using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAdventureLibrary;

namespace AdventureMaker
{
    public partial class MakePlayer : Form
    {
        private AdventureGame game = new();

        private Player player = new();
        public MakePlayer(AdventureGame adventuregame)
        {
            game = adventuregame;
            InitializeComponent();
            InitCheckListbox();
            InitListbox();
        }

        private void btnaddinventory_Click(object sender, EventArgs e)
        {
            foreach(var c in clboxaddobjects.Items)
            {
                player.Inventory.Add(game.Objects.Find(x => x.Name == c.ToString()));
            }
            InitListbox();
        }

        private void InitListbox()
        {
            lboxplayerinventory.Items.Clear();  
            foreach(var c in player.Inventory)
            {
                lboxplayerinventory.Items.Add(c.Name);
            }
        }

        private void InitCheckListbox()
        {
            clboxaddobjects.Items.Clear();
            foreach (var c in game.Objects)
            {
                clboxaddobjects.Items.Add(c.Name);
            }
        }
        private void lboxplayerinventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnremoveinventory_Click(object sender, EventArgs e)
        {
            foreach(var c in lboxplayerinventory.SelectedItems)
            {
                player.Inventory.Remove(player.Inventory.Find(x => x.Name == c.ToString()));
            }
            InitListbox();
        }

        private void btncreateplayer_Click(object sender, EventArgs e)
        {
            
            player.Health = int.Parse(tboxplayerhealth.Text);
            player.Name = tboxplayername.Text;
            player.Description = rtboxsummary.Text;
            player.Strength = int.Parse(tboxplayerstrength.Text);
            game.Players.Add(player);
            MainForm form = new MainForm(game);
            form.Show();
            this.Close();
        }
    }
}

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
   
    public partial class EditPlayer : UserControl
    {
        private AdventureGame game = new();

        private Player player = new();

        private Room room = new();

        private bool isroom;

        public EditPlayer(AdventureGame adventuregame)
        {
            game = adventuregame;
            InitializeComponent();
            InitCheckListbox();
            InitListbox();

        }


        public EditPlayer(AdventureGame adventuregame, Player _player)
        {
            game = adventuregame;
            player = _player;
            InitializeComponent();


        }

        public EditPlayer(AdventureGame adventuregame, Player _player, Room _room)
        {
            game = adventuregame;
            player = _player;
            room = _room;
            isroom = true;
            InitializeComponent();

        }

        public void LoadPlayer()
        {
            if (player.Name != "")
            {
                tboxplayername.Text = player.Name;
                tboxplayerhealth.Text = player.Health.ToString();
                tboxplayerstrength.Text = player.Strength.ToString();
                rtboxsummary.Text = player.Description;


            }
        }

        public void SavePlayer()
        {
            int health;
            int strength;

            if (int.TryParse(tboxplayerhealth.Text, out health) && int.TryParse(tboxplayerstrength.Text, out strength))
            {
                player.Name = tboxplayername.Text;
                player.Health = health;
                player.Strength = strength;
                player.Description = rtboxsummary.Text;
            }
            
           
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            LoadPlayer();
            InitCheckListbox();
            InitListbox();
            
        }

        private void btnaddinventory_Click(object sender, EventArgs e)
        {
            foreach (var c in clboxaddobjects.CheckedItems)
            {
                player.Inventory.Add(game.Objects.Find(x => x.Name == c.ToString()));;
               
            }
            InitCheckListbox();
            InitListbox();
        }
        private void InitListbox()
        {
            lboxplayerinventory.Items.Clear();
            lboxsynonyms.Items.Clear();
            foreach (var c in player.Inventory)
            {
                lboxplayerinventory.Items.Add(c.Name);
            }
            foreach(var c in player.Keywords)
            {
                lboxsynonyms.Items.Add(c);
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

        private void btnremoveinventory_Click(object sender, EventArgs e)
        {
            foreach (var c in lboxplayerinventory.SelectedItems)
            {
                player.Inventory.Remove(player.Inventory.Find(x => x.Name == c.ToString()));
            }
            InitListbox();
        }

        private void btncreateplayer_Click(object sender, EventArgs e)
        {
            SavePlayer();
            if (isroom == true)
            {
                room.Players.Add(player);
                RoomMaker roommaker = new(game, room);
                roommaker.Show();
                ((MakePlayer)this.TopLevelControl).Close();
            }
            game.Players.Add(player);
            MainForm form = new MainForm(game);
            form.Show();
            ((MakePlayer)this.TopLevelControl).Close();
        }

        private void btneditinventory_Click(object sender, EventArgs e)
        {
            if (lboxplayerinventory.SelectedItem != null)
            {
                SavePlayer();
                Objects objectss = new(game, player.Inventory.Find(x => x.Name == lboxplayerinventory.SelectedItem), player);
                objectss.Show();
                ((MakePlayer)this.TopLevelControl).Close();
            }
        }

        private void btnaddsynonym_Click(object sender, EventArgs e)
        {
            player.Keywords.Add(tboxsynonyms.Text);
            InitListbox();
        }

        private void btnremovesynonym_Click(object sender, EventArgs e)
        {
            player.Keywords.Remove((String)lboxsynonyms.SelectedItem);
            InitListbox();
        }
    }
}

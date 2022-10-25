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
using System.Text.Json;
using System.Text.Json.Serialization;
using AdventureMaker;
using System.Runtime.CompilerServices;

namespace Form1
{
    public partial class MainForm : Form
    {
        public AdventureGame AdventureGame { get; set; } = new AdventureGame();
        public MainForm(AdventureGame game)
        {
            AdventureGame = game;
            InitializeComponent();
            InitObjects();
            InitPlayers();
            InitRooms();
            tboxgamename.Text = game.Name; 
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnaddobject_Click(object sender, EventArgs e)
        {
            Objects objects = new(AdventureGame);
            objects.Show();
            this.Close();
        }

        private void tboxgamename_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsavename_Click(object sender, EventArgs e)
        {
            AdventureGame.Name = tboxgamename.Text;
        }

        private void InitObjects()
        {
            lboxobjects.Items.Clear();
            if(AdventureGame.Objects.Count > 0)
            {
                foreach (var c in AdventureGame.Objects)
                {
                    lboxobjects.Items.Add(c.Name);
                }
            }
           
        }

        private void InitRooms()
        {
            lboxrooms.Items.Clear();
            if (AdventureGame.Rooms.Count > 0)
            {
                foreach (var c in AdventureGame.Rooms)
                {
                    lboxrooms.Items.Add(c.Name);
                }
            }
            
           
        }

        private void InitPlayers()
        {
            if (AdventureGame.Players.Count > 0)
            {
                lboxplayers.Items.Clear();
                foreach (var c in AdventureGame.Players)
                {
                    lboxplayers.Items.Add(c.Name);
                }
            }

        }
           
            

        private void InitVerbs()
        {
            lboxverbs.Items.Clear();
            foreach (var c in AdventureGame.Verbs)
            {
                lboxverbs.Items.Add(c.WordString);
            }
        }

        private void lblitems_Click(object sender, EventArgs e)
        {

        }

        private void btnremoveobject_Click(object sender, EventArgs e)
        {
            if(lboxobjects.SelectedItems.Count > 0)
            {
             foreach(var c in lboxobjects.SelectedItems)
                {
                    AdventureGame.Objects.Remove(AdventureGame.Objects.Find(x => x.Name == c));
                }
               
            }
            InitObjects();
        }

        private void btnsavegame_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new();
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string jsonString = JsonSerializer.Serialize(AdventureGame);
                File.WriteAllText(sfd.FileName, jsonString);

            }




            /*FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            
            string fileName = (folder.SelectedPath + "\\" + tboxgamename.Text + ".txt");
            File.WriteAllText(fileName, jsonString); */
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            MakePlayer makePlayer = new MakePlayer(AdventureGame);
            makePlayer.Show();
            this.Close();
        }

        private void btnremoveplayers_Click(object sender, EventArgs e)
        {
            foreach( var c in lboxplayers.SelectedItems)
            {
                AdventureGame.Players.Remove(AdventureGame.Players.Find(x => x.Name == c));
            }
            InitPlayers();
        }

        private void btneditobjects_Click(object sender, EventArgs e)
        {
            Objects objects = new(AdventureGame, AdventureGame.Objects.Find(x => x.Name == lboxobjects.SelectedItem));
            objects.Show();
            this.Close();
            
        }

        private void btneditplayers_Click(object sender, EventArgs e)
        {
            MakePlayer makePlayer = new(AdventureGame, AdventureGame.Players.Find(x => x.Name == lboxplayers.SelectedItem));
            makePlayer.Show();
            this.Close();
        }

        private void btnaddrooms_Click(object sender, EventArgs e)
        {
           RoomMaker room = new(AdventureGame);
           room.Show();
           this.Close();
            
          
    
            
        }

        private void btneditrooms_Click(object sender, EventArgs e)
        {
            RoomMaker room = new(AdventureGame, AdventureGame.Rooms.Find(x => x.Name == lboxrooms.SelectedItem.ToString()));
            room.Show();
            this.Close();
        }
    }
}

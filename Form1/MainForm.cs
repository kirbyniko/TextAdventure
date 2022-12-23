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
using System.Diagnostics;

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
            InitVerbs();
            InitStats();
            tboxgamename.Text = game.Name;
        }

        public MainForm()
        {
            InitializeComponent();
            AdventureGame.InitLists();
            InitVerbs();
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
            if (AdventureGame.Objects.Count > 0)
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
                lboxverbs.Items.Add(c.Name);
            }
        }

        private void InitStats()
        {
            lboxstats.Items.Clear();
            foreach (var c in AdventureGame.Stats)
            {
                lboxstats.Items.Add(c.Name);
            }
        }

        private void lblitems_Click(object sender, EventArgs e)
        {

        }

        private void btnremoveobject_Click(object sender, EventArgs e)
        {
            if (lboxobjects.SelectedItems.Count > 0)
            {
                foreach (var c in lboxobjects.SelectedItems)
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
            foreach (var c in lboxplayers.SelectedItems)
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

        private void btnaddverbs_Click(object sender, EventArgs e)
        {
            VerbForm verbform = new(AdventureGame);
            verbform.Show();
            this.Close();

        }

        private void btnremoveverbs_Click(object sender, EventArgs e)
        {
            AdventureGame.Verbs.Remove(AdventureGame.Verbs.Find(x => x.Name == lboxverbs.SelectedItem.ToString()));
            InitVerbs();

        }

        private void btneditverbs_Click(object sender, EventArgs e)
        {
            VerbForm verbform1 = new VerbForm(AdventureGame, AdventureGame.Verbs.Find(x => x.Name == lboxverbs.SelectedItem.ToString()));
            verbform1.Show();
            this.Close();
        }

        private void btnaddstat_Click(object sender, EventArgs e)
        {
            EditStat editStat = new(AdventureGame);
            editStat.Show();
            this.Close();
        }

        private void btnremovestat_Click(object sender, EventArgs e)
        {

            foreach (var c in lboxstats.SelectedItems)
            {
                AdventureGame.Stats.Remove(AdventureGame.Stats.Find(x => x.Name == c));
            }
        }

        private void btneditstat_Click(object sender, EventArgs e)
        {
            if (lboxstats.SelectedItems.Count > 0)
            {
                EditStat editStat = new(AdventureGame, AdventureGame.Stats.Find(x => x.Name == lboxstats.SelectedItem));
                editStat.Show();
                this.Close();
            }

        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {

            OpenFileDialog ol = new OpenFileDialog();
            ol.Title = "Please select the file for your game!";
            ol.ShowDialog();
            string filePath = ol.FileName;


            Process.Start("C:\\Users\\filthymilkman\\source\\repos\\TextAdventure\\TextAdventure\\bin\\Release\\net6.0\\TextAdventure.exe", filePath.ToString());



        }
    }
}

using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAdventureLibrary;

namespace AdventureMaker
{
    public partial class EditObject : UserControl
    {

        private AdventureGame adventureGame;

        private List<string> synonyms { get; set; } = new List<string>();

        private List<string> verbs = new List<string> ();

        private Item item = new Item();

        private Player player = new Player();

        private Room room = new();

        private List<TextBox> textBoxes = new();

        private List<Label> labels = new();

        private Point location;

        private string objecttype;



        public EditObject()
        {
            InitializeComponent();
        }

        public EditObject(AdventureGame Game, Item obj, Player _player)
        {
            player = _player;
            adventureGame = Game;
            item = obj;
            objecttype = "player";

            InitSynonyms();

            InitializeComponent();
        }

        public EditObject(AdventureGame Game, Item obj, Room _room)
        {
            room = _room;
            adventureGame = Game;
            item = obj;
            objecttype = "room";
           

            InitSynonyms();

            InitializeComponent();
        }


        public EditObject(AdventureGame Game, Item obj)
        {
            adventureGame = Game;
            item = obj;
            objecttype = "edit";
            verbs = obj.Verbs;
            InitSynonyms();
            InitializeComponent();
        }

        private void WriteItem()
        {
            item.Name = tboxobjectname.Text;
            item.Keywords.Clear();
            item.Keywords.Add(item.Name.ToLower());
            item.Description = rtboxobjectsummary.Text;
            item.Keywords.AddRange(synonyms);
            item.Verbs = verbs;
        }
        private void InitSynonyms()
        {
            synonyms.Clear();
            foreach (var c in item.Keywords)
            {
                synonyms.Add(c);
            }
        }

        private void LoadStats()
        {
            location = tboxobjectweight.Location;
            foreach (var c in item.Stats)
            {
                TextBox box = new TextBox();
                Label label = new Label();
                label.Text = c.Name;
                box.PlaceholderText = "Type " + c.Name + " here...";
                box.Location = location;
                box.Location.Offset(0, 29);
                label.Location = box.Location;
                label.Location.Offset(120, 3);
                labels.Add(label);
                textBoxes.Add(box);
            }
        }

        private void InitLocations()
        {
            lblobjectsummary.Location = textBoxes.Last().Location;
            lblobjectsummary.Location.Offset(0, 40);
            rtboxobjectsummary.Location = lblobjectsummary.Location;
            rtboxobjectsummary.Location.Offset(0, 18);
        }
        public EditObject(AdventureGame game)
        {
            adventureGame = game;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            synonyms.Add(tboxsynonyms.Text);
            InitListbox();
        }

        public void InitListbox()
        {
            lboxsynonyms.Items.Clear();
            foreach (var c in synonyms)
            {
                lboxsynonyms.Items.Add(c);
            }

            lboxverbs.Items.Clear();

            foreach (var c in verbs)
            {
                lboxverbs.Items.Add(c);
            }

            clboxverbs.Items.Clear();

            foreach (var c in adventureGame.Verbs)
            {
                clboxverbs.Items.Add(c.Name);
            }

        }

        public void LoadItem()
        {
            tboxobjectname.Text = item.Name;
            tboxdropchance.Text = item.DropChance.ToString();
            rtboxobjectsummary.Text = item.Description;
            foreach (var c in synonyms)
            {
                lboxsynonyms.Items.Add(c);
            }
        }

        private void SaveDropchance()
        {
            if (tboxdropchance.Text != "")
            {
                item.DropChance = Convert.ToInt32(tboxdropchance.Text);
            }
            else
            {
                item.DropChance = 0;
            }
        }

        private void SaveItem()
        {


            if (tboxobjectname.Text != "" && rtboxobjectsummary.Text != "")
            {

                SaveDropchance();

                switch (objecttype)
                {
                    case "player":
                        player.Inventory.Remove(item);
                        item = new Item();
                        WriteItem();
                       
                        player.Inventory.Add(item);

                        MakePlayer makeplayer = new(adventureGame, player);
                        makeplayer.Show();
                        ((Objects)this.TopLevelControl).Close();
                        break;

                    case "edit":
                        adventureGame.Objects.Remove(item);
                        WriteItem();
                        adventureGame.Objects.Add(item);
                 
                        MainForm mainForm = new(adventureGame);
                        mainForm.Show();
                        ((Objects)this.TopLevelControl).Close();
                        break;

                    case "room":
                        room.Items.Remove(item);
                        WriteItem();
                        room.Items.Add(item);

                        RoomMaker roomMaker = new(adventureGame, room);
                        roomMaker.Show();
                        ((Objects)this.TopLevelControl).Close();
                        break;
                    default:
                        item = new Item();
                        WriteItem();
                        adventureGame.Objects.Add(item);
                        MainForm mainForm1 = new(adventureGame);
                        mainForm1.Show();
                        ((Objects)this.TopLevelControl).Close();
                        break;

                }
            }
            else
            {
                lblobjectfields.Text = "Fix empty fields!";
            }
        }
        private void btncreateobject_Click(object sender, EventArgs e)
        {
            SaveItem();


        }

        private void btnremovesynonym_Click(object sender, EventArgs e)
        {
            synonyms.Remove((String)lboxsynonyms.SelectedItem);
            InitListbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var c in clboxverbs.CheckedItems)
            {
                verbs.Add(adventureGame.Verbs.Find(x => x.Name == c).Name);
            }
            InitListbox();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            verbs.Remove((String)lboxverbs.SelectedItem);
            InitListbox();

        }
    }
}

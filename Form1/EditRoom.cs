using Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAdventureLibrary;

namespace AdventureMaker
{
    public partial class EditRoom : UserControl
    {
        private AdventureGame adventureGame = new();

        private Room room = new();

        private Room referenceroom = new();
        public EditRoom()
        {
            InitializeComponent();
        }
        public EditRoom(AdventureGame _adventureGame)
        {
            adventureGame = _adventureGame;
            InitializeComponent();
        }
        public EditRoom(AdventureGame adventure, Room _room)
        {
            adventureGame = adventure;
            room = _room;
            
            InitializeComponent();
        }

        public void LoadRoom()
        {
            tboxroomname.Text = room.Name;
            rtboxlongdescription.Text = room.Description;
            rtboxshortdescription.Text = room.ShortDescription;
            if (adventureGame.CurrentRoom == room)
            {
                cboxdefaultroom.Checked = true;
            }
        }

        private void SaveRoom()
        {
            room.Name = tboxroomname.Text;
            room.Description = rtboxlongdescription.Text;
            room.ShortDescription = rtboxshortdescription.Text;
        }
        public void InitListbox()
        {
            lboxroomobjects.Items.Clear();
            lboxsynonyms.Items.Clear();
            lboxroomplayers.Items.Clear();

            foreach (var c in room.Items)
            {
                lboxroomobjects.Items.Add(c.Name);
            }

            foreach (var c in room.Keywords)
            {
                lboxsynonyms.Items.Add(c);
            }

            foreach (var c in room.Players)
            {
                lboxroomplayers.Items.Add(c.Name);
            }

            foreach (var c in room.AdjacentRooms)
            {
                lboxadjacentrooms.Items.Add(c);
            }
        }
        private void InitCheckListbox()
        {
            clboxaddobjects.Items.Clear();
            clboxaddplayers.Items.Clear();
            clboxaddrooms.Items.Clear();

            if(adventureGame.Objects != null)
            {
                foreach (var c in adventureGame.Objects)
                {
                    clboxaddobjects.Items.Add(c.Name);
                }
            }

            if (adventureGame.Players != null)
            {
                foreach (var c in adventureGame.Players)
                {
                    clboxaddplayers.Items.Add(c.Name);
                }
            }

            if (adventureGame.Rooms != null)
            {
                foreach (var c in adventureGame.Rooms)
                {
                    clboxaddrooms.Items.Add(c.Name);
                }
            }


           
        }

        private void lblplayersummary_Click(object sender, EventArgs e)
        {

        }

        private void rtboxsummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddinventory_Click(object sender, EventArgs e)
        { 
            foreach(var c in clboxaddobjects.CheckedItems)
            {
                room.Items.Add(adventureGame.Objects.Find(x => x.Name == c.ToString()));
            }
           
            InitCheckListbox();
            InitListbox();
        }

        private void btnaddplayers_Click(object sender, EventArgs e)
        {
            foreach(var c in clboxaddplayers.CheckedItems)
            {
                room.Players.Add(adventureGame.Players.Find(x => x.Name == c.ToString()));
            }
            InitCheckListbox();
            InitListbox();
        }

        private void btnaddrooms_Click(object sender, EventArgs e)
        {
            foreach (var c in clboxaddrooms.Items)
            {
                room.AdjacentRooms.Add(new AdjacentRoom(adventureGame.Rooms.Find(x => x.Name == c.ToString()).Name, adventureGame.Rooms.Find(x => x.Name == c.ToString())));

            }
            InitCheckListbox();
            InitListbox();
        }

        private void btnaddsynonym_Click(object sender, EventArgs e)
        {
            room.Keywords.Add(tboxsynonyms.Text);
            InitListbox();
        }

        private void btnremovesynonym_Click(object sender, EventArgs e)
        {
            room.Keywords.Remove((String)lboxsynonyms.SelectedItem);
            InitListbox();
        }

        private void btneditinventory_Click(object sender, EventArgs e)
        {
            if (lboxroomobjects.SelectedItem != null)
            {
                SaveRoom();
                Objects objectss = new(adventureGame, room.Items.Find(x => x.Name == lboxroomobjects.SelectedItem), room);
                objectss.Show();
                ((RoomMaker)this.TopLevelControl).Close();
            }
        }

        private void EditRoom_VisibleChanged(object sender, EventArgs e)
        {
            LoadRoom();
            InitCheckListbox();
            InitListbox();
        }

        private void btnremoveinventory_Click(object sender, EventArgs e)
        {
            foreach (var c in lboxroomobjects.SelectedItems)
            {
                room.Items.Remove(room.Items.Find(x => x.Name == c.ToString()));
            }
            InitListbox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveRoom();
            MakePlayer make = new(adventureGame, adventureGame.Players.Find(x => x.Name == lboxroomplayers.SelectedItem), room);
            make.Show();
            ((RoomMaker)this.TopLevelControl).Close();

        }

        private void btncreateroom_Click(object sender, EventArgs e)
        {
            SaveRoom();

            if (adventureGame.Rooms.Contains(adventureGame.Rooms.Find(x => x.Name == room.Name)))
            {
                referenceroom = adventureGame.Rooms.Find(x => x.Name == room.Name);
                referenceroom = room;
                if (cboxdefaultroom.Checked)
                {
                    adventureGame.CurrentRoom = room;
                }
                MainForm main = new MainForm(adventureGame);
                main.Show();
                ((RoomMaker)this.TopLevelControl).Close();

            }
            else
            {
                adventureGame.Rooms.Add(room);

                room.Verbosity = 1;
                if (cboxdefaultroom.Checked)
                {
                    adventureGame.CurrentRoom = room;
                }
                MainForm mainForm = new MainForm(adventureGame);
                mainForm.ShowDialog();
                ((RoomMaker)this.TopLevelControl).Close();
            }
            
           
        }

        private void btnremoveroomplayers_Click(object sender, EventArgs e)
        {
            foreach (var c in lboxroomplayers.SelectedItems)
            {
                room.Players.Remove(room.Players.Find(x => x.Name == c.ToString()));
            }
            InitListbox();
        }
    }
}

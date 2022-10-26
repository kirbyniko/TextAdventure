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
    public partial class RoomMaker : Form
    {
        private AdventureGame adventureGame = new();

        private EditRoom editroom = new();

        private Room referenceroom = new();
        public RoomMaker(AdventureGame game)
        {
            adventureGame = game;
            editroom = new(adventureGame);
            InitializeComponent();
        }
        public RoomMaker(AdventureGame game, Room room)
        {
            adventureGame = game;
            referenceroom = room;
            editroom = new(adventureGame, referenceroom);
            InitializeComponent();
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            editroom.LoadRoom();
            editroom.InitListbox();
            panel1.Controls.Add(editroom);
            panel1.Size = editroom.Size;
            this.Size = panel1.Size + new Size(60, 60);
        }
    }
}

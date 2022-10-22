using AdventureMaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAdventureLibrary;

namespace Form1
{
    public partial class Objects : Form
    {
        private EditObject editobject;

        private AdventureGame adventureGame;

        private string objecttype;

        public Objects(AdventureGame _adventureGame, Item item, Player player)
        {
            adventureGame = _adventureGame;
            objecttype = "player";
            editobject = new(adventureGame, item, player);
            InitializeComponent();
        }

        public Objects(AdventureGame _adventureGame, Item item)
        {
            adventureGame = _adventureGame;
            objecttype = "edit";
            editobject = new(adventureGame, item);
            InitializeComponent();
        }

        public Objects(AdventureGame _adventureGame, Item item, Room room)
        {
            adventureGame = _adventureGame;
            objecttype = "room";
            editobject = new(adventureGame, item, room);
            InitializeComponent();
        }

        public Objects(AdventureGame _adventureGame)
        {
            adventureGame = _adventureGame;

            editobject = new(adventureGame);

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
             editobject.LoadItem();
             editobject.InitListbox();
             panel1.Controls.Add(editobject);
             panel1.Size = editobject.Size;
             this.Size = panel1.Size + new Size(60, 60);
        }
    }
}

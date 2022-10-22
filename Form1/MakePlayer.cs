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

        private EditPlayer editplayer;
        public MakePlayer(AdventureGame adventuregame)
        {
            game = adventuregame;
            editplayer = new EditPlayer(game);
            InitializeComponent();
     
        }

      
        public MakePlayer(AdventureGame adventuregame, Player _player)
        {
            game = adventuregame;
            editplayer = new EditPlayer(game, _player);
            InitializeComponent();
        }

        private void btnaddinventory_Click(object sender, EventArgs e)
        {
        }

      
        private void lboxplayerinventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnremoveinventory_Click(object sender, EventArgs e)
        {
           
        }

        private void btncreateplayer_Click(object sender, EventArgs e)
        {
           
        }

        private void btneditinventory_Click(object sender, EventArgs e)
        {
           
            
        }

        private void MakePlayer_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(editplayer);
            panel1.Size = editplayer.Size;
            this.Size = panel1.Size + new Size(60, 60);
        }
    }
}

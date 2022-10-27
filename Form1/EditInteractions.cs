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
    public partial class EditInteractions : UserControl
    {
        private AdventureGame game = new();
        public EditInteractions(AdventureGame _game)
        {
            game = _game;
            InitializeComponent();
        }

        private void InitCombobox()
        {
            foreach(var c in game.Verbs)
            {
                comboxverbs.Items.Add(c.WordString);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

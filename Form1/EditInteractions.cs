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
            comboxverbs.Items.Clear();
            foreach(var c in game.Verbs)
            {
                comboxverbs.Items.Add(c.Name);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboxInteractions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboxSubjectType.SelectedItem.ToString())
            {
                case "Rooms":
                    break;
                case "Players":
                    break;
                case "Objects":
                    break;
            }

        }

        private void comboxSpecificObject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

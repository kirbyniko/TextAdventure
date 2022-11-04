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
using System.Windows.Forms.Design;
using TextAdventureLibrary;

namespace AdventureMaker
{
    public partial class EditStat : Form
    {
        private AdventureGame game = new();

        private Stat stat = new();

        EditStat editstat = new EditStat();
        public EditStat()
        {
            InitializeComponent();
        }

        public EditStat(AdventureGame _game)
        {
            game = _game;
            editstat = new(_game);
            InitializeComponent();
        }

        public EditStat(AdventureGame _game, Stat _stat)
        {
            game = _game;
            stat = _stat;
            editstat = new EditStat(_game, _stat);
            InitializeComponent();


        }

        private void editStats1_Load(object sender, EventArgs e)
        {
           

        }

        private void EditStat_VisibleChanged(object sender, EventArgs e)
        {
           

        }
    }
}

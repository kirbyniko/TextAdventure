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
    public partial class VerbForm : Form
    {
        EditVerb editverb;

        Word word = new();

        AdventureGame game = new();
        public VerbForm(AdventureGame _game)
        {
            game = _game;
            editverb = new(game);
            InitializeComponent();
        }

        public VerbForm(AdventureGame _game, Word _word)
        {
            word = _word;
            game = _game;
            editverb = new(game, word);
            InitializeComponent();
        }
    }
}

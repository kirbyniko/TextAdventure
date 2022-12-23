using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TextAdventureLibrary;
using Form1;

namespace AdventureMaker
{
    public partial class EditVerb : UserControl
    {

        AdventureGame Game = new();

        Word verb = new();

        private bool edit;

        private List<String> synonyms = new List<string>();


        public EditVerb(AdventureGame _game)
        {
            Game = _game;
            InitializeComponent();
            
        }

        public EditVerb()
        {
            InitializeComponent();

        }

        public EditVerb(AdventureGame _game, Word word)
        {
            Game = _game;
            verb = word;
            edit = true;
            InitializeComponent();
        }

        public void LoadWord()
        {
            tboxverbname.Text = verb.Name;
            synonyms = verb.Keywords;
            
           
        }

        public void InitListbox()
        {
            lboxsynonyms.Items.Clear();
            foreach (var a in synonyms)
            {
                lboxsynonyms.Items.Add(a);
            }
        }
        public void SaveWord()
        {
            if(tboxverbname.Text.ToString() != "")
            {
               verb.Name = tboxverbname.Text;
               verb.Keywords = synonyms;
            }
            else
            {
                lblfillfields.Text = "Please fill in a name!";
            }
           
        }


        private void EditVerb_Load(object sender, EventArgs e)
        {
            if(edit == true)
            {
                LoadWord();
            }
        }

        private void EditVerb_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void comboxdgv_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           

        }

        private void btnaddsynonym_Click(object sender, EventArgs e)
        {
            synonyms.Add(tboxsynonyms.Text);
            InitListbox();
        }

        private void btnremovesynonym_Click(object sender, EventArgs e)
        {
            synonyms.Remove(lboxsynonyms.SelectedItem.ToString());
            InitListbox();
        }

        private void btncreateverb_Click(object sender, EventArgs e)
        {
            
            if (verb.Name != "")
            {
                if (edit)
                {
                    Game.Verbs.Remove(Game.Verbs.Find(x => x == verb));
                    SaveWord();
                    Game.Verbs.Add(verb);
                }
                else
                {
                    SaveWord();
                    Game.Verbs.Add(verb);
                }
                MainForm main = new MainForm(Game);
                main.ShowDialog();
                ((VerbForm)this.TopLevelControl).Close();
            }
            else
            {
                lblfillfields.Text = "Please fill in a name!";
            }

        }
    }
}

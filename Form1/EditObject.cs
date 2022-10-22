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
    public partial class EditObject : UserControl
    {

        private AdventureGame adventureGame;

        private List<String> synonyms { get; set; }
        public EditObject(AdventureGame game)
        {
            adventureGame = game;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            synonyms.Add(tboxsynonyms.Text);
        }

        private void btncreateobject_Click(object sender, EventArgs e)
        {

            int weight;
            int value;

            if (tboxobjectname.Text != "" && tboxobjectvalue.Text != "" && tboxobjectweight.Text != "" && rtboxobjectsummary.Text != "")
            {
                if (int.TryParse(tboxobjectweight.Text, out weight))
                {
                    if (int.TryParse(tboxobjectvalue.Text, out value))
                    {
                        adventureGame.Objects.Add(new Item(tboxobjectname.Text, rtboxobjectsummary.Text, weight, value, synonyms));
                        MainForm mainForm = new(adventureGame);
                        mainForm.Show();
                       // this.Close();

                    }
                    else
                    {
                        lblobjectfields.Text = "Fix Value!";
                    }
                }
                else
                {
                    lblobjectfields.Text = "Fix Weight";
                }
            }
            else
            {
                lblobjectfields.Text = "Fix empty fields!";
            }


        }
    }
}

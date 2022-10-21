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

namespace Form1
{
    public partial class Objects : Form
    {
        private AdventureGame adventureGame;
        public Objects(AdventureGame _adventureGame)
        {
            adventureGame = _adventureGame;
            InitializeComponent();
        }

        private void btncreateobject_Click(object sender, EventArgs e)
        {
            int weight;
            int value;

            if(tboxobjectname.Text != "" && tboxobjectvalue.Text != "" && tboxobjectweight.Text != "" && rtboxobjectsummary.Text != "")
            {
                if (int.TryParse(tboxobjectweight.Text, out weight))
                {
                    if (int.TryParse(tboxobjectvalue.Text, out value))
                    {
                        adventureGame.Objects.Add(new Item(tboxobjectname.Text, rtboxobjectsummary.Text, weight, value));
                        MainForm mainForm = new(adventureGame);
                        mainForm.Show();
                        this.Close();

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

        private void lblobjectfields_Click(object sender, EventArgs e)
        {

        }

        private void rtboxobjectsummary_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblobjectsummary_Click(object sender, EventArgs e)
        {

        }

        private void lblvalue_Click(object sender, EventArgs e)
        {

        }

        private void tboxobjectvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblweight_Click(object sender, EventArgs e)
        {

        }

        private void tboxobjectweight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void tboxobjectname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

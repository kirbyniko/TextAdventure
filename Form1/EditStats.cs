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
    public partial class EditStats : UserControl
    {
        private Stat stat = new();

        private AdventureGame game = new();
        public EditStats(AdventureGame _game, Stat _stat)
        {
            game = _game;
            stat = _stat;
            InitializeComponent();
        }

        public EditStats(AdventureGame _game)
        {
            game = _game;
            InitializeComponent();
        }

        public EditStats()
        {
            InitializeComponent();
        }

        private void EditStats_Load(object sender, EventArgs e)
        {
            comboxAddtoall.Items.Add("Items");
            comboxAddtoall.Items.Add("Rooms");
            comboxAddtoall.Items.Add("Places");
        }

        private void SaveStat()
        {
            if (tboxobjectname.Text != "" && rtboxobjectsummary.Text != "")
            {
                lblwarning.Text = "";
                stat.Name = tboxobjectname.Text;
                stat.Description = rtboxobjectsummary.Text;
                if (cboxInteger.Checked)
                {
                    stat.boolInteger = true;
                }

                if(game.Stats.Contains(game.Stats.Find(x => x.Name == stat.Name)) != true)
                {
                    game.Stats.Add(stat);
                }
                else
                {
                    game.Stats.Remove(game.Stats.Find(x => x.Name == stat.Name));
                }



            }
            else
            {
                lblwarning.Text = "Please fill a name and description!";
            }
        }

        public void LoadStat()
        {
            tboxobjectname.Text = stat.Name;
            rtboxobjectsummary.Text = stat.Description;
            cboxInteger.Checked = stat.boolInteger;
        }

        private void btncreatestat_Click(object sender, EventArgs e)
        {
            SaveStat();

            if(lblwarning.Text == "")
            {
                MainForm mainform = new(game);
                mainform.Show();
                ((EditStat)this.TopLevelControl).Close();
            }
            
        }

        private void lblwarning_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void EditStats_VisibleChanged(object sender, EventArgs e)
        {
            comboxAddtoall.Items.Add("Rooms");
            comboxAddtoall.Items.Add("Players");
            comboxAddtoall.Items.Add("Objects");

            if(stat.Name != "")
            {
                LoadStat();
            }
        }

        private void btnAddtoall_Click(object sender, EventArgs e)
        {
            switch (comboxAddtoall.SelectedText)
            {
                case "Rooms":
                    game.RoomStats.Add(stat);
                    break;
                case "Players":
                    game.PlayerStats.Add(stat);
                    break;
                case "Objects":
                    game.ObjectStats.Add(stat);
                    break;
            }
        }
    }
}

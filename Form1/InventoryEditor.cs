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
    public partial class InventoryEditor : Form
    {
        private Player player { get; set; }

        private Item item { get; set; }

       // private List<String> Keywords { get; set; }

        private AdventureGame adventuregame { get; set; }
        public InventoryEditor(AdventureGame Game, Item obj, Player _player)
        {
            player = _player;
            adventuregame = Game;
            item = obj;
            tboxobjectname.Text = item.Name;
            tboxobjectvalue.Text = item.Value.ToString();
            tboxobjectweight.Text = item.Weight.ToString();
            rtboxobjectsummary.Text = item.Description;

            InitializeComponent();
        }

        private void btneditobjectinstance_Click(object sender, EventArgs e)
        {
            int weight;
            int value;

            if (int.TryParse(tboxobjectweight.Text, out weight))
            {
                if (int.TryParse(tboxobjectvalue.Text, out value))
                {
                   // adventuregame.Objects.Add(new Item(tboxobjectname.Text, rtboxobjectsummary.Text, weight, value));
                    MainForm mainForm = new(adventuregame);
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
            player.Inventory.Add(item);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureMaker
{
    public partial class EditStats : UserControl
    {
        private Stat stat = new();

        private AdventureGame game = new();
        public EditStats(AdventureGame _game, Stat _stat)
        {
            InitializeComponent();
        }

        private void EditStats_Load(object sender, EventArgs e)
        {
            comboxAddtoall.Items.Add("Items");
            comboxAddtoall.Items.Add("Rooms");
            comboxAddtoall.Items.Add("Places");
        }

        private void btncreatestat_Click(object sender, EventArgs e)
        {

        }
    }
}

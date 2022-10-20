using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAdventureLibrary;

namespace Form1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btncreategame_Click(object sender, EventArgs e)
        {
            if(tboxinputgamename.Text != "")
            {
                AdventureGame game = new AdventureGame();
                game.Name = tboxinputgamename.Text;
                MainForm form = new(game);
                form.Show();
                this.Hide();
                
            }
           
        }

        private void btneditgame_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;
            string jsonString = File.ReadAllText(filePath);
            AdventureGame game = JsonSerializer.Deserialize<AdventureGame>(jsonString);
            MainForm form = new(game);
            form.Show();
            this.Hide();
        }

        private void btnplaygame_Click(object sender, EventArgs e)
        {
            string filename = tboxinputgamename.Text + ".json";
            string jsonString = File.ReadAllText(filename);
            //AdventureGame game = JsonSerializer.Deserialize<AdventureGame>(jsonString);
        //
        

        }
    }
}

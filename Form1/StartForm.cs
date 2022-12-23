using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        OpenFileDialog o;
        public StartForm()
        {
            InitializeComponent();
        }

        private void btncreategame_Click(object sender, EventArgs e)
        {
            { 
                MainForm form = new();
                form.Show();
                this.Hide();
                
            }
           
        }

        private void btneditgame_Click(object sender, EventArgs e)
        {

            o = ChooseFile();
            string filePath = o.FileName;
            string jsonString = File.ReadAllText(filePath);
            AdventureGame game = JsonSerializer.Deserialize<AdventureGame>(jsonString);
            game.InitLists();
            MainForm form = new(game);
            form.Show();
            this.Hide();
        }

        private void btnplaygame_Click(object sender, EventArgs e)
        {
            OpenFileDialog ol = new OpenFileDialog();
            ol.Title = "Please select the file for your game!";
            ol.ShowDialog();
            string filePath = ol.FileName;
            


            Process.Start("C:\\Users\\filthymilkman\\source\\repos\\TextAdventure\\TextAdventureClone\\TextAdventure\\bin\\Release\\net6.0\\TextAdventure.exe", filePath.ToString());

            

        }


        private void button3_Click(object sender, EventArgs e)
        {
            o = ChooseFile();
        }

        private OpenFileDialog ChooseFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
           return openFileDialog;
        }
    }
}

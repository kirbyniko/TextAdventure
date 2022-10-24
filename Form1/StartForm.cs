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
              //  MainForm form = new();
               // form.Show();
                this.Hide();
                
            }
           
        }

        private void btneditgame_Click(object sender, EventArgs e)
        {

            o = ChooseFile();
            string filePath = o.FileName;
            string jsonString = File.ReadAllText(filePath);
            AdventureGame game = JsonSerializer.Deserialize<AdventureGame>(jsonString);
            MainForm form = new(game);
            form.Show();
            this.Hide();
        }

        private void btnplaygame_Click(object sender, EventArgs e)
        {
            o.Title = "Please select the Cmd.exe for your game!";
            o.ShowDialog();
            ProcessStartInfo psi = new ProcessStartInfo();
            Process.Start(o.FileName);
            


        }

        private void UpdatePage()
        {
            label2.Text = o.FileName.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            o = ChooseFile();
            UpdatePage();
        }

        private OpenFileDialog ChooseFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            openFileDialog.ShowDialog();
           return openFileDialog;
        }
    }
}

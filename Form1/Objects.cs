using AdventureMaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
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
            EditObject editobject = new(adventureGame);
            pnleditobjects.Controls.Add(editobject);

            
            InitializeComponent();
        }

    }
}

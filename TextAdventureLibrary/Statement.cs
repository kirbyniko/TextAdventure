using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLibrary;

namespace TextAdventureLibrary
{
    public class Statement
    {
        public List<Word> Words { get; set; } = new List<Word>();

        public Word Verb { get; set; } = new Word();

        public List<Word> Objects { get; set; } = new List<Word>();

        public List<Word> Players { get; set; } = new List<Word>();

        public List<Word> Places { get; set; } = new List<Word>();

        public void GetItem(AdventureGame game)
        {
            if (game.CurrentRoom.Items.Contains(Objects[0].Item))
            {
                game.Players.First().Inventory.Add(Objects[0].Item);
                game.CurrentRoom.Items.Remove(Objects[0].Item);
                Console.WriteLine("You pick up the " + Objects[0].Item.Name);
            }
            else
            {
                Console.WriteLine("You do not see a " + Objects[0].Item.Name + " in this room");
            }
           

        }

        public void DropItem(AdventureGame game)
        {
            if (game.Players[0].Inventory.Contains(Objects[0].Item))
            {
                game.Players.First().Inventory.Remove(Objects[0].Item);
                game.CurrentRoom.Items.Add(Objects[0].Item);
                Console.WriteLine("You drop the " + Objects[0].Item.Name);
            }
            else
            {
                Console.WriteLine("You do have a " + Objects[0].Item.Name + " in your inventory");
            }


        }

    }
}



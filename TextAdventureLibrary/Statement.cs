using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

        public void GetItem(AdventureGame game, Word o)
        {
            bool inroom = false;

            foreach(var c in game.CurrentRoom.Items)
            {
                foreach(var s in o.Keywords)
                {
                    if (c.Keywords.Contains(s))
                    {
                        game.Players.First().Inventory.Add(c);
                        game.CurrentRoom.Items.Remove(c);
                        Console.WriteLine("You pick up the " + c.Name);
                        inroom = true;
                        break;
                    }
                }
                
              
            }

            if(inroom == false)
            {
                Console.WriteLine("You do not see a " + o.Name + " in this room");
            }

    

        }

        public void DropItem(AdventureGame game)
        {
            foreach (var c in game.Objects)
            {
                if (game.Players[0].Inventory.Contains(c))
                {
                    game.Players.First().Inventory.Remove(c);
                    game.CurrentRoom.Items.Add(c);
                    Console.WriteLine("You drop the " + c.Name);
                }
                else
                {
                    Console.WriteLine("You do have a " + c.Name + " in your inventory");
                }
            }

        }

    }
}



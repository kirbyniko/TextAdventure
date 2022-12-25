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


            if (game.Players.Count() > 0)
            {
                List<Item> items = (List<Item>)game.CurrentRoom.Items.Where(x => x.Name == o.Item.Name);

                game.Players.First().Inventory.Add(o.Item);
                game.CurrentRoom.Items.Remove((Item)game.CurrentRoom.Items.Where(x => x.Name == o.Item.Name));
                Console.WriteLine("You pick up the " + o.Name);
                inroom = true;

            }
            else
            {
                Console.WriteLine("There are no players, we must fix this exception.");
            }




            if (inroom == false)
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



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

            if (game.CurrentRoom.Items.Contains(game.CurrentRoom.Items.FirstOrDefault(x => x.Name == o.Item.Name)))
            {


                if (game.Players.Count() > 0)
                {

                    game.Players.First().Inventory.Add(game.CurrentRoom.Items.FirstOrDefault(x => x.Name == o.Item.Name));
                    game.CurrentRoom.Items.Remove(game.CurrentRoom.Items.FirstOrDefault(x => x.Name == o.Item.Name));


                    Console.WriteLine("You pick up the " + o.Name);
                    inroom = true;

                }
                else
                {
                    Console.WriteLine("There are no players, we must fix this exception.");
                }

            }

            else
            {
                Console.WriteLine("You do not see a " + o.Name + " in this room");
            }



        }

        public void DropItem(AdventureGame game)
        {
            if (game.Players.Count() > 0)
            {
                foreach (var c in game.Objects)
                // player count check should come before foreach loop
                {

                    if (game.Players[0].Inventory.Count() > 0)
                    {
                        if (game.Players[0].Inventory.Contains(game.Players[0].Inventory.First(x => x.Name == c.Name)))

                        {
                            game.Players.First().Inventory.Remove((game.Players[0].Inventory.First(x => x.Name == c.Name)));
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
            else
            {
                Console.WriteLine("No Players in this game! Fix exception!");
            }
        }

    }

}




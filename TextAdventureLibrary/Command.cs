using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Command
    {

        public List<string> Verbs { get; set; } = new List<string>();

        public List<string> Places { get; set; } = new List<string>();

        public List<Item> Objects { get; set; } = new List<Item>();

        public Item Item { get; set; } = new Item();

        public void ClearLists()
        {
            Objects.Clear();
            Places.Clear();
            Verbs.Clear();
        }

        public void GetItem(AdventureGame game)
        {
            if ((Verbs[0] == "get" | Verbs[0] == "obtain" | Verbs[0] == "pickup") & Objects[0].Verbs.Contains("get"))
            {
                game.Players.First().Inventory.Add(Objects[0]);
                game.CurrentRoom.Items.Remove(Objects[0]);
                Console.WriteLine("You pick up the " + Objects[0].Name);
            }
        }

        public void LookAround(AdventureGame game)
        {
            if (Verbs[0] == "look")
            {

            }
        }

        public List<string> GetVerb(AdventureGame game, List<string> words)
        {
            foreach (var word in words)
            {
                if (game.Verbs.Contains(word))
                {
                    game.Command.Verbs.Add(word);
                }
            }

            return game.Command.Verbs;
    
        }

        public List<string> GetPlace(AdventureGame game, List<string> words)
        {
            foreach (var word in words)
            {
                if (game.Places.Contains(word))
                {
                    game.Command.Places.Add(word);
                }
            }

            return game.Command.Places;
        }

        public List<Item> GetObject(AdventureGame game, List<string> words)
        {
            foreach (var word in words)
            {
                if (game.ObjectKeywords.Contains(word))
                {
                    foreach(var c in game.Objects)
                    {
                        if (c.Keywords.Contains(word))
                        {
                            game.Command.Objects.Add(c);
                        }
                    }
                    

                }
            }

            return game.Command.Objects;
        }

        public void isPerson()
        {

        }

        public void isAdverb()
        {

        }
    }


}

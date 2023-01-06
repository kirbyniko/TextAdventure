using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class UserCommand
    {
        public List<Statement> Statements { get; set; } = new List<Statement>();
        public List<Word> Words { get; set; } = new List<Word>();

        public List<string> Verbs { get; set; } = new List<string>();

        public List<string> Places { get; set; } = new List<string>();

        public List<Item> Objects { get; set; } = new List<Item>();
        public List<Player> Players { get; set; } = new List<Player>();

        public Item Item { get; set; } = new Item();

        public Player SelectFromMultiple(List<Player> list)
        {
            Console.WriteLine("It appears there are multiple " + list[0].Name + "s!");
            int i = 1;
            int inputint = -1;
            foreach(var c in list)
            {
                Console.WriteLine(i++ + ". " + c.Name + ", " + c.Description);
            }
            Console.WriteLine("Please type the ID of the " + list[0].Name + " that you would like to select!");
            string input = Console.ReadLine();
            int.TryParse(input, out inputint);
            while (inputint == -1 ^ inputint >= list.Count + 1)
            {
                Console.WriteLine("Please type a number corresponding to a choice!");
                input = Console.ReadLine();
                int.TryParse (input, out inputint);
            }
            return list[inputint - 1];
        }
        public void ClearLists()
        {
            Objects.Clear();
            Places.Clear();
            Verbs.Clear();
            Words.Clear();
            Statements.Clear();
        }


        public void LookAround(AdventureGame game)
        {
            if (Verbs[0] == "look")
            {
                foreach(Player player in game.Command.Players)
                {
                    Console.WriteLine("You see " + player.Description);
                }
                foreach(Item item in game.Command.Objects)
                {
                    Console.WriteLine("You see " + item.Description);
                }
            }
        }
    }


}

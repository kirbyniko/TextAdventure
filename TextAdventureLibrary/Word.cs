using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary
{
    public class Word
    {
        public List<string> Keywords { get; set; } = new List<string>();
        public string Name { get; set; }

        public string Type { get; set; }

        public Item Item { get; set; }

        public Player Player { get; set; }

        public Room Place { get; set; }

        //Used in ForEquals()
        public Word()
        {
  
        }

        //For inputted words
        public Word(string word)
        {
            Name = word;
        }

        //For Verbs and Places without rooms
        public Word(string word, List<string> synonyms, string type)
        {
            Name = word;
            Keywords = synonyms;
            Type = type;
        }

        //For Items
        public Word(string word, List<string> synonyms, string type, Item item)
        {
            Name = word;
            Keywords = synonyms;
            Type = type;
            Item = item;
        }

        //For Players
        public Word(string word, List<string> synonyms, string type, Player player)
        {
            Name = word;
            Keywords = synonyms;
            Type = type;
            Player = player;
        }

        //For Places
        public Word(string word, List<string> synonyms, string type, Room place)
        {
            Name = word;
            Type = type;
            Place = place;
            Keywords = synonyms;
        }
    }
}

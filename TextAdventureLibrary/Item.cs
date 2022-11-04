﻿using System.Reflection.Emit;

namespace TextAdventureLibrary
{
  
    public class Item
    {
        public int Index { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }
        public int DropChance { get; set; }

        public Word Word { get; set; } = new Word();

        public List<Stat> Stats { get; set; } = new List<Stat>();
        public List<string> Verbs { get; set; } = new List<string>();
        public List<string> Keywords { get; set; } = new List<string>();

        public Item(string name, string description, int weight, int value)
        {
            Name = name;
            Description = description;
         //   Weight = weight;
          //  Value = value;

        }
        public Item(string name, string description, int weight, int value, List<String> keywords)
        {
            Name = name;
            Description = description;
          //  Weight = weight;
           // Value = value;
            Keywords = keywords;

        }

        public Item()
        {
                
        }
    }

    


    
}
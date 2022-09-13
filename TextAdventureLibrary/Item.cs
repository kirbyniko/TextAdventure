using System.Reflection.Emit;

namespace TextAdventureLibrary
{
  
    public class Item
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Weight { get; set; }

        public int Value { get; set; }

        public List<string> Verbs { get; set; } = new List<string>();
        public List<string> Keywords { get; set; } = new List<string>();

        public Item(string name, string description, int weight, int value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;

        }

        public Item()
        {

        }
    }

    


    
}
namespace TextAdventureLibrary
{
  
    public class Player
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Health { get; set; }

        public List<Item> Inventory { get; set; } = new List<Item>();

        public int Strength { get; set; }

        public Player(string name, string description, int health)
        {
            Name = name;
            Description = description;
            Health = health;
        }
    }
}
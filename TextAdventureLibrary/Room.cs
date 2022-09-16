namespace TextAdventureLibrary
{
    public class Room
    {

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public string ShortDescription { get; set; } = "";

        public int Verbosity { get; set; }

        public Word Word { get; set; }

        public Room DefaultExit { get; set; }

        public List<AdjacentRoom> AdjacentRooms { get; set; } = new List<AdjacentRoom>();

        public List<Player> Players { get; set; } = new List<Player>();

        public List<Item> Items { get; set; } = new List<Item>();

  

        public Room(string name, string description, string shortdescription) 
        {
            Name = name;
            Description = description;
            ShortDescription = shortdescription;
            Verbosity = 1;


        }


    }
}
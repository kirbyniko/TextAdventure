namespace TextAdventureLibrary
{
   
    public class AdventureGame
    {
        public string Name { get; set; }
        public Room CurrentRoom { get; set; }
        public List<string> Verbs { get; set; } = new List<string>();
        public List<string> Places { get; set; } = new List<string>();
        public List<string> ObjectKeywords { get; set; } = new List<string>();
        public List<Item> Objects { get; set; } = new List<Item>();
        public Command Command { get; set; } = new Command();
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Item> Items { get; set; } = new List<Item>();
        public List<Player> Players { get; set; } = new List<Player>();
        public List<AdjacentRoom> AdjacentRooms { get; set; } = new List<AdjacentRoom>();
        public void InitLists()
        {
            //Fighting
            Verbs.Add("kill");
            Verbs.Add("punch");
            Verbs.Add("stab");
            Verbs.Add("kick");
            Verbs.Add("shoot");

            //Moving
            Verbs.Add("open");
            Verbs.Add("exit");
            Verbs.Add("leave");
            Verbs.Add("go");
            Verbs.Add("enter");

            //Interacting
            Verbs.Add("unlock");
            Verbs.Add("talk");
            Verbs.Add("pick");
            Verbs.Add("pickup");
            Verbs.Add("drop");
            Verbs.Add("get");
            Verbs.Add("remove");
            Verbs.Add("obtain");
            Verbs.Add("help");
            Verbs.Add("eat");
            Verbs.Add("drink");
            Verbs.Add("grab");

            //Items
            ObjectKeywords.Add("rat");
            ObjectKeywords.Add("ratcarcass");


            //Places
            Places.Add("cell");
            Places.Add("hallway");
            Places.Add("north");
            Places.Add("south");
            Places.Add("west");
            Places.Add("east");
            Places.Add("northblock");
            Places.Add("controlroom");


        }

        //public AdventureGame(string name, Room room)
        //{
        //    string name = Name;

        //    CurrentRoom = room = CurrentRoom;
        //}
        public AdventureGame()
        {

        }


        public List<Item> InitItems()
        {
            Item sword = new Item("Sword", "A blade of sharp steel and a dull handle wrapped in tattered leather", 10, 200);
            Item bow = new Item("Elven Longbow", "A shiny bow made of enchanted elven greenwood strung with a string of fire", 5, 500);
            Item ratcarcass = new Item("Rat Carcass", "A stiff dead rat with a horrible smell emanating", 2, 5);

            ratcarcass.Keywords.Add("rat");
            ratcarcass.Keywords.Add("ratcarcass");

            ratcarcass.Verbs.Add("get");

            List<Item> Items = new List<Item>();

            Items.Add(sword);
            Items.Add(bow); 
            Items.Add(ratcarcass);  
            
            return Items;

        }

        public List<Room> InitRooms()
        {

            Room cell = new Room("Cell", "You find yourself in a decrepit prison cell, among  a hallway full of other inmates. Dressed in rags and equipped with nothing, by miracle the door to the hallway in front of you opens.", "You enter your old prison cell.");
            Room hallway = new Room("Hallway", "You walk out into the large hallway of cells, no guards in immediate sight. You notice a path to your North, labelled 'North block'' for the north block of the prison. There is a path to south, albeit unlabelled.", "You enter the hallway, North leads to Northblock, you can enter your cell, or move South.");
            Room northblock = new Room("North Block", "You enter the North Block, four large walls of stacked cells. In the middle is the Control Center, a locked door.", "You enter the North Block, and are surrounded by cells. You see the Control Room.");

            AdjacentRoom acell = new AdjacentRoom(cell.Name, cell);
            AdjacentRoom ahallway = new AdjacentRoom(hallway.Name, hallway);
            AdjacentRoom anorthblock = new AdjacentRoom(northblock.Name, northblock);

            AdjacentRooms.Add(acell);
            AdjacentRooms.Add(ahallway);
            AdjacentRooms.Add(anorthblock);

            //Cell Adjacent Rooms

            AdjacentRoom cellhallway = new AdjacentRoom(ahallway.Name, ahallway.Room);

            cellhallway.Keywords.Add("hallway");
            cellhallway.Keywords.Add("door");

            cell.AdjacentRooms.Add(cellhallway);

            //Hallway Adjacent Rooms

            AdjacentRoom hallwaycell = new AdjacentRoom(acell.Name, acell.Room);

            hallwaycell.Keywords.Add("cell");

            hallway.AdjacentRooms.Add(hallwaycell);

            AdjacentRoom hallwaynorthblock = new AdjacentRoom(anorthblock.Name, anorthblock.Room);

            hallwaynorthblock.Keywords.Add("north");
            hallwaynorthblock.Keywords.Add("northblock");
            hallwaynorthblock.Keywords.Add("north block");

            hallway.AdjacentRooms.Add(hallwaynorthblock);

            //Northblock Adjacent Rooms

            AdjacentRoom northblockhallway = new AdjacentRoom(ahallway.Name, ahallway.Room);

            northblockhallway.Keywords.Add("hallway");
            northblockhallway.Keywords.Add("south");
       
            northblock.AdjacentRooms.Add(northblockhallway);

            cell.Items.Add(Objects[2]);

            List<Room> rooms = new List<Room>();

            rooms.Add(cell);
            rooms.Add(hallway);
            rooms.Add(northblock);

            return rooms;

        }

        public List<Player> InitPlayers()
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Prisoner", "weak criminal human", 10));

            return players;
        }


    }

    
}
using System.Runtime.CompilerServices;

namespace TextAdventureLibrary
{
   
    public class AdventureGame
    {
        public string Name { get; set; }
        public Room CurrentRoom { get; set; }
       
        public List<string> Places { get; set; } = new List<string>();
        public List<string> ObjectKeywords { get; set; } = new List<string>();
        public List<string> PlayerKeywords { get; set; } = new List<string>();
        public List<Word> Verbs { get; set; } = new List<Word>();
        public List<Word> Words { get; set; } = new List<Word>();
        public List<Item> Objects { get; set; } = new List<Item>();
        public List<Stat> Stats { get; set; } = new List<Stat>();
        public List<Stat> PlayerStats { get; set; } = new List<Stat>();
        public List<Stat> ObjectStats { get; set; } = new List<Stat>();
        public List<Stat> RoomStats { get; set; } = new List<Stat>();
        public UserCommand Command { get; set; } = new UserCommand();
        public List<Room> Rooms { get; set; } = new List<Room>();
        public List<Player> Players { get; set; } = new List<Player>();
        public List<AdjacentRoom> AdjacentRooms { get; set; } = new List<AdjacentRoom>();
        public void InitLists()
        {
            //Verbs 

            if(Verbs.Count() == 0)
            {
                List<string> getsynonyms = new List<string>();
                getsynonyms.Add("pickup");
                getsynonyms.Add("pick");
                getsynonyms.Add("obtain");
                getsynonyms.Add("grab");
                getsynonyms.Add("get");

                Words.Add(new Word("get", getsynonyms, "verb"));
                Verbs.Add(FindEquals("get"));

                List<string> attacksynonyms = new List<string>();
                attacksynonyms.Add("punch");
                attacksynonyms.Add("stab");
                attacksynonyms.Add("hit");
                attacksynonyms.Add("kill");
                attacksynonyms.Add("slay");
                attacksynonyms.Add("attack");
                attacksynonyms.Add("shoot");

                Words.Add(new Word("attack", attacksynonyms, "verb"));
                Verbs.Add(FindEquals("attack"));

                List<string> dropsynonyms = new List<string>();
                dropsynonyms.Add("remove");
                dropsynonyms.Add("drop");

                Words.Add(new Word("drop", dropsynonyms, "verb"));
                Verbs.Add(FindEquals("drop"));

                List<string> exitsynonyms = new List<string>();
                exitsynonyms.Add("exit");
                exitsynonyms.Add("leave");

                Words.Add(new Word("exit", exitsynonyms, "verb"));
                Verbs.Add(FindEquals("exit"));

                List<string> entersynonyms = new List<string>();
                entersynonyms.Add("go");
                entersynonyms.Add("enter");

                Words.Add(new Word("enter", entersynonyms, "verb"));
                Verbs.Add(FindEquals("enter"));

            }


            //Places


        }

        Word FindEquals(string word)
        {
            Word returnword = new Word();

            foreach(Word w in Words)
            {
                if (w.Keywords.Contains(word))
                {
                    returnword = w;
                }
            }

            return returnword;
        }


        public List<Item> InitItems()
        {
            Item sword = new Item("Sword", "A blade of sharp steel and a dull handle wrapped in tattered leather", 10, 200);
            Item bow = new Item("Elven Longbow", "A shiny bow made of enchanted elven greenwood strung with a string of fire", 5, 500);
            Item ratcarcass = new Item("Rat Carcass", "A stiff dead rat with a horrible smell emanating", 2, 5);
            Item key = new Item("Key", "A heavy iron key", 3, 10);

            ratcarcass.Keywords.Add("rat");
            ratcarcass.Keywords.Add("ratcarcass");

            sword.Keywords.Add("sword");

            key.Keywords.Add("key");

            bow.Keywords.Add("bow");

            ratcarcass.Verbs.Add("get");
            sword.Verbs.Add("get");

            List<Item> Items = new List<Item>();

            Items.Add(sword);
            Items.Add(bow); 
            Items.Add(ratcarcass);
            Items.Add(key);

            
            return Items;

        }

        public void AddKeywords()
        {
            foreach (Item item in Objects)
            {
                item.Word = new Word(item.Keywords[0], item.Keywords, "object", item);
                Words.Add(item.Word);
                ObjectKeywords.AddRange(item.Keywords);
            }

            foreach (var c in Players)
            {
                c.Word = new Word(c.Keywords[0], c.Keywords, "player", c);
                Words.Add(c.Word);

                if (c.Keywords.Count >= 1)
                {
                    PlayerKeywords.AddRange(c.Keywords);
                }
                
            }

            foreach (var c in Rooms)
            {
                List<string> syn = new List<string>();
                syn.Add(c.Name);
                c.Word = new Word(c.Name, syn, "place", c);
                Words.Add(c.Word);
                Places.Add(c.Word.Name);
            }

        }

        public List<Room> InitRooms()
        {

            Room cell = new Room("cell", "You find yourself in a decrepit prison cell, among  a hallway full of other inmates. Dressed in rags and equipped with nothing, by miracle the door to the hallway in front of you opens.", "You enter your old prison cell.");
            Room hallway = new Room("hallway", "You walk out into the large hallway of cells, no guards in immediate sight. You notice a path to your North, labelled 'North block'' for the north block of the prison. There is a path to south, albeit unlabelled.", "You enter the hallway, North leads to Northblock, you can enter your cell, or move South.");
            Room northblock = new Room("north block", "You enter the North Block, four large walls of stacked cells. In the middle is the Control Center, a locked door.", "You enter the North Block, and are surrounded by cells. You see the Control Room.");

            hallway.Players.Add(Players[1]);

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

            //Init basic direction words
            List<string> southsynonyms = new List<string>();
            southsynonyms.Add("south");
            southsynonyms.Add("s");
            Words.Add(new Word("south", southsynonyms, "place"));

            List<string> northsynonyms = new List<string>();
            northsynonyms.Add("north");
            northsynonyms.Add("n");
            Words.Add(new Word("north", northsynonyms, "place"));

            List<string> eastsynonyms = new List<string>();
            eastsynonyms.Add("east");
            eastsynonyms.Add("e");
            Words.Add(new Word("east", eastsynonyms, "place"));

            List<string> westsynonyms = new List<string>();
            westsynonyms.Add("west");
            westsynonyms.Add("w");
            Words.Add(new Word("west", westsynonyms, "place"));

            List<string> doorsynonyms = new List<string>();
            doorsynonyms.Add("door");
            doorsynonyms.Add("entrance");
            Words.Add(new Word("door", westsynonyms, "place"));

            return rooms;
  

        }

        public List<Player> InitPlayers()
        {
            List<Player> players = new List<Player>();

            players.Add(new Player("Prisoner", "weak criminal human", 10));
            players.Add(new Player("Guard", "average-sized warrior dressed in guards clothes, equipped with a sword", 15));

            players[0].Keywords.Add("me");
            players[0].Keywords.Add("myself");

            players[1].Keywords.Add("guard");

            players[1].Inventory.Add(Objects.Find(x => x.Name == "sword"));


            return players;
        }


    }

    
}
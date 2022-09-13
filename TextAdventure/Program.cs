// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.RegularExpressions;
using TextAdventureLibrary;


string Input;
List<string> Words = new List<string>();

Console.WriteLine("Hello, World!");

AdventureGame game = InitGame();

while (true)
{
    DisplayRoom(game);
    Input = GetInput();
    Words = ParseInput(Input);

    game.Command.Verbs = game.Command.GetVerb(game, Words);
    game.Command.Objects = game.Command.GetObject(game, Words);
    game.Command.Places = game.Command.GetPlace(game, Words);
     

    if (game.Command.Objects.Count() >= 1)
    {
        if (game.Command.Objects[0].Verbs.Contains(game.Command.Verbs[0]))
        {
            game.Command.GetItem(game);
        }
    }

    if (game.Command.Places.Count() >= 1 & (game.Command.Verbs.Count() == 0 | game.Command.Verbs.Contains("go") | game.Command.Verbs.Contains("enter")))
    {

        foreach (var c in game.CurrentRoom.AdjacentRooms)
        {
            foreach (var k in c.Keywords)
            {
                if (k == game.Command.Places[0])
                {
                    game.CurrentRoom = c.Room;
                }
            }
        }
    }

    game.Command.ClearLists();
   

}

AdventureGame InitGame()
{
    AdventureGame adventureGame = new AdventureGame();
    adventureGame.Name = "God's Fist";

    adventureGame.Objects = adventureGame.InitItems();
    adventureGame.Rooms = adventureGame.InitRooms();
    adventureGame.Players = adventureGame.InitPlayers();
    adventureGame.InitLists();
    adventureGame.CurrentRoom = adventureGame.Rooms[0];

    Console.WriteLine("You are playing " + adventureGame.Name + " Press any key to continue");
    Console.ReadLine();

    return adventureGame;
}

void DisplayRoom(AdventureGame adventureGame)
{
    switch (adventureGame.CurrentRoom.Verbosity)
    {
        case 1:
            Console.WriteLine(adventureGame.CurrentRoom.Description);
            adventureGame.CurrentRoom.Verbosity = 0;
            break;
        case 0:
            Console.WriteLine(adventureGame.CurrentRoom.ShortDescription);
            break;

        
    }

    if (adventureGame.CurrentRoom.Items != null & adventureGame.CurrentRoom.Items.Count() != 0)
    {
        int index = 0;
        Console.Write("There is a ");

        foreach (Item item in adventureGame.CurrentRoom.Items)
        {
            index++;
            Console.WriteLine(item.Name + ", it appears to be " + item.Description);

            if (adventureGame.CurrentRoom.Items.Count != index)
            {
                Console.Write("There is also a");
            }
        }



    }

}

string GetInput()
{
    
    string input;
    input = Console.ReadLine().ToLower();
    return input;


}

List<string> ParseInput(string input)
{
    List<string> words = input.Split(" ").ToList();
    return words;
    
 
}

//@"^[a-zA-Z0-9]+$"
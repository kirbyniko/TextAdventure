// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using TextAdventureLibrary;



string Input;

AdventureGame game = new AdventureGame();

Console.ReadLine();

if (args.Length > 0)
{
    string Filename = args[0];
    string jsonstring = File.ReadAllText(Filename);
    AdventureGame agame = JsonSerializer.Deserialize<AdventureGame>(jsonstring);
    game = agame;
    game.AddKeywords();
}
else
{
    string Filename = "C:\\Users\\filthymilkman\\Documents\\newfile\\BeeGame";
    string jsonstring = File.ReadAllText(Filename);
    AdventureGame agame = JsonSerializer.Deserialize<AdventureGame>(jsonstring);
    game = agame;
    game.AddKeywords();

    /*


    Console.WriteLine("Not enough args! Arg!");
    game.Name = "God's Fist";
    Console.WriteLine("You are playing " + game.Name);
    game.Objects = game.InitItems();
    game.Players = game.InitPlayers();
    game.Rooms = game.InitRooms();
    game.AddKeywords();
    game.InitLists();
    game.CurrentRoom = game.Rooms[0];
    
    */



    Console.ReadLine();
}






while (true)
{
    DisplayRoom(game);
    Input = GetInput();
    game.Command.Words = ParseInput(Input);
    game = GetWordTypes(game);
    //Game.Command is the users command.
    game.Command.Statements = CreateStatements(game);

    RunStatements();
    game.Command.ClearLists();



}

AdventureGame InitGame()
{
    AdventureGame adventureGame = new AdventureGame();
    adventureGame.Name = "God's Fist";

    adventureGame.Objects = adventureGame.InitItems();
    adventureGame.Players = adventureGame.InitPlayers();
    adventureGame.Rooms = adventureGame.InitRooms();

    adventureGame.InitLists();

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

    if (adventureGame.CurrentRoom.Items != null && adventureGame.CurrentRoom.Items.Count() != 0)
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
    if (adventureGame.CurrentRoom.Players != null && adventureGame.CurrentRoom.Players.Count() > 1)
    {
        foreach (Player player in adventureGame.CurrentRoom.Players)
            if (player.Name != adventureGame.Players[0].Name)
            {
                Console.WriteLine("There is " + player.Description + " in the room.");
            }
    }

}

string GetInput()
{

    string input;
    input = Console.ReadLine().ToLower();
    return input;


}

List<Word> ParseInput(string input)
{
    List<Word> words = new List<Word>();
    List<string> wordstrings = input.Split(" ").ToList();
    foreach (var word in wordstrings)
    {
        words.Add(new Word(word));
    }

    return words;


}

AdventureGame GetWordTypes(AdventureGame game)
{
    List<Word> words = new List<Word>();

    foreach (Word word in game.Command.Words)
    {
        foreach (var c in game.Words.Where(c => c.Keywords.Contains(word.Name)))
        {
            words.Add(c);
            break;
        }
    }

    game.Command.Words = words;

    return game;

}

List<Statement> CreateStatements(AdventureGame game)
{
    List<Statement> statements = new List<Statement>();
    Statement statement = new Statement();
    statements.Add(statement);
    int index = 0;
    int verbs = 0;

    foreach (Word word in game.Command.Words)
    {
        switch (word.Type)
        {
            case "verb":
                if (verbs == 0)
                {
                    statements[index].Verb = word;
                    verbs++;
                }
                else
                {
                    index++;
                    verbs++;
                    statements.Add(new Statement());
                    statements[index].Verb = word;

                }
                break;

            case "place":
                statements[index].Places.Add(word);
                break;

            case "player":
                statements[index].Players.Add(word);
                break;

            case "object":
                statements[index].Objects.Add(word);
                break;

            case "and":
                index++;
                statements.Add(new Statement());
                break;
        }

        statements[index].Words.Add(word);


    }
    return statements;
}

bool isEmptyorNull(string s)
{
    bool isEmpty = true;

    if (s != "" && s != null)
    {
        isEmpty = false;
    }
    return isEmpty;
}
void RunStatements()
{
    foreach (var c in game.Command.Statements)
    {
        bool isempty = isEmptyorNull(c.Verb.Name);

        if (isempty != true)
        {
            if (c.Verb.Name != null && c.Verb.Name != "")
            {
                if (c.Objects.Count > 0 || c.Places.Count > 0 || c.Players.Count > 0)
                {
                    foreach (var o in c.Objects)
                    {
                        if (o.Item.Verbs.Contains(c.Verb.Name))
                        {
                            switch (c.Verb.Name)
                            {
                                case "get":
                                    c.GetItem(game, o);
                                    break;
                                case "drop":
                                    c.DropItem(game);
                                    break;
                            }
                            //Run Get and what not, clearly they are using the verb on the object
                        }
                        else
                        {
                            Console.WriteLine("You cannot " + c.Verb.Name + " a " + o.Name + "!");
                        }

                    }

                    if (c.Players.Count > 0)
                    {
                        foreach (var o in c.Players)
                        {
                            if (game.CurrentRoom.Players.Contains(o.Player))
                            {
                                switch (c.Verb.Name)
                                {
                                    case "attack":
                                        //  Console.WriteLine("You did " + damage + " damage to the " + o.Name);
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You do not see " + o.Player.Name + "!");
                            }

                        }
                    }


                    switch (c.Places.Count)
                    {

                        case 0:
                            break;
                        case 1:
                            if (c.Verb.Keywords.Contains("enter"))
                            {
                                if (game.CurrentRoom.AdjacentRooms.Contains(c.Places[0].Name))
                                {
                                    game.CurrentRoom.Players.Remove(game.Players[0]);
                                    game.CurrentRoom = game.Rooms.First(x => x.Name == c.Places[0].Name);


                                    game.CurrentRoom.Players.Add(game.Players[0]);
                                    DisplayRoom(game);
                                }
                                else
                                {
                                    Console.WriteLine("You cannot access " + c.Places[0].Name + " from here!");
                                }

                            }
                            break;
                        default:
                            Console.WriteLine("You cannot " + c.Verb.Name + " a" + c.Places[0].Name);
                            break;
                    }




                }

            }


        }

        if (isEmptyorNull(c.Verb.Name)! && c.Places.Count() == 0 && c.Objects.Count() == 0 && c.Players.Count() == 0)
        {
            Console.WriteLine("I did not understand a word you said.");
        }
        else if (isEmptyorNull(c.Verb.Name)! && c.Places.Count() == 0 && c.Objects.Count() == 0 && c.Players.Count() == 0)
        {
            Console.WriteLine("I did not understand please try again!");
        }
    }


}


//@"^[a-zA-Z0-9]+$"
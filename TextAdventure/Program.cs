// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using TextAdventureLibrary;



string Input;

AdventureGame game = new AdventureGame();

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
    Console.WriteLine("Not enough args! Arg!");
    game.Name = "God's Fist";
    Console.WriteLine("You are playing " + game.Name);
    game.Objects = game.InitItems();
    game.Players = game.InitPlayers();
    game.Rooms = game.InitRooms();
    game.InitLists();
    game.CurrentRoom = game.Rooms[0];
    
    
    
    
    
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
        foreach (var c in game.Words)
        {
            if (c.Synonyms.Contains(word.WordString))
            {
                words.Add(c);
            }

        }

        game.Command.Words = words;
    }

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

    if(s != "" && s != null)
    {
        isEmpty = false;
    }
    return isEmpty;
}
void RunStatements()
{
    foreach (var c in game.Command.Statements)
    {
        bool isempty = isEmptyorNull(c.Verb.WordString);

        if (isempty != true)
        {
            foreach (var o in c.Objects)
            {
                if (o.Item.Verbs.Contains(c.Verb.WordString))
                {
                    switch (c.Verb.WordString)
                    {
                        case "get":
                            c.GetItem(game);
                            break;
                        case "drop":
                            c.DropItem(game);
                            break;
                    }
                    //Run Get and what not, clearly they are using the verb on the object
                }
                else
                {
                    Console.WriteLine("You cannot " + c.Verb.WordString + " a" + o.WordString + "!");
                }

            }

            if (c.Players.Count > 0)
            {
                foreach (var o in c.Players)
                {
                    if (game.CurrentRoom.Players.Contains(o.Player))
                    {
                        switch (c.Verb.WordString)
                        {
                            case "attack":
                              //  Console.WriteLine("You did " + damage + " damage to the " + o.WordString);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not see " + o.Player.Name + "!");
                    }
                   
                }
            }

            if (c.Places.Count > 0)
            {
                if (c.Verb.Synonyms.Contains("enter"))
                {
                    foreach (var a in game.CurrentRoom.AdjacentRooms)
                    {
                        foreach (var b in a.Keywords)
                            if (c.Places[0].Synonyms.Contains(b))
                            {
                                game.CurrentRoom.Players.Remove(game.Players[0]);
                            
                                game.CurrentRoom.Players.Add(game.Players[0]);
                                DisplayRoom(game);
                                return;

                            }
                    }
                    Console.WriteLine("You cannot enter " + c.Places[0].WordString);
                }

                else
                {
                    Console.WriteLine("You cannot " + c.Verb.WordString + " a" + c.Places[0].WordString);
                }
            }

        }

        if (isEmptyorNull(c.Verb.WordString)! && c.Places.Count() == 0 && c.Objects.Count() == 0 && c.Players.Count() == 0)
        {
            Console.WriteLine("I did not understand a word you said.");
        }
        else if (isEmptyorNull(c.Verb.WordString)! && c.Places.Count() == 0 && c.Objects.Count() == 0 && c.Players.Count() == 0)
        {
            Console.WriteLine("I did not understand please try again!");
        }
    }


}


//@"^[a-zA-Z0-9]+$"
var date = DateTime.UtcNow;

string? name = GetName();

Menu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string? name, DateTime date)
{
    Console.WriteLine("------------------------------------------------------------------------------------");

    Console.WriteLine($"Hello {name}. It is {date}.  Welcome to the Math Game!");
    Console.WriteLine($@"What game would you like to play?
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quite the program");

    Console.WriteLine("------------------------------------------------------------------------------------");

    // Process menu selection
    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(1);
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}
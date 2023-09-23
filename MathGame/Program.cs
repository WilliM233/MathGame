Console.WriteLine("Please type your name");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("------------------------------------------------------------------------------------");

Console.WriteLine($"Hello {name.ToUpper()}. It is {date.DayOfWeek}.  Welcome to the Math Game!");
Console.WriteLine($@"What game would you like to play?
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quite the program");

Console.WriteLine("------------------------------------------------------------------------------------");

// Process menu selection
var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    Console.WriteLine("Addition game selected");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    Console.WriteLine("Subtraction game selected");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    Console.WriteLine("Multiplication game selected");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    Console.WriteLine("Division game selected");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid Input");
}
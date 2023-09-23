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
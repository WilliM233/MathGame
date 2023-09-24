namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();

        internal void ShowMenu(string? name, DateTime date)
        {
            Console.WriteLine("------------------------------------------------------------------------------------");

            Console.WriteLine($"Hello {name}. It is {date}.  Welcome to the Math Game!");
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"What game would you like to play?
V - View Previous Games
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
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game selected");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game selected");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game selected");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game selected");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}

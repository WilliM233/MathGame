namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int score = 0;

            Console.WriteLine("Question 1: 5 + 10");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (5 + 10))
            {
                Console.WriteLine("Great Job!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Not quite...");
            }

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 2: 18 - 3");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (18 - 3))
            {
                Console.WriteLine("Great Job!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Not quite...");
            }

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 3: 3 * 5");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (3 * 5))
            {
                Console.WriteLine("Great Job!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Not quite...");
            }

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Question 4: 30 / 2 ");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (30 / 2))
            {
                Console.WriteLine("Great Job!");
                score += 1;
            }
            else
            {
                Console.WriteLine("Not quite...");
            }

            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"You scored: {score}");
        }
    }
}
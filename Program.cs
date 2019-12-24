using System;

// Namespace
namespace NumberGuessingGame
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set up application variables.
            string appName = "Number Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Robert Nielsen";

            // App Header Setup
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            // Gather user name info.
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello {0}, let's play a game...", userName);
            Console.WriteLine();

            // Define correct number and guess number.
            int correctNum = 7;
            int guessNum = 0;

            // Ask user for a number.
            Console.WriteLine("Guess a number between 1 and 10.");

            // Determine if number is correct.
            while(guessNum != correctNum)
            {
                string inputNum = Console.ReadLine();
                guessNum = Int32.Parse(inputNum);

                if(guessNum != correctNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} is not correct. Guess again...", guessNum);
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }

        }
    }
}

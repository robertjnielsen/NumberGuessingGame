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
            GetAppInfo();
            
            // Gather user name info.
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello {0}, let's play a game...", userName);
            Console.WriteLine();

            while(true) 
            {
                // Define correct random number and guess number.
                Random ranNum = new Random();
                int correctNum = ranNum.Next(1, 10);
                int guessNum = 0;

                // Ask user for a number.
                Console.WriteLine("Guess a number between 1 and 10.");

                // Determine if number is correct.
                while (guessNum != correctNum)
                {
                    string inputNum = Console.ReadLine();

                    // Validate the user entered a number.
                    if (!int.TryParse(inputNum, out guessNum))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a number.");
                        Console.WriteLine();
                        Console.ResetColor();
                        continue;
                    }

                    guessNum = Int32.Parse(inputNum);

                    if (guessNum != correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} is not correct. Guess again...", guessNum);
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                }

                // Output success message.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct! {0} was the random number.", guessNum);
                Console.WriteLine();
                Console.ResetColor();

                // Ask the user to play again.
                Console.WriteLine("Do you want to play again? [Y or N]");
                string guessAgain = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if(guessAgain == "Y")
                {
                    continue;
                } 
                else if(guessAgain == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        static void GetAppInfo()
        {
            // Set up application variables.
            string appName = "Number Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "Robert James Nielsen";

            // App Header Setup
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
    }
}

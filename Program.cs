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

            GreetUser();

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
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number.");
                        continue;
                    }

                    guessNum = Int32.Parse(inputNum);

                    if (guessNum != correctNum)
                    {
                        PrintColorMessage(ConsoleColor.Red, $"{guessNum} is not correct. Guess again...");
                    }
                }

                // Output success message.
                PrintColorMessage(ConsoleColor.Green, $"Correct! {guessNum} was the random number.");

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

        // Display app information.
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

        // Ask the user their name, and greet them.
        static void GreetUser()
        {
            // Gather user name info.
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello {0}, let's play a game...", userName);
            Console.WriteLine();
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}

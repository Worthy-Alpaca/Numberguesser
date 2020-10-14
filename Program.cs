using System;

// Namespace
namespace Numberguesser
{
    // Main Class
    class Program
    {
        // Entry point
        static void Main(string[] args)
        {
            GetAppInfo();      

            Console.WriteLine("Hello, lets play a game...");

            

            // guess variable

            int guess = 0;

            // ask user for number
            
            while (true)
            {
                Console.WriteLine("Why don't you guess a number between 1 and 10?");
                Random random = new Random();

                int correctNumber = random.Next(1, 10);
                // while guess is not correct
                while (guess != correctNumber)
                {
                    // get user input
                    string guessInput = Console.ReadLine();

                    // check if input is number
                    if (!int.TryParse(guessInput, out guess))
                    {
                        PrintWithColor(ConsoleColor.Red, "That wasn't a number.");

                        continue;
                    }

                    // parse to INT and guess
                    guess = Int32.Parse(guessInput);

                    if (guess != correctNumber)
                    {
                        PrintWithColor(ConsoleColor.Red, "Wrong number, try again.");
                    }
                }

                // Output Success message
                PrintWithColor(ConsoleColor.Yellow, "That was correct.");

                Console.WriteLine("Wanna play again? [y/n]");

                string answer = Console.ReadLine().ToLower();

                if(answer == "y")
                {
                    continue;
                } 
                else if (answer == "n")
                {
                    return;
                } else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Stephan Schumacher";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // write header
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // reset text color
            Console.ResetColor();
        }

        static void PrintWithColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            // write header
            Console.WriteLine(message);
            // reset text color
            Console.ResetColor();
        }
    }
}

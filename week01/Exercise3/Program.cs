using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        // Stretch challenge 2: keep playing while the user says "yes"
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Core requirement 3: the computer picks a random number from 1 to 100
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;   // Stretch challenge 1: count the guesses

            // Core requirement 2: keep looping until the guess matches
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Core requirement 1: tell the user higher, lower, or correct
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine().Trim().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
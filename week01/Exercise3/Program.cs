using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate random magic number (1–100)
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have chosen a number between 1 and 100.");

            // Loop until user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);

                guessCount++;

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

            // Show number of guesses (stretch)
            Console.WriteLine($"You guessed it in {guessCount} tries.");

            // Ask to play again (stretch)
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
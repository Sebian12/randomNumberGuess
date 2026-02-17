using System;

class RandomNumberGuess
{
    static void Main()
    {
        Random randomizer = new Random();
        int maxValue = 1000;
        int targetNumber = randomizer.Next(maxValue + 1); // Generates a number between 0 and maxValue (1000)

        int guess = -1;
        int attempts = 0;

        Console.WriteLine("Welcome to Random Number Guess!");
        Console.WriteLine($"I have chosen a number between 0 and {maxValue}. Try to guess it!");

        while (guess != targetNumber)
        {
            Console.Write("Enter your guess: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (guess < 0)
            {
                Console.WriteLine("Please enter a positive number or zero.");
                continue;
            }

            attempts++;

            if (guess < targetNumber)
                Console.WriteLine("Too low!");
            else if (guess > targetNumber)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
        }
    }
}

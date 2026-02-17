Random randomizer = new Random();
int maxValue = 1000;
int targetNumber = randomizer.Next(maxValue + 1); // Generating a random number between 0 and 1000

Console.WriteLine("Welcome to Random Number Guess!");
Console.WriteLine($"I have chosen a number between 0 and {maxValue}. Try to guess it!");
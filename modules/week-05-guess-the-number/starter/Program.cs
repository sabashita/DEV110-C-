namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        // TODO 1: Complete the helper method named ReadIntInRange
        // Why: It avoids repeating the same input-validation code for max value and rounds.

        string prompt = "Enter a max value (10-100):";// Prompt: "Enter a max value (10-100): "
        int min = 10; //range
        int max = 100;//range
        int maxValue = ReadIntInRange(prompt, min, max);//max value

        // TODO 3: Get a valid number of rounds (1-3) using ReadIntInRange
        // Prompt: "How many rounds? (1-3): "
        prompt = "How many rounds? (1-3): ";
        min = 1; max = 3;
        int rounds = getRound(prompt, min, max);

        // TODO 4: Use a for loop to repeat the game for each round
        // Example: for (int round = 1; round <= rounds; round++)
        // NOTE: The round header, secret number, and guessing loop are inside this for loop.

        for (int i = 0; i < rounds; i++)
        {

            // TODO 5: Display the round header (inside the for loop)
            // Example: Console.WriteLine($"\nRound {round} of {rounds}");
            Console.WriteLine($"\n═════Round: {i} of {rounds}══════");

            // TODO 6: Generate a secret number in the range 1..max (inclusive)
            // Hint: Random random = new Random(maxValue + round);
            // Hint: int secret = random.Next(1, maxValue + 1);
            Random random = new Random(maxValue + i);
            int secret = random.Next(1, maxValue + 1);


            // TODO 7: Initialize guess tracking variables (inside the for loop)
            // Hint: int guess = 0; int guessCount = 0;
            // TODO 8: Use a while loop to keep asking until the guess is correct
            // Hint: while (guess != secret) { ... }
            // NOTE: Everything related to a single guess goes inside this while loop.
            int guess = 0;
            int guessCount = 0;
            bool isValid = false;

            while (guess != secret)
            {
                Console.WriteLine($"Please guess the number (1-{maxValue})");
                isValid = int.TryParse(Console.ReadLine(), out int guessing);
                if (!isValid)
                {
                    Console.WriteLine($"Please enter the valid number (range: 1-{maxValue}).");
                }
                else
                {
                    if (secret > guessing)
                    {
                        Console.WriteLine($"too lower");
                    }
                    else if (secret < guessing)
                    {
                        Console.WriteLine($"too higher");
                    }
                    guess = guessing;
                }

                guessCount++;
            }

            Console.WriteLine($"Correct! You got it in {guessCount} guesses.");

        }
        Console.WriteLine("Thanks for playing!");



        // TODO 9: Read a guess and validate that it is a number (inside the while loop)
        // Prompt: $"Guess a number (1-{maxValue}): "
        // Hint: int.TryParse() and continue the loop if invalid
        // Hint: if parsing fails, skip feedback and ask again

        // TODO 10: Update guessCount and provide feedback (inside the while loop)
        // Track guessCount and print: "Too low.", "Too high.", or
        // "Correct! You got it in X guesses."

        // TODO 11: Print a closing message after all rounds finish
        // Example: "Thanks for playing!"
    }


    // TODO 2: Get a valid max value (10-100) using ReadIntInRange
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        bool isValid = true;
        int value = 0;
        do
        {
            Console.Write(prompt);
            //int.TryParse() and range check (value >= 10 && value <= 100)
            isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid || value < min || value > max)
            {
                Console.WriteLine($"Please enter a number from {min} to {max}.");
            }

        } while (!isValid || value < min || value > max);

        return value;
    }


    // Hint: int.TryParse() and range check (value >= 1 && value <= 3)
    // Store result in an int named rounds
    private static int getRound(string prompt, int min, int max)
    {
        bool isValid = true;
        int value = 0;
        do
        {
            isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid || value < min || value > max)
            {
                Console.WriteLine($"Please enter rounds(numbers) from {min} to {max}.");
            }
        } while (!isValid || value < min || value > max);

        return value;
    }
}

/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Haiyang Li
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        // TODO 1: Implement the main game loop
        // The loop should:
        // - Let player choose a template
        // - Collect words for the template
        // - Generate and display the story using template.GenerateStory()
        // - Ask if the player wants to play again
        // - Repeat if they answer 'y'
        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    // TODO 2: Implement ChooseTemplate
    private static StoryTemplate ChooseTemplate()
    {
        // Print these exact lines:
        Console.WriteLine("1) Debugging at the Zoo");
        Console.WriteLine("2) The Standup Meeting");

        int choice = ReadIntInRange("Choose a template (1-2): ", 1, 2);

        if (choice == 1)
        {
            return new StoryTemplate(
                "Debugging at the Zoo",
                new string[]
                {
                "Enter an adjective: ",
                "Enter an animal (plural): ",
                "Enter a verb ending in -ing: ",
                "Enter a programming language: ",
                "Enter a debugging tool (example: breakpoint): ",
                "Enter a number: ",
                "Enter an emotion: ",
                "Enter an exclamation: "
                },
                // {0}..{7}
                "Today I visited the {0} zoo. I saw {1} {2} while writing {3}. " +
                "I used a {4} {5} times until the bug disappeared. I felt {6} and yelled, \"{7}!\""
            );
        }

        return new StoryTemplate(
            "The Standup Meeting",
            new string[]
            {
            "Enter a name: ",
            "Enter an adjective: ",
            "Enter a noun: ",
            "Enter a verb (past tense): ",
            "Enter a number: ",
            "Enter a plural noun: ",
            "Enter a type of bug (example: null reference): ",
            "Enter a snack: "
            },
            "At today's standup, {0} gave a {1} update about the {2}. " +
            "They {3} it {4} times, but the team still found {5} of a {6}. " +
            "To survive the meeting, everyone grabbed a {7}."
        );
    }

    // TODO 3: Implement CollectWords
    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info($"Collecting {template.Prompts.Length} words for: {template.Title}");

        string[] words = new string[template.Prompts.Length];

        for (int i = 0; i < template.Prompts.Length; i++)
        {
            // here template.Prompts[i] is "Enter ...: "
            words[i] = ReadNonEmptyString(template.Prompts[i]);
        }

        Console.WriteLine();
        return words;
    }

    // TODO 4: Implement ReadYesNo
    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (input != null)
            {
                return true;
            }

            if (input.Equals("n"))
            {
                return false;
            }

            Console.WriteLine("Please enter 'y' or 'n'");
        }
    }

    // TODO 5: Implement ReadIntInRange
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;

            isValid = int.TryParse(input, out value);

            if (!isValid || value < min || value > max)
            {
                isValid = false;
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
        }
        while (!isValid);
        // - Return the valid integer
        return value;
    }

    // TODO 6: Implement ReadNonEmptyString
    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            //Show the prompt,Read input
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();//trim the input

            if (input != null)
            {
                return input;//Return the valid non-empty string
            }

            Console.WriteLine("Input cannot be empty. Please try again.");
        }
    }
}

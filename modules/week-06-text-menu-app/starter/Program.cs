/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: YourName
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO 1: Build a title banner using strings
        // Create variables for:
        // - title: "Text Menu Studio"
        // - subtitle: "Strings + Console Output Patterns"
        // - divider: 48 equals signs (hint: use new string() constructor)
        // Display: divider, title in uppercase, subtitle, divider

        Console.WriteLine("=== Cozy Cafe Studio Maker ===\n");

        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);

        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        int choice = 0;

        // TODO 2: Create a menu loop that repeats until user chooses 6 (Exit)
        // Hint: Use a while loop
        while (choice != 6)
        {
            // TODO 3: Print the menu box
            // Required menu option texts (tests check for these):
            // - 1) Greeting Card
            // - 2) Name Tag Formatter
            // - 3) Phrase Analyzer
            // - 4) Fancy Receipt Line
            // - 5) Menu Banner Builder
            // - 6) Exit
            Console.WriteLine("+*********************************+");
            Console.WriteLine("| 1) Greeting Card                |");
            Console.WriteLine("| 2) Name Tag Card                |");
            Console.WriteLine("| 3) Phrase Analyzer              |");
            Console.WriteLine("| 4) Fancy Receipt Line           |");
            Console.WriteLine("| 5) Menu Banner Builder          |");
            Console.WriteLine("| 6) Exit                         |");
            Console.WriteLine("+*********************************+");

            // TODO 4: Get menu choice from user
            // Use ReadIntInRange helper with prompt: "Choose an option (1-6): "
            // Range: 1 to 6

            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);
            Console.WriteLine();

            // TODO 5: Use a switch statement to handle each menu option
            switch (choice)
            {
                // ===== OPTION 1: Greeting Card =====
                // Prompts: "Enter your name: " and "Enter a short message: "
                // Required string operations:
                // - Use Trim() to clean up the name
                // - Use ToUpper() for an uppercase version
                // - Use concatenation OR interpolation for greeting text
                // - Use string.Format() for at least one output line
                // - Display a boxed card with the name, uppercase name, and message
                // Include the word "Message:" in your output
                case 1:
                    Console.Write("Enter your name: ");
                    string yourName = Console.ReadLine();
                    Console.WriteLine("Enter a short message: ");
                    string message = Console.ReadLine();
                    yourName = yourName.Trim().ToUpper();
                    message = message.Trim().ToUpper();

                    Console.WriteLine("=" + new string('=', 48) + '=');
                    Console.WriteLine(("| WELCOME TO " + yourName + '!').PadRight(49) + "|");
                    Console.WriteLine(("|" + message).PadRight(49) + "|");
                    Console.WriteLine("=" + new string('=', 48) + '=');
                    break;


                // ===== OPTION 2: Name Tag Formatter =====
                // Prompts: "Enter first name: " and "Enter last name: "
                // Required string operations:
                // - Use Trim() on both inputs
                // - Use concatenation to build full name
                // - Use string indexing to get first characters for initials
                // - Use ToUpper() for initials
                // - Use ToLower() for lowercase version
                // Display three things:
                // - Name tag with the full name (include a bracket [)
                // - Initials (use word "Initials:" in label)
                // - Lowercase version (use word "Lowercase:" in label)
                case 2:
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter last name: ");
                    string lastName = Console.ReadLine();
                    firstName = firstName.Trim();
                    lastName = lastName.Trim();
                    char fIntial = firstName[0];
                    char lIntial = lastName[0];

                    string initial = $"{fIntial}{lIntial}";
                    initial = initial.ToUpper();
                    string lowerInitial = initial.ToLower();
                    Console.WriteLine($"Name tag: [{firstName}{lastName}]");
                    Console.WriteLine($"Initials: {initial}");
                    Console.WriteLine($"Lowercase: {lowerInitial}");
                    break;

                case 3:
                    // ===== OPTION 3: Phrase Analyzer =====
                    Console.WriteLine("Enter a phrase: ");
                    string phrase = Console.ReadLine();
                    phrase = phrase.Trim();
                    int length = phrase.Length;
                    bool containsA = phrase.ToLower().Contains("a");//Contains
                    string dash = phrase.Replace(" ", "-");//Replace
                    string[] words = phrase.Split(' ');//Split
                    // - Use string.Join() to create comma-separated list
                    string listWords = string.Join(", ", words);
                    // Display: length, contains check, dashed version, and words list
                    Console.WriteLine($"Length: {length}");
                    Console.WriteLine($"Contains 'a': {containsA}");
                    Console.WriteLine($"Dashed version: {dash}");
                    Console.WriteLine($"Words: {listWords}");
                    break;

                // ===== OPTION 4: Fancy Receipt Line =====
                // Prompts: "Enter item name: ", "Enter price: ", "Enter quantity (1-9): "
                case 4:
                    Console.Write("Enter item name: ");
                    string item = Console.ReadLine().Trim();

                    Console.Write("Enter price: ");
                    double price = ReadDouble(Console.ReadLine());
                    //Enter quantity (1-9):
                    Console.Write("Enter quantity (1-9): ");
                    int quantity = ReadIntInRange("Enter item name:", 1, 9);
                    // - Calculate total (price * quantity)
                    double total = price * quantity;

                    Console.WriteLine();
                    Console.WriteLine("===== RECEIPT =====");
                    // Header row
                    Console.WriteLine(string.Format("{0,-15} {1,5} {2,10}",
                        "ITEM", "QTY", "TOTAL"));
                    Console.WriteLine("===================");
                    // alignment + currency
                    Console.WriteLine(string.Format("{0,-15} {1,5} {2,10:C2}",
                        item, quantity, total));
                    break;

                case 5:
                    // Prompts: "Enter a title: ", "Enter a subtitle: ", "Enter width (30-60): "

                    Console.Write("Enter a title: ");
                    title = Console.ReadLine().Trim();

                    Console.Write("Enter a subtitle: ");
                    subtitle = Console.ReadLine().Trim();
                    // Use ReadIntInRange for width (min=30, max=60)
                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
                    // - Create border line with equals signs (use new string constructor)
                    string border = new string('=', width);

                    // Use ToUpper() on title
                    title = title.ToUpper();

                    //PadLeft
                    string centeredTitle = title.PadLeft((width + title.Length) / 2);
                    string centeredSubtitle = subtitle.PadLeft((width + subtitle.Length) / 2);

                    // Display banner with borders and centered text
                    Console.WriteLine(border);
                    Console.WriteLine(centeredTitle);
                    Console.WriteLine(centeredSubtitle);
                    Console.WriteLine(border);

                    Console.WriteLine();
                    Console.WriteLine("Alignment Examples:");

                    // - Show three alignment examples (centered, left, right)
                    Console.WriteLine("Left aligned:".PadRight(width));
                    Console.WriteLine("Centered:".PadLeft((width + "Centered:".Length) / 2));
                    Console.WriteLine("Right aligned:".PadLeft(width));
                    break;
                // ===== OPTION 6: Exit with String Analysis =====

                case 6:
                    // Prompt: "Enter a closing word: "
                    Console.Write("Enter a closing word: ");
                    string input = (Console.ReadLine() ?? "").Trim();
                    // - Use Equals() with StringComparison.OrdinalIgnoreCase to compare with "goodbye"
                    bool isGoodbye = input.Equals("goodbye", StringComparison.OrdinalIgnoreCase);

                    // - Use Substring() to extract first 3 characters (check length first!)
                    string first3 = "";
                    if (input.Length >= 3)
                    {
                        first3 = input.Substring(0, 3);
                    }
                    else
                    {
                        first3 = "Too short";
                    }

                    // - Use EndsWith() to check if ends with "!"
                    bool endsWithExclamation = input.EndsWith("!");

                    // - Use IndexOf() to find position of space character
                    int spacePosition = input.IndexOf(' ');

                    // ===== Display results =====
                    Console.WriteLine($"Equals 'goodbye' (ignore case): {isGoodbye}");
                    Console.WriteLine($"First 3 characters: {first3}");
                    Console.WriteLine($"Ends with '!': {endsWithExclamation}");
                    Console.WriteLine($"Index of space: {spacePosition}");
                    Console.WriteLine("Goodbye!");
                    break;

            }


        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;
        // TODO 7: Implement input validation
        // Use a do-while loop with int.TryParse()
        // Keep prompting until input is valid AND within range
        // Return the valid number
        do
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out value);//validation
        } while (!isValid || value < min || value > max);

        return value; // Remove this placeholder
    }

    private static double ReadDouble(string prompt)
    {
        // TODO 8: Implement input validation
        // Use a do-while loop with double.TryParse()
        // Keep prompting until input is a valid number
        // Return the valid number
        double value;
        bool isValid;

        do
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            isValid = double.TryParse(input, out value); //validation
        } while (!isValid);

        return value; // Remove this placeholder
    }
}

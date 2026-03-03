/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Haiyang Li
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Builds a class roster using parallel arrays and a simple menu.
- */

namespace ClassRoster;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("***** Class Roster *****");
        Console.WriteLine();

        // TODO 1: parallel arrays + capacity + count
        const int rosterCapacity = 3;
        string[] rosterNames = new string[rosterCapacity];
        int[] rosterCredits = new int[rosterCapacity];
        int count = 0;

        int choice = 0;

        // TODO 2: menu loop
        while (choice != 4)
        {
            // Print the menu options (every loop)
            Console.WriteLine("[1] Add multiple students");
            Console.WriteLine("[2] Print class roster");
            Console.WriteLine("[3] Print roster (sorted)");
            Console.WriteLine("[4] Exit");

            // TODO 3: Get the menu choice
            choice = ReadIntInRange("Choose an option: ", 1, 4);

            // TODO 4: switch handle
            switch (choice)
            {
                case 1:
                    {
                        // ===== OPTION 1: Add multiple students =====
                        if (count == rosterCapacity)
                        {
                            Console.WriteLine("Roster is full. Cannot add more students.");
                        }
                        else
                        {
                            //remainslot equls capacity minus count
                            int remainingSlots = rosterCapacity - count;
                            int toAdd = ReadIntInRange(
                                $"How many students do you want to add? (1-{remainingSlots}): ",
                                1,
                                remainingSlots);

                            string[] newNames = new string[toAdd];
                            int[] newCredits = new int[toAdd];

                            for (int i = 0; i < toAdd; i++)
                            {
                                Console.Write($"Enter name for student {i + 1}: ");
                                newNames[i] = Console.ReadLine() ?? string.Empty;

                                newCredits[i] = ReadIntInRange(
                                    $"Enter credits for {newNames[i]} (0-200): ",
                                    0,
                                    200);
                            }

                            // copy into roster arrays
                            for (int i = 0; i < toAdd; i++)
                            {
                                rosterNames[count] = newNames[i];
                                rosterCredits[count] = newCredits[i];
                                count++;
                            }

                            Console.WriteLine("Students add already");
                        }

                        break;
                    }

                case 2:
                    {
                        // ===== OPTION 2: Print class roster =====
                        if (count == 0)
                        {
                            Console.WriteLine("Roster is empty.");
                        }
                        else
                        {
                            string[] lines = BuildRosterLines(rosterNames, rosterCredits, count);
                            Console.WriteLine("Class Roster:");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }

                        break;
                    }

                case 3:
                    {
                        // ===== OPTION 3: Print roster (sorted) =====
                        if (count == 0)
                        {
                            Console.WriteLine("Roster is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Sort by:");
                            Console.WriteLine("[1] Name");
                            Console.WriteLine("[2] Credits");

                            int sortChoice = ReadIntInRange("Choose an option: ", 1, 2);

                            CopyUsedRoster(rosterNames, rosterCredits, count, out string[] sortedNames, out int[] sortedCredits);

                            if (sortChoice == 1)
                            {
                                Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase);
                            }
                            else
                            {
                                Array.Sort(sortedCredits, sortedNames);
                            }

                            string[] lines = BuildRosterLines(sortedNames, sortedCredits, count);
                            Console.WriteLine("Class Roster (Sorted):");
                            foreach (string line in lines)
                            {
                                Console.WriteLine(line);
                            }
                        }

                        break;
                    }

                case 4:
                    {
                        // ===== OPTION 4: Exit =====
                        Console.WriteLine("Goodbye");
                        break;
                    }
            }

            // TODO 9: blank line between actions (not after Exit)
            if (choice != 4)
            {
                Console.WriteLine();
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);//determin the valid enter
        }
        while (!isValid || value < min || value > max);

        return value;
    }

    private static string[] BuildRosterLines(string[] names, int[] credits, int count)
    {
        // TODO 6.1
        string[] lines = new string[count];

        for (int i = 0; i < count; i++)
        {
            //parall arrays
            lines[i] = $"{i}) {names[i]} - Credits: {credits[i]}";
        }

        return lines;
    }

    private static void CopyUsedRoster(string[] sourceNames, int[] sourceCredits, int count,
        out string[] names, out int[] credits)
    {
        // TODO 7.1
        names = new string[count];
        credits = new int[count];

        //new clear arrays to sort
        for (int i = 0; i < count; i++)
        {
            names[i] = sourceNames[i];
            credits[i] = sourceCredits[i];
        }
    }
}

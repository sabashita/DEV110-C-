/*******************************************************************************
 * Course: DEV 110
 * Instructor: Zak Brinlee
 * Term: Winter 2026
 *
 * Programmer: Haiyang Li
 * Assignment: Week 10: Habit Tracker (File I/O)
 *
 * What does this program do?:
 * A menu-driven Habit Tracker that loads habits from a CSV file and lets you
 * view, add, update, and save your habits back to disk.
 * ******************************************************************************/

using System.Globalization;
using System.IO;
using System.Linq;

namespace HabitTracker;

/// <summary>
/// Main program class for the Habit Tracker application.
/// Your work this week: implement the eight TODO methods below.
/// The Main method, menu loop, and ReadIntInRange helper are fully provided.
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point — prompts for file paths, loads habits, then runs the menu.
    /// Fully provided; no changes needed here.
    /// </summary>
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Habit Tracker: File I/O ===");
        Console.WriteLine();

        // Prompt for the path to the habits CSV file
        Console.Write("Enter habits file path: ");
        string path = (Console.ReadLine() ?? string.Empty).Trim();
        Console.WriteLine();

        // Load all habits (you will implement LoadHabits below)
        List<Habit> habits = LoadHabits(path);

        Console.WriteLine();

        // Menu loop — keeps running until the user chooses Save & Quit
        bool running = true;
        while (running)
        {
            Console.WriteLine("--- Menu ---");
            Console.WriteLine("1. View Habits");
            Console.WriteLine("2. View Summary");
            Console.WriteLine("3. Add Habit");
            Console.WriteLine("4. Update Habit");
            Console.WriteLine("5. Save & Quit");
            Console.Write("Choice (1-5): ");

            int choice = ReadIntInRange(1, 5);
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    PrintHabits(habits);
                    break;
                case 2:
                    PrintSummary(habits);
                    break;
                case 3:
                    AddHabit(habits);
                    break;
                case 4:
                    UpdateHabit(habits);
                    break;
                case 5:
                    SaveHabits(path, habits);
                    running = false;
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Goodbye!");
    }

    // Load habits from a CSV file.
    private static List<Habit> LoadHabits(string path)
    {
        List<Habit> habits = new List<Habit>();

        try
        {
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Skip blank lines
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split(',');

                // Skip invalid rows
                if (parts.Length < 3)
                {
                    continue;
                }

                string name = parts[0].Trim();
                string status = parts[1].Trim();
                string frequency = parts[2].Trim();

                bool isCompleted = status.Equals("done", StringComparison.OrdinalIgnoreCase);

                habits.Add(new Habit(name, isCompleted, frequency));
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File not found — {path}");
        }

        return habits;
    }

    // Print all habits.
    private static void PrintHabits(List<Habit> habits)
    {
        Console.WriteLine("--- Your Habits ---");

        foreach (Habit habit in habits)
        {
            habit.DisplayInfo();
        }
    }

    // Print summary stats for daily and weekly habits.
    private static void PrintSummary(List<Habit> habits)
    {
        Console.WriteLine("--- Summary ---");

        int dailyTotal = habits.Count(h => h.Frequency == "daily");
        int dailyCompleted = habits.Count(h => h.Frequency == "daily" && h.IsCompleted);

        int weeklyTotal = habits.Count(h => h.Frequency == "weekly");
        int weeklyCompleted = habits.Count(h => h.Frequency == "weekly" && h.IsCompleted);

        double dailyRate = dailyTotal == 0 ? 0 : (double)dailyCompleted / dailyTotal * 100;
        double weeklyRate = weeklyTotal == 0 ? 0 : (double)weeklyCompleted / weeklyTotal * 100;

        Console.WriteLine(
            $"Daily:    {dailyCompleted}/{dailyTotal} completed ({dailyRate.ToString("F1", CultureInfo.InvariantCulture)}%)");

        Console.WriteLine(
            $"Weekly:   {weeklyCompleted}/{weeklyTotal} completed ({weeklyRate.ToString("F1", CultureInfo.InvariantCulture)}%)");
    }

    // Add a new habit.
    private static void AddHabit(List<Habit> habits)
    {
        Console.WriteLine("--- Add Habit ---");

        Console.Write("Habit name: ");
        string name = (Console.ReadLine() ?? string.Empty).Trim();

        Console.Write("Frequency ((D)aily or (W)eekly): ");
        string input = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();

        string frequency = input == "D" ? "daily" : "weekly";

        habits.Add(new Habit(name, false, frequency));

        Console.WriteLine($"Added: {name} ({frequency})");
    }

    // Update a habit's name and completion status.
    private static void UpdateHabit(List<Habit> habits)
    {
        if (habits.Count == 0)
        {
            Console.WriteLine("No habits to update.");
            return;
        }

        Console.WriteLine("--- Update Habit ---");

        for (int i = 0; i < habits.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {habits[i].Name}");
        }

        Console.Write("Enter habit number: ");
        int choice = ReadIntInRange(1, habits.Count);
        int index = choice - 1;

        Habit habit = habits[index];

        Console.Write($"New name (press Enter to keep \"{habit.Name}\"): ");
        string newName = (Console.ReadLine() ?? string.Empty).Trim();

        if (!string.IsNullOrWhiteSpace(newName))
        {
            habit.Name = newName;
        }

        // Toggle completed status
        habit.IsCompleted = !habit.IsCompleted;

        Console.WriteLine($"Updated: {habit.Name} — now {(habit.IsCompleted ? "completed" : "pending")}");
    }

    // Save habits back to the CSV file.
    private static void SaveHabits(string path, List<Habit> habits)
    {
        string[] lines = habits
            .Select(h => $"{h.Name},{(h.IsCompleted ? "done" : "pending")},{h.Frequency}")
            .ToArray();

        File.WriteAllLines(path, lines);

        Console.WriteLine($"Habits saved to {path}.");
    }

    /// <summary>
    /// Reads an integer from the console, repeating until a valid value
    /// in [min, max] is entered. Fully provided — no changes needed.
    /// </summary>
    private static int ReadIntInRange(int min, int max)
    {
        while (true)
        {
            string line = (Console.ReadLine() ?? string.Empty).Trim();
            if (int.TryParse(line, out int value) && value >= min && value <= max)
            {
                return value;
            }

            Console.Write($"Please enter a number between {min} and {max}: ");
        }
    }
}

# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:Haiyang Li**

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer:file.ReadAllLines returns a string array, where each element represents one line from the file.
I used it to read all lines from the CSV file, then looped through each line.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer:Blank lines do not contain any data. If we try to process them, it may cause errors when splitting or accessing array elements.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer:File.WriteAllLines is an array of strings to a file. It takes a file path and a string array, and each element becomes a line in the file. It overwrites the exist of file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select is used to convert  habit into a string, and ToArray turns the result into an array. This is needed because File.WriteAllLines requires a string array.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: FileNotFoundException happens when the program can not find the file at the given path. It usually occurs if the file does not exist or the path is wrong.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer:We catch FileNotFoundException because it's a specific and expected error when the file is missing. Catching Exception would catch everything.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1.I learned how to load and save data from a CSV file.
2.I learned how to handle file errors without crashing the program.
3.I learned how to use LINQ to count and format data.

**What was the trickiest part of this assignment and how did you work through it?**

Answer: The trickiest part was reading and processing the CSV data. I solved it by checking for invalid lines and test the program step by step to make sure it worked correctly.

## Time Spent

**Total time:** 4.5 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 1 hours
- Implementing LoadHabits: 1 hour
- Implementing PrintHabits / PrintSummary: 30 min
- Implementing AddHabit / UpdateHabit / SaveHabits: 30 min
- Testing and debugging:  1 hour
- Writing study notes:  30 min

**Most time-consuming part:**

Answer:debugging

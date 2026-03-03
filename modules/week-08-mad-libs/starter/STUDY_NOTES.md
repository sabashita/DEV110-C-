# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Haiyang Li

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer:ChooseTemplate() – Displays the two story options and returns the selected
StoryTemplate.CollectWords() – Prompts the user for all required words and returns them in a string array.
ReadYesNo() – Validates and reads a “y” or “n” response.
ReadIntInRange() – Reads and validates a number within a specified range.
ReadNonEmptyString() – Ensures the user enters a non-empty string.
GenerateStory() Validates input and builds the  story.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer:Moving code into helper methods improve readable by break the program into tasks

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer:The StoryTemplate class stores the story title, prompts, and template text. using GenerateStory() method to format the story

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer:Using a template allows the same program logic to work with different prompts and text.

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer:I set a breakpoint inside GenerateStory()

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer:Stepping through the code helped me understand the execution flow and confirm that loops

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer:

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1.I have learned create by using template to generate the long text.
2.
3.

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: the private methods is helped me to understand program structure

## Time Spent

**Total time:** [4 hours]

**Breakdown:**

- Planning structure (methods/classes): [1 hours]
- Input validation: [0.5 hours]
- Story templates + formatting: [1 hours]
- Testing and debugging: [0.5 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer:I have take more time to practice the formatting.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer:

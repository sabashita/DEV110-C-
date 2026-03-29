# Week 6: Text Menu App - Study Notes

**Name:Haiyang Li**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer:

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: isValid = int.TryParse(input, out value);//validation

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: excution imediately then do the determine of loop

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: the logical is not complex, unnecessary to use for loop.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: sepreate the int helper and double helper handle

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer:using TryParse to validate input.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer:int.TryParse can handle "string" without error, double can handle decimal

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer:Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer:

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer:

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.I have learned the methods like Replace, Contains, Join, Padleft, PadRight formatting.
2.
3.
4.
5.

**Which loop felt most natural to use and why?**

Answer: do...while

## Time Spent

**Total time:** [4 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [1 hours]
- String formatting: [0.5 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:string formattin handle

## Reflection

**What would you do differently next time?**

Answer:string validation handle

**How did using three different loop types improve your understanding of repetition?**

Answer:

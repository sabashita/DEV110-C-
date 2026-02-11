# Week 5: Guess the Number - Study Notes

**Name:Haiyang Li**

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: when I want to do repeat things and do some logic determine or assignment to different variables in consistent

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer:when first time typing needed

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer:

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: when I want to do some variables assignment work or put/take some variables from arrays

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer:

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer: Transit two of variables to determine a range. By using greatter and smaller notion

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer: using if conditions to determine rounds

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer:using int.Tryparse method.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer: uesing Tryparse method and set variables with "out" which is C# gramma

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer:when the customer typing number, I using the variables to count++ in the loop

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer:

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer:

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer:

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer:

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.I learned the int.Tryparse method, the "out" could me out int value, and the scope of value is in the if condition or method when you declare in the int.Tryparse(); otherwise is declare outside of the int.Tryparse it could be gloallbal variables.
2.I was struggle with git/GitHub handle, I screw up the PR and branch last night, but I fix it today.
3.
4.
5.

**Which loop felt most natural to use and why?**

Answer:

## Time Spent

**Total time:** [3.5 hours]

**Breakdown:**

- Planning the loops: [1 hours]
- Input validation: [1 hours]
- Guessing logic: [30 hours]
- Testing and debugging: [20 hours]
- Writing documentation: [40 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:Git/GitHub

## Reflection

**What would you do differently next time?**

Answer:

**How did using three different loop types improve your understanding of repetition?**

Answer:
For the do...while, it will excution immediately 1st loop when declare do.., then getting loop another round. it will skip out the first time "while()" condition determine
For the while, it will excution after the condition determine of "while()".
For the for..loop, when you do not want to declare the variables separate in the "while..loop", you can declare in the for() method, it's structuring and convenient to use.


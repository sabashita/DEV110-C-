# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:Haiyang Li**

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: using parallel arryas assign the variables at the same time, same index of arrays

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: count variable for how many slot has used

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer:because the count represent how many slots are currently in use. so looping to count prevents get null.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer:build an array of formatted roster lines using the buildRosterlines method ,then crate a new string[] to count and use for loop to formatted name and credit

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer:copy from only used portion of roster into new arrays using copyUsedRoster method.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.array.sort to sort the numbers as asc
2.
3.
4.
5.

**Which loop felt most natural to use and why?**

Answer:for...loop, because is ensure of array size

## Time Spent

**Total time:** [5 hours]

**Breakdown:**

- Planning the arrays/menu: [0.5 hours]
- Input validation: [0.5 hours]
- Add + print roster features: [1 hours]
- Sorting feature: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: sorting and print roster

## Reflection

**What would you do differently next time?**

Answer:

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer:for using by ensure size of array, foreach can using by unsure array or object,is automactically to assign into the object.

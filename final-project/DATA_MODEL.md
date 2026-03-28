# Final Project — Data Model Planning Template

_Fill this out **before** writing any code. Think through your app's data first._

---

## Scenario (1–2 sentences)

_What does your app do? Who uses it and why?_

This app is a user to order a burger meal from a console menu. The user selects a burger, a side, optionally removes toppings, and then sees a receipt and enters a payment.

---

## Inputs (with types)

_List **at least 5** named inputs your app collects or works with. Include the data type for each._

_Example format:_
_- `movieTitle` (string) — the name of the movie the user enters_

burgerChoice (int) — the user selects which burger they want
sideChoice (int) — the user selects which side item they want
removeToppingsChoice (string) — whether the user wants to remove toppings (Y/N)
paymentAmount (double) — the amount of money the user enters to pay
removeCheese (string) — whether to remove cheese (Y/N)
removeTomato (string) — whether to remove tomato (Y/N)
removeOnion (string) — whether to remove onion (Y/N)

---

## Calculated or Derived Values

_List any values your program computes from the inputs (totals, averages, counts, formatted strings, etc.)._
_If your app doesn't calculate anything, write "None" and explain why._

subtotal (double) — sum of burger price and side price
tax (double) — calculated from subtotal using a tax rate
total (double) — subtotal plus tax
change (double) — payment amount minus total

---

## Outputs (what the user sees)

_Describe what the program displays. Include menu options, summary views, confirmation messages, etc._

The program displays a menu of burger options and side options. It then asks the user about removing toppings. After the selection, the app show a formatted receipt including the selected items, removed toppings, subtotal, tax, and total. it displays whether the payment is enough and shows the change

---

## Edge Case to Consider (at least 1)

_What could go wrong or behave unexpectedly? How will your app handle it?_

_Examples: file not found, user enters a letter instead of a number, empty list, duplicate entry._

If the user enters an invalid menu choice , the program will ask them to enter a valid choice again. if the payment amount is less than the total, the program will show a message indicating  payment instead of crashing.

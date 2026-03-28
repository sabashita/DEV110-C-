using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Welcome to Burger Menu App ===\n");

        // Create menu
        List<MenuItem> burgers = new List<MenuItem>
        {
            new MenuItem("Kilo Burger", 3.49),
            new MenuItem("Mega Burger", 5.49),
            new MenuItem("Chicken Sandwich", 6.17)
        };

        List<MenuItem> sides = new List<MenuItem>
        {
            new MenuItem("Fries", 3.79),
            new MenuItem("Onion Rings", 4.39),
            new MenuItem("Salad", 3.56)
        };

        // Create order
        Order order = new Order();

        // Choose burger
        Console.WriteLine("Choose a burger:");
        for (int i = 0; i < burgers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {burgers[i].Name} - ${burgers[i].Price}");
        }

        int burgerChoice = GetValidChoice(burgers.Count);
        order.Burger = burgers[burgerChoice - 1];

        Console.WriteLine();

        // Choose side
        Console.WriteLine("Choose a side:");
        for (int i = 0; i < sides.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sides[i].Name} - ${sides[i].Price}");
        }

        int sideChoice = GetValidChoice(sides.Count);
        order.Side = sides[sideChoice - 1];

        Console.WriteLine();

        // Remove topping
        Console.WriteLine("Remove toppings? (Y/N)");
        string remove = Console.ReadLine().ToLower();

        if (remove == "y")
        {
            AskRemove("cheese", order);
            AskRemove("tomato", order);
            AskRemove("onion", order);
        }

        // Print receipt
        PrintReceipt(order);

        // Payment
        Console.Write("\n Enter payment amount: ");
        double payment = Convert.ToDouble(Console.ReadLine());

        double total = order.GetTotal();

        if (payment >= total)
        {
            double change = payment - total;
            Console.WriteLine($"Payment accepted. Change: ${change:F2}");
        }
        else
        {
            Console.WriteLine("Not enough payment.");
        }

        Console.WriteLine("\nThank you!");
    }

    // get valid menu choice
    static int GetValidChoice(int max)
    {
        int choice;

        while (true)
        {
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= max)
            {
                return choice;
            }

            Console.WriteLine("Invalid choice. Try again.");
        }
    }

    // ask to remove topping
    static void AskRemove(string topping, Order order)
    {
        Console.Write($"No {topping}? (Y/N): ");
        string input = Console.ReadLine().ToLower();

        if (input == "y")
        {
            order.RemovedToppings.Add(topping);
        }
    }

    // print receipt
    static void PrintReceipt(Order order)
    {
        Console.WriteLine("\n===== RECEIPT =====");

        Console.WriteLine($"Burger: {order.Burger.Name} - ${order.Burger.Price:F2}");
        Console.WriteLine($"Side: {order.Side.Name} - ${order.Side.Price:F2}");

        if (order.RemovedToppings.Count > 0)
        {
            Console.WriteLine("Removed toppings: " + string.Join(" || ", order.RemovedToppings));
        }

        double subtotal = order.GetSubtotal();
        double tax = order.GetTax();
        double total = order.GetTotal();

        Console.WriteLine($"Subtotal: ${subtotal:F2}");
        Console.WriteLine($"Tax: ${tax:F2}");
        Console.WriteLine($"Total: ${total:F2}");
    }
}

using System.Collections.Generic;

public class Order
{
    public MenuItem Burger { get; set; }
    public MenuItem Side { get; set; }

    public List<string> RemovedToppings { get; set; } = new List<string>();

    public double TaxRate { get; set; } = 0.10;

    public double GetSubtotal()
    {
        return Burger.Price + Side.Price;
    }

    public double GetTax()
    {
        return GetSubtotal() * TaxRate;
    }

    public double GetTotal()
    {
        return GetSubtotal() + GetTax();
    }
}

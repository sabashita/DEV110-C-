using System.Data;

namespace HelloGitHub;

public class Program
{
    public static void Main(string[] args)
    {
        // TODO: Write code that outputs "Hello, GitHub!" to the console
        Console.WriteLine("Hello, GitHub!");

        Console.WriteLine("Please input two numbers to calculate:");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 + num2;
        // Console.WriteLine($"The sum of {num1} and {num2} is {result}");
        Console.WriteLine("The sum of {0} + {1} is {2}", num1, num2, result);
    }
}

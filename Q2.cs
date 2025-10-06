using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose operation: + - * /");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine($"Result: {a + b}");
                break;
            case '-':
                Console.WriteLine($"Result: {a - b}");
                break;
            case '*':
                Console.WriteLine($"Result: {a * b}");
                break;
            case '/':
                if (b != 0)
                    Console.WriteLine($"Result: {a / b}");
                else
                    Console.WriteLine("Division by zero not allowed.");
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }
}

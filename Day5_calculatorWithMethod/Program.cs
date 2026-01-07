using System;

class Program
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        Console.Write("Enter firts number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Choose operation (+ - * /): ");
        string op = Console.ReadLine();

        double result = 0;

        if (op == "+")
            result = Add(a, b);
        else if (op == "-")
            result = Subtract(a, b);
        else if (op == "*")
            result = Multiply(a, b);
        else if (op == "/")
            result = Divide(a, b);
        else
            Console.WriteLine("Invalid operation");

        Console.WriteLine("Result = " + result);
        Console.ReadLine();
    }
}
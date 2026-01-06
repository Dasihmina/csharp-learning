using System;
class Program
{
    static void Main()
    {
        Console.Write("Choose a number (1-3): ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Hello");
                break;

            case 2:
                Console.WriteLine("Bye");
                break;

            case 3:
                Console.WriteLine("Exit");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.ReadLine();
    }
}
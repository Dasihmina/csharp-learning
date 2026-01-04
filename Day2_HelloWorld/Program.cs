using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your favourite color?: ");
        string color = Console.ReadLine();

        Console.Write("What is your favourite number?: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your favourite color is {color} and favourite number is {number}.");
        Console.ReadLine();
    }


}
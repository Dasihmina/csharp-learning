using System;

class Program
{
    static void Main() {

        Console.Write("How old are you?: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine($"You are {age} years old!");

        if (age >= 18) {
            Console.WriteLine("You are old enough to vote!");
        } else { 
            Console.WriteLine("You aren`t old enough to vote!");
        }

     }
}

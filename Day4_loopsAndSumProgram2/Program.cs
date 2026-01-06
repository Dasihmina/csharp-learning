using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        int sum = 0;

        while (i <= n) 
        {
            Console.WriteLine(i);
            sum += i;
            ++i;

           
        }
        Console.WriteLine("Sum = " + sum);
        Console.ReadLine();
     }
}
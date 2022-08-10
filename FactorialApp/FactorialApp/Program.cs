using System;

public class FactorialApp2
{
    static void Main(string[] args)
    // Declare variables and then initialize to zero.
    {
        int num;

        // Display title as the C# console calculator app.
        Console.WriteLine("Console Factorial Calculator in C#\r");
        Console.WriteLine("------------------------\n");

        // Ask the user to type the first number.
        Console.WriteLine("Type a number, and then press Enter");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= num; i++)
            if (i == num)
                Console.WriteLine($"Your result:" + 1);
            else
                Console.WriteLine($"Your result: " + (i * (i - 1)));

        // Wait for the user to respond before closing.
        Console.Write("Press any key to close the Factorial Calculator console app...");
        Console.ReadKey();
    }
}
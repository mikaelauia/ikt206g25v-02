using System;
using Testlib;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            // Read input from the user
            string? input = Console.ReadLine();

            // Exit if the input is empty or null
            if (string.IsNullOrEmpty(input)) break;

            // Use the StartsWithUpper method from Testlib
            Console.WriteLine($"Input: {input} {"Begins with uppercase?",30}: " +
                              $"{(input.StartsWithUpper() ? "Yes" : "No")}{Environment.NewLine}");

            row += 3;
        } while (true);

        return;

        // Local method to reset the console screen
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}
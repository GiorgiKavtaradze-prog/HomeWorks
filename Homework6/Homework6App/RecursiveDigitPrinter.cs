using System;
using System.Linq;

namespace Homework6App;

public static class RecursiveDigitPrinter
{
    public static string GetDigitsSeparated(int number)
    {
        return GetDigitsSeparatedRecursive(Math.Abs(number));
    }

    private static string GetDigitsSeparatedRecursive(int number)
    {
        if (number < 10)
        {
            return number.ToString();
        }
        return GetDigitsSeparatedRecursive(number / 10) + " - " + (number % 10);
    }

    public static void PrintDigitsSeparated(int number)
    {
        Console.WriteLine(GetDigitsSeparated(number));
    }

    public static void Run()
    {
        Console.WriteLine("=== Task 5: Recursive Digit Printer ===\n");
        while (true)
        {
            string input = InputHelper.GetStringInput("Enter a number (or type 'exit' to quit): ");
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            if (int.TryParse(input, out int number))
            {
                PrintDigitsSeparated(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
            Console.WriteLine();
        }
    }
}

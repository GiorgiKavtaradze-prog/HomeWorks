using System;

namespace Homework3App;

public static class DivisibilityChecker
{
    private const int Divisor = 5;
    private const string SuccessMessage = "Yes";
    private const string FailureMessage = "No";

    public static void Run()
    {
        Console.WriteLine("\n=== Divisibility Checker ===");
        var number = InputHelper.GetIntInput($"Enter a number to check divisibility by {Divisor}: ");
        var isDivisible = CheckDivisibility(number, Divisor);
        DisplayResult(isDivisible);
    }

    private static bool CheckDivisibility(int dividend, int divisor)
    {
        return dividend % divisor == 0;
    }

    private static void DisplayResult(bool result)
    {
        Console.WriteLine(result ? SuccessMessage : FailureMessage);
    }
}

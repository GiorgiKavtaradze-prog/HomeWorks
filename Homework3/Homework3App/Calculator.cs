using System;

namespace Homework3App;

public static class Calculator
{
    private const string DivisionByZeroMessage = "Not Allowed To Divide By Zero";

    public static void Run()
    {
        Console.WriteLine("\n=== Arithmetic Operations Tool ===");
        
        double x = InputHelper.GetDoubleInput("X = ");
        double y = InputHelper.GetDoubleInput("Y = ");

        var results = CalculateOperations(x, y);

        DisplayResults(results);
    }

    private static CalculatorResults CalculateOperations(double x, double y)
    {
        var max = Math.Max(x, y);
        var min = Math.Min(x, y);

        return new CalculatorResults
        {
            Sum = x + y,
            Difference = max - min,
            Product = x * y,
            Division = min == 0 ? DivisionByZeroMessage : (max / min).ToString()
        };
    }

    private static void DisplayResults(CalculatorResults results)
    {
        Console.WriteLine();
        Console.WriteLine($"X+Y {results.Sum}");
        Console.WriteLine($"X-Y {results.Difference}");
        Console.WriteLine($"X*Y {results.Product}");
        Console.WriteLine($"X/Y {results.Division}");
    }

    private struct CalculatorResults
    {
        public double Sum { get; init; }
        public double Difference { get; init; }
        public double Product { get; init; }
        public string Division { get; init; }
    }
}

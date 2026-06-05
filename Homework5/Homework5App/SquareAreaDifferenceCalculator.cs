using System;

namespace Homework5App;

public static class SquareAreaDifferenceCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== Task 1: Calculate Area Difference Between Squares ===");
        int radius = InputHelper.GetIntInput("Enter the radius: ");
        int difference = CalculateDifference(radius);
        Console.WriteLine(difference);
        Console.WriteLine();
    }

    public static int CalculateDifference(int radius)
    {
        int bigSquareArea = (2 * radius) * (2 * radius);
        int smallSquareArea = 2 * radius * radius;
        return bigSquareArea - smallSquareArea;
    }
}

using System;

namespace Homework3App;

public static class Swapper
{
    private const string HeaderText = "=== Variable Value Swap Tool ===";

    public static void Run()
    {
        Console.WriteLine($"\n{HeaderText}");
        
        var x = InputHelper.GetIntInput("Enter X: ");
        var y = InputHelper.GetIntInput("Enter Y: ");

        Console.WriteLine($"\nBefore Swap: X = {x}, Y = {y}");

        var result = PerformSwap(x, y);

        DisplayResult(result);
    }

    private static SwapResult PerformSwap(int x, int y)
    {
        return new SwapResult
        {
            NewX = y,
            NewY = x
        };
    }

    private static void DisplayResult(SwapResult result)
    {
        Console.WriteLine($"After Swap:  X = {result.NewX}, Y = {result.NewY}");
    }

    private struct SwapResult
    {
        public int NewX { get; init; }
        public int NewY { get; init; }
    }
}

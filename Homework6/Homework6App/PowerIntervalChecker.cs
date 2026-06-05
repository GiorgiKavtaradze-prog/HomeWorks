using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6App;

internal static class PowerIntervalChecker
{
    public static int Run()
    {
        try
        {
            var (a, b, n) = GetInputParameters();
            var result = AnalyzePowerInterval(a, b, n);
            DisplayResults(a, b, n, result);
            return result.Count;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return 0;
        }
        finally
        {
            PauseBeforeExit();
        }
    }

    private static (int a, int b, int n) GetInputParameters()
    {
        Console.WriteLine("Enter interval parameters:");
        int a = InputHelper.GetIntInput("  • Minimum number (a): ");
        int b = InputHelper.GetIntInput("  • Maximum number (b): ");
        int n = InputHelper.GetIntInput("  • Power exponent (n): ");
        
        return (a, b, n);
    }

    private static PowerIntervalResult AnalyzePowerInterval(int a, int b, int n)
    {
        if (!ValidateParameters(a, b, n))
            return new PowerIntervalResult { Count = 0, ValidBases = new List<int>() };

        int minBase = FindMinBase(a, n);
        int maxBase = FindMaxBase(b, n);

        var validBases = Enumerable
            .Range(minBase, Math.Max(0, maxBase - minBase + 1))
            .Where(x => IsPowerInRange(x, n, a, b))
            .ToList();

        return new PowerIntervalResult 
        { 
            Count = validBases.Count,
            ValidBases = validBases,
            MinBase = minBase,
            MaxBase = maxBase
        };
    }

    private static bool ValidateParameters(int a, int b, int n) =>
        n > 0 && a >= 0 && b >= 0 && a <= b;

    private static int FindMinBase(int a, int n)
    {
        int minBase = (int)Math.Ceiling(Math.Pow(a, 1.0 / n));
        while (Math.Pow(minBase, n) < a) minBase++;
        return minBase;
    }

    private static int FindMaxBase(int b, int n)
    {
        int maxBase = (int)Math.Floor(Math.Pow(b, 1.0 / n));
        while (Math.Pow(maxBase, n) > b) maxBase--;
        return maxBase;
    }

    private static bool IsPowerInRange(int x, int n, int a, int b)
    {
        double power = Math.Pow(x, n);
        return power >= a && power <= b;
    }

    private static void DisplayResults(int a, int b, int n, PowerIntervalResult result)
    {
        Console.WriteLine($"\n Results: [{a}, {b}] with power {n}");
        if (result.Count == 0)
        {
            Console.WriteLine("No numbers found in the interval.\n");
            return;
        }

        Console.WriteLine($"Count: {result.Count} number(s)\n");
        Console.WriteLine("Valid bases:");
        
        foreach (var base_ in result.ValidBases)
        {
            var power = Math.Pow(base_, n);
            Console.WriteLine($" • {base_}^{n} = {power:F0}");
        }
        
        Console.WriteLine();
    }

    private record PowerIntervalResult
    {
        public int Count { get; init; }
        public List<int> ValidBases { get; init; } = new();
        public int MinBase { get; init; }
        public int MaxBase { get; init; }
    }

    private static void PauseBeforeExit()
    {
        try
        {
            Console.WriteLine("Press any key to exit...");
            if (Console.IsInputRedirected)
            {
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.ReadKey(true);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"An error occurred while waiting for key press: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Exiting application...");
        }
    }
}

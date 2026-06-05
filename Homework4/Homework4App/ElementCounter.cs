using System;
using System.Linq;

namespace Homework4App;

public static class ElementCounter
{
    public static void Run()
    {
        Console.WriteLine("=== Task 3: Element Counter ===");
        
        int n = InputHelper.GetIntInput("Enter the size of the array (n): ");
        int[] numbers = InputHelper.GetIntArrayInput(n, $"Enter {n} integers separated by spaces: ");
        
        var elementStats = CountElements(numbers);
        
        PrintElementStats(elementStats);
    }

    private static (int Number, int Count, int Sum)[] CountElements(int[] numbers)
    {
        return numbers
            .GroupBy(n => n)
            .Select(g => (
                Number: g.Key,
                Count: g.Count(),
                Sum: g.Sum()
            ))
            .OrderBy(x => x.Number)
            .ToArray();
    }

    private static void PrintElementStats((int Number, int Count, int Sum)[] stats)
    {
        Console.WriteLine();
        foreach (var stat in stats)
        {
            Console.WriteLine($"{stat.Number} appears {stat.Count} times sum {stat.Sum}");
        }
    }
}

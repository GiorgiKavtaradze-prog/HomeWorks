using System;
using System.Linq;

namespace Homework4App;

public static class TopNSelector
{
    public static void Run()
    {
        Console.WriteLine(" === Task 4: Top N Largest Numbers === ");
        
        int n = InputHelper.GetIntInput("Enter the size of the array (n): ");
        int[] numbers = InputHelper.GetIntArrayInput(n, $"Enter {n} integers separated by spaces: ");
        int topN = InputHelper.GetIntInput("Enter how many top numbers to show: ");
        
        int[] topNumbers = GetTopNLargest(numbers, topN);
        
        PrintArray($"Top {topN} Numbers", topNumbers);
    }

    private static int[] GetTopNLargest(int[] numbers, int topN)
    {
        return numbers
            .OrderByDescending(x => x)
            .Take(topN)
            .OrderBy(x => x)
            .ToArray();
    }

    private static void PrintArray(string label, int[] array)
    {
        Console.WriteLine($"{label}: {string.Join(" ", array)}");
    }
}

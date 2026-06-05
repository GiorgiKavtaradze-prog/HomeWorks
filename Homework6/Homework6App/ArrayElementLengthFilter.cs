
using System;
using System.Linq;

namespace Homework5App;

public static class ArrayElementLengthFilter
{
    public static void Run()
    {
        Console.WriteLine("=== Task 6: Filter Array Elements by Length ===");
        int n = InputHelper.GetIntInput("Enter N (length to filter by): ");
        
        Console.Write("Enter the array elements (space-separated): ");
        string? input = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No elements to process.");
            Console.WriteLine();
            return;
        }

        string[] elements = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var filtered = elements.Where(e => e.Length == n).ToArray();

        if (filtered.Length > 0)
        {
            Console.WriteLine("Elements with length {0}: {1}", n, string.Join(" ", filtered));
        }
        else
        {
            Console.WriteLine("No elements found with length {0}.", n);
        }
        Console.WriteLine();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5App;

public static class JackpotChecker
{
    public static void Run()
    {
        Console.WriteLine("=== Task 2: Check Jackpot ===");
        Console.Write("Enter the list (space-separated, e.g., \"@ @ @ @ @ @\"): ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No");
            Console.WriteLine();
            return;
        }

        List<string> items = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        bool isJackpot = IsJackpot(items);
        Console.WriteLine(isJackpot ? "Yes" : "No");
        Console.WriteLine();
    }

    public static bool IsJackpot(List<string> items)
    {
        if (items == null || items.Count == 0)
            return false;

        string first = items[0];
        return items.All(item => item == first);
    }
}

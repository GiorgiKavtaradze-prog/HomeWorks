
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework5App;

public static class FootballPointsCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== Task 3: Calculate Football Team Points ===");
        Console.Write("Enter results (space-separated, e.g., \"win win draw loss\"): ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine(0);
            Console.WriteLine();
            return;
        }

        List<string> results = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        int totalPoints = CalculatePoints(results);
        Console.WriteLine(totalPoints);
        Console.WriteLine();
    }

    public static int CalculatePoints(List<string> results)
    {
        if (results == null || results.Count == 0)
            return 0;

        int points = 0;
        foreach (string result in results)
        {
            switch (result.ToLower())
            {
                case "win":
                    points += 3;
                    break;
                case "draw":
                    points += 1;
                    break;
                case "loss":
                    points += 0;
                    break;
            }
        }
        return points;
    }
}

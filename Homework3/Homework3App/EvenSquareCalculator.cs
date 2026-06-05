using System;
using System.Collections.Generic;

namespace Homework3App;

public static class EvenSquareCalculator
{
    private const string HeaderText = "=== Even Numbers Square Tool ===";

    public static void Run()
    {
        Console.WriteLine($"\n{HeaderText}");

        var n = InputHelper.GetIntInput("Enter n: ");

        var results = GetEvenSquares(n);

        DisplayResults(results);
    }

    /// <summary>
    /// Finds all even numbers from 1 up to n (exclusive) and calculates their squares.
    /// Following the example: Input 10 -> Output 4, 16, 36, 64 (2^2, 4^2, 6^2, 8^2)
    /// </summary>
    private static List<int> GetEvenSquares(int n)
    {
        var squares = new List<int>();

        for (var i = 1; i < n; i++)
        {
            if (i % 2 == 0)
            {
                squares.Add(i * i);
            }
        }

        return squares;
    }

    private static void DisplayResults(List<int> squares)
    {
        Console.WriteLine("\nOutput:");
        foreach (var square in squares)
        {
            Console.WriteLine(square);
        }
    }
}

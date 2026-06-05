using System;
using System.Collections.Generic;

namespace Homework3App;

public static class MultiplicationTable
{
    private const string HeaderText = "=== Multiplication Table Tool ===";
    private const int TableLimit = 9;

    public static void Run()
    {
        Console.WriteLine($"\n{HeaderText}");

        var number = InputHelper.GetIntInput("Enter a number: ");

        var tableData = GenerateTable(number);

        DisplayTable(number, tableData);
    }

    private static List<MultiplicationEntry> GenerateTable(int number)
    {
        var entries = new List<MultiplicationEntry>();

        for (var i = 1; i <= TableLimit; i++)
        {
            entries.Add(new MultiplicationEntry
            {
                Multiplier = i,
                Result = number * i
            });
        }

        return entries;
    }

    private static void DisplayTable(int number, List<MultiplicationEntry> entries)
    {
        Console.WriteLine();
        foreach (var entry in entries)
        {
            Console.WriteLine($"{number} * {entry.Multiplier} = {entry.Result}");
        }
    }

    private struct MultiplicationEntry
    {
        public int Multiplier { get; init; }
        public int Result { get; init; }
    }
}

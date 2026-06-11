using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework8App;

public static class InputHelper
{
    public static int GetInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;
            Console.WriteLine("Please enter a valid integer.");
        }
    }

    public static long GetLong(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (long.TryParse(Console.ReadLine(), out long value))
                return value;
            Console.WriteLine("Please enter a valid number.");
        }
    }

    public static List<int> GetIntList(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) continue;
            
            var numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(part => int.TryParse(part, out int num) ? (int?)num : null)
                .OfType<int>()
                .ToList();

            if (numbers.Count > 0)
                return numbers;
            Console.WriteLine("Please enter valid integers separated by spaces.");
        }
    }

    public static string GetString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                return input;
            Console.WriteLine("Please enter a non-empty string.");
        }
    }

    public static string GetMultiline(string prompt, string endMarker = "END")
    {
        Console.WriteLine(prompt);
        List<string> lines = new();
        string? line;
        while ((line = Console.ReadLine()) != endMarker)
        {
            if (line != null)
                lines.Add(line);
        }
        return string.Join(Environment.NewLine, lines);
    }
}

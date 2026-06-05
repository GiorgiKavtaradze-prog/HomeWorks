using System;
using System.Linq;

namespace Homework6App;

public static class InputHelper
{
    public static int GetIntInput(string message)
    {
        foreach (var _ in Enumerable.Range(0, int.MaxValue))
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out var result))
            {
                return result;
            }
            Console.WriteLine("Invalid format. Please enter an integer.");
        }
        return default;
    }

    public static int[] GetIntArrayInput(int count, string message)
    {
        foreach (var _ in Enumerable.Range(0, int.MaxValue))
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            if (input != null)
            {
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == count)
                {
                    int[] result = new int[count];
                    bool allValid = true;
                    for (int i = 0; i < count; i++)
                    {
                        if (!int.TryParse(parts[i], out result[i]))
                        {
                            allValid = false;
                            break;
                        }
                    }
                    if (allValid)
                    {
                        return result;
                    }
                    Console.WriteLine("Invalid input. Please enter valid integers.");
                }
                else
                {
                    Console.WriteLine($"Please enter exactly {count} numbers.");
                }
            }
        }
        return Array.Empty<int>();
    }

    public static string GetStringInput(string message)
    {
        while (true)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            Console.WriteLine("Invalid input. Please enter a non-empty string.");
        }
    }
}

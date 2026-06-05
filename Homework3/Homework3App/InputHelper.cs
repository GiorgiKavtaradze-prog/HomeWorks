using System;
using System.Linq;

namespace Homework3App;

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

    public static double GetDoubleInput(string message)
    {
        foreach (var _ in Enumerable.Range(0, int.MaxValue))
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            Console.WriteLine("Invalid format. Please enter a numeric value.");
        }
        return default;
    }
}

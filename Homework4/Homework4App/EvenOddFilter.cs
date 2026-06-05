using System;
using System.Collections.Generic;

namespace Homework4App;

public static class EvenOddFilter
{
    public static void Run()
    {
        Console.WriteLine("=== Task 1: Even and Odd Number Filter ===");
        
        int n = InputHelper.GetIntInput("Enter the size of the array (n): ");
        int[] numbers = InputHelper.GetIntArrayInput(n, $"Enter {n} integers separated by spaces: ");
        
        var (evens, odds) = FilterEvenOdd(numbers);
        
        PrintArray("Even Numbers ", evens);
        PrintArray("Odd Numbers ", odds);
    }

    private static (int[] EvenNumbers, int[] OddNumbers) FilterEvenOdd(int[] numbers)
    {
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();

        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evens.Add(number);
            }
            else
            {
                odds.Add(number);
            }
        }

        return (evens.ToArray(), odds.ToArray());
    }

    private static void PrintArray(string label, int[] array)
    {
        Console.WriteLine($"{label}: {string.Join(" ", array)}");
    }
}

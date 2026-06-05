using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6App;

public static class GenericListProcessor
{
    public static void ProcessList<T>(List<T> list)
    {
        if (list == null)
        {
            Console.WriteLine("List cannot be null.");
            return;
        }

        if (list.Count == 0)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (typeof(T) == typeof(string))
        {
            ProcessStringList(list.Cast<string>().ToList());
        }
        else if (typeof(T) == typeof(int))
        {
            ProcessIntList(list.Cast<int>().ToList());
        }
        else if (typeof(T) == typeof(bool))
        {
            ProcessBoolList(list.Cast<bool>().ToList());
        }
        else
        {
            Console.WriteLine($"Unsupported list type: {typeof(T)}");
        }
    }

    private static void ProcessStringList(List<string> list)
    {
        list.Select(s => s.ToUpperInvariant())
            .ToList()
            .ForEach(Console.WriteLine);
    }

    private static void ProcessIntList(List<int> list)
    {
        Console.WriteLine(list.Sum());
    }

    private static void ProcessBoolList(List<bool> list)
    {
        Console.WriteLine($"first Element is {list.First()}");
        Console.WriteLine($"Last Element is {list.Last()}");
        int middleIndex = list.Count / 2;
        Console.WriteLine($"Middle Element is {list[middleIndex]}");
    }

    private static List<string> ParseStringList(string input)
    {
        return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
    }

    private static List<int> ParseIntList(string input)
    {
        return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(part => int.TryParse(part, out int num) ? (IsValid: true, Value: num) : (IsValid: false, Value: 0))
                    .Where(x => x.IsValid)
                    .Select(x => x.Value)
                    .ToList();
    }

    private static List<bool> ParseBoolList(string input)
    {
        return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(part => bool.TryParse(part, out bool value) ? (IsValid: true, Value: value) : (IsValid: false, Value: false))
                    .Where(x => x.IsValid)
                    .Select(x => x.Value)
                    .ToList();
    }

    public static void Run()
    {
        Console.WriteLine("=== Task 4: Generic List Processor ===\n");
        
        while (true)
        {
            Console.WriteLine("Choose list type:");
            Console.WriteLine("1 - String list");
            Console.WriteLine("2 - Int list");
            Console.WriteLine("3 - Bool list");
            Console.WriteLine("Type 'exit' to quit");
            
            string choice = InputHelper.GetStringInput("Enter choice: ");

            if (choice.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            switch (choice)
            {
                case "1":
                    string stringInput = InputHelper.GetStringInput("Enter strings separated by space: ");
                    List<string> stringList = ParseStringList(stringInput);
                    ProcessList(stringList);
                    break;

                case "2":
                    string intInput = InputHelper.GetStringInput("Enter integers separated by space: ");
                    List<int> intList = ParseIntList(intInput);
                    ProcessList(intList);
                    break;

                case "3":
                    string boolInput = InputHelper.GetStringInput("Enter booleans (true/false) separated by space: ");
                    List<bool> boolList = ParseBoolList(boolInput);
                    ProcessList(boolList);
                    break;

                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
            
            Console.WriteLine();
        }
    }
}

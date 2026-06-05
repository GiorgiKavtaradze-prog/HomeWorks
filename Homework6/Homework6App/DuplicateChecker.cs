using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework6App;

public static class DuplicateChecker
{
    public static bool ContainsDuplicate(int[] nums)
    {
        if (nums == null || nums.Length <= 1)
            return false;
        
        return nums.Distinct().Count() != nums.Length;
    }

    public static void Run()
    {
        Console.WriteLine("=== Task 6: Duplicate Checker ===\n");
        while (true)
        {
            string input = InputHelper.GetStringInput("Enter numbers separated by space (or type 'exit' to quit): ");
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            int[] nums = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(part => int.TryParse(part, out int num) ? (IsValid: true, Value: num) : (IsValid: false, Value: 0))
                              .Where(x => x.IsValid)
                              .Select(x => x.Value)
                              .ToArray();

            bool hasDuplicates = ContainsDuplicate(nums);
            Console.WriteLine(hasDuplicates.ToString().ToLowerInvariant());
            Console.WriteLine();
        }
    }
}

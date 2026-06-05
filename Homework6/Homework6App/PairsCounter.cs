using System;
using System.Linq;

namespace Homework6App;

public static class PairsCounter
{
    public static int CountPairs(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        return input
            .GroupBy(c => c)
            .Sum(g => g.Count() / 2);
    }

    public static void Run()
    {
        Console.WriteLine("=== Task 2: Letter Pairs Counter ===\n");
        while (true)
        {
            string userInput = InputHelper.GetStringInput("Enter a string of letters: ");

            if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            int pairCount = CountPairs(userInput.ToUpper());
            Console.WriteLine($"Number of letter pairs in '{userInput}': {pairCount}\n");
        }
    }
}

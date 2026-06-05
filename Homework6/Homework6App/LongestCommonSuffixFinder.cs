using System;
using System.Linq;

namespace Homework6App;

public static class LongestCommonSuffixFinder
{
    public static string FindLongestCommonSuffix(string s1, string s2)
    {
        if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            return string.Empty;

        int maxPossibleLength = Math.Min(s1.Length, s2.Length);

        int longestMatchLength = Enumerable.Range(0, maxPossibleLength + 1)
            .Reverse()
            .First(length =>
            {
                if (length == 0)
                    return true;
                return s1.Substring(s1.Length - length) == s2.Substring(s2.Length - length);
            });

        return longestMatchLength == 0 ? string.Empty : s1.Substring(s1.Length - longestMatchLength);
    }

    public static void Run()
    {
        Console.WriteLine("=== Task 3: Longest Common Suffix Finder ===\n");
        while (true)
        {
            string s1 = InputHelper.GetStringInput("Enter first string: ");
            
            if (s1.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            string s2 = InputHelper.GetStringInput("Enter second string: ");

            string result = FindLongestCommonSuffix(s1, s2);
            Console.WriteLine($"Longest common suffix: '{result}'\n");
        }
    }
}

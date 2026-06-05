using System;

namespace Homework5App;

public static class MarathonProgressCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== Task 5: Marathon Progress ===");
        int count = InputHelper.GetIntInput("Enter the number of days: ");
        int[] scores = InputHelper.GetIntArrayInput(count, "Enter scores separated by space: ");
        int progressDays = CalculateProgressDays(scores);
        Console.WriteLine(progressDays);
        Console.WriteLine();
    }

    public static int CalculateProgressDays(int[] scores)
    {
        if (scores.Length < 2)
        {
            return 0;
        }

        int progressCount = 0;
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > scores[i - 1])
            {
                progressCount++;
            }
        }
        return progressCount;
    }
}

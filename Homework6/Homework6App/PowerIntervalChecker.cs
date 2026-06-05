using System;
using System.Linq;

namespace Homework6App;

public static class PowerIntervalChecker
{
    public static int CountPowersInRange(int a, int b, int n)
    {
        if (n < 1 || a > b)
            return 0;

        return Enumerable.Range(1, int.MaxValue)
            .Select(baseNum =>
            {
                long power = 1;
                for (int i = 0; i < n; i++)
                {
                    power *= baseNum;
                    if (power > b)
                        return (power: power, isValid: false);
                }
                return (power: power, isValid: true);
            })
            .TakeWhile(result => result.isValid || result.power <= b)
            .Where(result => result.isValid && result.power >= a && result.power <= b)
            .Count();
    }

    public static void Run()
    {
        int a = InputHelper.GetIntInput("Enter a: ");
        int b = InputHelper.GetIntInput("Enter b: ");
        int n = InputHelper.GetIntInput("Enter n: ");
        int result = CountPowersInRange(a, b, n);
        Console.WriteLine(result);
    }
}
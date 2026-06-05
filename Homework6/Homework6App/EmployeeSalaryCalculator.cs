
using System;

namespace Homework5App;

public static class EmployeeSalaryCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== Task 4: Calculate Employee Weekly Salary ===");
        int[] hours = InputHelper.GetIntArrayInput(7, "Enter hours worked for 7 days (space-separated, e.g., \"8 8 8 8 8 0 0\"): ");
        int totalSalary = CalculateSalary(hours);
        Console.WriteLine(totalSalary);
        Console.WriteLine();
    }

    public static int CalculateSalary(int[] hoursWorked)
    {
        if (hoursWorked == null || hoursWorked.Length != 7)
            return 0;

        int total = 0;
        const int regularHourlyRate = 10;
        const int overtimeExtraRate = 5;
        const int weekendMultiplier = 2;
        const int regularDailyHours = 8;

        for (int day = 0; day < 7; day++)
        {
            int hours = hoursWorked[day];
            if (hours <= 0)
                continue;

            bool isWeekend = day >= 5;

            if (isWeekend)
            {
                total += hours * regularHourlyRate * weekendMultiplier;
            }
            else
            {
                if (hours <= regularDailyHours)
                {
                    total += hours * regularHourlyRate;
                }
                else
                {
                    total += regularDailyHours * regularHourlyRate;
                    total += (hours - regularDailyHours) * (regularHourlyRate + overtimeExtraRate);
                }
            }
        }

        return total;
    }
}

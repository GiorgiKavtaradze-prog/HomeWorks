using System.Linq;

namespace Homework7App;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public int[] WeeklyHours { get; set; }

    public Employee(string firstName, string lastName, int age, string position, int[] weeklyHours)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Position = position;
        WeeklyHours = weeklyHours;
    }

    public decimal CalculateWeeklySalary()
    {
        decimal baseRate = GetBaseRate();

        int totalHours = WeeklyHours.Sum();

        decimal totalSalary = WeeklyHours
            .Select((hours, day) => CalculateDaySalary(hours, day, baseRate))
            .Sum();

        if (totalHours > 50)
            totalSalary *= 1.2m;

        return totalSalary;
    }

    private decimal CalculateDaySalary(int hours, int day, decimal baseRate)
    {
        if (hours == 0)
            return 0;

        bool isWeekend = day >= 5;
        int regularHours = Math.Min(hours, 8);
        int overtimeHours = Math.Max(hours - 8, 0);

        decimal dayRate = baseRate;
        if (isWeekend)
            dayRate *= 2;

        decimal overtimeRate = dayRate + 5;

        return regularHours * dayRate + overtimeHours * overtimeRate;
    }

    private decimal GetBaseRate()
    {
        return Position.ToLower() switch
        {
            "manager" => 40m,
            "developer" => 30m,
            "tester" => 20m,
            _ => 10m
        };
    }
}

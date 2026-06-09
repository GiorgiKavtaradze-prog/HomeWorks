namespace Homework7App;

public static class SalaryCalculator
{
    public static void Run()
    {
        Console.WriteLine("=== Company and Employee Salary Calculator ===");
        Console.WriteLine();

        Console.Write("Is the company local? (yes/no): ");
        string? isLocalInput = Console.ReadLine();
        bool isLocal = isLocalInput?.ToLower() == "yes";
        Company company = new Company(isLocal);

        Console.WriteLine();
        Console.WriteLine("=== Employee Information ===");
        string firstName = InputHelper.GetStringInput("Enter first name: ");
        string lastName = InputHelper.GetStringInput("Enter last name: ");
        int age = InputHelper.GetIntInput("Enter age: ");
        string position = InputHelper.GetStringInput("Enter position (manager/developer/tester/other): ");
        int[] weeklyHours = InputHelper.GetIntArrayInput(7, "Enter weekly hours (7 numbers separated by spaces, Mon-Sun): ");

        Employee employee = new Employee(firstName, lastName, age, position, weeklyHours);

        Console.WriteLine();
        Console.WriteLine("=== Calculation Results ===");
        decimal weeklySalary = employee.CalculateWeeklySalary();
        Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
        Console.WriteLine($"Weekly Salary: ${weeklySalary:F2}");

        decimal tax = company.CalculateTax(weeklySalary);
        Console.WriteLine($"Tax to pay: ${tax:F2}");
    }
}

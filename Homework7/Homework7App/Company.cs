namespace Homework7App;

public class Company
{
    public bool IsLocal { get; set; }

    public Company(bool isLocal)
    {
        IsLocal = isLocal;
    }

    public decimal CalculateTax(decimal totalSalary)
    {
        return IsLocal ? totalSalary * 0.18m : totalSalary * 0.05m;
    }
}

namespace Homework_9;

public class Company(bool isNative)
{
    private bool IsNative { get; } = isNative;

    protected void CalculateTax(string occupation, int hourlyRate, int salary)
    {
        var tax = IsNative ? salary * 0.18 : salary * 0.05;
        var netSalary = salary - tax;
        
        Console.WriteLine($"Occupation: {occupation}, Hourly Rate: {hourlyRate}, Gross Salary: {salary}, Tax: {tax}, Net Salary: {netSalary}");
    }
}
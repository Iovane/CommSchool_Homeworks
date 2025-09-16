namespace Homework_9;

public class Employee(string name, string lastName, int age, string occupation, List<int> hoursWorked, bool isNative)
    : Company(isNative)
{
    public string Name { get; } = name;
    public string LastName { get; } = lastName;
    public int Age { get; } = age;
    public string Occupation { get; } = occupation;
    public List<int> HoursWorked { get; } = hoursWorked;

    private readonly Dictionary<string, int> _hourlyRates = new()
    {
        { "Manager", 40 },
        { "Developer", 30 },
        { "Tester", 20 },
        { "Other", 10 }
    };
    private const int OvertimeHourlyRate = 5;
    private const int WeekendMultiplier = 2;
    private const int StandardWorkHours = 8;

    public void CalculateSalary()
    {
        var salaryInWeek = 0;

        for (var i = 0; i < HoursWorked.Count; i++)
        {
            var hoursForDay = HoursWorked[i];
            var isWeekend = i >= 5;

            salaryInWeek += CalculateDailySalary(hoursForDay, Occupation, isWeekend);
        }

        CalculateTax(Occupation, GetHourlyRate(Occupation), salaryInWeek);
    }

    private int CalculateDailySalary(int hours, string occupation, bool isWeekend)
    {
        var hourlyRate = GetHourlyRate(occupation);
        
        if (isWeekend)
        {
            return hours * hourlyRate * WeekendMultiplier;
        }

        if (hours <= StandardWorkHours)
        {
            return hours * hourlyRate;
        }

        return (StandardWorkHours * hourlyRate) +
               ((hours - StandardWorkHours) * OvertimeHourlyRate);
    }
    
    private int GetHourlyRate(string occupation)
    {
        int hourlyRate;
        try
        {
            hourlyRate = _hourlyRates[occupation];
        }
        catch (KeyNotFoundException ignored)
        {
            hourlyRate = _hourlyRates["Other"];
        }

        return hourlyRate;
    }
}
namespace Homework_9.Task_2;

public class Student(string name, int age, int yearOfEnrollment)
{
    private string Name { get; } = name;
    private int Age { get; } = age;
    private int YearOfEnrollment { get; } = yearOfEnrollment;

    public Subjects GetSubject()
    {
        var values = Enum.GetValues<Subjects>();
        Random random = new();
        var randomIndex = random.Next(values.Length);
        
        return values[randomIndex];

    }
    
    public int YearsLeft()
    {
        var yearsLeft = YearOfEnrollment + 4 - DateTime.Now.Year;
        return yearsLeft > 0 ? yearsLeft : 0;
    }
}
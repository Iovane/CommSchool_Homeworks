using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class ModernChair : Chair
{
    public override int Legs { get; set; } = 1;
    public override void HasLegs()
    {
        Console.WriteLine($"Modern Chair has {Legs} legs");
    }

    public override void SitOn()
    {
        Console.WriteLine("Modern Chair can be used to sit on");   
    }
}
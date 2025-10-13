using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class VictorianChair : Chair
{
    public override int Legs { get; set; } = 4;
    public override void HasLegs()
    {
        Console.WriteLine($"Victorian Chair has {Legs} legs");   
    }

    public override void SitOn()
    {
        Console.WriteLine("Victorian Chair can be used to sit on");
    }
}
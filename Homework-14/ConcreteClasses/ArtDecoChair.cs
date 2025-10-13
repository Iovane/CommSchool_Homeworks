using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class ArtDecoChair : Chair
{
    public override int Legs { get; set; } = 4;
    public override void HasLegs()
    {
        Console.WriteLine($"Art Deco Chair has {Legs} legs");
    }

    public override void SitOn()
    {
        Console.WriteLine("Art Deco Chair can be used to sit on");
    }
}
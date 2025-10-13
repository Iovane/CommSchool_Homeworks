using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class VictorianSofa : Sofa
{
    public override int Legs { get; set; } = 4;
    public override void HasLegs()
    {
        Console.WriteLine($"Victorian Sofa has {Legs} legs");  
    }
}
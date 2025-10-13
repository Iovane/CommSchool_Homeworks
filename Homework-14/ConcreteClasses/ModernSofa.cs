using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class ModernSofa : Sofa
{
    public override int Legs { get; set; } = 1;
    public override void HasLegs()
    {
        Console.WriteLine($"Modern Sofa has {Legs} legs");
    }
}
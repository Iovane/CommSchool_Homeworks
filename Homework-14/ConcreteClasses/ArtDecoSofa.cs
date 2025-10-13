using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class ArtDecoSofa : Sofa
{
    public override int Legs { get; set; } = 4;

    public override void HasLegs()
    {
        Console.WriteLine($"Art Deco Sofa has {Legs} legs");
    }
}
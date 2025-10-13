using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class ArtDecoCoffeeTable : CoffeeTable
{
    public override int Legs { get; set; } = 1;
    public override void HasLegs()
    {
        Console.WriteLine($"Art Deco Coffee Table has {Legs} legs");
    }
}
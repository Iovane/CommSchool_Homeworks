using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class ModernCoffeeTable : CoffeeTable
{
    public override int Legs { get; set; } = 4;
    public override void HasLegs()
    {
        Console.WriteLine($"Modern Coffee Table {Legs} legs");
    }
}
using Homework_14.AbstractClasses;

namespace Homework_14.ConcreteClasses;

public class VictorianCoffeeTable : CoffeeTable
{
    public override int Legs { get; set; } = 4;
    public override void HasLegs()
    {
        Console.WriteLine($"Victorian Coffee Table {Legs} legs");   
    }
}
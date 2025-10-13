using Homework_14.AbstractClasses;
using Homework_14.ConcreteClasses;

namespace Homework_14.Factories;

public class ModernFurnitureFactory : FurnitureFactory
{
    public override Chair CreateChair()
    {
        return new ModernChair();
    }

    public override Sofa CreatSofa()
    {
        return new ModernSofa();
    }

    public override CoffeeTable CreateCoffeeTable()
    {
        return new ModernCoffeeTable();
    }
}
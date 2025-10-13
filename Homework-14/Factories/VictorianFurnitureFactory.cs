using Homework_14.AbstractClasses;
using Homework_14.ConcreteClasses;

namespace Homework_14.Factories;

public class VictorianFurnitureFactory : FurnitureFactory
{
    public override Chair CreateChair()
    {
        return new VictorianChair();
    }

    public override Sofa CreatSofa()
    {
        return new VictorianSofa();
    }

    public override CoffeeTable CreateCoffeeTable()
    {
        return new VictorianCoffeeTable();
    }
}
using Homework_14.AbstractClasses;
using Homework_14.ConcreteClasses;

namespace Homework_14.Factories;

public class ArtDecoFurnitureFactory : FurnitureFactory
{
    public override Chair CreateChair()
    {
        return new ArtDecoChair();
    }

    public override Sofa CreatSofa()
    {
        return new ArtDecoSofa();
    }

    public override CoffeeTable CreateCoffeeTable()
    {
        return new ArtDecoCoffeeTable();
    }
}
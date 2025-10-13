using Homework_14.AbstractClasses;
using Homework_14.Factories;
using Homework_14.Task_2;

namespace Homework_14;

class Program
{
    static void Main(string[] args)
    {
        #region Task 1

        FurnitureFactory victorianFactory = new VictorianFurnitureFactory();
        FurnitureFactory modernFactory = new ModernFurnitureFactory();
        FurnitureFactory artDecoFactory = new ArtDecoFurnitureFactory();

        var victorianChair = victorianFactory.CreateChair();
        var modernChair = modernFactory.CreateChair();
        var artDecoChair = artDecoFactory.CreateChair();

        var victorianSofa = victorianFactory.CreatSofa();
        var modernSofa = modernFactory.CreatSofa();
        var artDecoSofa = artDecoFactory.CreatSofa();

        var victorianCoffeeTable = victorianFactory.CreateCoffeeTable();
        var modernCoffeeTable = modernFactory.CreateCoffeeTable();
        var artDecoCoffeeTable = artDecoFactory.CreateCoffeeTable();

        victorianChair.HasLegs();
        victorianChair.SitOn();
        modernChair.HasLegs();
        modernChair.SitOn();
        artDecoChair.HasLegs();
        artDecoChair.SitOn();

        victorianSofa.HasLegs();
        modernSofa.HasLegs();
        artDecoSofa.HasLegs();

        victorianCoffeeTable.HasLegs();
        modernCoffeeTable.HasLegs();
        artDecoCoffeeTable.HasLegs();

        #endregion
        
        #region Task 2

        Actor actor = new StuntDouble();
        
        actor.Responsibility();
        actor.Responsibility();
        actor.Responsibility();
        actor.Responsibility();
        actor.Responsibility();
        
        #endregion
    }
}
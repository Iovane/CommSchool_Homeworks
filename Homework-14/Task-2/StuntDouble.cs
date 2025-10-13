namespace Homework_14.Task_2;

public class StuntDouble : Actor
{
    private MainActor _realActor;
    public override void Responsibility()
    {
        if (_realActor == null) _realActor = new MainActor();
        
        if (Random.Shared.Next(2) == 1) _realActor.Responsibility();
        else Console.WriteLine("My responsibility is to be in simple and dangerous scenes");
    }
}
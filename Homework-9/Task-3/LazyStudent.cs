namespace Homework_9.Task_3;

public class LazyStudent(string name) : Student(name)
{
    
    public override void Study()
    {
        Console.WriteLine("Lazy Student is not studying");
    }
    
    public override void Read()
    {
        Console.WriteLine("Lazy Student is not reading");
    }
    
    public override void Write()
    {
        Console.WriteLine("Lazy Student is not writing");
    }
    
    public override void Relax()
    {
        Console.WriteLine("Lazy Student is relaxing");
    }
}
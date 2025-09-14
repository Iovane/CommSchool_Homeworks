namespace Homework_9.Task_3;

public class GoodStudent(string name) : Student(name)
{
    public override void Study()
    {
        Console.WriteLine("Good Student is studying");
    }

    public override void Read()
    {
        Console.WriteLine("Good Student is reading");
    }

    public override void Write()
    {
        Console.WriteLine("Good Student is writing");
    }

    public override void Relax()
    {
        Console.WriteLine("Good Student is relaxing");
    }
}
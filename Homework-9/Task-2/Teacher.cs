namespace Homework_9.Task_2;

public class Teacher(string name, bool isCertified)
{
    public string Name { get; } = name;
    public bool IsCertified { get; } = isCertified;
    
    public void Teach(Subjects subject)
    {
        switch (subject)
        {
            case Subjects.Math:
            {
                var random = new Random();
                Console.WriteLine(random.NextInt64() + random.NextInt64());
                break;
            }
            case Subjects.English:
                Console.WriteLine("Hello, as you can see I can speak English");
                break;
            case Subjects.Chemistry:
                Console.WriteLine("H₂O");
                break;
            default:
                Console.WriteLine("I'm not competent in this subject");
                break;
        }
    }
}
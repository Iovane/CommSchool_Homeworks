namespace Homework_9.Task_3;

public class Classroom(params Student[] students)
{
    public Student[] Students { get; } = students;
    
    public void WhatsHappening()
    {
        var students = Students.ToList();
        students.ForEach(x =>
        {
            x.Study();
            x.Read();
            x.Write();
            x.Relax();
        });
    }
}
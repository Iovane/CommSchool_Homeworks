namespace Homework_9.Task_3;

public class Classroom(params Student[] students)
{
    private Student[] Students { get; } = students;
    
    public void WhatsHappening()
    {
        var students = Students.ToList();
        students.ForEach(x => x.Study());
        students.ForEach(x => x.Read());
        students.ForEach(x => x.Write());
        students.ForEach(x => x.Relax());
    }
}
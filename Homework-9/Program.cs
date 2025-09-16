using Homework_9.Task_2;
using Homework_9.Task_3;
using Student = Homework_9.Task_2.Student;

namespace Homework_9;

class Program
{
    static void Main()
    {
        #region Task 1

        var employee = new Employee("John", "Doe", 25, "Developer", [8, 8, 8, 8, 8, 8, 0], true);
        var employee1 = new Employee("Lika", "Doe", 23, "Manager", [8, 12, 8, 5, 8, 0, 0], false);
        var employee2 = new Employee("007", "Doe", 18, "Tester", [8, 8, 8, 8, 8, 8, 0], true);
        var employee3 = new Employee("Luka", "Doe", 70, "Other", [8, 8, 8, 8, 8, 8, 0], true);
        var employee4 = new Employee("Davit", "Doe", 43, "Magari Devops", [12, 8, 8, 12, 8, 8, 12], false);

        employee.CalculateSalary();
        employee1.CalculateSalary();
        employee2.CalculateSalary();
        employee3.CalculateSalary();
        employee4.CalculateSalary();

        #endregion

        #region Task 2

        var teacher = new Teacher("Giorgi", true);
        var student = new Student("John", 19, 2021);

        Console.WriteLine($"{student.YearsLeft()} year(s) left to graduate");
        teacher.Teach(student.GetSubject());

        #endregion

        #region Task 3

        var goodStudent = new GoodStudent("John");
        var lazyStudent = new LazyStudent("Jane");
        var classroom = new Classroom(goodStudent, lazyStudent);

        classroom.WhatsHappening();

        #endregion
    }
}
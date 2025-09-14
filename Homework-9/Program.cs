namespace Homework_9;

class Program
{
    static void Main(string[] args)
    {
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
    }
}
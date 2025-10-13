using System.Text.Json;
using System.Xml.Linq;

namespace Homework_11.Task_1;

public class CreateFile
{
    public static void CreateWithLines()
    {
        const string filePath = @"C:\Users\Kong\RiderProjects\CommSchool_Homeworks\Homework-11\Files\file.txt";

        Console.WriteLine("Enter number of lines: ");
        var n = int.Parse(Console.ReadLine()!);

        File.WriteAllText(filePath, "");

        for (var i = 0; i < n; i++)
        {
            Console.WriteLine($"line number {i + 1}:");
            var text = Console.ReadLine();
            File.AppendAllText(filePath, text + "\n");
        }

        var lines = File.ReadAllLines(filePath);
        Console.WriteLine(lines[n - 1]);
    }

    public static void CreateFileWithMultiplicationTable()
    {
        const string filePath =
            @"/Users/iovchikovani/RiderProjects/CommSchool_Homeworks/Homework-11/Files/multiplication.txt";
        Console.WriteLine("Enter The Number: ");
        var n = int.Parse(Console.ReadLine()!);

        File.WriteAllText(filePath, "");

        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= 9; j++)
            {
                var content = $"{i} * {j} = {i * j} \n";
                File.AppendAllText(filePath, content);
            }

            File.AppendAllText(filePath, "\n");
        }
    }

    public static void CreateXmlFile()
    {
        const string filePath = @"/Users/iovchikovani/RiderProjects/CommSchool_Homeworks/Homework-11/Files/output.xml";
        Console.Write("Enter string: ");
        var input = Console.ReadLine();

        Console.Write("Enter number of splits: ");
        var n = int.Parse(Console.ReadLine() ?? "1");

        var len = input!.Length;
        var partSize = len / n;
        var remainder = len % n;

        var parts = new string[n];
        var index = 0;

        for (var i = 0; i < n; i++)
        {
            var currentSize = partSize + (i < remainder ? 1 : 0);
            parts[i] = input.Substring(index, currentSize);
            index += currentSize;
        }

        var root = new XElement("Root");
        for (var i = 0; i < n; i++)
        {
            var node = new XElement(parts[i], $"string {i + 1}");
            root.Add(node);
        }

        root.Save(filePath);
    }

    public static void ReadFromJsonAndCalculateDaysTillBirthday()
    {
        const string filePath = @"/Users/iovchikovani/RiderProjects/CommSchool_Homeworks/Homework-11/Files/bday.json";
        var reader = new StreamReader(filePath);

        var json = reader.ReadToEnd();

        var dates = JsonSerializer.Deserialize<Dates>(json);

        var currentDate = DateTime.Parse(dates!.currentDate).DayOfYear;
        var birthday = DateTime.Parse(dates.birthday).DayOfYear;

        if (birthday < currentDate)
        {
            Console.WriteLine(birthday - currentDate + 365);
        }
        else
        {
            Console.WriteLine(birthday - currentDate);
        }
    }
}
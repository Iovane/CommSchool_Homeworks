namespace Classwork_11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of lines: ");
        var n = int.Parse(Console.ReadLine()!);

        const string file = "/Users/iovchikovani/RiderProjects/CommSchool_Homeworks/Classwork-11/Files/file.txt";
        File.WriteAllText(file, "");

        for (var i = 0; i < n; i++)
        {
            Console.WriteLine($"line number {i + 1}:");
            var text = Console.ReadLine();
            File.AppendAllText(file, text + "\n");
        }

        Console.WriteLine("Input line to read");
        var text1 = Console.ReadLine();
        var lines = File.ReadAllLines(file);
        Console.WriteLine(lines[int.Parse(text1) - 1]);
    }
}
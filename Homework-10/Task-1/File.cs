namespace Homework_10;

public class File(int fileSize, string fileType) : FileWorker(fileSize)
{
    protected override string FileType { get; } = fileType;

    public override void Read()
    {
        Console.WriteLine($"I can read to {FileType} file with max storage {FileSize}");
    }

    public override void Write()
    {
        Console.WriteLine($"I can write to {FileType} file with max storage {FileSize}");
    }

    public override void Edit()
    {
        Console.WriteLine($"I can edit to {FileType} file with max storage {FileSize}");
    }

    public override void Delete()
    {
        Console.WriteLine($"I can delete to {FileType} file with max storage {FileSize}");
    }
}
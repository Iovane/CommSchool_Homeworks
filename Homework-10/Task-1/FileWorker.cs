namespace Homework_10;

public abstract class FileWorker(int fileSize)
{
    public int FileSize { get; } = fileSize;
    protected abstract string FileType { get; }

    public virtual void Read()
    {
    }

    public virtual void Write()
    {
    }

    public virtual void Edit()
    {
    }

    public virtual void Delete()
    {
    }
}
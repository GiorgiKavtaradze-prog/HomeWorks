namespace Homework8App.FileWorker;

public abstract class FileWorker(long maxFileSize)
{
    protected long MaxFileSize { get; } = maxFileSize;

    public abstract string FileExtension { get; }

    public abstract string Read(string filePath);

    public abstract void Write(string filePath, string content);

    public abstract void Edit(string filePath, string newContent);

    public abstract void Delete(string filePath);

    protected bool ValidateFileSize(string filePath)
    {
        if (!File.Exists(filePath))
            return true;

        var fileInfo = new FileInfo(filePath);
        return fileInfo.Length <= MaxFileSize;
    }

    protected string EnsureFileExtension(string filePath)
    {
        return Path.HasExtension(filePath) && Path.GetExtension(filePath).Equals(FileExtension, StringComparison.OrdinalIgnoreCase)
            ? filePath
            : Path.ChangeExtension(filePath, FileExtension);
    }
}

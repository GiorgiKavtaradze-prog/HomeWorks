namespace Homework8App.FileWorker;

public class JsonFileWorker(long maxFileSize) : FileWorker(maxFileSize)
{
    public override string FileExtension => ".json";

    public override string Read(string filePath)
    {
        var safePath = EnsureFileExtension(filePath);

        if (!File.Exists(safePath))
            throw new FileNotFoundException("File not found.", safePath);

        if (!ValidateFileSize(safePath))
            throw new InvalidOperationException($"File exceeds maximum allowed size of {MaxFileSize} bytes.");

        return File.ReadAllText(safePath);
    }

    public override void Write(string filePath, string content)
    {
        var safePath = EnsureFileExtension(filePath);

        var contentBytes = System.Text.Encoding.UTF8.GetByteCount(content);
        if (contentBytes > MaxFileSize)
            throw new InvalidOperationException($"Content exceeds maximum allowed size of {MaxFileSize} bytes.");

        File.WriteAllText(safePath, content);
    }

    public override void Edit(string filePath, string newContent)
    {
        var safePath = EnsureFileExtension(filePath);

        if (!File.Exists(safePath))
            throw new FileNotFoundException("File not found.", safePath);

        var contentBytes = System.Text.Encoding.UTF8.GetByteCount(newContent);
        if (contentBytes > MaxFileSize)
            throw new InvalidOperationException($"Content exceeds maximum allowed size of {MaxFileSize} bytes.");

        File.WriteAllText(safePath, newContent);
    }

    public override void Delete(string filePath)
    {
        var safePath = EnsureFileExtension(filePath);

        if (!File.Exists(safePath))
            throw new FileNotFoundException("File not found.", safePath);

        File.Delete(safePath);
    }
}

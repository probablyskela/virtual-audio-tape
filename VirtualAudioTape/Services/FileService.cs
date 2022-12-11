using VirtualAudioTape.Exceptions;

namespace VirtualAudioTape.Services;

public static class FileService
{
    private static readonly string[] AllowedExtensions = { "wav" };

    public static (FileInfo, FileStream) LinkAudioFile(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("File at given path was not found.", path);
        }

        var fileInfo = new FileInfo(path);

        if (!AllowedExtensions.Contains(fileInfo.Extension))
        {
            throw new FileExtensionNotSupportedException(
                $"File extension {fileInfo.Extension} is currently not supported.");
        }

        var fileStream = fileInfo.OpenRead();

        return (fileInfo, fileStream);
    }
}
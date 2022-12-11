using VirtualAudioTape.Exceptions;

namespace VirtualAudioTape.Services;

/// <summary>
/// This class provides various methods for working with files.
/// </summary>
public static class FileService
{
    private static readonly string[] AllowedExtensions = { "wav" };

    /// <summary>
    /// Verifies file's existence and extension then creates <see cref="FileInfo"/> and <see cref="FileStream"/> objects.   
    /// </summary>
    /// <param name="path">Path to the audio file.</param>
    /// <returns></returns>
    /// <exception cref="FileNotFoundException">File is not found.</exception>
    /// <exception cref="FileExtensionNotSupportedException">File extension is not supported by the library.</exception>
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
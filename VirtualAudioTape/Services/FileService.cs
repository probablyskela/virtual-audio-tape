using VirtualAudioTape.AudioFiles;
using VirtualAudioTape.Exceptions;

namespace VirtualAudioTape.Services;

/// <summary>
/// This class provides various methods for working with files.
/// </summary>
public static class FileService
{
    /// <summary>
    /// Verifies file's existence and extension then creates <see cref="AudioFile"/> object.   
    /// </summary>
    /// <param name="path">Path to the audio file.</param>
    /// <returns><see cref="AudioFile"/> object</returns>
    /// <exception cref="FileNotFoundException">File is not found.</exception>
    /// <exception cref="FileExtensionNotSupportedException">File extension is not supported by the library.</exception>
    public static AudioFile LinkAudioFile(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("File at given path was not found.", path);
        }

        var fileInfo = new FileInfo(path);

        return fileInfo.Extension switch
        {
            _ => throw new FileExtensionNotSupportedException(
                $"File extension {fileInfo.Extension} is currently not supported.")
        };
    }
}
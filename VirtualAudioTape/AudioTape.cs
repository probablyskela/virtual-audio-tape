using VirtualAudioTape.Services;

namespace VirtualAudioTape;

/// <summary>
/// This class links with an audio file for further processing.
/// </summary>
public class AudioTape
{
    private FileInfo _fileInfo;
    private FileStream _fileStream;

    public AudioTape(string path)
    {
        (_fileInfo, _fileStream) = FileService.LinkAudioFile(path);
    }
}
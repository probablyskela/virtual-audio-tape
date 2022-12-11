using VirtualAudioTape.AudioFiles;
using VirtualAudioTape.Services;

namespace VirtualAudioTape;

/// <summary>
/// This class provides interface for working with different audio files extensions.
/// </summary>
public sealed class AudioTape : IDisposable
{
    private readonly AudioFile _audioFile;

    public AudioTape(string path)
    {
        _audioFile = FileService.LinkAudioFile(path);
    }

    public void Dispose()
    {
        _audioFile.Dispose();
    }
}
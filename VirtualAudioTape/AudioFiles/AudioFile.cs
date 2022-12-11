namespace VirtualAudioTape.AudioFiles;

/// <summary>
/// Base class for all audio files classes.
/// </summary>
public abstract class AudioFile : IDisposable
{
    private readonly FileInfo _fileInfo;
    private readonly FileStream _fileStream;

    protected AudioFile(FileInfo fileInfo, FileStream fileStream)
    {
        _fileInfo = fileInfo;
        _fileStream = fileStream;
    }

    /// <summary>
    /// Changes audio file's tempo by multiplier.
    /// </summary>
    /// <param name="multiplier">Multiplier by which audio file's tempo will be changed.</param>
    /// <param name="keepPitch">True to keep audio file's pitch, False otherwise.</param>
    /// <returns>True if method succeeded, False otherwise.</returns>
    public abstract bool ChangeTempoByMultiplier(double multiplier, bool keepPitch);

    /// <summary>
    /// Changes audio file's tempo to desired BPM.
    /// </summary>
    /// <param name="bpm">BPM to change audio file to</param>
    /// <param name="keepPitch">True to keep audio file's pitch, False otherwise.</param>
    /// <returns>True if method succeeded, False otherwise.</returns>
    public abstract bool ChangeTempoToBpm(double bpm, bool keepPitch);

    /// <summary>
    /// Trim the audio file.
    /// </summary>
    /// <param name="start">Starting offset.</param>
    /// <param name="end">End offset.</param>
    /// <returns>True if method succeeded, False otherwise.</returns>
    public abstract bool Trim(int start, int end);

    public void Dispose()
    {
        _fileStream.Dispose();
    }
}
namespace VirtualAudioTape.Exceptions;

/// <summary>
/// Represents file extension exception.
/// </summary>
public class FileExtensionNotSupportedException : NotSupportedException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FileExtensionNotSupportedException"/> class with
    /// a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception,
    /// or a null reference if no inner exception is specified.</param>
    public FileExtensionNotSupportedException(string? message = null, Exception? innerException = null)
        : base(message, innerException)
    {
    }
}
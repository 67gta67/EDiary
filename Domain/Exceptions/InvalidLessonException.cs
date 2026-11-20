namespace Domain.Exceptions;

public class InvalidLessonException : Exception
{
    public InvalidLessonException()
    {
    }

    public InvalidLessonException(string message)
        : base(message)
    {
    }

    public InvalidLessonException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}